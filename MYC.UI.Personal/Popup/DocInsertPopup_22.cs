using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Personal.Popup
{
    public partial class DocInsertPopup_22 : MYCForm
    {
        protected bool Details = false;

        protected DataTable dt_Detail = new DataTable();
        protected DataTable dt_Import = new DataTable();

        protected List<Label> lstLbSch = new List<Label>();
        protected List<TextBox> lstTxtSch = new List<TextBox>();

        protected string FromDate = "";
        protected string ToDate = "";

        protected CheckComboBox cbockMember = new CheckComboBox();

        public string DOC_TYP_CD { get; set; }
        
        public DocInsertPopup_22()
        {
            InitializeComponent();
        }

        private void DocInsertPopup_Load(Object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitControls();

            DTOFactory.Complete();
        }

        private void InitControls()
        {
            cboPlan.Params.Clear();
            cboPlan.Params.Add("strUserId", DTOFactory.UserId);
            cboPlan.Params.Add("strDocType", "21");
            cboPlan.Params.Add("strDocType2", DOC_TYP_CD);
            cboPlan.BindDataSet();

            cbockMember.MultiSelection = true;
            cbockMember.Params.Clear();
            cbockMember.Params.Add("strCompType", "M");
            cbockMember.BindDataSet();

            txtUserName.Text = DTOFactory.UserName;
            txtWorkDesc.Text = DTOFactory.TeamName;
            txtGrade.Text = DTOFactory.Grade;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearSearchData();

            SetSearchData("DOC_TYP_CD", DOC_TYP_CD);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);
            SetSearchData("SUBJECT", txtSite.Text);
            SetSearchData("USER_ID_LVAL", cboPlan.ValueList);
            SetSearchData("SITE_NM", txtSubject.Text);            

            SetServiceId("SetDocList");

            DataTable _dt = new DataTable();
            _dt.Columns.Add("GRP_NM");
            _dt.Columns.Add("SUBJECT");
            _dt.Columns.Add("DOC_DESC");

            for (int i=0; i < lstLbSch.Count; i++)
            {
                DataRow row = _dt.NewRow();
                row["GRP_NM"] = lstLbSch[i].Text;
                row["DOC_DESC"] = lstTxtSch[i].Text;
                _dt.Rows.Add(row);
            }

            DTOFactory.SetDTOTable("ds_list", _dt.Copy());

            try
            {
                DTOFactory.Transaction(new DocDTO());

                DialogResult = DialogResult.OK;
                ViewMessage.Info("문서 등록이 완료 되었습니다.");
                Close();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void cboPlan_TextChanged(object sender, EventArgs e)
        {
            if (!"".Equals(cboPlan.ValueList))
            {
                ClearSearchData();
                SetSearchData("DOC_ID", cboPlan.ValueList.ToString());
                SetSearchData("DOC_TYP_CD", "21");

                SetServiceId("GetDocDetailItem");

                DTOFactory.Transaction(new DocDTO());
                
                try
                {
                    DataSet ds = DTOFactory.GetDataSet();

                    dt_Import = ds.Tables["ds_doc"];
                    dt_Detail = ds.Tables["ds_list"];

                    #region 날짜 변환
                    FromDate = dt_Import.Rows[0]["START_TM"].ToString();
                    ToDate = dt_Import.Rows[0]["END_TM"].ToString();
                    DateTime dtFrom = DateTime.Parse(FromDate + " 00:00:00");
                    DateTime dtTo = DateTime.Parse(ToDate + " 00:00:00");
                    #endregion

                    txtSite.Text = dt_Import.Rows[0]["SITE_NM"].ToString();
                    txtSubject.Text = dt_Import.Rows[0]["SUBJECT"].ToString();
                    cbockMember.SetItemChecked(dt_Import.Rows[0]["USER_ID_LVAL"].ToString());

                    lstLbSch.Clear();
                    lstTxtSch.Clear();
                    PnlSch.Controls.Clear();

                    txtDate.Text = string.Format("{0} ~ {1} ({2} 일간)", FromDate, ToDate, (dtTo - dtFrom).Days + 1);

                    for (int i = 0; i < dt_Detail.Rows.Count; i++)
                    {
                        Label lbtmp = new Label()
                        {
                            Size = new System.Drawing.Size(107, 50),
                            Location = new System.Drawing.Point(0, i * 50),
                            Font = new System.Drawing.Font("굴림", 9),
                            BorderStyle = BorderStyle.FixedSingle,
                            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                            Text = dtFrom.AddDays(i).ToString("yyyy-MM-dd")
                        };

                        TextBox txtTmp = new TextBox()
                        {
                            Size = new System.Drawing.Size(449, 50),
                            Location = new System.Drawing.Point(107, i * 50),
                            Multiline = true,
                            Text = dt_Detail.Rows[i]["DOC_DESC"].ToString()
                        };

                        PnlSch.Controls.Add(lbtmp);
                        PnlSch.Controls.Add(txtTmp);

                        lstLbSch.Add(lbtmp);
                        lstTxtSch.Add(txtTmp);
                    }
                }
                catch(Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }
    }
}
