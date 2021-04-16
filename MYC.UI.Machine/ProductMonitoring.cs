#pragma warning disable IDE1006
using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.Machine.Popup;
using MYC.UI.DTO;

namespace MYC.UI.Machine
{
    public partial class ProductMonitoring : MYCControl
    {
        #region Field
        protected DataTable _dtList = new DataTable();
        protected DataTable _dtModel = new DataTable();
        protected DataTable _dtStatus = new DataTable();
        protected DataTable _dtComp = new DataTable();
        protected DataTable _dtUser = new DataTable();
        protected DataTable _dtMgrCode = new DataTable();
        protected DataTable _dtVer = new DataTable();
        #endregion

        #region Init
        public ProductMonitoring()
        {
            InitializeComponent();

            InitDataTable();
            InitSpread();
            InitControls();
        }

        private void InitDataTable()
        {
        }

        private void InitSpread()
        {
        }

        private void InitControls()
        {
            #region Model Type
            cboType.Params.Add("strItem", "MODEL_TYPE");
            cboType.BindDataSet();
            #endregion Model Type

            #region 장비상태
            cboStatus.Params.Add("strItem", "EQP_STATUS");
            cboStatus.BindDataSet();
            _dtStatus = cboStatus.DataSource;
            #endregion 장비상태

            CheckComboBox cbo = new CheckComboBox()
            {
                Sql = "CommonSearch#getUserList"
            };
            cbo.Params.Clear();
            cbo.Params.Add("strCompType", "M,C,V");
            cbo.BindDataSet();
            _dtUser = cbo.DataSource;

            cbo = new CheckComboBox()
            {
                Sql = "CommonSearch#getCompList"
            };
            cbo.Params.Clear();
            cbo.Params.Add("strCompType", "M,C,V");
            cbo.BindDataSet();
            _dtComp = cbo.DataSource;

            cbo = new CheckComboBox()
            {
                Sql = "CommonSearch#getVerList"
            };
            cbo.Params.Clear();
            cbo.Params.Add("strModel", "");
            cbo.BindDataSet();
            _dtVer = cbo.DataSource;

            cbo = new CheckComboBox()
            {
                Sql = "CommonSearch#getManagerCode"
            };
            cbo.Params.Clear();
            cbo.Params.Add("strCompCode", "");
            cbo.BindDataSet();
            _dtMgrCode = cbo.DataSource;
            DataRow nr = _dtMgrCode.NewRow();
            nr["ITEM_CD"] = "";
            nr["ITEM_NM"] = "(선택없음)";
            _dtMgrCode.Rows.Add(nr);

        }
        #endregion

        #region Event
        private void cboType_TextChanged(object sender, EventArgs e)
        {
            cboModel.Params.Clear();
            cboModel.Params.Add("strModel", cboType.ValueList);
            cboModel.BindDataSet();
        _dtModel = cboModel.DataSource;
        }

        private void cboModel_TextChanged(object sender, EventArgs e)
        {
            #region 장비 List
            cbockProduct.Params.Clear();
            cbockProduct.Params.Add("strModel", cboModel.ValueList);
            cbockProduct.Params.Add("strStatus", cboStatus.ValueList);
            cbockProduct.BindDataSet();
            #endregion
        }

        private void cboStatus_TextChanged(object sender, EventArgs e)
        {
            cbockProduct.Params.Clear();
            cbockProduct.Params.Add("strModel", cboModel.ValueList);
            cbockProduct.Params.Add("strStatus", cboStatus.ValueList);
            cbockProduct.BindDataSet();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetMachineList();
        }

        #endregion

        #region Method
        private void BindData()
        {
            ClearSearchData();
            SetSearchData("MODEL_TYPE", cboType.ValueList);
            SetSearchData("MODEL_ID", cboModel.ValueList);
            SetSearchData("STAT_CD", cboStatus.ValueList);
            SetSearchData("PRODUCT_ID", cbockProduct.ValueList);
        }

