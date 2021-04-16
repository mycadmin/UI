using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Machine.Popup
{
    public partial class MachineHistory : MYCForm
    {
        public string ProductId { get; set; }
        public string MgrCd { get; set; }

        protected DataTable dtColumn;

        public MachineHistory()
        {
            InitializeComponent();
            InitControls();
        }

        private void MachineHistory_Load(object sender, EventArgs e)
        {
            tabHistory.TabPages[0].Text = ProductId;
            BtnSearch_Click(this, null);
        }

        private void InitControls()
        {
            
        }

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            ClearSearchData();
            SetSearchData("PRODUCT_ID", ProductId);
            SetSearchData("MGR_CD", MgrCd);
            SetServiceId("GetProductHistory");
            
            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                dtColumn = ds_return.Tables["ds_column"];
                gd_Eqp.DataSource = ds_return.Tables["ds_history"];
                gd_Eqp.SetGridColumn(ds_return.Tables["ds_column"]);
                
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewHistory(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if ("PRODUCT".Equals(view.Columns[e.ColumnIndex].Name))
            {
                ClearSearchData();
                SetSearchData("PRODUCT_ID", view.Rows[e.RowIndex].Cells["PRODUCT_ID"].Value);
                SetServiceId("GetProductHistory");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());
                    DataSet ds_return = DTOFactory.GetDataSet();

                    DataGridView gv = new DataGridView()
                    {
                        Dock = DockStyle.Fill
                    };

                    gv.CellContentClick += ViewHistory;
                    gv.DataSourceChanged += SetGrid;
                    
                    int index = tabHistory.TabPages.Count;
                    tabHistory.TabPages.Add(view.Rows[e.RowIndex].Cells["PRODUCT_ID"].Value.ToString());
                    tabHistory.TabPages[index].Controls.Add(gv);

                    gv.DataSource = ds_return.Tables["ds_history"];
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
            else if ("MGR".Equals(view.Columns[e.ColumnIndex].Name))
            {
                ClearSearchData();
                SetSearchData("MGR_CD", view.Rows[e.RowIndex].Cells["MGR_CD"].Value);
                SetServiceId("GetProductHistory");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());
                    DataSet ds_return = DTOFactory.GetDataSet();

                    DataGridView gv = new DataGridView()
                    {
                        Dock = DockStyle.Fill
                    };

                    gv.CellContentClick += ViewHistory;
                    gv.DataSourceChanged += SetGrid;
                    
                    int index = tabHistory.TabPages.Count;
                    tabHistory.TabPages.Add(view.Rows[e.RowIndex].Cells["MGR_NM"].Value.ToString());
                    tabHistory.TabPages[index].Controls.Add(gv);

                    gv.DataSource = ds_return.Tables["ds_history"];
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void SetGrid(object sender, EventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            view.SelectionMode = DataGridViewSelectionMode.CellSelect;

            if (view.Rows.Count > 0)
            {
                DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                {
                    Text = "제품이력",
                    HeaderText = "",
                    Name = "PRODUCT",
                    UseColumnTextForButtonValue = true
                };
                view.Columns.AddRange(bt);

                DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                {
                    Text = "장비이력",
                    HeaderText = "",
                    Name = "MGR",
                    UseColumnTextForButtonValue = true
                };
                view.Columns.AddRange(bt2);
            }
        }
    }
}
