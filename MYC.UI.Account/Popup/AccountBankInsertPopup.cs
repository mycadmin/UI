using System;
using System.Data;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Account.Popup
{
    public partial class AccountBankInsertPopup : MYCForm
    {
        public string ACC_CD { get; set; }
        protected string Link = "";

        public AccountBankInsertPopup()
        {
            InitializeComponent();
        }

        private void AccountBankInsertPopup_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            cboType.Params.Add("strItem", "ACCOUNT_TYPE");
            cboType.BindDataSet();

            cboBank.Params.Add("strItem", "BANK_NAME");
            cboBank.BindDataSet();

            cboUser.Params.Add("COMP_TYP", "M");
            cboUser.BindDataSet();

            if (!"".Equals(ACC_CD))
            {
                GetBankInfo();
            }
        }

        private void GetBankInfo()
        {
            ClearSearchData();
            SetSearchData("ACC_CD", ACC_CD);
            SetServiceId("GetBankAccountList");

            try
            {
                DTOFactory.Transaction(new AccountDTO());
                DataTable dt = DTOFactory.GetDataTable();

                cboType.SetItemChecked(dt.Rows[0]["ACC_TYP_CD"].ToString());
                cboBank.SetItemChecked(dt.Rows[0]["BNK_COMP_CD"].ToString());
                cboUser.SetItemChecked(dt.Rows[0]["USER_ID"].ToString());

                txtBankCode.Text = dt.Rows[0]["BNK_NO"].ToString();
                txtBankDesc.Text = dt.Rows[0]["ACC_DESC"].ToString();
                Link = dt.Rows[0]["LINK_CD"].ToString();
                txtBankImage.Text = "";

                cboType.Enabled = false;
                cboBank.Enabled = false;
                txtBankCode.Enabled = false;
                btnFile.Enabled = false;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void FileUpload(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBankImage.Text = frm.FileName;
            }
        }

        private void ViewFile(object sender, EventArgs e)
        {
            if (!"".Equals(txtBankImage.Text))
            {
                System.Diagnostics.Process.Start(txtBankImage.Text);
            }
        }

        private void FormClose(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Save(object sender, EventArgs e)
        {
            if ("".Equals(ACC_CD))
            {
                FileSender file = new FileSender("", txtBankImage.Text);

                Link = file.GetLinkCode();
                file.Close();
            }

            ClearSearchData();
            SetSearchData("ACC_CD", ACC_CD);
            SetSearchData("ACC_TYPE", cboType.ValueList);
            SetSearchData("OUT_BANK_NM", cboBank.ValueList);
            SetSearchData("OUT_BANK_NO", txtBankCode.Text);
            SetSearchData("USER_ID", cboUser.ValueList);
            SetSearchData("ACCOUNT_DESC", txtBankDesc.Text);
            SetSearchData("LINK_CODE", Link);
            SetSearchData("UPT_USER_ID", DTOFactory.UserId);
            SetServiceId("SetBankAccountList");

            try
            {
                DTOFactory.Transaction(new AccountDTO());

                DialogResult = DialogResult.OK;
                ViewMessage.Info("등록이 완료 되었습니다.");
                Close();
            }
            catch(Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
    }
}
