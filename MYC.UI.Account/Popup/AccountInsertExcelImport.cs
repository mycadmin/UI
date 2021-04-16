using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control.Common;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Account.Popup
{
    public partial class AccountInsertExcelImport : MYCForm
    {
        public AccountInsertExcelImport()
        {
            InitializeComponent();
        }

        private void AccountInsertExcelImport_Load(object sender, EventArgs e)
        {
            InitSpread();
        }

        private void InitSpread()
        {
            gd_list.SelectionMode = DataGridViewSelectionMode.CellSelect;

            gd_list.ExcelImport();

            DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
            {
                Text = "삭제",
                HeaderText = "관리",
                Name = "DEL",
                UseColumnTextForButtonValue = true
            };
            gd_list.Columns.AddRange(bt);
        }

        private void DeleteSel(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
            {
                gd_list.Rows.RemoveAt(e.RowIndex);//
            }
        }

        private void Close(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Save(object sender, EventArgs e)
        {
            AccountDTO dto = new AccountDTO();

            foreach (DataRow row in gd_list.Rows)//
            {
                if (row[0].ToString().Length > 0)
                {
                    if (rdoBank.Checked)
                    {
                        dto.ACC_ID += ";" + row[0];
                        dto.ACC_DT += ";" + DateTime.Parse(row[1].ToString()).ToString("yyyy-MM-dd");
                        dto.CASH += ";" + row[7];
                        dto.CASH_DESC += ";" + row[8];
                        dto.ACCOUNT_DESC += ";" + row[9];
                        dto.OUT_BANK_NM += ";" + row[2];
                        dto.OUT_BANK_NO += ";" + row[3];
                        dto.IN_BANK_NM += ";" + row[4];
                        dto.IN_BANK_NO += ";" + row[5];
                        dto.IN_NAME += ";" + row[6];
                    }
                    else if (rdoCard.Checked)
                    {
                        dto.ACC_ID += ";" + row[0];
                        dto.ACC_DT += ";" + DateTime.Parse(row[1].ToString()).ToString("yyyy-MM-dd");
                        dto.CASH += ";" + row[8];
                        dto.CASH_DESC += ";" + row[9];
                        dto.ACCOUNT_DESC += ";" + row[10];
                        dto.ACC_TYPE += ";" + row[2];
                        dto.CARD_NM += ";" + row[3];
                        dto.CARD_NO += ";" + row[4];
                        dto.ACC_NO += ";" + row[5];
                        dto.OUT_COMP_NM += ";" + row[6];
                        dto.OUT_COMP_REG_ID += ";" + row[7];
                    }
                }
            }

            try
            {
                ClearSearchData();
                SetSearchData("ACC_ID", dto.ACC_ID != null && dto.ACC_ID.Length > 0 ? dto.ACC_ID.Substring(1) : "");
                SetSearchData("ACC_DT", dto.ACC_DT != null && dto.ACC_DT.Length > 0 ? dto.ACC_DT.Substring(1) : "");
                SetSearchData("CASH", dto.CASH != null && dto.CASH.Length > 0 ? dto.CASH.Substring(1) : "");
                SetSearchData("CASH_DESC", dto.CASH_DESC != null && dto.CASH_DESC.Length > 0 ? dto.CASH_DESC.Substring(1) : "");
                SetSearchData("ACCOUNT_DESC", dto.ACCOUNT_DESC != null && dto.ACCOUNT_DESC.Length > 0 ? dto.ACCOUNT_DESC.Substring(1) : "");
                SetSearchData("OUT_BANK_NM", dto.OUT_BANK_NM != null && dto.OUT_BANK_NM.Length > 0 ? dto.OUT_BANK_NM.Substring(1) : "");
                SetSearchData("OUT_BANK_NO", dto.OUT_BANK_NO != null && dto.OUT_BANK_NO.Length > 0 ? dto.OUT_BANK_NO.Substring(1) : "");
                SetSearchData("IN_BANK_NM", dto.IN_BANK_NM != null && dto.IN_BANK_NM.Length > 0 ? dto.IN_BANK_NM.Substring(1) : "");
                SetSearchData("IN_BANK_NO", dto.IN_BANK_NO != null && dto.IN_BANK_NO.Length > 0 ? dto.IN_BANK_NO.Substring(1) : "");
                SetSearchData("IN_NAME", dto.IN_NAME != null && dto.IN_NAME.Length > 0 ? dto.IN_NAME.Substring(1) : "");
                SetSearchData("ACC_TYPE", dto.ACC_TYPE != null && dto.ACC_TYPE.Length > 0 ? dto.ACC_TYPE.Substring(1) : "");
                SetSearchData("CARD_NM", dto.CARD_NM != null && dto.CARD_NM.Length > 0 ? dto.CARD_NM.Substring(1) : "");
                SetSearchData("CARD_NO", dto.CARD_NO != null && dto.CARD_NO.Length > 0 ? dto.CARD_NO.Substring(1) : "");
                SetSearchData("ACC_NO", dto.ACC_NO != null && dto.ACC_NO.Length > 0 ? dto.ACC_NO.Substring(1) : "");
                SetSearchData("OUT_COMP_NM", dto.OUT_COMP_NM != null && dto.OUT_COMP_NM.Length > 0 ? dto.OUT_COMP_NM.Substring(1) : "");
                SetSearchData("OUT_COMP_REG_ID", dto.OUT_COMP_REG_ID != null && dto.OUT_COMP_REG_ID.Length > 0 ? dto.OUT_COMP_REG_ID.Substring(1) : "");
                SetSearchData("LINK_CODE", "");
                SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                SetServiceId(rdoBank.Checked ? "SetBankAccountImport" : "SetCardAccountImport");
                DTOFactory.Transaction(new AccountDTO());
                
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
                DialogResult = DialogResult.Cancel;
            }
        
            if (DialogResult == DialogResult.OK)
                ViewMessage.Info("등록이 완료 되었습니다.");

            Close();
        }
    }
}
