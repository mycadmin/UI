using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Personal.Popup
{
    public partial class DocInsertPopup_11 : MYCForm
    {
        protected bool Details = false;

        protected DataTable dt_Detail = new DataTable();
        protected DataTable dt_Import = new DataTable();

        public string DOC_TYP_CD { get; set; }
        
        public DocInsertPopup_11()
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
            txtUserName.Text = DTOFactory.UserName;
            txtWorkDesc.Text = DTOFactory.TeamName;
            txtGrade.Text = DTOFactory.Grade;

            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            dtFromTime.Value = DateTime.Now;
            dtToTime.Value = DateTime.Now;

            RdoCd01.Checked = false;
            RdoCd02.Checked = false;
            RdoCd03.Checked = false;
            RdoCd04.Checked = false;
            RdoCd05.Checked = false;
            RdoCd06.Checked = false;
            RdoCd07.Checked = false;
            RdoCd08.Checked = false;
            RdoCd09.Checked = false;
            PnlTime.Enabled = false;

            switch (DOC_TYP_CD)
            {

                case "11":
                    RdoCd01.Checked = true;
                    break;
                case "12":
                    RdoCd02.Checked = true;
                    break;
                case "13":
                    RdoCd03.Checked = true;
                    break;
                case "14":
                    RdoCd04.Checked = true;
                    break;
                case "15":
                    RdoCd05.Checked = true;
                    PnlTime.Enabled = true;
                    break;
                case "16":
                    RdoCd06.Checked = true;
                    PnlTime.Enabled = true;
                    break;
                case "17":
                    RdoCd07.Checked = true;
                    break;
                case "18":
                    RdoCd08.Checked = true;
                    break;
                case "19":
                    RdoCd09.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearSearchData();

            SetSearchData("DOC_TYP_CD", DOC_TYP_CD);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);

            if ("15".Equals(DOC_TYP_CD) || "16".Equals(DOC_TYP_CD))
            {
                SetSearchData("START_TM", dtFrom.Value.ToString("yyyy-MM-dd") + " " + dtFromTime.Value.ToString("HH"));
                SetSearchData("END_TM", dtTo.Value.ToString("yyyy-MM-dd") + " " + dtToTime.Value.ToString("HH"));
            }
            else
            {
                SetSearchData("START_TM", dtFrom.Value.ToString("yyyy-MM-dd"));
                SetSearchData("END_TM", dtTo.Value.ToString("yyyy-MM-dd"));
            }
            SetSearchData("DOC_DESC", txtDocDesc.Text);

            SetServiceId("SetDocList");

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

            if (date > 0)            
                lbDelay.Text = "(" + date.ToString() + "일간)";
            else
                lbDelay.Text = "";
        }
    }
}
