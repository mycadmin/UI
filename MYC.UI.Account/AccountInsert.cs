using System;
using System.Data;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.Account.Popup;
using MYC.UI.DTO;

namespace MYC.UI.Account
{
    public partial class AccountInsert : MYCControl
    {
        #region Field        
        protected DataTable _dtCard = new DataTable();
        protected DataTable _dtBank = new DataTable();

        protected bool bool1 = true;
        #endregion

        public AccountInsert()
        {
            InitializeComponent();
        }

        private void AccountInsert_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitDataTable();
            InitControls();

            DTOFactory.Complete();
        }

        private void InitDataTable()
        {
        }

        private void InitControls()
        {
            dtFrom.Value = DateTime.Now.AddMonths(-3);
            dtTo.Value = DateTime.Now;

            dtFrom.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-") + "01");
            dtTo.Value = DateTime.Now;
        }

        private void NewAccount(object sender, EventArgs e)
        {
            var frm = new AccountInsertPopup();

            frm.ShowDialog();
        }

        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("FROM_DT", dtFrom.Value.ToString("yyyy-MM-dd"));
            SetSearchData("TO_DT", dtTo.Value.ToString("yyyy-MM-dd"));
            SetServiceId("GetAccountHistory");

            try
            {
                DTOFactory.Transaction(new AccountDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                _dtCard = ds_return.Tables["ds_card"];
                _dtBank = ds_return.Tables["ds_bank"];

                if (bool1)
                {
                    gd_Card.DataSource = _dtCard;
                    gd_Bank.DataSource = _dtBank;

                    gd_Card.SetGridColumn(ds_return.Tables["ds_column1"]);
                    gd_Bank.SetGridColumn(ds_return.Tables["ds_column2"]);

                    bool1 = false;
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void Excel_Import(object sender, EventArgs e)
        {
            var frm = new AccountInsertExcelImport();
            frm.ShowDialog();

        }
    }
}
