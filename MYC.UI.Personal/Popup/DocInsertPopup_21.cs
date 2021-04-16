using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Personal.Popup
{
    public partial class DocInsertPopup_21 : MYCForm
    {
        protected bool Details = false;

        protected DataTable dt_Detail = new DataTable();
        protected DataTable dt_Import = new DataTable();

        protected List<Label> lstLbSch = new List<Label>();
        protected List<TextBox> lstTxtSch = new List<TextBox>();

        protected int delay = 0;

        public string DOC_TYP_CD { get; set; }
        
        public DocInsertPopup_21()
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
            cbockMember.Params.Clear();
            cbockMember.Params.Add("strCompType", "M");
            cbockMember.BindDataSet();

            txtUserName.Text = DTOFactory.UserName;
            txtWorkDesc.Text = DTOFactory.TeamName;
            txtGrade.Text = DTOFactory.Grade;

            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearSearchData();

            SetSearchData("DOC_TYP_CD", DOC_TYP_CD);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);
            SetSearchData("START_TM", dtFrom.Value.ToString("yyyy-MM-dd"));
            SetSearchData("END_TM", dtTo.Value.ToString("yyyy-MM-dd"));
            SetSearchData("SUBJECT", txtSite.Text);
            SetSearchData("USER_ID_LVAL", cbockMember.ValueList);
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

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Parse(dtFrom.Value.ToString("yyyy-MM-dd 00:00:00"));
            dtTo.Value = DateTime.Parse(dtTo.Value.ToString("yyyy-MM-dd 00:00:00"));

            int date = (dtTo.Value - dtFrom.Value).Days + 1;

            if (date != delay)
            {
                lstLbSch.Clear();
                lstTxtSch.Clear();
                PnlSch.Controls.Clear();

                if (date > 0)
                {
                    lbDelay.Text = "(" + date.ToString() + "일간)";

                    for (int i = 0; i < date; i++)
                    {
                        Label lbtmp = new Label()
                        {
                            Size = new System.Drawing.Size(107, 50),
                            Location = new System.Drawing.Point(0, i * 50),
                            Font = new System.Drawing.Font("굴림", 9),
                            BorderStyle = BorderStyle.FixedSingle,
                            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                            Text = dtFrom.Value.AddDays(i).ToString("yyyy-MM-dd")
                        };

                        TextBox txtTmp = new TextBox()
                        {
                            Size = new System.Drawing.Size(449, 50),
                            Location = new System.Drawing.Point(107, i * 50),
                            Multiline = true
                        };

                        PnlSch.Controls.Add(lbtmp);
                        PnlSch.Controls.Add(txtTmp);

                        lstLbSch.Add(lbtmp);
                        lstTxtSch.Add(txtTmp);
                    }
                }
                else
                    lbDelay.Text = "";
            }

            delay = date;
            
        }
    }
}
