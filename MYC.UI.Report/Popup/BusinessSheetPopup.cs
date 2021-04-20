using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Sender;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Report
{
    public partial class BusinessSheetPopup : MYCForm
    {
        protected DataTable _dtFile = new DataTable();

        public string DOC_ID { get; set; }
        public string SUBJECT { get; set; }
        public string COMP_CD { get; set; }
        public string COMP_USER_ID { get; set; }
        public DateTime ACCEPT_DT{get; set;}
        public string USER_ID { get; set; }
        public string COST { get; set; }
        public string PROJECT_ID{ get; set; }
        public bool BF { get; set; }

        public BusinessSheetPopup()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BusinessSheetPopup_Load(object sender, EventArgs e)
        {
            InitDataTable();
            InitControl();
        }

        private void InitControl()
        {
            DTOFactory.Action();

            cboComp.Params.Clear();
            cboComp.Params.Add("strCompType", "G");
            cboComp.BindDataSet();

            cboCompUser.Params.Clear();
            cboCompUser.Params.Add("strCompType", "G");
            cboCompUser.BindDataSet();

            cboUser.Params.Clear();
            cboUser.Params.Add("strCompType", "M");
            cboUser.BindDataSet();

            cboProject.Params.Clear();
            cboProject.Params.Add("strProject", "");
            cboProject.Params.Add("strUserId", "");
            cboProject.Params.Add("strStatus", "");
            cboProject.BindDataSet();

            dtCreateTime.Value = DateTime.Now;
            dtAcceptTime.Value = DateTime.Now;
            lstFile.DataSource = _dtFile;

            if(BF)
            {
                txtSubject.Text = SUBJECT;
                cboComp.SetItemChecked(COMP_CD);
                cboCompUser.SetItemChecked(COMP_USER_ID);
                dtAcceptTime.Value = ACCEPT_DT;
                cboUser.SetItemChecked(USER_ID);
                cboProject.SetItemChecked(PROJECT_ID);
                txtCost.Text = COST;

                label6.Enabled = false;
                lstFile.Enabled = false;
                btnFileAdd.Enabled = false;
                btnFileView.Enabled = false;
                btnFileDel.Enabled = false;
            }

            DTOFactory.Complete();
        }

        private void cboComp_TextChanged(object sender, EventArgs e)
        {
            if (!"".Equals(cboComp.ValueList))
            {
                cboCompUser.Params.Clear();
                cboCompUser.Params.Add("strCompCode", cboComp.ValueList);
                cboCompUser.BindDataSet();
            }
            else
            {
                cboCompUser.Params.Clear();
                cboCompUser.Params.Add("strCompType", "G");
                cboCompUser.BindDataSet();
            }
        }

        private void InitDataTable()
        {
            _dtFile.Columns.Add("DIR");
        }

        private void FileAdd(object sender, EventArgs e)
        {
            var frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow row = _dtFile.NewRow();
                row["DIR"] = frm.FileName;
                _dtFile.Rows.Add(row);
            }
        }

        private void ProcessFile(object sender, EventArgs e)
        {
            if (lstFile.SelectedIndex > -1)
            {
                System.Diagnostics.Process.Start(_dtFile.Rows[lstFile.SelectedIndex]["DIR"].ToString());
            }
        }

        private void FileDelete(object sender, EventArgs e)
        {
            if (lstFile.SelectedIndex > -1)
            {
                _dtFile.Rows.RemoveAt(lstFile.SelectedIndex);
            }
        }

        private void InsertData(object sender, EventArgs e)
        {
            if (!BF)
            {
                ClearSearchData();
                SetSearchData("SUBJECT", txtSubject.Text);
                SetSearchData("CST_COMP_CD", cboComp.ValueList);
                SetSearchData("CST_USER_ID", cboCompUser.ValueList);
                SetSearchData("USER_ID_LST", cboUser.ValueList);
                SetSearchData("STATUS", "S");
                SetSearchData("PRO_ID", cboProject.ValueList);
                SetSearchData("CREATE_TM", dtCreateTime.Value.ToString("yyyy-MM-dd") + " 00:00:00");
                SetSearchData("ACCEPT_TM", dtAcceptTime.Value.ToString("yyyy-MM-dd") + " 18:00:00");
                SetSearchData("COST", ("".Equals(txtCost.Text) ? "0" : txtCost.Text).Replace(",", ""));
                SetSearchData("GRP_NO", "사업 접수");
                SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                SetServiceId("InsertBusinessList");

                DTOFactory.Transaction(new ReportDTO());

                try
                {
                    DataTable dt = DTOFactory.GetDataTable();

                    string LINK_CODE = dt.Rows[0]["LINK_CODE"].ToString();

                    if ("".Equals(LINK_CODE))
                    {
                        ViewMessage.Info("이미 등록된 사업 정보 입니다.");
                    }
                    else
                    {
                        SetSearchData("LINK_CODE", LINK_CODE);

                        foreach (DataRow row in _dtFile.Rows)
                        {
                            new FileSender(LINK_CODE, row["DIR"].ToString());
                        }

                        SetServiceId("InsertBusinessDocument");

                        DTOFactory.Transaction(new ReportDTO());

                        ViewMessage.Info("사업 등록을 완료 하였습니다.");

                        Close();
                    }

                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
            else
            {
                ClearSearchData();
                SetSearchData("DOC_ID", DOC_ID);
                SetSearchData("SUBJECT", txtSubject.Text);
                SetSearchData("CST_COMP_CD", cboComp.ValueList);
                SetSearchData("CST_USER_ID", cboCompUser.ValueList);
                SetSearchData("USER_ID_LST", cboUser.ValueList);
                SetSearchData("STATUS", "S");
                SetSearchData("PRO_ID", cboProject.ValueList);
                SetSearchData("CREATE_TM", dtCreateTime.Value.ToString("yyyy-MM-dd") + " 00:00:00");
                SetSearchData("ACCEPT_TM", dtAcceptTime.Value.ToString("yyyy-MM-dd") + " 18:00:00");
                SetSearchData("COST", ("".Equals(txtCost.Text) ? "0" : txtCost.Text).Replace(",", ""));
                SetSearchData("GRP_NO", "사업 접수");
                SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                SetServiceId("UpdateBusinessList");

                DTOFactory.Transaction(new ReportDTO());

                ViewMessage.Info("사업 수정을 완료 하였습니다.");

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void KeyFilter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void PriceChange(object sender, EventArgs e)
        {
            TextBox ctl = (TextBox)sender;

            string strPrice = ctl.Text.Replace(",", "");

            ctl.Text = ClsSpread.GetPriceNum(strPrice);
            ctl.Select(ctl.Text.Length, 1);
        }

        private void GetCheckResult(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("SUBJECT", txtSubject.Text);
            SetServiceId("GetBusiness");
            DTOFactory.SetDTO(_dtSearch);
            DTOFactory.Transaction(new ReportDTO());

            try
            {
                DataTable dt = DTOFactory.GetDataTable();

                string LINK_CODE = dt.Rows[0]["LINK_CODE"].ToString();

                SetSearchData("LINK_CODE", LINK_CODE);

                foreach (DataRow row in _dtFile.Rows)
                {
                    new FileSender(LINK_CODE, row["DIR"].ToString());
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }

            SetServiceId("InsertBusinessDocument");
            DTOFactory.Transaction(new ReportDTO());

            ViewMessage.Info("사업 등록을 완료 하였습니다.");
        }
    }
}
