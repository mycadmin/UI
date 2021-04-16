using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Admin
{
    public partial class CodeManager : MYCControl_noframe
    {
        #region Field        
        protected DataTable _dtGroup = new DataTable();
        protected DataTable _dtItem = new DataTable();

        protected bool btnbool = false;
        #endregion

        public CodeManager()
        {
            InitializeComponent();
        }

        private void CodeManager_Load(object sender, EventArgs e)
        {
            InitSpread();

            ClearSearchData();
            SetServiceId("GetList");

            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet();
                _dtGroup = ds.Tables["ds_list"];
                gd_List.DataSource = _dtGroup;

                gd_List.Columns["ITEM_ID"].Width = panel2.Width - 20;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void InitSpread()
        {
            gd_Item.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gd_Item.ReadOnly = false;
        }

        private void AddList(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("새로 생성할 Group명칭을 입력 하시오.", "Group Add");
            DataRow dr = _dtGroup.NewRow();
            dr["ITEM_ID"] = input;
            _dtGroup.Rows.Add(dr);
        }

        private void ListClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearSearchData();
            SetSearchData("ITEM_ID", gd_List.SelectedCells[0].Value);
            SetServiceId("GetItemList");

            DTOFactory.Action();

            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet();
                _dtItem = ds.Tables["ds_item"];
                gd_Item.DataSource = _dtItem;

                if (!btnbool)
                {
                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                    {
                        Text = "저장",
                        HeaderText = "관리",
                        Name = "SAVE",
                        UseColumnTextForButtonValue = true
                    };
                    gd_Item.Columns.AddRange(bt);

                    btnbool = true;
                }
                                
                gd_Item.Columns["ITEM_CD"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }

            DTOFactory.Complete();
        }

        private void ItemClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if ("관리".Equals(view.Columns[e.ColumnIndex].HeaderText))
            {
                ClearSearchData();
                SetSearchData("ITEM_ID", gd_List.SelectedCells[0].Value);
                SetSearchData("SEQ_NO", _dtItem.Rows[e.RowIndex]["SEQ_NO"].ToString());
                SetSearchData("ITEM_CD", _dtItem.Rows[e.RowIndex]["ITEM_CD"]);
                SetSearchData("ITEM_NM", _dtItem.Rows[e.RowIndex]["ITEM_NM"]);
                SetServiceId("SetItemList");

                try
                {
                    DTOFactory.Transaction(new AdminDTO());

                    ViewMessage.Info("저장이 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }   
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
            _dtItem.Rows.Add();

            gd_Item.Rows[gd_Item.Rows.Count - 1].Cells["ITEM_CD"].ReadOnly = false;
        }
    }
}
