using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;
using MYC.UI.Machine.Popup;

namespace MYC.UI.Machine
{
    public partial class ProductDeliver : MYCControl
    {
        #region Field
        protected DataTable _dtList = new DataTable();
        protected DataTable _dtItem = new DataTable();
        protected DataTable _dtDeliModel = new DataTable();
        protected DataTable _dtModel = new DataTable();
        #endregion

        public ProductDeliver()
        {
            DTOFactory.Action();

            InitializeComponent();

            InitDataTable();
            InitSpread();
            InitControls();

            DTOFactory.Complete();
        }

        private void InitDataTable()
        {
        }

        private void InitSpread()
        {
            gd_List.MultiSelect = false;
            gd_Item.MultiSelect = false;
            gd_DeliModel.MultiSelect = false;
            gd_Model.MultiSelect = false;

            gd_DeliModel.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gd_Model.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        
        private void InitControls()
        {
            cboComp.Params.Clear();
            cboComp.Params.Add("strCompType", "C");
            cboComp.BindDataSet();

            cbockModel.Params.Clear();
            cbockModel.Params.Add("strModel", "");
            cbockModel.BindDataSet();

            cboStatus.Params.Clear();
            cboStatus.Params.Add("strItem", "DELI_TYPE");
            cboStatus.BindDataSet();

            dtTo.Value = DateTime.Now;
            dtFrom.Value = DateTime.Now.AddMonths(-1);
        }

        private void AddItem(object sender, EventArgs e)
        {
            if ("".Equals(cboComp.ValueList))
            {
                ViewMessage.Warning("업체를 선택 해 주시기 바랍니다.");
                return;
            }

            var frm = new CustomerOrderInsertPopup()
            {
                COMP_CD = cboComp.ValueList
            };

            frm.ShowDialog();
        }

        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("FROM_DT", dtFrom.Value.ToString("yyyy-MM-dd"));
            SetSearchData("TO_DT", dtTo.Value.ToString("yyyy-MM-dd"));
            SetSearchData("COMP_CD", cboComp.ValueList);
            SetSearchData("MODEL_ID", cbockModel.ValueList);
            SetSearchData("STAT_CD", cboStatus.ValueList);
            SetServiceId("GetDeliverList");
            
            try
            {
                DTOFactory.Transaction(new MachineDTO());

                DataSet ds = DTOFactory.GetDataSet();

                _dtList = ds.Tables["ds_list"];
                gd_List.DataSource = _dtList;

                if (!gd_List.LabelDisplayed)
                {
                    gd_List.SetGridColumn(ds.Tables["ds_column"]);
                }

                if (gd_List.Rows.Count > 0)
                {
                    gd_List.Rows[0].Selected = true;
                    ViewDetail(gd_List, new DataGridViewCellEventArgs(0,0));
                }
            }
            catch(Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewDetail(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            int row = e.RowIndex;

            if (row > -1)
            {
                ClearSearchData();
                SetSearchData("DOC_ID", view.Rows[row].Cells["DOC_ID"].Value);
                SetSearchData("COMP_CD", view.Rows[row].Cells["DELI_COMP_CD"].Value);
                SetServiceId("GetDeliverItem");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());

                    DataSet ds = DTOFactory.GetDataSet();

                    _dtItem = ds.Tables["ds_Item"];
                    gd_Item.DataSource = _dtItem;

                    if (!gd_Item.LabelDisplayed)
                    {
                        gd_Item.SetGridColumn(ds.Tables["ds_column"]);
                    }

                    if (gd_List.Rows.Count > 0)
                    {
                        gd_Item.Rows[0].Selected = true;
                        ViewModel(gd_Item, new DataGridViewCellEventArgs(0, 0));
                    }
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void ViewModel(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            int row = e.RowIndex;

            if (row > -1)
            {
                ClearSearchData();
                SetSearchData("DOC_ID", view.Rows[row].Cells["DOC_ID"].Value);
                SetSearchData("MODEL_ID", view.Rows[row].Cells["MODEL_ID"].Value);
                SetServiceId("GetProductList");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());

                    DataSet ds = DTOFactory.GetDataSet();

                    _dtDeliModel = ds.Tables["ds_model"];
                    gd_DeliModel.DataSource = _dtDeliModel;
                    _dtModel = ds.Tables["ds_model2"];
                    gd_Model.DataSource = _dtModel;

                    if (!gd_DeliModel.LabelDisplayed)
                    {
                        gd_DeliModel.SetCheckGridColumn(ds.Tables["ds_column"], "CHK");
                        gd_DeliModel.SetCheckGridColumn(ds.Tables["ds_column"], "CHK");

                        gd_DeliModel.Columns["COMP_NM"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void ProductDeliver_Resize(object sender, EventArgs e)
        {
            gd_DeliModel.Height = splitContainer2.Panel2.Height - 80;
            gd_Model.Height = splitContainer2.Panel2.Height - 80;
        }
    }
}
