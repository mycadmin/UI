using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Account.Popup
{
    public partial class AccountCardInsertPopup : MYCForm
    {
        public string ACC_CD { get; set; }
        public string BANK_ACC_CD { get; set; }

        public AccountCardInsertPopup()
        {
            InitializeComponent();
        }

        private void AccountCardInsertPopup_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            cboType.Params.Add("strItem", "ACCOUNT_TYPE");
            cboType.BindDataSet();

            cboBank.Params.Add("strBankComp", "");
            cboBank.BindDataSet();
            cboBank.SetItemChecked(BANK_ACC_CD);
            cboBank.Enabled = false;

            cboCard.Params.Add("strItem", "CARD_NAME");
            cboCard.BindDataSet();

            cboUser.Params.Add("COMP_TYP", "M");
            cboUser.BindDataSet();

            if (!"".Equals(ACC_CD))
            {
                GetCardInfo();
            }
        }

        private void GetCardInfo()
        {
            ClearSearchData();
            SetSearchData("ACC_CD", ACC_CD);
            SetServiceId("GetCardAccountList");

            try
            {

                DTOFactory.Transaction(new AccountDTO());
                DataTable dt = DTOFactory.GetDataTable();

                cboType.SetItemChecked(dt.Rows[0]["ACC_TYP_CD"].ToString());
                cboBank.SetItemChecked(dt.Rows[0]["ACC_CD"].ToString());
                cboCard.SetItemChecked(dt.Rows[0]["CARD_COMP_CD"].ToString());
                cboUser.SetItemChecked(dt.Rows[0]["USER_ID"].ToString());

                txtCardCode.Text = dt.Rows[0]["CARD_NO"].ToString();
                txtCardDesc.Text = dt.Rows[0]["ACC_DESC"].ToString();
                
                cboType.Enabled = false;
                cboBank.Enabled = false;
                cboCard.Enabled = false;
                txtCardCode.Enabled = false;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void FormClose(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Save(object sender, EventArgs e)
        {
            ClearSearchData();

            if ("".Equals(cboType.ValueList))
            {
                ViewMessage.Info("항목을 선택 해 주시기 바랍니다.");
                return;
            }
            if ("".Equals(cboCard.ValueList))
            {
                ViewMessage.Info("카드사를 선택 해 주시기 바랍니다.");
                return;
            }
            if ("".Equals(txtCardCode.Text))
            {
                ViewMessage.Info("카드 번호를 선택 해 주시기 바랍니다.");
                return;
            }

            SetSearchData("ACC_CD", ACC_CD);
            SetSearchData("ACC_TYPE", cboType.ValueList);
            SetSearchData("OUT_BANK_NM", cboBank.ValueList);
            SetSearchData("CARD_NM", cboCard.ValueList);
            SetSearchData("CARD_NO", txtCardCode.Text);
            SetSearchData("USER_ID", cboUser.ValueList);
            SetSearchData("ACCOUNT_DESC", txtCardDesc.Text);
            SetSearchData("UPT_USER_ID", DTOFactory.UserId);
            SetServiceId("SetCardAccountList");

            try
            {
                DTOFactory.Transaction(new AccountDTO());

                DialogResult = DialogResult.OK;
                ViewMessage.Info("등록이 완료 되었습니다.");
                Close();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
    }
}
