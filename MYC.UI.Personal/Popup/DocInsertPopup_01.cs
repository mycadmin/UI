using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Personal.Popup
{
    public partial class DocInsertPopup_01 : MYCForm
    {
        protected bool Details = false;

        protected DataTable dt_Detail = new DataTable();
        protected DataTable dt_Import = new DataTable();

        public string DOC_TYP_CD { get; set; }
        
        public DocInsertPopup_01()
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
            txtBirth.Text = DTOFactory.UserBirth;
            txtAddr.Text = "(" + DTOFactory.UserAddrCode + ") " + DTOFactory.UserAddr;
            txtRegDt.Text = DTOFactory.JoinDate.Substring(0, 4) + "년 " + DTOFactory.JoinDate.Substring(4, 2) + "월 " + DTOFactory.JoinDate.Substring(6, 2) + "일";
            txtWorkDesc.Text = DTOFactory.TeamName;
            txtGrade.Text = DTOFactory.Grade;
            txtWorkDate.Text = DTOFactory.JoinDate.Substring(0, 4) + "년 " + DTOFactory.JoinDate.Substring(4, 2) + "월 " + DTOFactory.JoinDate.Substring(6, 2) + "일 ~ 현재";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearSearchData();

            SetSearchData("DOC_TYP_CD", DOC_TYP_CD);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);
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
    }
}
