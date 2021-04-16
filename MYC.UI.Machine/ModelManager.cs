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
    public partial class ModelManager : MYCControl_noframe
    {
        #region Field        
        protected DataTable _dtModel = new DataTable();
        protected DataTable _dtPlan = new DataTable();
        protected DataTable _dtEstimate = new DataTable();
        protected DataTable _dtDocument = new DataTable();
        #endregion

        #region Init
        public ModelManager()
        {
            InitializeComponent();
        }

        private void ModelManager_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();
            InitControls();
            DTOFactory.Complete();
        }

        private void InitControls()
        {
            cboType.Params.Clear();
            cboType.Params.Add("strItem", "MODEL_TYPE");
            cboType.BindDataSet();

            cboProductType.Params.Clear();
            cboProductType.Params.Add("strItem", "PRODUCT_CODE");
            cboProductType.BindDataSet();

            cboMaterial.Params.Clear();
            cboMaterial.Params.Add("strItem", "MATERIAL_CODE");
            cboMaterial.BindDataSet();

            cboVendor.Params.Clear();
            cboVendor.Params.Add("strCompType", "V");
            cboVendor.BindDataSet();

            cboProject.Params.Clear();
            cboProject.Params.Add("strUserId", DTOFactory.UserId);
            cboProject.BindDataSet();
        }
        #endregion

        private void GetModelList(object sender, EventArgs e)
        {
            if (!"".Equals(cboType.ValueList))
            {
                ClearSearchData();
                SetSearchData("MODEL_TYPE", cboType.ValueList);
                SetServiceId("GetModelList");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());
                    DataSet ds = DTOFactory.GetDataSet();

                    _dtModel = ds.Tables["ds_model"];
                    gd_List.DataSource = _dtModel;

                    gd_List.SetGridColumn(ds.Tables["ds_column"]);

                    pnlMain.Enabled = false;
                    pnlPlan.Enabled = false;
                    pnlEstimate.Enabled = false;
                    pnlDocument.Enabled = false;

                    txtModelId.Text = "";
                    txtModelName.Text = "";
                    txtSpecD.Text = "";
                    txtSpecW.Text = "";
                    txtSpecH.Text = "";
                    txtModelCode.Text = "";
                    cboMaterial.SetItemChecked("");                    
                    cboProductType.SetItemChecked("");
                    cboVendor.SetItemChecked("");

                    _dtPlan.Clear();
                    _dtEstimate.Clear();
                    _dtDocument.Clear();

                    btnModelAdd.Enabled = true;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void AddModelRow(object sender, EventArgs e)
        {
            DataRow dr = _dtModel.NewRow();
            dr["PLAN_CD"] = DateTime.Now.ToString("yyyyMMddHHmmss");
            dr["ESTIMATE_CD"] = DateTime.Now.AddSeconds(1).ToString("yyyyMMddHHmmss");
            dr["LINK_CD"] = DateTime.Now.AddSeconds(2).ToString("yyyyMMddHHmmss");
            _dtModel.Rows.Add(dr);
        }

        private void GetModelInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataRow row = _dtModel.Rows[e.RowIndex];
                GetModelInfo(e.RowIndex);

                pnlMain.Enabled = true;

                if (!"".Equals(row["MODEL_ID"]))
                {
                    pnlPlan.Enabled = true;
                    pnlEstimate.Enabled = true;
                    pnlDocument.Enabled = true;
                }

                txtModelId.Text = row["MODEL_ID"].ToString();
                txtModelName.Text = row["MODEL_NM"].ToString();
                txtSpecD.Text = row["SPEC_D_VAL"].ToString();
                txtSpecW.Text = row["SPEC_W_VAL"].ToString();
                txtSpecH.Text = row["SPEC_H_VAL"].ToString();
                txtModelCode.Text = row["MODEL_CD"].ToString();
                cboMaterial.SetItemChecked(row["MATERIAL_CD"].ToString());
                cboProductType.SetItemChecked(row["PRODUCT_TYP_CD"].ToString());
                cboVendor.SetItemChecked(row["VENDOR_CD"].ToString());
                cboProject.SetItemChecked(row["PRO_ID"].ToString());
            }
        }

        private void GetModelInfo(int index)
        {
            DataRow row = _dtModel.Rows[index];
            
            ClearSearchData();
            SetSearchData("PLAN_CD", row["PLAN_CD"]);
            SetSearchData("ESTIMATE_CD", row["ESTIMATE_CD"]);
            SetSearchData("LINK_CODE", row["LINK_CD"]);
            SetServiceId("GetModelInfo");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtPlan = ds.Tables["ds_plan"];
                _dtEstimate = ds.Tables["ds_estimate"];
                _dtDocument = ds.Tables["ds_document"];
                LstPlan.DataSource = _dtPlan;
                LstEstimate.DataSource = _dtEstimate;
                LstDocument.DataSource = _dtDocument;
                LstPlan.DisplayMember = "FILE_DESC";
                LstEstimate.DisplayMember = "FILE_DESC";
                LstDocument.DisplayMember = "FILE_DESC";                
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void KeyFilter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    TextBox control = (TextBox)sender;

                    if (control.Text.Split('.').Length == 1)
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void ModelSave(object sender, EventArgs e)
        {
            DataRow row = _dtModel.Rows[gd_List.SelectedRows[0].Index];
            ClearSearchData();
            SetSearchData("MODEL_ID", txtModelId.Text);
            SetSearchData("MODEL_CD", txtModelCode.Text);
            SetSearchData("MODEL_NM", txtModelName.Text);
            SetSearchData("MMDEL_TYPE", cboType.ValueList);
            SetSearchData("PRODUCT_TYPE", cboProductType.ValueList);
            SetSearchData("SPEC_W", "".Equals(txtSpecW.Text) ? 0 : float.Parse(txtSpecW.Text));
            SetSearchData("SPEC_D", "".Equals(txtSpecD.Text) ? 0 : float.Parse(txtSpecD.Text));
            SetSearchData("SPEC_H", "".Equals(txtSpecH.Text) ? 0 : float.Parse(txtSpecH.Text));
            SetSearchData("YENDOR_CD", cboVendor.ValueList);
            SetSearchData("MATERIAL_CD", cboMaterial.ValueList);
            SetSearchData("PLAN_CD", row["PLAN_CD"]);
            SetSearchData("ESTIMATE_CD", row["ESTIMATE_CD"]);
            SetSearchData("LINK_CODE", row["LINK_CD"]);
            SetSearchData("PROJECT_ID", cboProject.ValueList);
            SetSearchData("USER_ID", DTOFactory.UserId);
            SetServiceId("SetModelInfo");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataTable dt = DTOFactory.GetDataTable();

                DataRow row2 = dt.Rows[0];

                pnlPlan.Enabled = true;
                pnlEstimate.Enabled = true;
                pnlDocument.Enabled = true;

                foreach(DataColumn col in dt.Columns)
                {
                    row[col.ColumnName] = row2[col.ColumnName].ToString();
                }
                txtModelId.Text = row2["MODEL_ID"].ToString();

                ViewMessage.Info("저장이 완료 되었습니다.");
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void AddLink(object sender, EventArgs e)
        {
            DTOFactory.Action();
            Button btn = (Button)sender;
            OpenFileDialog frm = new OpenFileDialog();
            DataRow row = _dtModel.Rows[gd_List.SelectedRows[0].Index];

            string filter = "";
            string linkcode = "";

            if ("btnPlanImport".Equals(btn.Name))
            {
                filter = "CAD Files (*.dwg,*.dxf,*.dwt,*.dwf)|*.dwg;*.dxf;*.dwt;*.dwf|All Files (*.*)|*.*";
                linkcode = row["PLAN_CD"].ToString();
            }
            else if ("btnEstimateImport".Equals(btn.Name))
            {
                filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                linkcode = row["ESTIMATE_CD"].ToString();
            }
            else if ("btnDocumentImport".Equals(btn.Name))
            {
                filter = "All Files (*.*)|*.*";
                linkcode = row["LINK_CD"].ToString();
            }

            frm.Filter = filter;

            if (frm.ShowDialog() == DialogResult.OK)
            {   
                FileSender snd = new FileSender(linkcode, frm.FileName);
                snd.Close();

                GetModelInfo(gd_List.SelectedRows[0].Index);
            }
            DTOFactory.Complete();
        }

        private void ViewLink(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string link = "";

            if ("btnPlanView".Equals(btn.Name))
            {
                link = _dtPlan.Rows[LstPlan.SelectedIndex]["LINK"].ToString();
            }
            else if ("btnEstimateView".Equals(btn.Name))
            {
                link = _dtEstimate.Rows[LstEstimate.SelectedIndex]["LINK"].ToString();
            }
            else if ("btnDocumentView".Equals(btn.Name))
            {
                link = _dtDocument.Rows[LstDocument.SelectedIndex]["LINK"].ToString();
            }

            FileGet get = new FileGet(link);
            get.Close();
        }

        private void RemoveLink(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow row = _dtModel.Rows[gd_List.SelectedRows[0].Index];
            string linkcode = "";

            if ("btnPlanRemove".Equals(btn.Name))
            {
                if (LstPlan.SelectedIndex == -1)
                    return;

                linkcode = row["PLAN_CD"].ToString();
                row = _dtPlan.Rows[LstPlan.SelectedIndex];
                
            }
            else if ("btnEstimateRemove".Equals(btn.Name))
            {
                if (LstEstimate.SelectedIndex == -1)
                    return;

                linkcode = row["ESTIMATE_CD"].ToString();
                row = _dtEstimate.Rows[LstEstimate.SelectedIndex];
            }
            else if ("btnDocumentRemove".Equals(btn.Name))
            {
                if (LstDocument.SelectedIndex == -1)
                    return;

                linkcode = row["LINK_CD"].ToString();
                row = _dtDocument.Rows[LstDocument.SelectedIndex];                
            }

            if (System.Windows.Forms.MessageBox.Show(
                row["FILE_DESC"] + " File을 삭제 하시겠습니까?", "File 제거"
                , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FileSender snd = new FileSender(linkcode, row["LINK"].ToString(), false);
                snd.Close();

                if ("btnPlanImport".Equals(btn.Name))
                {
                    _dtPlan.Rows.RemoveAt(LstPlan.SelectedIndex);
                }
                else if ("btnEstimateImport".Equals(btn.Name))
                {
                    _dtEstimate.Rows.RemoveAt(LstEstimate.SelectedIndex);
                }
                else if ("btnDocumentImport".Equals(btn.Name))
                {
                    _dtDocument.Rows.RemoveAt(LstDocument.SelectedIndex);
                }
            }
        }
    }
}
