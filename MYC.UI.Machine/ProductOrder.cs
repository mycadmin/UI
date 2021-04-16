using System;
using System.Data;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;
using MYC.Control.Method;

namespace MYC.UI.Machine
{
    public partial class ProductOrder : MYCControl
    {
        #region Field
        protected DataTable dt_Order = new DataTable();
        protected DataTable dt_QtyCd = new DataTable();
        protected DataTable dt_VendorCd = new DataTable();
        #endregion

        public ProductOrder()
        {
            InitializeComponent();

            DTOFactory.Action();
            InitControls();
            DTOFactory.Complete();
        }

        private void InitControls()
        {
            #region Customer
            cboCustomer.Params.Add("strCompType", "C");
            cboCustomer.BindDataSet();
            #endregion Customer

            #region Model Type
            cboType.Params.Add("strItem", "MODEL_TYPE");
            cboType.BindDataSet();
            #endregion Model Type

            CheckComboBox cbotmp = new CheckComboBox()
            {
                Sql = "CommonSearch#getCommonItems"
            };
            cbotmp.Params.Add("strItem", "QTY_CODE");
            cbotmp.BindDataSet();
            dt_QtyCd = cbotmp.DataSource;

            cbotmp.Sql = "CommonSearch#getCompList";
            cbotmp.Params.Clear();
            cbotmp.Params.Add("strCompType", "V");
            cbotmp.BindDataSet();
            dt_VendorCd = cbotmp.DataSource;

            rdoCust.Checked = true;
        }

        #region 고객사 발주 조회 조건
        private void CboCustomer_TextChanged(object sender, EventArgs e)
        {
            cboCompUser.Params.Clear();
            cboCompUser.Params.Add("strCompType", "C");
            cboCompUser.Params.Add("strCompCode", cboCustomer.ValueList);
            cboCompUser.BindDataSet();
        }

        private void CboCompUser_TextChanged(object sender, EventArgs e)
        {
            cboDocId.Params.Clear();
            cboDocId.Params.Add("strCompCode", cboCustomer.ValueList);
            cboDocId.Params.Add("strCompUser", cboCompUser.ValueList);
            cboDocId.BindDataSet();
        }