        private void GetMachineList()
        {
            BindData();

            SetServiceId("GetProductList");
            
            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                _dtList = ds_return.Tables["ds_equip"];
                gd_list.DataSource = _dtList;

                if (!gd_list.LabelDisplayed)
                {
                    gd_list.SetGridColumn(ds_return.Tables["ds_column"]);
                    gd_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    gd_list.ReadOnly = false;

                    DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtModel,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "모델명",
                        DataPropertyName = "MODEL_ID",
                        Name = "MODEL_ID",
                        Width = 280
                    };
                    int index = gd_list.Columns["MODEL_ID"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["MODEL_ID"]);
                    gd_list.Columns.AddRange(cb);
                    cb.DisplayIndex = index;

                    DataGridViewComboBoxColumn cb2 = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtStatus,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "상태",
                        DataPropertyName = "STAT_CD",
                        Name = "STAT_CD",
                        Width = 120
                    };
                    index = gd_list.Columns["STAT_CD"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["STAT_CD"]);
                    gd_list.Columns.AddRange(cb2);
                    cb2.DisplayIndex = index;

                    DataGridViewComboBoxColumn cb3 = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtComp,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "담당업체",
                        DataPropertyName = "COMP_CD",
                        Name = "COMP_CD",
                        Width = 200
                    };
                    index = gd_list.Columns["COMP_CD"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["COMP_CD"]);
                    gd_list.Columns.AddRange(cb3);
                    cb3.DisplayIndex = index;
                    
                    DataGridViewComboBoxColumn cb4 = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtUser,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "담당자",
                        DataPropertyName = "USER_ID",
                        Name = "USER_ID",
                        Width = 200
                    };
                    index = gd_list.Columns["USER_ID"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["USER_ID"]);
                    gd_list.Columns.AddRange(cb4);
                    cb4.DisplayIndex = index;
                    
                    DataGridViewComboBoxColumn cb5 = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtMgrCode,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "설치 위치",
                        DataPropertyName = "MGR_CD",
                        Name = "MGR_CD",
                        Width = 200
                    };
                    index = gd_list.Columns["MGR_CD"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["MGR_CD"]);
                    gd_list.Columns.AddRange(cb5);
                    cb5.DisplayIndex = index;

                    /*
                    DataGridViewComboBoxColumn cb6 = new DataGridViewComboBoxColumn()
                    {
                        ValueType = typeof(DataTable),
                        DataSource = _dtVer,
                        DisplayMember = "ITEM_NM",
                        ValueMember = "ITEM_CD",
                        HeaderText = "버전",
                        DataPropertyName = "VER_CD",
                        Name = "VER_CD",
                        Width = 120
                    };
                    index = gd_list.Columns["VER_CD"].DisplayIndex;
                    gd_list.Columns.Remove(gd_list.Columns["VER_CD"]);
                    gd_list.Columns.AddRange(cb6);
                    cb6.DisplayIndex = index;
                    */
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
                        Text = "이력보기",
                        HeaderText = "",
                        Name = "HISTORY",
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

        #endregion

        private void ProductAction(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    ClearSearchData();
                    SetSearchData("PRODUCT_ID", row.Cells["PRODUCT_ID"].Value);
                    SetSearchData("STAT_CD", row.Cells["STAT_CD"].Value);
                    SetSearchData("VER_CD", row.Cells["VER_CD"].Value);
                    SetSearchData("COMP_CD", row.Cells["COMP_CD"].Value);
                    SetSearchData("COMP_USER_ID", row.Cells["USER_ID"].Value);
                    SetSearchData("MGR_CD", row.Cells["MGR_CD"].Value);
                    SetSearchData("DESC", row.Cells["MGR_DESC"].Value);
                    SetSearchData("USER_ID", DTOFactory.UserId);
                    SetServiceId("SetProductInfo");

                    try
                    {
                        DTOFactory.Transaction(new MachineDTO());
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
                else if ("HISTORY".Equals(view.Columns[e.ColumnIndex].Name))
                {

                    var frm = new MachineHistory()
                    {
                        ProductId = row.Cells["PRODUCT_ID"].Value.ToString()
                    };
                    frm.ShowDialog();
                }
            }
        }
    }
}
