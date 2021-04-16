using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace MYC.UI.Machine.Popup
{
    public partial class CustomerOrderInsertPopup : MYCForm
    {
        public string COMP_CD { get; set; }
        protected DataTable _dt = new DataTable();

        public CustomerOrderInsertPopup()
        {
            InitializeComponent();
        }

        private void CustomerOrderInsertPopup_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();
            
            InitDataTable();
            InitSpread();
            InitControls();

            DTOFactory.Complete();
        }

        private void InitDataTable()
        {
            _dt.Columns.Add("ITEM_NO");
            _dt.Columns.Add("MODEL_ID");
            _dt.Columns.Add("UNIT_COST");
            _dt.Columns.Add("QTY");
        }

        private void InitSpread()
        {
            gd_List.ReadOnly = true;
            gd_List.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gd_List.DataSource = _dt;

            gd_List.Columns[0].HeaderText = "관리번호";
            gd_List.Columns[1].HeaderText = "제품코드";
            gd_List.Columns[2].HeaderText = "단가";
            gd_List.Columns[3].HeaderText = "수량";

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn()
            {
                HeaderText = "관리",
                Name = "DELETE",
                Text = "삭제",
                UseColumnTextForButtonValue = true
            };

            gd_List.Columns.Add(btn1);
        }

        private void InitControls()
        {
            cboCustomer.Params.Clear();
            cboCustomer.Params.Add("strCompType", "C");
            cboCustomer.BindDataSet();
            cboCustomer.SetItemChecked(COMP_CD);

            cboCustMember.Params.Clear();
            cboCustMember.Params.Add("strCompType", "C");
            cboCustMember.Params.Add("strCompCode", cboCustomer.ValueList);
            cboCustMember.BindDataSet();

            cboDeliSite.Params.Clear();
            cboDeliSite.Params.Add("strItem", string.Format("DELIVERY_SITE_{0}", cboCustomer.ValueList));
            cboDeliSite.BindDataSet();

            cboPriceType.Params.Clear();
            cboPriceType.Params.Add("strItem", "PRICE_TYPE");
            cboPriceType.BindDataSet();

            cboModel.Params.Clear();
            cboModel.Params.Add("strCompCode", cboCustomer.ValueList);
            cboModel.BindDataSet();

            dtTarget.Value = DateTime.Now;
        }

        private void Save(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("COMP_CD", cboCustMember.ValueList);
            SetSearchData("UPDATE_DT", dtTarget.Value.ToString("yyyy-MM-dd"));
            SetSearchData("CST_USER_ID", DTOFactory.UserId);
            if ("".Equals(cboCustMember.ValueList))
            {
                ViewMessage.Warning("고객사 담당자를 선택해 주시기 바랍니다.");
                return;
            }
            else
            {
                SetSearchData("COMP_USER_ID", cboCustMember.ValueList);
            }

            if ("".Equals(txtDeliNo.Text))
            {
                ViewMessage.Warning("발주번호를 입력해 주시기 바랍니다.");
                return;
            }
            else
            {
                SetSearchData("DOC_ID", txtDeliNo.Text);
            }

            if ("".Equals(cboDeliSite.ValueList))
            {
                ViewMessage.Warning("납품 장소를 선택해 주시기 바랍니다.");
                return;
            }
            else
            {
                SetSearchData("SITE_NM", cboDeliSite.ValueList);
            }

            if ("".Equals(cboPriceType.ValueList))
            {
                ViewMessage.Warning("대금 지불 방식을 선택해 주시기 바랍니다.");
                return;
            }
            else
            {
                SetSearchData("STAT_CD", cboPriceType.ValueList);
            }

            if (_dt.Rows.Count == 0)
            {
                ViewMessage.Warning("납품 리스트가 없습니다.");
                return;
            }
            else
            {
                string ITEM_NO = "";
                string MODEL_ID = "";
                string UNIT_COST = "";
                string QTY = "";

                foreach (DataRow row in _dt.Rows)
                {
                    ITEM_NO += "," + row["ITEM_NO"];
                    MODEL_ID += "," + row["MODEL_ID"];
                    UNIT_COST += "," + row["UNIT_COST"];
                    QTY += "," + row["QTY"];
                }

                SetSearchData("SEQ_NO", ITEM_NO.Substring(1));
                SetSearchData("MODEL_ID", MODEL_ID.Substring(1));
                SetSearchData("UNIT_COST", UNIT_COST.Substring(1));
                SetSearchData("QTY", QTY.Substring(1));
                SetServiceId("SetDeliverList");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());

                    ViewMessage.Info("납품 등록이 완료 되었습니다.");
                    Close();
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void AddRow(object sender, EventArgs e)
        {
            DataRow dr = _dt.NewRow();

            if ("".Equals(txtItemNo.Text))
            {
                ViewMessage.Warning("관리번호를 입력해 주시기 바랍니다.");
                return;
            }
            else
            {
                dr["ITEM_NO"] = txtItemNo.Text;
            }

            if ("".Equals(cboModel.ValueList))
            {
                ViewMessage.Warning("제품 모델을 선택해 주시기 바랍니다.");
                return;
            }
            else
            {
                dr["MODEL_ID"] = cboModel.ValueList;
            }

            if ("".Equals(txtUnitCost.Text))
            {
                ViewMessage.Warning("제품 단가를 입력해 주시기 바랍니다.");
                return;
            }
            else
            {
                dr["UNIT_COST"] = txtUnitCost.Text;
            }

            if ("".Equals(txtCount.Text))
            {
                ViewMessage.Warning("납품 수량을 입력해 주시기 바랍니다.");
                return;
            }
            else
            {
                dr["QTY"] = txtCount.Text;
            }

            _dt.Rows.Add(dr);
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if ("DELETE".Equals(view.Columns[e.ColumnIndex].Name))
            {
                _dt.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
