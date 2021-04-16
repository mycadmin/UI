using System;
using System.Data;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Account.Popup
{
    public partial class AccountInsertPopup : MYCForm
    {
        public AccountInsertPopup()
        {
            InitializeComponent();
        }

        private void AccountInsertPopup_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            cboType.Params.Add("strItem", "CASH_TYPE");
            cboType.BindDataSet();

            cboCard.Params.Add("strCardComp", "");
            cboCard.Params.Add("strUserId", "");
            cboCard.BindDataSet();

            cboBankCode.Params.Add("strBankComp", "");
            cboBankCode.BindDataSet();
        }

        private void SetGroup(object sender, EventArgs e)
        {
            grpCard.Visible = rdoCard.Checked;
            grpBank.Visible = rdoBank.Checked;
        }

        private void FileUpload(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtReceipt.Text = frm.FileName;
            }
        }

        private void ViewFile(object sender, EventArgs e)
        {
            if (!"".Equals(txtReceipt.Text))
            {
                System.Diagnostics.Process.Start(txtReceipt.Text);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (!"".Equals(txtReceipt.Text))
            {
                FileSender file = new FileSender("", txtReceipt.Text);
                string Link = file.GetLinkCode();
                file.Close();

                ClearSearchData();
                SetSearchData("ACC_DT", calAccDate.Value.ToString("yyyy-MM-dd"));
                SetSearchData("CASH", txtAccCash.Text.Replace(",", ""));
                SetSearchData("CASH_DESC", txtAccDesc.Text);
                SetSearchData("ACCOUNT_DESC", txtAccInfo.Text);
                SetSearchData("LINK_CODE", Link);
                SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                if (rdoBank.Checked)
                {
                    SetSearchData("ACC_CD", cboBankCode.ValueList);
                    SetSearchData("IN_BANK_NM", txtInBankName.Text);
                    SetSearchData("IN_BANK_NO", txtInBankNo.Text);
                    SetSearchData("IN_NAME", txtInUserName.Text);
                    SetServiceId("SetBankAccountHistory");
                }
                else if (rdoCard.Checked)
                {
                    SetSearchData("ACC_TYPE", cboType.ValueList);
                    SetSearchData("ACC_CD", cboCard.ValueList);
                    SetSearchData("ACC_NO", txtAccNo.Text);
                    SetSearchData("OUT_COMP_NM", txtOutName.Text);
                    SetSearchData("OUT_COMP_REG_ID", txtOutRegId.Text);
                    SetServiceId("SetCardAccountHistory");
                }
                else
                {
                    ViewMessage.Error("잘못된 선택 입니다.");
                }

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
            else
            {
                ViewMessage.Error("첨부 파일이 없습니다.");
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
