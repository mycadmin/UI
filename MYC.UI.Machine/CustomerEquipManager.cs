using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Machine
{
    public partial class CustomerEquipManager : MYCControl
    {
        #region Field        
        protected DataTable _dtList = new DataTable();
        protected DataTable _dtComp = new DataTable();
        #endregion

        #region Init
        public CustomerEquipManager()
        {
            InitializeComponent();
        }

        private void CustomerEquipManager_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            cboComp.Params.Clear();
            cboComp.Params.Add("strCompType", "C");
            cboComp.BindDataSet();
            _dtComp = cboComp.DataSource;
        }
        #endregion

        private void GridAction(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    DataGridViewRow row = view.Rows[view.SelectedCells[0].RowIndex];

                    ClearSearchData();
                    SetSearchData("MGR_CD", row.Cells["MGR_CD"].Value);
                    SetSearchData("PROC_COMP_CD", row.Cells["PROC_COMP_CD"].Value);
                    SetSearchData("PROC_EQP_ID", row.Cells["PROC_EQP_ID"].Value);
                    SetSearchData("PROD_COMP_CD", row.Cells["PROD_COMP_CD"].Value);
                    SetSearchData("PROD_MODEL_ID", row.Cells["PROD_MODEL_ID"]);
                    SetSearchData("CRT_USER_ID", DTOFactory.UserId);

                    SetServiceId("SetEqpInfo");

                    try
                    {
                        DTOFactory.Transaction(new ManagerDTO());
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
                else if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
                {

                }
            }
        }

        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("PROC_COMP_CD", cboComp.ValueList);
            SetServiceId("GetEqpList");

            try
            {
                DTOFactory.Transaction(new ManagerDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                _dtList = ds_return.Tables["ds_equip"];
                gd_list.DataSource = _dtList;

                if (!gd_list.LabelDisplayed)
                {
                    gd_list.SetGridColumn(ds_return.Tables["ds_column"]);
                    gd_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    gd_list.ReadOnly = false;
                    gd_list.Columns["MGR_CD"].ReadOnly = true;

                    DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtComp,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "고객사",
                        DataPropertyName = "PROC_COMP_CD",
                        Name = "PROC_COMP_CD"
                    };
                    int index = gd_list.Columns["PROC_COMP_CD"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["PROC_COMP_CD"]);
                    gd_list.Columns.AddRange(cb);
                    cb.DisplayIndex = index;

                    DataGridViewComboBoxColumn cb2 = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtComp,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "제조사",
                        DataPropertyName = "PROD_COMP_CD",
                        Name = "PROD_COMP_CD"
                    };
                    index = gd_list.Columns["PROD_COMP_CD"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["PROD_COMP_CD"]);
                    gd_list.Columns.AddRange(cb2);
                    cb2.DisplayIndex = index;

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                    {
                        Text = "저장",
                        HeaderText = "",
                        Name = "SAVE",
                        UseColumnTextForButtonValue = true
                    };
                    gd_list.Columns.AddRange(bt);

                    DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                    {
                        Text = "삭제",
                        HeaderText = "",
                        Name = "DEL",
                        UseColumnTextForButtonValue = true
                    };
                    gd_list.Columns.AddRange(bt2);
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ConTextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
            }
        }

        private void RowAdd(object sender, EventArgs e)
        {
            DataRow dr = _dtList.NewRow();
            dr["PROC_COMP_CD"] = cboComp.ValueList;
            _dtList.Rows.Add(dr);
        }
    }
}
