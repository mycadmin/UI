using System;
using System.Data;
using System.IO;
using MYC.Control;
using MYC.Control.Common;
using MYC.Sender;
using MYC.UI.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace MYC.UI.Machine.Popup
{
    public partial class ProductorderPopup : MYCForm
    {
        public DataSet DS { set; get; }

        public ProductorderPopup()
        {
            InitializeComponent();
        }

        private void ProductorderPopup_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();
            InitControls();

            DTOFactory.Complete();
        }

        private void InitControls()
        {
            #region 년도
            cboYear.Items.Clear();
            for (int i = -3; i <= 0; i++)
            {
                cboYear.Items.Add(DateTime.Now.AddYears(i).ToString("yyyy"));
            }

            cboYear.SelectedIndex = 3;
            #endregion

            #region 담당자
            cboMember.Params.Add("strCompType", "M");
            cboMember.BindDataSet();
            #endregion
        }

        private void Search(object sender, EventArgs e)
        {
            if (!"".Equals(cboOrder.ValueList))
            {
                ClearSearchData();
                SetSearchData("DOC_ID", cboOrder.ValueList);
                SetServiceId("GetOrder");

                try
                {
                    DTOFactory.Transaction(new ProductDTO());
                    DS = DTOFactory.GetDataSet();

                    txtDocId.Text = DS.Tables["ds_master"].Rows[0]["DOC_ID"].ToString();
                    txtCrtDt.Text = DS.Tables["ds_master"].Rows[0]["CRT_DT"].ToString();
                    txtVendorNm.Text = DS.Tables["ds_master"].Rows[0]["VENDOR_NM"].ToString();
                    txtOrderDt.Text = DS.Tables["ds_master"].Rows[0]["ORDER_DT"].ToString();
                    txtVendorTel.Text = DS.Tables["ds_master"].Rows[0]["VENDOR_TEL"].ToString();

                    gd_List.DataSource = DS.Tables["ds_list"];
                    gd_List.SetGridColumn(DS.Tables["ds_column"]);

                    for (int i = 0; i < gd_List.RowCount; i++)
                    {
                        gd_List.Rows[i].Cells["NO"].Value = i + 1;
                    }
                }
                catch (Exception e1)
                {
                    ViewMessage.Error(e1.Message);
                }
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            DTOFactory.Action();

            try
            {
                DataTable dt_orderMaster = DS.Tables["ds_master"];
                DataTable dt_orderList = DS.Tables["ds_list"];

                string path = @"c:\temp\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";

                Excel.Application app = new Excel.Application();
                Excel.Workbook work = app.Workbooks.Add();
                Excel._Worksheet sheet = (Excel._Worksheet)app.ActiveSheet;
                app.ActiveWindow.DisplayGridlines = false;

                #region width 정의
                ((Excel.Range)sheet.Cells[1, 1]).EntireColumn.ColumnWidth = 3;
                ((Excel.Range)sheet.Cells[1, 2]).EntireColumn.ColumnWidth = 8;
                ((Excel.Range)sheet.Cells[1, 3]).EntireColumn.ColumnWidth = 9;
                ((Excel.Range)sheet.Cells[1, 4]).EntireColumn.ColumnWidth = 2;
                ((Excel.Range)sheet.Cells[1, 5]).EntireColumn.ColumnWidth = 4;
                ((Excel.Range)sheet.Cells[1, 6]).EntireColumn.ColumnWidth = 5.88;
                ((Excel.Range)sheet.Cells[1, 7]).EntireColumn.ColumnWidth = 5;
                ((Excel.Range)sheet.Cells[1, 8]).EntireColumn.ColumnWidth = 5;
                ((Excel.Range)sheet.Cells[1, 9]).EntireColumn.ColumnWidth = 10;
                ((Excel.Range)sheet.Cells[1, 10]).EntireColumn.ColumnWidth = 10;
                ((Excel.Range)sheet.Cells[1, 11]).EntireColumn.ColumnWidth = 10.88;
                #endregion

                #region 발주서 제목
                //height
                ((Excel.Range)sheet.Cells[1, 1]).EntireRow.RowHeight = 15;
                ((Excel.Range)sheet.Cells[2, 1]).EntireRow.RowHeight = 33;
                ((Excel.Range)sheet.Cells[3, 1]).EntireRow.RowHeight = 15;
                ((Excel.Range)sheet.Cells[4, 1]).EntireRow.RowHeight = 33;
                ((Excel.Range)sheet.Cells[5, 1]).EntireRow.RowHeight = 13.5;

                //셀 병합
                sheet.Range["A1", "B1"].Merge();
                sheet.Range["A2", "B2"].Merge();

                sheet.Range["C1", "J2"].Merge();

                sheet.Range["A3", "B3"].Merge();
                sheet.Range["A4", "B4"].Merge();
                sheet.Range["D3", "E3"].Merge();
                sheet.Range["D4", "E4"].Merge();
                sheet.Range["F3", "J3"].Merge();
                sheet.Range["F4", "J4"].Merge();

                //색지정
                sheet.Range["A1", "B1"].Interior.Color = System.Drawing.Color.FromArgb(200, 200, 200);
                sheet.Range["A3", "K3"].Interior.Color = System.Drawing.Color.FromArgb(200, 200, 200);

                //BorderLine
                sheet.Range["A1", "B2"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A1", "B2"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A1", "B2"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A1", "B2"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A1", "B2"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A1", "B2"].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;

                sheet.Range["A3", "K4"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A3", "K4"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A3", "K4"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A3", "K4"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A3", "K4"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A3", "K4"].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;

                sheet.Range["A1", "K7"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["F4", "J4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                //font
                sheet.Range["A1", "B1"].Font.Bold = true;
                sheet.Range["A3", "K3"].Font.Bold = true;

                sheet.Range["A1", "K4"].Font.Size = 10;
                sheet.Range["C1", "J2"].Font.Size = 24;

                sheet.Range["A4", "K4"].WrapText = true;

                sheet.Range["A2", "B2"].NumberFormat = 0;

                //데이터 입력
                sheet.Cells[1, 1] = "발주번호";
                sheet.Cells[1, 3] = "발  주  서";
                sheet.Cells[3, 1] = "발주일자";
                sheet.Cells[3, 3] = "지불조건";
                sheet.Cells[3, 4] = "사업장";
                sheet.Cells[3, 6] = "납품장소";
                sheet.Cells[3, 11] = "납기일";

                sheet.Cells[2, 1] = dt_orderMaster.Rows[0]["DOC_ID"].ToString();
                sheet.Cells[4, 1] = dt_orderMaster.Rows[0]["CRT_DT"].ToString();
                sheet.Cells[4, 3] = dt_orderMaster.Rows[0]["COST_TYP"].ToString();
                sheet.Cells[4, 4] = dt_orderMaster.Rows[0]["COMP_NM"].ToString();
                sheet.Cells[4, 6] = dt_orderMaster.Rows[0]["ADDR"].ToString();
                sheet.Cells[4, 11] = dt_orderMaster.Rows[0]["ORDER_DT"].ToString();

                //Logo
                FileInfo flLogo = new FileInfo(@"C:\Temp\" + dt_orderMaster.Rows[0]["LOGO"].ToString());
                ImageGet logo = new ImageGet(dt_orderMaster.Rows[0]["LOGO"].ToString());

                using (FileStream stream = new FileStream(flLogo.FullName, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = logo.GetImageBlock();
                    stream.Write(buffer, 0, buffer.Length);
                }

                sheet.Shapes.AddPicture(flLogo.FullName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue
                    , 388, 2, 90, 45);
                flLogo.Delete();
                #endregion

                #region 공급사 내용
                //height
                ((Excel.Range)sheet.Cells[6, 1]).EntireRow.RowHeight = 15;
                ((Excel.Range)sheet.Cells[7, 1]).EntireRow.RowHeight = 33;
                ((Excel.Range)sheet.Cells[8, 1]).EntireRow.RowHeight = 13.5;

                //셀병합
                sheet.Range["A6", "B6"].Merge();
                sheet.Range["A7", "B7"].Merge();
                sheet.Range["C6", "H6"].Merge();
                sheet.Range["C7", "H7"].Merge();

                //색지정
                sheet.Range["A6", "K6"].Interior.Color = System.Drawing.Color.FromArgb(200, 200, 200);

                //Font
                sheet.Range["A6", "K7"].Font.Size = 10;

                sheet.Range["A6", "K6"].Font.Bold = true;

                sheet.Range["C7", "H7"].WrapText = true;

                //데이터 입력
                sheet.Cells[6, 1] = "공급사";
                sheet.Cells[6, 3] = "주소";
                sheet.Cells[6, 9] = "대표";
                sheet.Cells[6, 10] = "직위";
                sheet.Cells[6, 11] = "연락처";

                sheet.Cells[7, 1] = dt_orderMaster.Rows[0]["VENDOR_NM"].ToString();
                sheet.Cells[7, 3] = dt_orderMaster.Rows[0]["VENDOR_ADDR"].ToString();
                sheet.Cells[7, 9] = dt_orderMaster.Rows[0]["VENDOR_USER_NM"].ToString();
                sheet.Cells[7, 10] = dt_orderMaster.Rows[0]["VENDOR_GRADE_NM"].ToString();
                sheet.Cells[7, 11] = dt_orderMaster.Rows[0]["VENDOR_TEL"].ToString();

                //BorderLine
                sheet.Range["A6", "K7"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A6", "K7"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A6", "K7"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A6", "K7"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A6", "K7"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A6", "K7"].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;

                sheet.Range["A6", "K7"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["C7", "H7"].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                #endregion

                #region 물품
                //height
                ((Excel.Range)sheet.Cells[9, 1]).EntireRow.RowHeight = 15;

                //병합
                sheet.Range["C9", "D9"].Merge();
                sheet.Range["E9", "F9"].Merge();

                //BorderLine
                sheet.Range["A9", "K9"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A9", "K9"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A9", "K9"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A9", "K9"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A9", "K9"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                sheet.Range["A9", "K9"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //색지정
                sheet.Range["A9", "K9"].Interior.Color = System.Drawing.Color.FromArgb(200, 200, 200);

                //Font
                sheet.Range["A9", "K9"].Font.Size = 10;

                sheet.Range["A9", "K9"].Font.Bold = true;

                //입력
                sheet.Cells[9, 1] = "No.";
                sheet.Cells[9, 2] = "자재코드";
                sheet.Cells[9, 3] = "품명";
                sheet.Cells[9, 5] = "규격";
                sheet.Cells[9, 7] = "수량";
                sheet.Cells[9, 8] = "단위";
                sheet.Cells[9, 9] = "단가";
                sheet.Cells[9, 10] = "금액";
                sheet.Cells[9, 11] = "비고";

                int i = 0;
                for (; i < dt_orderList.Rows.Count; i++)
                {
                    ((Excel.Range)sheet.Cells[10 + i, 1]).EntireRow.RowHeight = 30;

                    //병합
                    sheet.Range[string.Format("C{0}", 10 + i), string.Format("D{0}", 10 + i)].Merge();
                    sheet.Range[string.Format("E{0}", 10 + i), string.Format("F{0}", 10 + i)].Merge();

                    //BorderLine
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Range[string.Format("I{0}", 10 + i), string.Format("J{0}", 10 + i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                    sheet.Range[string.Format("I{0}", 10 + i), string.Format("J{0}", 10 + i)].NumberFormat = "\\ #,##0\"원\"";

                    //Font
                    sheet.Range[string.Format("B{0}", 10 + i), string.Format("K{0}", 10 + i)].Font.Size = 8;

                    sheet.Range[string.Format("B{0}", 10 + i), string.Format("K{0}", 10 + i)].WrapText = true;

                    //데이터 입력
                    sheet.Cells[10 + i, 1] = i + 1.ToString();
                    sheet.Cells[10 + i, 2] = dt_orderList.Rows[i]["MODEL_ID"].ToString();
                    sheet.Cells[10 + i, 3] = dt_orderList.Rows[i]["MODEL_NM"].ToString();
                    sheet.Cells[10 + i, 5] = dt_orderList.Rows[i]["SPEC_VAL"].ToString();
                    sheet.Cells[10 + i, 7] = dt_orderList.Rows[i]["QTY"].ToString();
                    sheet.Cells[10 + i, 8] = dt_orderList.Rows[i]["QTY_CD"].ToString();
                    sheet.Cells[10 + i, 9] = dt_orderList.Rows[i]["UNIT_COST"].ToString();
                    sheet.Cells[10 + i, 10] = dt_orderList.Rows[i]["COST"].ToString();

                }
                //빈칸 그리드
                for (; i < 16; i++)
                {
                    ((Excel.Range)sheet.Cells[10 + i, 1]).EntireRow.RowHeight = 30;

                    //병합
                    sheet.Range[string.Format("C{0}", 10 + i), string.Format("D{0}", 10 + i)].Merge();
                    sheet.Range[string.Format("E{0}", 10 + i), string.Format("F{0}", 10 + i)].Merge();

                    //BorderLine
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Range[string.Format("A{0}", 10 + i), string.Format("K{0}", 10 + i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                }
                #endregion

                #region 합계

               ((Excel.Range)sheet.Cells[26, 1]).EntireRow.RowHeight = 30;

                sheet.Range["A26", "F26"].Merge();
                sheet.Range["G26", "H26"].Merge();
                sheet.Range["I26", "J26"].Merge();

                sheet.Range["A26", "K26"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A26", "K26"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A26", "K26"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A26", "K26"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["A26", "K26"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                sheet.Range["A26", "K26"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["G26", "J26"].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                sheet.Range["I26", "J26"].NumberFormat = "\\ #,##0\"원\"";

                sheet.Cells[26, 1] = "합 계(부가세 별도)";
                sheet.Cells[26, 7] = "=sum(G10:G25)";
                sheet.Cells[26, 9] = "=sum(J10:J25)";
                #endregion

                Excel.PageSetup ps = sheet.PageSetup;
                ps.LeftMargin = 53.4;
                ps.RightMargin = 53.4;
                ps.HeaderMargin = 22.8;
                ps.FooterMargin = 22.8;
                ps.TopMargin = 57.3;
                ps.BottomMargin = 57.3;

                work.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                work.Close();
                app.Quit();

                DTOFactory.Complete();
                //2021-02-19 hsh 완료 popup 대신 실행 기능으로 변경
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                DTOFactory.Complete();

                ViewMessage.Error(ex.Message);
            }
        }

        private void SetOrderList(object sender, EventArgs e)
        {
            cboOrder.Params.Clear();
            cboOrder.Params.Add("strYear", cboYear.Text);
            cboOrder.Params.Add("strUserId", cboMember.ValueList);
            cboOrder.BindDataSet();
        }
    }
}