        private void BtnCustSearch_Click(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("DOC_ID", cboDocId.ValueList);
            SetServiceId("GetOrderList");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                SetGrid(ds_return);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        #endregion

        #region 자체 발주 조회 조건
        private void CboType_TextChanged(object sender, EventArgs e)
        {
            cboModel.Params.Clear();
            cboModel.Params.Add("strModel", cboType.ValueList);
            cboModel.BindDataSet();
        }

        private void BtnSelfSearch(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("MODEL_TYPE_CD", cboType.ValueList);
            SetSearchData("MODEL_ID", cboModel.ValueList);
            SetServiceId("GetModelList");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                SetGrid(ds_return);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
        #endregion

        private void OrderChange(object sender, EventArgs e)
        {
            //2021-02-19 hsh : 상단 라벨 Visible 처리 추가
            if (rdoCust.Checked)
            {
                lbCust.Visible = true;
                pnlCust.Visible = true;
                lbSelf.Visible = false;
                pnlSelf.Visible = false;
            }
            else
            {
                lbCust.Visible = false;
                pnlCust.Visible = false;
                lbSelf.Visible = true;
                pnlSelf.Visible = true;
            }
        }

        private void SetGrid(DataSet _ds)
        {
            if (dt_Order.Columns.Count == 0)
            {
                dt_Order = _ds.Tables["ds_order"].Clone();

                gd_Order.DataSource = dt_Order;
                gd_Order.SetGridColumn(_ds.Tables["ds_order_column"]);

                gd_Order.SelectionMode = DataGridViewSelectionMode.CellSelect;
                gd_Order.ReadOnly = false;
                gd_Order.Columns["MODEL_ID"].ReadOnly = true;
                gd_Order.Columns["MODEL_NM"].ReadOnly = true;
                gd_Order.Columns["SPEC_VAL"].ReadOnly = true;
                gd_Order.Columns["COST"].ReadOnly = true;

                gd_Order.Columns["QTY"].DefaultCellStyle.Format = "###,###";
                gd_Order.Columns["UNIT_COST"].DefaultCellStyle.Format = "###,###,###,###";
                gd_Order.Columns["COST"].DefaultCellStyle.Format = "###,###,###,###";
                gd_Order.Columns["DELI_DT"].DefaultCellStyle.Format = "####-##-##";

                DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn()
                {
                    ValueType = typeof(DataTable),
                    DataSource = dt_QtyCd,
                    DisplayMember = "ITEM_CD",
                    ValueMember = "ITEM_CD",
                    HeaderText = "단위",
                    DataPropertyName = "QTY_CD"
                };

                DataGridViewComboBoxColumn cb2 = new DataGridViewComboBoxColumn()
                {
                    ValueType = typeof(DataTable),
                    DataSource = dt_VendorCd,
                    DisplayMember = "ITEM_NM",
                    ValueMember = "ITEM_CD",
                    HeaderText = "발주처",
                    DataPropertyName = "VENDOR_CD"
                };

                DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                {
                    Text = "삭제",
                    HeaderText = "관리",
                    Name = "DEL",
                    UseColumnTextForButtonValue = true
                };

                int index = gd_Order.Columns["QTY_CD"].DisplayIndex;
                gd_Order.Columns.Remove(gd_Order.Columns["QTY_CD"]);
                gd_Order.Columns.AddRange(cb);
                cb.DisplayIndex = index;

                index = gd_Order.Columns["VENDOR_CD"].DisplayIndex;
                gd_Order.Columns.Remove(gd_Order.Columns["VENDOR_CD"]);
                gd_Order.Columns.AddRange(cb2);
                cb2.DisplayIndex = index;

                gd_Order.Columns.AddRange(bt);
            }

            dt_Order.Merge(_ds.Tables["ds_order"]);
        }

        private void Gd_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if ("관리".Equals(view.Columns[e.ColumnIndex].HeaderText))
            {
                dt_Order.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Gd_Order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row > -1)
            {
                dt_Order.Rows[row]["COST"] = int.Parse(dt_Order.Rows[row]["QTY"].ToString()) * int.Parse(dt_Order.Rows[row]["UNIT_COST"].ToString());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string strModelId = "";
            string strQty = "";
            string strQtyCd = "";
            string strUnitCost = "";
            string strDeliDt = "";
            string strCmt = "";
            string strDoc = "";
            string strVendor = "";
            string strOrderComp = "";

            foreach (DataRow gr in dt_Order.Rows)
            {
                if (!"".Equals(gr["VENDOR_CD"].ToString()))
                {
                    strDoc += "," + gr["ORDER_ID"].ToString();
                    strVendor += "," + gr["VENDOR_CD"].ToString();
                    strOrderComp += "," + gr["ORDER_COMP_CD"].ToString();
                    strModelId += "," + gr["MODEL_ID"].ToString();
                    strQty += "," + gr["QTY"].ToString();
                    strQtyCd += "," + gr["QTY_CD"].ToString();
                    strUnitCost += "," + gr["UNIT_COST"].ToString();
                    string date = gr["DELI_DT"].ToString();

                    if (!"".Equals(date) && date.Length == 8)
                        date = date.Substring(0, 4) + "-" + date.Substring(4, 2) + "-" + date.Substring(6, 2);

                    strDeliDt += "," + date;

                    strCmt += "," + gr["CMT_DESC"].ToString();
                }
            }

            ClearSearchData();
            SetSearchData("DOC_ID", strDoc.Length > 0 ? strDoc.Substring(1) : strDoc);
            SetSearchData("ORDER_COMP_CD", strOrderComp.Length > 0 ? strOrderComp.Substring(1) : strOrderComp);
            SetSearchData("COMP_CD", strVendor.Length > 0 ? strVendor.Substring(1) : strVendor);
            SetSearchData("MODEL_ID", strModelId.Length > 0 ? strModelId.Substring(1) : strModelId);
            SetSearchData("QTY", strQty.Length > 0 ? strQty.Substring(1) : strQty);
            SetSearchData("QTY_CD", strQtyCd.Length > 0 ? strQtyCd.Substring(1) : strQtyCd);
            SetSearchData("UNIT_COST", strUnitCost.Length > 0 ? strUnitCost.Substring(1) : strUnitCost);
            SetSearchData("DELI_DT", strDeliDt.Length > 0 ? strDeliDt.Substring(1) : strDeliDt);
            SetSearchData("DESC", strCmt.Length > 0 ? strCmt.Substring(1) : strCmt);
            SetSearchData("USER_ID", DTOFactory.UserId);
            SetServiceId("SetOrderRequest");
            DTOFactory.Transaction(new ProductDTO());
            
            ViewMessage.Info("발주요청서 저장 처리가 완료 되었습니다.");
        }


        private void BtnSample_Click(object sender, EventArgs e)
        {
            var frm = new Popup.ProductorderPopup();
            frm.ShowDialog();   
        }
    }
}
