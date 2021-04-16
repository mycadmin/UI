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
    public partial class CustomerModelManager : MYCControl
    {
        #region Field        
        protected DataTable _dtModel = new DataTable();
        protected DataTable _dtEst = new DataTable();
        protected DataTable _dtSpec = new DataTable();
        #endregion

        #region Init
        public CustomerModelManager()
        {
            InitializeComponent();
        }

        private void CustomerModelManager_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitDataTable();
            InitControls();

            DTOFactory.Complete();
        }

        private void InitDataTable()
        {
            _dtModel.Columns.Add("COMP_CD");
            _dtModel.Columns.Add("CST_MODEL_ID");
            _dtModel.Columns.Add("MODEL_DESC");
            _dtModel.Columns.Add("MODEL_ID_LVAL");
        }

        private void InitControls()
        {
            cboComp.Params.Clear();
            cboComp.Params.Add("strCompType", "C");
            cboComp.BindDataSet();

            cboCompCode.Params.Clear();
            cboCompCode.Params.Add("strCompType", "C");
            cboCompCode.BindDataSet();

            cbockModel.Params.Clear();
            cbockModel.Params.Add("strModel", "");
            cbockModel.BindDataSet();

            cboQtyType.Params.Clear();
            cboQtyType.Params.Add("strItem", "QTY_CODE");
            cboQtyType.BindDataSet();
        }
        #endregion

        #region Event
        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("COMP_CD", cboComp.ValueList);
            SetServiceId("GetModelList");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtModel = ds.Tables["ds_model"];
                gd_List.DataSource = _dtModel;
                gd_List.SetGridColumn(ds.Tables["ds_column"]);

                txtModelId.Text = "";
                txtModelDesc.Text = "";
                txtGrp1.Text = "";
                txtGrp2.Text = "";
                txtItm.Text = "";
                txtSpec.Text = "";
                txtSpecDesc.Text = "";
                txtEstNo.Text = "";
                txtEstSubject.Text = "";
                txtEstUnitCost.Text = "";
                txtEstDesc.Text = "";

                cboCompCode.SetItemChecked(cboComp.ValueList);
                cbockModel.SetItemChecked("");
                cboQtyType.SetItemChecked("");

                if (_dtModel.Rows.Count > 0)
                {
                    GetModelInfo(0);
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
        #endregion

        private void AddModelRow(object sender, EventArgs e)
        {
                DataRow dr = _dtModel.NewRow();
                _dtModel.Rows.Add(dr);
        }

        private void GetModelInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GetModelInfo(e.RowIndex);
            }
        }

        private void GetModelInfo(int row)
        {
            ClearSearchData();
            SetSearchData("COMP_CD", _dtModel.Rows[row]["COMP_CD"]);
            SetSearchData("MODEL_CD", _dtModel.Rows[row]["CST_MODEL_ID"]);
            SetServiceId("GetModelDetail");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtEst = ds.Tables["ds_est"];
                _dtSpec = ds.Tables["ds_spec"];

                gd_Spec.DataSource = _dtSpec;
                gd_Est.DataSource = _dtEst;

                gd_Est.SetGridColumn(ds.Tables["ds_column2"]);
                gd_Spec.SetGridColumn(ds.Tables["ds_column3"]);
                
                txtModelId.Text = _dtModel.Rows[row]["CST_MODEL_ID"].ToString();
                txtModelDesc.Text = _dtModel.Rows[row]["MODEL_DESC"].ToString();
                cbockModel.SetItemChecked(_dtModel.Rows[row]["MODEL_ID_LVAL"].ToString());

                if (_dtEst.Rows.Count > 0)
                {
                    txtEstNo.Text = _dtEst.Rows[0]["GRP_NO"].ToString();
                    txtEstSubject.Text = _dtEst.Rows[0]["MODEL_DESC"].ToString();
                    txtEstUnitCost.Text = _dtEst.Rows[0]["UNIT_COST"].ToString();
                    txtEstDesc.Text = _dtEst.Rows[0]["ITM_DESC"].ToString();
                    cboQtyType.SetItemChecked(_dtEst.Rows[0]["QTY_CD"].ToString());
                }

                if (_dtSpec.Rows.Count > 0)
                {
                    txtGrp1.Text = _dtSpec.Rows[0]["ITM_GRP_NM_1"].ToString();
                    txtGrp2.Text = _dtSpec.Rows[0]["ITM_GRP_NM_2"].ToString();
                    txtItm.Text = _dtSpec.Rows[0]["ITM_NM"].ToString();
                    txtSpec.Text = _dtSpec.Rows[0]["SPEC_NM"].ToString();
                    txtSpecDesc.Text = _dtSpec.Rows[0]["SPEC_DESC"].ToString();
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void GetSpec(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int row = e.RowIndex;

                txtGrp1.Text = _dtSpec.Rows[row]["ITM_GRP_NM_1"].ToString();
                txtGrp2.Text = _dtSpec.Rows[row]["ITM_GRP_NM_2"].ToString();
                txtItm.Text = _dtSpec.Rows[row]["ITM_NM"].ToString();
                txtSpec.Text = _dtSpec.Rows[row]["SPEC_NM"].ToString();
                txtSpecDesc.Text = _dtSpec.Rows[row]["SPEC_DESC"].ToString();
            }
        }

        private void GetEst(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int row = e.RowIndex;

                txtEstNo.Text = _dtEst.Rows[row]["GRP_NO"].ToString();
                txtEstSubject.Text = _dtEst.Rows[row]["MODEL_DESC"].ToString();
                txtEstUnitCost.Text = _dtEst.Rows[row]["UNIT_COST"].ToString();
                txtEstDesc.Text = _dtEst.Rows[row]["ITM_DESC"].ToString();
                cboQtyType.SetItemChecked(_dtEst.Rows[row]["QTY_CD"].ToString());
            }
        }

        private void KeyFilter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) || e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void SetPrice(object sender, EventArgs e)
        {
            string strPrice = txtModelDesc.Text.Replace(",", "");

            txtModelDesc.Text = ClsSpread.GetPriceNum(strPrice);
            txtModelDesc.Select(txtModelDesc.Text.Length, 1);
        }

        private void ModelSave(object sender, EventArgs e)
        {
            if (!"".Equals(cboCompCode.ValueList))
            {
                if (gd_List.SelectedRows.Count > 0)
                {
                    DataRow row = _dtModel.Rows[gd_List.SelectedRows[0].Index];

                    if (row["CST_MODEL_ID"].ToString().Equals(txtModelId.Text))
                    {
                        row["CST_MODEL_ID"] = txtModelId.Text;
                        row["MODEL_DESC"] = txtModelDesc.Text;
                        row["MODEL_ID_LVAL"] = cbockModel.ValueList;
                    }
                    else
                    {
                        row = _dtModel.NewRow();
                        row["COMP_CD"] = cboComp.ValueList;
                        row["CST_MODEL_ID"] = txtModelId.Text;
                        row["MODEL_DESC"] = txtModelDesc.Text;
                        row["MODEL_ID_LVAL"] = cbockModel.ValueList;
                        _dtModel.Rows.Add(row);

                        _dtEst.Rows.Clear();
                        _dtSpec.Rows.Clear();

                        txtGrp1.Text = "";
                        txtGrp2.Text = "";
                        txtItm.Text = "";
                        txtSpec.Text = "";
                        txtSpecDesc.Text = "";
                        txtEstNo.Text = "";
                        txtEstSubject.Text = "";
                        txtEstUnitCost.Text = "";
                        txtEstDesc.Text = "";

                        cbockModel.SetItemChecked("");
                        cboQtyType.SetItemChecked("");
                    }
                }
                else
                {
                    DataRow row = _dtModel.NewRow();
                    row["COMP_CD"] = cboCompCode.ValueList;
                    row["CST_MODEL_ID"] = txtModelId.Text;
                    row["MODEL_DESC"] = txtModelDesc.Text;
                    row["MODEL_ID_LVAL"] = cbockModel.ValueList;
                    _dtModel.Rows.Add(row);
                }

                ClearSearchData();
                SetSearchData("COMP_CD", cboCompCode.ValueList);
                SetSearchData("MODEL_CD", txtModelId.Text);
                SetSearchData("MODEL_ID", cbockModel.ValueList);
                SetSearchData("MODEL_NM", txtModelDesc.Text);
                SetSearchData("USER_ID", DTOFactory.UserId);
                SetServiceId("SetModelInfo");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());

                    ViewMessage.Info("저장이 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void ModelSpecNew(object sender, EventArgs e)
        {
            DataRow row = _dtSpec.NewRow();
            row["COMP_CD"] = cboCompCode.ValueList;
            row["CST_MODEL_ID"] = txtModelId.Text;
            row["SEQ_NO"] = "".Equals(_dtSpec.Compute("MAX(SEQ_NO)", "").ToString()) ? 1 : int.Parse(_dtSpec.Compute("MAX(SEQ_NO)", "").ToString()) + 1;
            _dtSpec.Rows.Add(row);

            gd_Spec.Rows[gd_Spec.Rows.Count - 1].Selected = true;

            ModelSpecSave(null, null);
        }

        private void ModelSpecSave(object sender, EventArgs e)
        {
            if (gd_Spec.SelectedRows.Count > 0)
            {
                DataRow row = _dtSpec.Rows[gd_Spec.SelectedRows[0].Index];

                row["ITM_GRP_NM_1"] = txtGrp1.Text;
                row["ITM_GRP_NM_2"] = txtGrp2.Text;
                row["ITM_NM"] = txtItm.Text;
                row["SPEC_NM"] = txtSpec.Text;
                row["SPEC_DESC"] = txtSpecDesc.Text;

                ClearSearchData();
                SetSearchData("COMP_CD", row["COMP_CD"]);
                SetSearchData("MODEL_CD", row["CST_MODEL_ID"]);
                SetSearchData("SEQ_NO", row["SEQ_NO"]);
                SetSearchData("GROUP_NM_1", row["ITM_GRP_NM_1"]);
                SetSearchData("GROUP_NM_2", row["ITM_GRP_NM_2"]);
                SetSearchData("ITEM_NM", row["ITM_NM"]);
                SetSearchData("SPEC_NM", row["SPEC_NM"]);
                SetSearchData("DESC", row["SPEC_DESC"]);
                SetSearchData("USER_ID", DTOFactory.UserId);
                SetServiceId("SetModelSpcInfo");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());

                    ViewMessage.Info("저장이 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void ModelEstNew(object sender, EventArgs e)
        {
            DataRow row = _dtEst.NewRow();

            row["COMP_CD"] = cboCompCode.ValueList;
            row["CST_MODEL_ID"] = txtModelId.Text;
            row["SEQ_NO"] = "".Equals(_dtEst.Compute("MAX(SEQ_NO)", "").ToString()) ? 1 : int.Parse(_dtEst.Compute("MAX(SEQ_NO)", "").ToString()) + 1;
            _dtEst.Rows.Add(row);

            gd_Est.Rows[gd_Est.Rows.Count - 1].Selected = true;

            ModelEstSave(null, null);
        }

        private void ModelEstSave(object sender, EventArgs e)
        {
            if (gd_Est.SelectedRows.Count > 0)
            {
                DataRow row = _dtEst.Rows[gd_Est.SelectedRows[0].Index];

                row["GRP_NO"] = txtEstNo.Text;
                row["MODEL_DESC"] = txtEstSubject.Text;
                row["QTY_CD"] = cboQtyType.ValueList;
                row["UNIT_COST"] = txtEstUnitCost.Text.Equals("") ? "0" : txtEstUnitCost.Text.Replace(",", "");
                row["ITM_DESC"] = txtEstDesc.Text;

                ClearSearchData();                
                SetSearchData("COMP_CD", row["COMP_CD"]);
                SetSearchData("MODEL_CD", row["CST_MODEL_ID"]);
                SetSearchData("SEQ_NO", row["SEQ_NO"]);
                SetSearchData("GROUP_NO", row["GRP_NO"]);
                SetSearchData("MODEL_NM", row["MODEL_DESC"]);
                SetSearchData("QTY", row["QTY_CD"]);
                SetSearchData("UNIT_COST", row["UNIT_COST"]);
                SetSearchData("DESC", row["ITM_DESC"]);
                SetSearchData("USER_ID", DTOFactory.UserId);
                SetServiceId("SetModelEstInfo");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());

                    ViewMessage.Info("저장이 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void ModelDelete(object sender, EventArgs e)
        {
            if (gd_List.SelectedRows.Count > 0)
            {
                DataRow row = _dtModel.Rows[gd_List.SelectedRows[0].Index];

                if (System.Windows.Forms.MessageBox.Show(
                        row["CST_MODEL_ID"].ToString() + " 제품의 이력을 일괄 삭제 하겠습니까?", "모델 삭제"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearSearchData();
                    SetSearchData("COMP_CD", row["COMP_CD"]);
                    SetSearchData("MODEL_CD", row["CST_MODEL_ID"]);
                    SetServiceId("DelModelInfo");

                    try
                    {
                        DTOFactory.Transaction(new MachineDTO());

                        ViewMessage.Info("삭제가 완료 되었습니다.");
                        _dtModel.Rows.RemoveAt(gd_List.SelectedRows[0].Index);

                        txtModelId.Text = "";
                        txtModelDesc.Text = "";
                        txtGrp1.Text = "";
                        txtGrp2.Text = "";
                        txtItm.Text = "";
                        txtSpec.Text = "";
                        txtSpecDesc.Text = "";
                        txtEstNo.Text = "";
                        txtEstSubject.Text = "";
                        txtEstUnitCost.Text = "";
                        txtEstDesc.Text = "";

                        cboCompCode.SetItemChecked(cboComp.ValueList);
                        cbockModel.SetItemChecked("");
                        cboQtyType.SetItemChecked("");

                        if (_dtModel.Rows.Count > 0)
                        {
                            GetModelInfo(0);
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
            }
        }

        private void ModelSpecDelete(object sender, EventArgs e)
        {
            if (gd_Est.SelectedRows.Count > 0)
            {
                DataRow row = _dtSpec.Rows[gd_Est.SelectedRows[0].Index];

                if (System.Windows.Forms.MessageBox.Show(
                        " 선택한 항목을 삭제 하겠습니까?", "Spec 삭제"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearSearchData();
                    SetSearchData("COMP_CD", row["COMP_CD"]);
                    SetSearchData("MODEL_CD", row["CST_MODEL_ID"]);
                    SetSearchData("GROUP_NM_1", row["ITM_GRP_NM_1"]);
                    SetSearchData("GROUP_NM_2", row["ITM_GRP_NM_2"]);
                    SetSearchData("ITEM_NM", row["ITM_NM"]);
                    SetServiceId("DelModelSpcInfo");

                    try
                    {
                        DTOFactory.Transaction(new MachineDTO());

                        ViewMessage.Info("삭제가 완료 되었습니다.");
                        _dtSpec.Rows.RemoveAt(gd_Est.SelectedRows[0].Index);

                        txtGrp1.Text = "";
                        txtGrp2.Text = "";
                        txtItm.Text = "";
                        txtSpec.Text = "";
                        txtSpecDesc.Text = "";
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
            }
        }

        private void ModelEstDelete(object sender, EventArgs e)
        {
            if (gd_Spec.SelectedRows.Count > 0)
            {
                DataRow row = _dtEst.Rows[gd_Spec.SelectedRows[0].Index];

                if (System.Windows.Forms.MessageBox.Show(
                        " 선택한 항목을 삭제 하겠습니까?", "견적서 삭제"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearSearchData();
                    SetSearchData("COMP_CD", row["COMP_CD"]);
                    SetSearchData("MODEL_CD", row["CST_MODEL_ID"]);
                    SetSearchData("SEQ_NO", row["SEQ_NO"]);
                    SetServiceId("DelModelEstInfo");

                    try
                    {
                        DTOFactory.Transaction(new MachineDTO());

                        ViewMessage.Info("삭제가 완료 되었습니다.");
                        _dtEst.Rows.RemoveAt(gd_Spec.SelectedRows[0].Index);

                        txtEstNo.Text = "";
                        txtEstSubject.Text = "";
                        txtEstUnitCost.Text = "";
                        txtEstDesc.Text = "";

                        cboQtyType.SetItemChecked("");
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
            }
        }
    }
}
