using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace MYC.UI.Report
{
    public partial class ProjectEstimate : MYCControl
    {
        #region Field
        protected DataTable dt_Group = new DataTable();
        protected DataTable dt_List = new DataTable();
        protected DataTable dt_NewGroup = new DataTable();

        protected bool bFix = true;
        #endregion

        public string Comp_CD;

        public ProjectEstimate()
        {
            InitializeComponent();
        }

        private void ProjectEstimate_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitControls();

            DTOFactory.Complete();
        }

        private void InitControls()
        {
            cboSearchComp.Params.Clear();
            cboSearchComp.Params.Add("strCompType", "C");
            cboSearchComp.BindDataSet();

            cboCashType1.Params.Clear();
            cboCashType1.Params.Add("strItem", "PRICE_TYPE");
            cboCashType1.BindDataSet();

            cboCashType2.Params.Clear();
            cboCashType2.Params.Add("strItem", "CASH_TYPE");
            cboCashType2.BindDataSet();

            cboWarrType.Params.Clear();
            cboWarrType.Params.Add("strItem", "WARRANTY_TYPE");
            cboWarrType.BindDataSet();

            cboProject.Params.Clear();
            cboProject.Params.Add("strProject", "");
            cboProject.Params.Add("strUserId", "");
            cboProject.Params.Add("strStatus", "");
            cboProject.BindDataSet();

            cboQtyCode.Params.Clear();
            cboQtyCode.Params.Add("strItem", "QTY_CODE");
            cboQtyCode.BindDataSet();

            txtDocId.Tag = "";

            dtFrom.Value = DateTime.Now.AddDays(-7);
            dtTo.Value = DateTime.Now;
        }

        private void KeyFilter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void SetPrice(object sender, EventArgs e)
        {
            TextBox ctl = (TextBox)sender;

            string strPrice = ctl.Text.Replace(",", "");

            ctl.Text = ClsSpread.GetPriceNum(strPrice);
            ctl.Select(ctl.Text.Length, 1);
        }

        private void PriceChange(object sender, EventArgs e)
        {
            if (!"".Equals(txtItemUnitCost.Text) && !"".Equals(txtQty.Text))
                txtItemCost.Text = ClsSpread.GetPriceNum((int.Parse(txtItemUnitCost.Text.Replace(",", "")) + ("".Equals(txtItemVat.Text) ? 0 : int.Parse(txtItemVat.Text.Replace(",", "")))) * int.Parse(txtQty.Text.Replace(",", "")));
            else
                txtItemCost.Text = "0";

            if ("txtItemUnitCost".Equals(((TextBox)sender).Name) && !"".Equals(txtItemUnitCost.Text))
            {
                double price = double.Parse(txtItemUnitCost.Text.Replace(",", ""));

                if (price > 10.0)
                {
                    price = (int)(price * 0.1);
                    txtItemVat.Text = (int.Parse(price.ToString())).ToString();
                }
            }

            SetPrice(sender, e);
        }

        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("FROM_DT", dtFrom.Value.ToString("yyyy/MM/dd"));
            SetSearchData("TO_DT", dtTo.Value.ToString("yyyy/MM/dd"));
            SetSearchData("CST_COMP_CD", cboSearchComp.ValueList);
            SetServiceId("GetEstimateList");

            cboCstUser.SetItemChecked("");
            cboProject.SetItemChecked("");
            cboCashType1.SetItemChecked("");
            cboCashType2.SetItemChecked("");
            cboWarrType.SetItemChecked("");

            txtDocId.Text = "";
            txtSubject.Text = "";
            txtCost.Text = "";
            txtVat.Text = "";

            calWorkDt.Value = DateTime.Now;

            DTOFactory.Action();

            try
            {
                DTOFactory.Transaction(new ReportDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                dt_Group = ds_return.Tables["ds_group"];
                gd_Group.DataSource = dt_Group;
                gd_Group.SetGridColumn(ds_return.Tables["ds_column"]);

                cboCstUser.Params.Clear();
                cboCstUser.Params.Add("strCompCode", cboSearchComp.ValueList);
                cboCstUser.BindDataSet();

                cboItmModel.Params.Clear();
                cboItmModel.Params.Add("strCompCode", cboSearchComp.ValueList);
                cboItmModel.BindDataSet();

                //검색 기록이 없을때 rows가 추가되는걸 방지
                if (gd_Group.Rows.Count == 0)
                    gd_Group.Columns["Rows"].Visible = false;

                panel5.Enabled = true;
                panel7.Enabled = true;
                if (dt_Group.Rows.Count != 0)
                    ViewGroup(gd_Group, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }

            DTOFactory.Complete();

        }

        private void ViewGroup(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                if (!"".Equals(row.Cells["CRT_TM"].Value.ToString()))
                    calWorkDt.Value = DateTime.Parse(row.Cells["CRT_TM"].Value.ToString());

                cboCstUser.SetItemChecked(row.Cells["CST_USER_ID"].Value.ToString());
                cboProject.SetItemChecked(row.Cells["PRO_ID"].Value.ToString());
                cboCashType1.SetItemChecked(row.Cells["CASH_TYP_CD_1"].Value.ToString());
                cboCashType2.SetItemChecked(row.Cells["CASH_TYP_CD_2"].Value.ToString());
                cboWarrType.SetItemChecked(row.Cells["WARRANTY_TYP_CD"].Value.ToString());

                txtDocId.Text = row.Cells["DOC_ID"].Value.ToString();
                txtDocId.Tag = "";
                txtSubject.Text = row.Cells["SUBJECT"].Value.ToString();
                txtCost.Text = ClsSpread.GetPriceNum(row.Cells["COST"].Value.ToString());
                txtVat.Text = ClsSpread.GetPriceNum(row.Cells["VAT"].Value.ToString());

                if (!"".Equals(row.Cells["DOC_ID"].Value.ToString()))
                {
                    ClearSearchData();
                    SetSearchData("DOC_ID", row.Cells["DOC_ID"].Value.ToString());
                    SetServiceId("GetEstimateItem");

                    try
                    {
                        DTOFactory.Transaction(new ReportDTO());
                        DataSet ds_return = DTOFactory.GetDataSet();

                        dt_List = ds_return.Tables["ds_list"];
                        gd_List.DataSource = dt_List;
                        gd_List.SetGridColumn(ds_return.Tables["ds_column"]);

                        panel3.Enabled = true;
                        panel5.Enabled = true;

                        gd_List.Columns[11].Visible = false;

                        //검색 기록이 없을때 rows가 추가되는걸 방지
                        if (gd_List.Rows.Count == 0)
                            gd_List.Columns["Rows"].Visible = false;

                        if ("Y".Equals(row.Cells["SEND_YN"].Value.ToString()))
                        {
                            //List
                            btnSave.Enabled = false;
                            txtSubject.Enabled = false;
                            calWorkDt.Enabled = false;
                            cboCstUser.Enabled = false;
                            cboCashType1.Enabled = false;
                            cboCashType2.Enabled = false;
                            cboWarrType.Enabled = false;
                            cboProject.Enabled = false;

                            //Item
                            txtNo.Enabled = false;
                            cboItmModel.Enabled = false;
                            txtItemName.Enabled = false;
                            txtQty.Enabled = false;
                            cboQtyCode.Enabled = false;
                            txtItemUnitCost.Enabled = false;
                            txtItemVat.Enabled = false;
                            txtItemDesc.Enabled = false;
                            btnItemSave.Enabled = false;
                            btnItemNew.Enabled = false;
                        }
                        else
                        {
                            //List
                            btnSave.Enabled = true;
                            txtSubject.Enabled = true;
                            calWorkDt.Enabled = true;
                            cboCstUser.Enabled = true;
                            cboCashType1.Enabled = true;
                            cboCashType2.Enabled = true;
                            cboWarrType.Enabled = true;
                            cboProject.Enabled = true;

                            //Item
                            txtNo.Enabled = true;
                            cboItmModel.Enabled = true;
                            txtItemName.Enabled = true;
                            txtQty.Enabled = true;
                            cboQtyCode.Enabled = true;
                            txtItemUnitCost.Enabled = true;
                            txtItemVat.Enabled = true;
                            txtItemDesc.Enabled = true;
                            btnItemSave.Enabled = true;
                            btnItemNew.Enabled = true;
                        }

                        if (dt_List.Rows.Count != 0)
                            ViewList(gd_List, new DataGridViewCellEventArgs(0, 0));
                        else
                        {
                            txtNo.Text = "";
                            txtItemName.Text = "";
                            txtQty.Text = "";
                            txtItemUnitCost.Text = "";
                            txtItemVat.Text = "";
                            txtItemCost.Text = "";
                            txtItemDesc.Text = "";
                            cboItmModel.SetItemChecked("");
                            cboQtyCode.SetItemChecked("");
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }

                }
            }
        }

        private void ViewList(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                bFix = true;

                DataGridViewRow row = view.Rows[e.RowIndex];

                txtNo.Text = row.Cells["GRP_NO"].Value.ToString();
                txtItemName.Text = row.Cells["MODEL_DESC"].Value.ToString();
                txtQty.Text = ClsSpread.GetPriceNum(row.Cells["QTY"].Value.ToString());
                txtItemUnitCost.Text = ClsSpread.GetPriceNum(row.Cells["UNIT_COST"].Value.ToString());
                txtItemVat.Text = ClsSpread.GetPriceNum(row.Cells["VAT"].Value.ToString());
                txtItemCost.Text = ClsSpread.GetPriceNum(row.Cells["COST"].Value.ToString());
                txtItemDesc.Text = row.Cells["ITM_DESC"].Value.ToString();

                cboItmModel.SetItemChecked(row.Cells["CST_MODEL_CD"].Value.ToString());
                cboQtyCode.SetItemChecked(row.Cells["QTY_CD"].Value.ToString());

                btnSave.Tag = row.Cells["SEQ_NO"].Value.ToString();

                bFix = false;
            }
        }

        private void SetCstModel(object sender, EventArgs e)
        {
            /*if (!bFix)
            {
                ClearSearchData();
                SetSearchData("CST_COMP_CD", cboSearchComp.ValueList);
                SetSearchData("CST_MODEL_CD", cboItmModel.ValueList);
                SetServiceId("GetCstModel");

                txtItemName.Text = "";
                txtItemUnitCost.Text = "";
                txtItemCost.Text = "";
                txtItemVat.Text = "";

                cboQtyCode.SetItemChecked("");

                //try
                //{
                    DTOFactory.Transaction(new ReportDTO());
                    //여기서 오류
                    DataTable dt = DTOFactory.GetDataTable();

                    txtItemName.Text = dt.Rows[0]["MODEL_DESC"].ToString();
                    txtItemUnitCost.Text = dt.Rows[0]["UNIT_COST"].ToString();

                    cboQtyCode.SetItemChecked(dt.Rows[0]["QTY_CD"].ToString());
                //}
                //catch (Exception ex)
                //{
                //    ViewMessage.Error(ex.Message);
                //}
            }
            */
        }

        private void NewGroup(object sender, EventArgs e)
        {
            var frm = new Popup.NewEstimatePopup();

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                dtTo.Value = DateTime.Now;
                cboSearchComp.SetItemChecked("");
                Search(null, null);

                gd_Group.Rows[gd_Group.Rows.Count - 1].Selected = true;

                SaveItem(null, null);
            }
            #region 원본
            /*
            //20200105 - hsh : 견적서 신규 생성 시 기존 견적서 복사 기능 추가
            if (System.Windows.Forms.MessageBox.Show(
                    "선택한 견적서의 내용을 복사 합니까?", "견적서 생성"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtDocId.Tag = txtDocId.Text;
            }
            else
            {
                txtDocId.Tag = "";
            }

            txtDocId.Text = "";
            SaveGroup(null, null);
            */
            #endregion
        }

        private void SaveGroup(object sender, EventArgs e)
        {
            ClearSearchData();
            //조회 조건
            SetSearchData("FROM_DT", dtFrom.Value.ToString("yyyy/MM/dd"));
            SetSearchData("TO_DT", dtTo.Value.ToString("yyyy/MM/dd"));
            SetSearchData("CST_COMP_CD", cboSearchComp.ValueList);

            //저장 조건
            SetSearchData("DOC_ID", txtDocId.Text);
            SetSearchData("STATUS", txtDocId.Tag);
            SetSearchData("SUBJECT", txtSubject.Text);
            SetSearchData("CST_USER_ID", cboCstUser.ValueList);
            SetSearchData("PRO_ID", cboProject.ValueList);
            SetSearchData("COST", txtCost.Text.Replace(",", ""));
            SetSearchData("VAT", txtVat.Text.Replace(",", ""));
            SetSearchData("CASH_TYP_CD_1", cboCashType1.ValueList);
            SetSearchData("CASH_TYP_CD_2", cboCashType2.ValueList);
            SetSearchData("WARR_TYP_CD", cboWarrType.ValueList);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);

            SetServiceId("SetEstimateList");

            txtNo.Text = "";
            txtItemName.Text = "";
            txtItemUnitCost.Text = "";
            txtItemVat.Text = "";
            txtItemCost.Text = "";
            txtQty.Text = "";
            txtDocId.Tag = "";

            cboItmModel.SetItemChecked("");
            cboQtyCode.SetItemChecked("");

            try
            {
                DTOFactory.Transaction(new ReportDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                DataTable dt = ds_return.Tables["ds_item"];

                dt_Group = ds_return.Tables["ds_group"];
                gd_Group.DataSource = dt_Group;
                gd_Group.SetGridColumn(ds_return.Tables["ds_column"]);

                string docId = dt.Rows[0]["DOC_ID"].ToString();

                foreach (DataGridViewRow vr in gd_Group.Rows)
                {
                    if (docId.Equals(vr.Cells["DOC_ID"].Value))
                    {
                        DataGridViewCellEventArgs arg = new DataGridViewCellEventArgs(0, vr.Index);
                        ViewGroup(gd_Group, arg);
                    }
                }
                panel3.Enabled = true;
                panel5.Enabled = true;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void NewItem(object sender, EventArgs e)
        {
            dt_List.Rows.Add();

            gd_List.Rows[gd_List.Rows.Count - 1].Selected = true;

            SaveItem(null, null);

            txtNo.Focus();
        }

        private void SaveItem(object sender, EventArgs e)
        {
            if (gd_List.Rows.Count > 0)
            {
                int row = gd_List.SelectedRows[0].Index;
                DataRow ndr = dt_List.Rows[row];

                ndr["GRP_NO"] = txtNo.Text;
                ndr["CST_MODEL_CD"] = cboItmModel.ValueList;
                ndr["MODEL_DESC"] = txtItemName.Text;
                ndr["QTY"] = txtQty.Text.Replace(",", "");
                ndr["QTY_CD"] = cboQtyCode.ValueList;
                ndr["UNIT_COST"] = txtItemUnitCost.Text.Replace(",", "");
                ndr["VAT"] = txtItemVat.Text.Replace(",", "");
                ndr["COST"] = txtItemCost.Text.Replace(",", "");
                ndr["ITM_DESC"] = txtItemDesc.Text;

                ClearSearchData();
                SetSearchData("DOC_ID", txtDocId.Text);
                SetSearchData("SEQ_NO", dt_List.Rows[row]["SEQ_NO"].ToString());
                SetSearchData("GRP_NO", txtNo.Text);
                SetSearchData("CST_MODEL_CD", cboItmModel.ValueList);
                SetSearchData("MODEL_DESC", txtItemName.Text);
                SetSearchData("QTY", txtQty.Text.Replace(",", ""));
                SetSearchData("QTY_CD", cboQtyCode.ValueList);
                SetSearchData("UNIT_COST", txtItemUnitCost.Text.Replace(",", ""));
                SetSearchData("VAT", txtItemVat.Text.Replace(",", ""));
                SetSearchData("COST", txtItemCost.Text.Replace(",", ""));
                SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                SetSearchData("DESC", txtItemDesc.Text);
                SetServiceId("SetEstimateItem");

                try
                {
                    DTOFactory.Transaction(new ReportDTO());
                    DataSet ds_return = DTOFactory.GetDataSet();

                    DataTable dt = ds_return.Tables["ds_item"];

                    dt_List.Rows[row]["SEQ_NO"] = dt.Rows[0]["SEQ_NO"];

                    int cost = 0;
                    int vat = 0;
                    int qty = 0;
                    foreach (DataGridViewRow vr in gd_List.Rows)
                    {
                        cost += "".Equals(vr.Cells["COST"].Value.ToString()) ? 0 : int.Parse(vr.Cells["COST"].Value.ToString());
                        qty = "".Equals(vr.Cells["QTY"].Value.ToString()) ? 0 : int.Parse(vr.Cells["QTY"].Value.ToString());
                        vat += "".Equals(vr.Cells["VAT"].Value.ToString()) ? 0 : int.Parse(vr.Cells["VAT"].Value.ToString()) * qty;
                    }

                    txtCost.Text = cost.ToString();
                    txtVat.Text = vat.ToString();
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }

                //금액 Update
                ClearSearchData();
                SetSearchData("DOC_ID", txtDocId.Text);
                SetSearchData("COST", txtCost.Text.Replace(",", ""));
                SetSearchData("VAT", txtVat.Text.Replace(",", ""));
                SetServiceId("UpdateEstimateList");

                try
                {
                    DTOFactory.Transaction(new ReportDTO());

                    row = gd_Group.SelectedRows[0].Index;

                    dt_Group.Rows[row]["COST"] = txtCost.Text.Replace(",", "");
                    dt_Group.Rows[row]["VAT"] = txtVat.Text.Replace(",", "");
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        public void ExportYN(object sender, EventArgs e)
        {
            if (!"Y".Equals(gd_Group.SelectedRows[0].Cells[30].Value.ToString()))
            {
                if (System.Windows.Forms.MessageBox.Show(
                    "견적서를 발행하면 수정할 수 없습니다.\n발행하시겠습니까?", "견적서 발행"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExcelExport(gd_Group, new DataGridViewCellEventArgs(0, gd_Group.SelectedRows[0].Index));
                }
            }
            else
            {
                ExcelExport(gd_Group, new DataGridViewCellEventArgs(0, gd_Group.SelectedRows[0].Index));
            }
        }

        public void ExcelExport(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            DataGridViewRow ViewRow = view.Rows[e.RowIndex];

            int row;

            for (row = 0; row < dt_Group.Rows.Count; row++)
            {
                if (ViewRow.Cells["DOC_ID"].Value.ToString() == dt_Group.Rows[row]["DOC_ID"].ToString())
                {
                    break;
                }
            }

            DTOFactory.Action();

            try
            {
                ClearSearchData();
                SetSearchData("DOC_ID", txtDocId.Text);
                SetServiceId("SendEstimateList");

                DTOFactory.Transaction(new ReportDTO());


                string path = @"c:\temp\" + dt_Group.Rows[row]["SUBJECT"].ToString() + ".xlsx";
                DateTime tm = DateTime.Parse(dt_Group.Rows[row]["CRT_TM"].ToString());

                Excel.Application app = new Excel.Application();
                Excel.Workbook work = app.Workbooks.Add();
                Excel._Worksheet sheet = (Excel._Worksheet)app.ActiveSheet;
                app.ActiveWindow.DisplayGridlines = false;

                #region 수정본
                #region Width 정의
                ((Excel.Range)sheet.Cells[1, 1]).EntireColumn.ColumnWidth = 4.3;
                ((Excel.Range)sheet.Cells[1, 2]).EntireColumn.ColumnWidth = 4.3;
                ((Excel.Range)sheet.Cells[1, 3]).EntireColumn.ColumnWidth = 8.38;
                ((Excel.Range)sheet.Cells[1, 4]).EntireColumn.ColumnWidth = 8.38;
                ((Excel.Range)sheet.Cells[1, 5]).EntireColumn.ColumnWidth = 8.38;
                ((Excel.Range)sheet.Cells[1, 6]).EntireColumn.ColumnWidth = 9.75;
                ((Excel.Range)sheet.Cells[1, 7]).EntireColumn.ColumnWidth = 4.3;
                ((Excel.Range)sheet.Cells[1, 8]).EntireColumn.ColumnWidth = 4.3;
                ((Excel.Range)sheet.Cells[1, 9]).EntireColumn.ColumnWidth = 5.5;
                ((Excel.Range)sheet.Cells[1, 10]).EntireColumn.ColumnWidth = 5.5;
                ((Excel.Range)sheet.Cells[1, 11]).EntireColumn.ColumnWidth = 8.38;
                ((Excel.Range)sheet.Cells[1, 12]).EntireColumn.ColumnWidth = 8.38;
                #endregion

                #region 견적서 HEAD

                #region Logo
                FileInfo flLogo = new FileInfo(@"C:\Temp\" + DTOFactory.CompLogo.ToString());
                ImageGet logo = new ImageGet(DTOFactory.CompLogo.ToString());

                using (FileStream stream = new FileStream(flLogo.FullName, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = logo.GetImageBlock();
                    stream.Write(buffer, 0, buffer.Length);
                }

                sheet.Shapes.AddPicture(flLogo.FullName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue
                    , 0, 0, 90, 45);
                flLogo.Delete();
                #endregion endLogo

                //Height
                int i, j = 0;
                for (i = 1; i < 8; i++)
                    ((Excel.Range)sheet.Cells[i, 1]).EntireRow.RowHeight = 16.5;

                ((Excel.Range)sheet.Cells[8, 1]).EntireRow.RowHeight = 8.25;
                ((Excel.Range)sheet.Cells[9, 1]).EntireRow.RowHeight = 4;
                ((Excel.Range)sheet.Cells[10, 1]).EntireRow.RowHeight = 21;
                ((Excel.Range)sheet.Cells[11, 1]).EntireRow.RowHeight = 30.8;
                ((Excel.Range)sheet.Cells[12, 1]).EntireRow.RowHeight = 16.5;

                //셀 병합
                sheet.Range["I6", "J6"].Merge();
                sheet.Range["K6", "L6"].Merge();
                sheet.Range["I7", "J7"].Merge();
                sheet.Range["K7", "L7"].Merge();
                sheet.Range["A11", "L11"].Merge();
                sheet.Range["A9", "I9"].Merge();
                sheet.Range["J9", "L9"].Merge();

                sheet.Range["A9", "I9"].Interior.Color = Color.FromArgb(87, 87, 87);
                sheet.Range["J9", "L9"].Interior.Color = Color.FromArgb(233, 79, 54);

                sheet.Range["I6", "L7"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["A11", "L11"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //데이터 입력
                sheet.Cells[4, 1] = "주식회사 엠와이씨";
                sheet.Cells[5, 1] = "충북 청주시 서원구 충대로 1 S21-1동 214호";
                sheet.Cells[6, 1] = "Tel 043)904-9300";
                sheet.Cells[6, 4] = "Fax 043)904-9301";
                sheet.Cells[6, 9] = "발급자";
                sheet.Cells[6, 11] = dt_Group.Rows[row]["USER_NM"].ToString();
                sheet.Cells[7, 9] = "발급일";
                sheet.Cells[7, 11] = tm.ToString("yyyy.MM.dd");
                sheet.Cells[7, 1] = "발행번호 : " + dt_Group.Rows[row]["DOC_ID"].ToString();


                sheet.Cells[11, 1] = "견  적  서";
                sheet.Range["A11", "L11"].Font.Bold = true; ;
                sheet.Range["A11", "L11"].Font.Size = 20;
                #endregion

                #region 업체 정보
                sheet.Range["A13", "E13"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                for (i = 13; i < 18; i++)
                {
                    ((Excel.Range)sheet.Cells[i, 1]).EntireRow.RowHeight = 21;
                }

                for (i = 13; i < 18; i++)
                {
                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Merge();
                    sheet.Range[string.Format("C{0}", i), string.Format("E{0}", i)].Merge();

                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);

                    sheet.Range[string.Format("A{0}", i), string.Format("E{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", i), string.Format("E{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", i), string.Format("E{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", i), string.Format("E{0}", i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                    sheet.Range[string.Format("A{0}", i), string.Format("E{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                sheet.Cells[13, 1] = "견적일자";
                sheet.Cells[13, 3] = tm.ToString("yy.MM.dd");
                sheet.Cells[14, 1] = "제 출 처";
                sheet.Cells[14, 3] = dt_Group.Rows[row]["CST_COMP_NM"].ToString();
                sheet.Cells[15, 1] = "담 당 자";
                sheet.Cells[15, 3] = dt_Group.Rows[row]["CST_USER_NM"].ToString() + "님";
                sheet.Cells[16, 1] = "PROJECT";
                sheet.Range["C16", "E16"].Font.Size = 10;
                sheet.Cells[16, 3] = dt_Group.Rows[row]["PRO_NM"].ToString();
                sheet.Cells[17, 1] = "유효기간";
                sheet.Cells[17, 3] = "발행후 3개월";

                #endregion

                #region 회사 정보
                sheet.Range["G13", "L13"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                for (i = 13; i < 18; i++)
                {
                    sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                    sheet.Range[string.Format("I{0}", i), string.Format("L{0}", i)].Merge();

                    sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);

                    sheet.Range[string.Format("G{0}", i), string.Format("L{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("G{0}", i), string.Format("L{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("G{0}", i), string.Format("L{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("G{0}", i), string.Format("L{0}", i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                    sheet.Range[string.Format("G{0}", i), string.Format("L{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                sheet.Range["G13", "H13"].Font.Size = 10;
                sheet.Cells[13, 7] = "사업자번호";
                sheet.Cells[13, 9] = dt_Group.Rows[row]["REG_ID"].ToString();
                sheet.Cells[14, 7] = "상 호 명";
                sheet.Cells[14, 9] = dt_Group.Rows[row]["COMP_NM"].ToString();
                sheet.Cells[15, 7] = "대표자명";
                sheet.Cells[15, 9] = dt_Group.Rows[row]["COMP_USER_NM"].ToString();
                sheet.Cells[16, 7] = "업   태";
                sheet.Cells[16, 9] = dt_Group.Rows[row]["COMP_TYP_1"].ToString();
                sheet.Cells[17, 7] = "업   종";
                sheet.Cells[17, 9] = dt_Group.Rows[row]["COMP_TYP_2"].ToString();
                #endregion

                #region Body
                sheet.Range["A18", "B18"].Merge();
                sheet.Range["C18", "E18"].Merge();
                sheet.Range["G18", "H18"].Merge();
                sheet.Range["I18", "K18"].Merge();

                sheet.Cells[18, 1] = "발주금액";
                sheet.Cells[18, 6] = "원정";
                sheet.Cells[18, 7] = @"(\";
                sheet.Cells[18, 12] = ")";

                sheet.Range["I18", "K18"].NumberFormat = "\\           #,##0";

                sheet.Range["A18", "E18"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["G18", "H18"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["L18", "L18"].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                sheet.Range["L19", "L19"].Font.Size = 8;
                sheet.Cells[19, 12] = "(단위 : KRW)";
                for (i = 21; i < 31; i++)
                    ((Excel.Range)sheet.Cells[i, 1]).EntireRow.RowHeight = 22.5;
                if (!chkVAT.Checked)
                {
                    string cost = (int.Parse(dt_Group.Rows[row]["COST"].ToString()) - int.Parse(dt_Group.Rows[row]["VAT"].ToString())).ToString();

                    sheet.Cells[18, 3] = ClsSpread.GetPriceNumtoHan(cost);
                    sheet.Cells[18, 9] = cost;
                    for (i = 20, j = 0; i < 32; i++, j++)
                    {
                        sheet.Range[string.Format("B{0}", i), string.Format("D{0}", i)].Merge();
                        sheet.Range[string.Format("G{0}", i), string.Format("J{0}", i)].Merge();
                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].Merge();

                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].Font.Size = 8;
                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].WrapText = true;
                        sheet.Range[string.Format("A{0}", i), string.Format("A{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);

                        sheet.Range[string.Format("A{0}", i), string.Format("E{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                        sheet.Cells[i, 1] = j;
                        if (i == 20)
                        {
                            sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);
                            sheet.Cells[i, 1] = "NO.";
                            sheet.Cells[i, 2] = "품명";
                            sheet.Cells[i, 5] = "수량";
                            sheet.Cells[i, 6] = "단가";
                            sheet.Cells[i, 7] = "합계";
                            sheet.Cells[i, 11] = "비고";
                        }
                        else if (i == 31)
                        {
                            sheet.Range[string.Format("A{0}", i), string.Format("D{0}", i)].Merge();
                            sheet.Range[string.Format("E{0}", i), string.Format("L{0}", i)].Merge();
                            sheet.Range[string.Format("E{0}", i), string.Format("L{0}", i)].NumberFormat = "_-₩* #,##0_-;-₩* #,##0_-;_-₩* \"-\"_-;_-@_-";
                            sheet.Range[string.Format("A{0}", i), string.Format("D{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);
                            sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            sheet.Cells[i, 1] = "합계";
                            sheet.Cells[i, 5] = cost;
                        }
                        if (j <= dt_List.Rows.Count - 1)
                        {
                            sheet.Cells[i + 1, 2] = dt_List.Rows[j]["MODEL_DESC"].ToString();
                            sheet.Cells[i + 1, 5] = dt_List.Rows[j]["QTY"].ToString() + dt_List.Rows[j]["QTY_NM"].ToString();
                            sheet.Range[string.Format("F{0}", i + 1), string.Format("J{0}", i + 1)].NumberFormat = "\\ #,##0";
                            sheet.Cells[i + 1, 6] = dt_List.Rows[j]["UNIT_COST"].ToString();
                            sheet.Cells[i + 1, 7] = int.Parse("".Equals(dt_List.Rows[j]["QTY"].ToString()) ? "0" : dt_List.Rows[j]["QTY"].ToString())
                                * int.Parse("".Equals(dt_List.Rows[j]["UNIT_COST"].ToString()) ? "0" : dt_List.Rows[j]["UNIT_COST"].ToString());
                            sheet.Cells[i + 1, 11] = dt_List.Rows[j]["ITM_DESC"].ToString();
                        }
                    }
                }
                else //부가세 포함
                {
                    sheet.Cells[18, 3] = ClsSpread.GetPriceNumtoHan(dt_Group.Rows[row]["COST"].ToString());
                    sheet.Cells[18, 9] = dt_Group.Rows[row]["COST"].ToString();
                    for (i = 20, j = 0; i < 33; i++, j++)
                    {
                        sheet.Range[string.Format("B{0}", i), string.Format("D{0}", i)].Merge();
                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                        sheet.Range[string.Format("I{0}", i), string.Format("J{0}", i)].Merge();
                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].Merge();

                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].Font.Size = 8;
                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].WrapText = true;
                        sheet.Range[string.Format("A{0}", i), string.Format("A{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);

                        sheet.Range[string.Format("A{0}", i), string.Format("E{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Range[string.Format("K{0}", i), string.Format("L{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                        sheet.Cells[i, 1] = j;
                        if (i == 20)
                        {
                            sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);
                            sheet.Cells[i, 1] = "NO.";
                            sheet.Cells[i, 2] = "품명";
                            sheet.Cells[i, 5] = "수량";
                            sheet.Cells[i, 6] = "단가";
                            sheet.Cells[i, 7] = "부가세";
                            sheet.Cells[i, 9] = "합계";
                            sheet.Cells[i, 11] = "비고";
                        }
                        else if (i == 31)
                        {
                            sheet.Range[string.Format("A{0}", i), string.Format("D{0}", i)].Merge();
                            sheet.Range[string.Format("E{0}", i), string.Format("L{0}", i)].Merge();
                            sheet.Range[string.Format("E{0}", i), string.Format("L{0}", i)].NumberFormat = "_-₩* #,##0_-;-₩* #,##0_-;_-₩* \"-\"_-;_-@_-";
                            sheet.Range[string.Format("A{0}", i), string.Format("D{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);
                            sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            sheet.Cells[i, 1] = "부가세";
                            sheet.Cells[i, 5] = dt_Group.Rows[row]["VAT"].ToString();
                        }
                        else if (i == 32)
                        {
                            sheet.Range[string.Format("A{0}", i), string.Format("D{0}", i)].Merge();
                            sheet.Range[string.Format("E{0}", i), string.Format("L{0}", i)].Merge();
                            sheet.Range[string.Format("E{0}", i), string.Format("L{0}", i)].NumberFormat = "_-₩* #,##0_-;-₩* #,##0_-;_-₩* \"-\"_-;_-@_-";
                            sheet.Range[string.Format("A{0}", i), string.Format("D{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);
                            sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            sheet.Cells[i, 1] = "합계";
                            sheet.Cells[i, 5] = dt_Group.Rows[row]["COST"].ToString();
                        }

                        if (j <= dt_List.Rows.Count - 1)
                        {
                            sheet.Cells[i + 1, 2] = dt_List.Rows[j]["MODEL_DESC"].ToString();
                            sheet.Cells[i + 1, 5] = dt_List.Rows[j]["QTY"].ToString() + dt_List.Rows[j]["QTY_NM"].ToString();
                            sheet.Range[string.Format("F{0}", i + 1), string.Format("J{0}", i + 1)].NumberFormat = "\\ #,##0";
                            sheet.Cells[i + 1, 6] = dt_List.Rows[j]["UNIT_COST"].ToString();
                            sheet.Cells[i + 1, 7] = dt_List.Rows[j]["VAT"].ToString();
                            sheet.Cells[i + 1, 9] = int.Parse("".Equals(dt_List.Rows[j]["QTY"].ToString()) ? "0" : dt_List.Rows[j]["QTY"].ToString())
                                * (int.Parse("".Equals(dt_List.Rows[j]["UNIT_COST"].ToString()) ? "0" : dt_List.Rows[j]["UNIT_COST"].ToString())
                                + int.Parse("".Equals(dt_List.Rows[j]["VAT"].ToString()) ? "0" : dt_List.Rows[j]["VAT"].ToString()));
                            sheet.Cells[i + 1, 11] = dt_List.Rows[j]["ITM_DESC"].ToString();
                        }
                    }
                }

                sheet.Range["A20", "L20"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["A20", "L20"].Font.Size = 11;

                #endregion

                #region Bottom
                sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].Merge();
                sheet.Range[string.Format("A{0}", i + 1), string.Format("L{0}", i + 3)].Merge();
                sheet.Range[string.Format("A{0}", i + 4), string.Format("B{0}", i + 4)].Merge();
                sheet.Range[string.Format("E{0}", i + 4), string.Format("F{0}", i + 4)].Merge();
                sheet.Range[string.Format("I{0}", i + 4), string.Format("L{0}", i + 4)].Merge();

                sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].Interior.Color = Color.FromArgb(242, 242, 242);
                sheet.Range[string.Format("A{0}", i), string.Format("L{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range[string.Format("A{0}", i + 4), string.Format("B{0}", i + 4)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range[string.Format("D{0}", i + 4), string.Format("D{0}", i + 4)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range[string.Format("I{0}", i + 4), string.Format("L{0}", i + 4)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                sheet.Cells[i, 1] = "특이사항";

                for (j = 31; j < i + 4; j++)
                {
                    ((Excel.Range)sheet.Cells[j, 1]).EntireRow.RowHeight = 21.7;
                }

                sheet.Range["A20", string.Format("L{0}", i + 4)].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A20", string.Format("L{0}", i + 4)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A20", string.Format("L{0}", i + 4)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A20", string.Format("L{0}", i + 4)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A20", string.Format("L{0}", i + 4)].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A20", string.Format("L{0}", i + 3)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                string strDesc = "";
                int no = 1;

                if (!"".Equals(dt_Group.Rows[row]["CASH_NM"].ToString()))
                {
                    strDesc += string.Format("{0}. 대금 지급조건: {1}\r\n", no++, dt_Group.Rows[row]["CASH_NM"]);
                }

                if (!"".Equals(dt_Group.Rows[row]["WARR_NM"].ToString()))
                {
                    strDesc += string.Format("{0}. 유지보수 조건: {1}\r\n", no++, dt_Group.Rows[row]["WARR_NM"]);
                }

                strDesc += string.Format("{0}. Project 담담자: {1}\r\n", no++, dt_Group.Rows[row]["EMAIL"]);

                int pos = strDesc.Length + 1;

                if (chkVAT.Checked)
                    strDesc += string.Format("{0}. 부가세 포함", no++);
                else
                    strDesc += string.Format("{0}. 부가세 별도", no++);

                sheet.Cells[i + 1, 1] = strDesc;
                sheet.Cells[i + 4, 1] = "담당자";
                sheet.Cells[i + 4, 3] = dt_Group.Rows[row]["USER_NM"].ToString();
                sheet.Cells[i + 4, 4] = "연락처";
                sheet.Cells[i + 4, 5] = dt_Group.Rows[row]["TEL_1"].ToString();
                sheet.Cells[i + 4, 7] = "결제 방법";
                sheet.Cells[i + 4, 9] = ("CASH".Equals(dt_Group.Rows[row]["CASH_TYP_CD_2"].ToString()) ? "■" : "□") + "현금  "
                                      + ("CARD".Equals(dt_Group.Rows[row]["CASH_TYP_CD_2"].ToString()) ? "■" : "□") + "카드  "
                                      + ("ETC".Equals(dt_Group.Rows[row]["CASH_TYP_CD_2"].ToString()) ? "■" : "□") + "기타 ";

                ((Excel.Range)sheet.Cells[i + 5, 1]).EntireRow.RowHeight = 15.5;
                ((Excel.Range)sheet.Cells[i + 6, 1]).EntireRow.RowHeight = 13.5;

                sheet.Range[string.Format("A{0}", i + 6), string.Format("L{0}", i + 6)].Merge();
                sheet.Range[string.Format("A{0}", i + 6), string.Format("L{0}", i + 6)].Font.Size = 9;
                sheet.Range[string.Format("A{0}", i + 6), string.Format("L{0}", i + 6)].Font.Color = Color.White;
                sheet.Range[string.Format("A{0}", i + 6), string.Format("L{0}", i + 6)].Interior.Color = Color.FromArgb(87, 87, 87);
                sheet.Range[string.Format("A{0}", i + 6), string.Format("L{0}", i + 6)].Font.Bold = true;
                sheet.Cells[i + 6, 1] = "     SOLUTIONS OF TECHNOLOGY";
                #endregion
                #endregion

                Excel.PageSetup ps = sheet.PageSetup;
                ps.LeftMargin = 28;
                ps.RightMargin = 28;

                if (chkVAT.Checked)
                {
                    ps.TopMargin = 41;
                    ps.BottomMargin = 41;
                }
                else
                {
                    ps.TopMargin = 48;
                    ps.BottomMargin = 48;
                }
                ps.HeaderMargin = 0;
                ps.FooterMargin = 0;
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                    file.Delete();

                work.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                work.Close();
                app.Quit();

                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }

            DTOFactory.Complete();

            ViewGroup(gd_Group, new DataGridViewCellEventArgs(0, e.RowIndex));
        }
    }
}
