using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.Sender;
using MYC.UI.DTO;

namespace MYC.UI.Account
{
    public partial class AccountManager : MYCControl_noframe
    {
        #region Field
        protected DataTable _dtBank = new DataTable();
        protected DataTable _dtCard = new DataTable();
        #endregion

        public AccountManager()
        {
            InitializeComponent();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitControls();

            DTOFactory.Complete();
        }

        private void InitControls()
        {
            ShowBank();
        }

        private void ShowBank()
        {
            ClearSearchData();
            SetSearchData("UPT_USER_ID", DTOFactory.UserId);
            SetServiceId("GetBankList");

            //try
            //{
                DTOFactory.Transaction(new AccountDTO());
                _dtBank = DTOFactory.GetDataTable("ds_bank");
                gd_Bank.DataSource = _dtBank;
            
                if (!gd_Bank.LabelDisplayed)
                {
                    gd_Bank.SetGridColumn(DTOFactory.GetDataTable("ds_column"));
                    gd_Bank.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    
                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                    {
                        Text = "보기",
                        HeaderText = "통장사본",
                        Name = "VIEW",
                        UseColumnTextForButtonValue = true
                    };
                    gd_Bank.Columns.AddRange(bt);

                    DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                    {
                        Text = "삭제",
                        HeaderText = "",
                        Name = "DEL",
                        UseColumnTextForButtonValue = true
                    };
                    gd_Bank.Columns.AddRange(bt2);

                    DataGridViewButtonColumn bt3 = new DataGridViewButtonColumn()
                    {
                        Text = "수정",
                        HeaderText = "",
                        Name = "SAVE",
                        UseColumnTextForButtonValue = true
                    };
                    gd_Bank.Columns.AddRange(bt3);
                }

                if (_dtBank.Rows.Count > 0)
                {
                    gd_Bank.Rows[0].Cells[0].Selected = true;
                    GetCardInfo(gd_Bank.Rows[gd_Bank.SelectedCells[0].RowIndex].Cells["BNK_COMP_CD"].Value.ToString(), gd_Bank.Rows[gd_Bank.SelectedCells[0].RowIndex].Cells["BNK_NO"].Value.ToString());
                }
            //}
            //catch (Exception ex)
            //{
            //    ViewMessage.Error(ex.Message);
            //}
        }

        private void BankAdd(object sender, EventArgs e)
        {
            var frm = new Popup.AccountBankInsertPopup()
            {
                ACC_CD = ""
            };
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowBank();
            }
        }

        private void CardAdd(object sender, EventArgs e)
        {
            var frm = new Popup.AccountCardInsertPopup()
            {
                ACC_CD = "",
                BANK_ACC_CD = gd_Bank.Rows[gd_Bank.SelectedCells[0].RowIndex].Cells["ACC_CD"].Value.ToString()
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetCardInfo(gd_Bank.Rows[gd_Bank.SelectedCells[0].RowIndex].Cells["BNK_COMP_CD"].Value.ToString(), gd_Bank.Rows[gd_Bank.SelectedCells[0].RowIndex].Cells["BNK_NO"].Value.ToString());
            }
        }

        private void Bank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if ("VIEW".Equals(view.Columns[e.ColumnIndex].Name))
            {
                new FileGet(view.Rows[e.RowIndex].Cells["LINK_CD"].Value.ToString());
            }
            else if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
            {
                if (System.Windows.Forms.MessageBox.Show(
                        " 통장 정보를 삭제 하시겠습니까?", "통장 제거"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearSearchData();
                    SetSearchData("ACC_CD", view.Rows[e.RowIndex].Cells["ACC_CD"].Value.ToString());
                    SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                    SetServiceId("DelBankAccountList");

                    try
                    {
                        DTOFactory.Transaction(new AccountDTO());

                        ViewMessage.Info("통장 정보를 제거 하였습니다.");

                        _dtBank = DTOFactory.GetDataTable("ds_bank");
                        gd_Bank.DataSource = _dtBank;
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
            }
            else if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name))
            {
                var frm = new Popup.AccountBankInsertPopup()
                {
                    ACC_CD = view.Rows[e.RowIndex].Cells["ACC_CD"].Value.ToString()
                };

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ShowBank();
                }
            }
        }

        private void Card_Search(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                GetCardInfo(gd_Bank.Rows[e.RowIndex].Cells["BNK_COMP_CD"].Value.ToString(), gd_Bank.Rows[e.RowIndex].Cells["BNK_NO"].Value.ToString());
        }

        private void GetCardInfo(string BANK_CD, string BANK_NO)
        {
            ClearSearchData();
            SetSearchData("OUT_BANK_NM", BANK_CD);
            SetSearchData("OUT_BANK_NO", BANK_NO);
            SetServiceId("GetCardList");

            try
            {
                DTOFactory.Transaction(new AccountDTO());
                _dtCard = DTOFactory.GetDataTable("ds_card");
                gd_Card.DataSource = _dtCard;

                if (!gd_Card.LabelDisplayed)
                {
                    gd_Card.SetGridColumn(DTOFactory.GetDataTable("ds_column"));
                    gd_Card.SelectionMode = DataGridViewSelectionMode.CellSelect;

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                    {
                        Text = "삭제",
                        HeaderText = "",
                        Name = "DEL",
                        UseColumnTextForButtonValue = true
                    };
                    gd_Card.Columns.AddRange(bt);

                    DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                    {
                        Text = "수정",
                        HeaderText = "",
                        Name = "SAVE",
                        UseColumnTextForButtonValue = true
                    };
                    gd_Card.Columns.AddRange(bt2);
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void Card_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            int row = gd_Bank.SelectedCells[0].RowIndex;

            if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
            {
                if (System.Windows.Forms.MessageBox.Show(
                        " 카드 정보를 삭제 하시겠습니까?", "카드 제거"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearSearchData();
                    SetSearchData("ACC_CD", view.Rows[e.RowIndex].Cells["ACC_CD"].Value.ToString());
                    SetSearchData("OUT_BANK)NM", gd_Bank.Rows[row].Cells["BNK_COMP_CD"].Value);
                    SetSearchData("OUT_BANK_NO", gd_Bank.Rows[row].Cells["BNK_NO"].Value);
                    SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                    SetServiceId("DelCardAccountList");

                    try
                    {
                        DTOFactory.Transaction(new AccountDTO());

                        ViewMessage.Info("카드 정보를 제거 하였습니다.");

                        _dtCard = DTOFactory.GetDataTable("ds_card");
                        gd_Card.DataSource = _dtCard;
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
            }
            else if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name))
            {
                var frm = new Popup.AccountCardInsertPopup()
                {
                    ACC_CD = view.Rows[e.RowIndex].Cells["ACC_CD"].Value.ToString(),
                    BANK_ACC_CD = gd_Bank.Rows[row].Cells["ACC_CD"].Value.ToString()
                };

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ShowBank();
                }
            }
        }
    }
}
