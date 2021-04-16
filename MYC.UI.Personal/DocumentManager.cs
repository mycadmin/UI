using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.Sender;
using MYC.UI.DTO;

using Excel = Microsoft.Office.Interop.Excel;

namespace MYC.UI.Personal
{
    public partial class DocumentManager : MYCControl
    {
        protected DataTable dt_Doc;
        protected DataTable dt_Item;

        string DOC_TYPE;
        public DocumentManager()
        {
            InitializeComponent();
        }

        private void DocumentManager_load(Object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitSpread();
            InitControls();
            Search(null, null);

            DTOFactory.Complete();
        }

        private void InitSpread()
        {

            gd_List.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void InitControls()
        {
            #region 조회 조건
            dtFrom.Value = DateTime.Now.AddDays(-7);
            dtTo.Value = DateTime.Now;

            cboDocType.Params.Clear();
            cboDocType.Params.Add("strItem", "DOC_TYPE");
            cboDocType.BindDataSet();
            #endregion
        }

        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("START_TM", dtFrom.Value.ToString("yyyy-MM-dd"));
            SetSearchData("END_TM", dtTo.Value.ToString("yyyy-MM-dd"));
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);
            SetSearchData("DOC_TYP_CD", cboDocType.ValueList);

            SetServiceId("GetDocList");

            DTOFactory.Action();

            try
            {
                DTOFactory.Transaction(new DocDTO());
                DataSet ds = DTOFactory.GetDataSet();

                gd_List.DataSource = ds.Tables["ds_list"];

                if (!gd_List.LabelDisplayed)
                {
                    gd_List.SetGridColumn(ds.Tables["ds_column"]);

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                    {
                        Text = "문서신청",
                        HeaderText = "관리",
                        Name = "insert",
                        UseColumnTextForButtonValue = true
                    };
                    gd_List.Columns.AddRange(bt);
                }
                if (gd_List.Rows.Count > 0)
                    ViewDocumentList(gd_List, new DataGridViewCellEventArgs(0, 0));
            }

            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }

            DTOFactory.Complete();
        }

        private void ViewDocumentList(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                ClearSearchData();
                SetSearchData("DOC_TYP_CD", row.Cells["DOC_TYP_CD"].Value);
                SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                SetSearchData("START_TM", dtFrom.Value.ToString("yyyy-MM-dd"));
                SetSearchData("END_TM", dtTo.Value.ToString("yyyy-MM-dd"));

                SetServiceId("GetDocItem");

                DOC_TYPE = row.Cells["DOC_TYP_CD"].Value.ToString();

                DocumentExport();
            }
        }

        private void DocumentExport()
        {
            DTOFactory.Transaction(new DocDTO());
            DataSet ds = DTOFactory.GetDataSet();

            dt_Doc = ds.Tables["ds_list"].Copy();
            gd_Doc.DataSource = dt_Doc;

            dt_Item = ds.Tables["ds_item"].Copy();

            if (!gd_Doc.LabelDisplayed)
            {
                gd_Doc.SetGridColumn(ds.Tables["ds_column"]);

                DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                {
                    Text = "문서 출력",
                    HeaderText = "관리",
                    Name = "Excel",
                    UseColumnTextForButtonValue = true
                };
                gd_Doc.Columns.AddRange(bt2);
            }
        }
        private void DocumentInsert(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                if ("문서신청".Equals(row.Cells[e.ColumnIndex].Value))
                {
                    switch (row.Cells["DOC_TYP_CD"].Value)
                    {
                        case "01":
                            var frm01 = new Popup.DocInsertPopup_01()
                            {
                                DOC_TYP_CD = row.Cells["DOC_TYP_CD"].Value.ToString()
                            };

                            frm01.ShowDialog();
                            break;
                        case "11":
                        case "12":
                        case "13":
                        case "14":
                        case "15":
                        case "16":
                        case "17":
                        case "18":
                        case "19":
                            var frm11 = new Popup.DocInsertPopup_11()
                            {
                                DOC_TYP_CD = row.Cells["DOC_TYP_CD"].Value.ToString()
                            };

                            frm11.ShowDialog();
                            break;
                        case "21":
                            var frm21 = new Popup.DocInsertPopup_21()
                            {
                                DOC_TYP_CD = row.Cells["DOC_TYP_CD"].Value.ToString()
                            };

                            frm21.ShowDialog();
                            break;
                        case "22":
                            var frm22 = new Popup.DocInsertPopup_22()
                            {
                                DOC_TYP_CD = row.Cells["DOC_TYP_CD"].Value.ToString()
                            };

                            frm22.ShowDialog();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void ExcelExport(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                if ("문서 출력".Equals(row.Cells[e.ColumnIndex].Value))
                {
                    if (!"승인".Equals(dt_Doc.Rows[e.RowIndex]["CFM_YN"].ToString()))
                    {
                        ViewMessage.Warning("승인되지 않은 문서입니다.");
                    }
                    else
                    {
                        DTOFactory.Action();

                        #region 공통
                        string DOC_TYP_NM = dt_Doc.Rows[e.RowIndex]["DOC_TYP_NM"].ToString();
                        string CRT_TM = dt_Doc.Rows[e.RowIndex]["CRT_TM"].ToString().Substring(0, 10);
                        string USER_NM = dt_Doc.Rows[e.RowIndex]["USER_NM"].ToString();
                        string WORK_DESC = dt_Doc.Rows[e.RowIndex]["WORK_DESC"].ToString();
                        string GRADE_CD = dt_Doc.Rows[e.RowIndex]["GRADE_CD"].ToString();
                        string DOC_DESC = dt_Doc.Rows[e.RowIndex]["DOC_DESC"].ToString();
                        string DOC_ID = dt_Doc.Rows[e.RowIndex]["DOC_ID"].ToString();
                        string path = @"c:\temp\" + DOC_TYP_NM + "_" + DateTime.Now.ToString("yyyyMMdd HHmm") + "_" + USER_NM + ".xlsx";

                        string START_DATE = !"".Equals(dt_Doc.Rows[e.RowIndex]["START_TM"].ToString()) ? dt_Doc.Rows[e.RowIndex]["START_TM"].ToString().Substring(0, 10) : "";
                        string END_DATE = !"".Equals(dt_Doc.Rows[e.RowIndex]["END_TM"].ToString()) ? dt_Doc.Rows[e.RowIndex]["END_TM"].ToString().Substring(0, 10) : "";

                        string START_TIME = "";
                        string END_TIME = "";

                        if (DOC_TYPE == "15" || DOC_TYPE == "16")
                        {
                            START_TIME = !"".Equals(dt_Doc.Rows[e.RowIndex]["START_TM"].ToString()) ? dt_Doc.Rows[e.RowIndex]["START_TM"].ToString().Substring(11, 2) + " : 00" : "";
                            END_TIME = !"".Equals(dt_Doc.Rows[e.RowIndex]["END_TM"].ToString()) ? dt_Doc.Rows[e.RowIndex]["END_TM"].ToString().Substring(11, 2) + " : 00" : "";
                        }

                        string SUBJECT = dt_Doc.Rows[e.RowIndex]["SUBJECT"].ToString();
                        string SITE_NM = dt_Doc.Rows[e.RowIndex]["SITE_NM"].ToString();
                        string USER_LVAL = dt_Doc.Rows[e.RowIndex]["USER_ID_LVAL"].ToString();

                        int i = 0;

                        Excel.Application app = new Excel.Application();
                        Excel.Workbook work = app.Workbooks.Add();
                        Excel._Worksheet sheet = (Excel._Worksheet)app.ActiveSheet;
                        app.ActiveWindow.DisplayGridlines = false;

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

                        #region width 정의
                        ((Excel.Range)sheet.Cells[1, 1]).EntireColumn.ColumnWidth = 8.38;
                        ((Excel.Range)sheet.Cells[1, 2]).EntireColumn.ColumnWidth = 8.38;
                        ((Excel.Range)sheet.Cells[1, 3]).EntireColumn.ColumnWidth = 8.38;
                        ((Excel.Range)sheet.Cells[1, 4]).EntireColumn.ColumnWidth = 8.38;
                        ((Excel.Range)sheet.Cells[1, 5]).EntireColumn.ColumnWidth = 8.38;
                        ((Excel.Range)sheet.Cells[1, 6]).EntireColumn.ColumnWidth = 3.3;
                        ((Excel.Range)sheet.Cells[1, 7]).EntireColumn.ColumnWidth = 3.3;
                        ((Excel.Range)sheet.Cells[1, 8]).EntireColumn.ColumnWidth = 8.38;
                        ((Excel.Range)sheet.Cells[1, 9]).EntireColumn.ColumnWidth = 8.38;
                        #endregion end width

                        #region Head
                        //Height
                        ((Excel.Range)sheet.Cells[1, 1]).EntireRow.RowHeight = 16.5;
                        ((Excel.Range)sheet.Cells[2, 1]).EntireRow.RowHeight = 16.5;
                        ((Excel.Range)sheet.Cells[3, 1]).EntireRow.RowHeight = 16.5;
                        ((Excel.Range)sheet.Cells[4, 1]).EntireRow.RowHeight = 16.5;
                        ((Excel.Range)sheet.Cells[5, 1]).EntireRow.RowHeight = 16.5;
                        ((Excel.Range)sheet.Cells[6, 1]).EntireRow.RowHeight = 16.5;
                        ((Excel.Range)sheet.Cells[7, 1]).EntireRow.RowHeight = 16.5;
                        ((Excel.Range)sheet.Cells[8, 1]).EntireRow.RowHeight = 8.25;
                        ((Excel.Range)sheet.Cells[9, 1]).EntireRow.RowHeight = 4;
                        ((Excel.Range)sheet.Cells[10, 1]).EntireRow.RowHeight = 21;
                        ((Excel.Range)sheet.Cells[11, 1]).EntireRow.RowHeight = 30.8;
                        ((Excel.Range)sheet.Cells[12, 1]).EntireRow.RowHeight = 16.5;

                        //셀 병합
                        sheet.Range["A6", "B6"].Merge();
                        sheet.Range["C6", "E6"].Merge();
                        sheet.Range["A7", "B7"].Merge();
                        sheet.Range["I7", "J7"].Merge();
                        sheet.Range["A11", "J11"].Merge();
                        sheet.Range["A9", "H9"].Merge();
                        sheet.Range["I9", "J9"].Merge();

                        sheet.Range["A9", "H9"].Interior.Color = Color.FromArgb(87, 87, 87);
                        sheet.Range["I9", "J9"].Interior.Color = Color.FromArgb(233, 79, 54);

                        sheet.Range["I7", "J7"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Range["A11", "J11"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                        //데이터 입력
                        sheet.Cells[4, 1] = "주식회사 엠와이씨";
                        sheet.Cells[5, 1] = "충북 청주시 서원구 충대로 1 S21-1동 214호";
                        sheet.Cells[6, 1] = "Tel 043)904-9300";
                        sheet.Cells[6, 3] = "Fax 043)904-9301";
                        sheet.Cells[7, 1] = "제 " + dt_Doc.Rows[e.RowIndex]["DOC_ID"].ToString() + " 호";
                        sheet.Cells[7, 8] = "발급일:";
                        sheet.Cells[7, 9] = CRT_TM;

                        //결재란
                        switch (DOC_TYPE)
                        {
                            case "01":
                            case "02":
                                break;

                            default:
                                sheet.Range["G1", "G4"].Merge();
                                sheet.Range["H2", "H4"].Merge();
                                sheet.Range["I2", "I4"].Merge();
                                sheet.Range["J2", "J4"].Merge();

                                sheet.Cells[1, 7] = "결\n재";
                                sheet.Cells[1, 8] = "본인";
                                sheet.Cells[1, 9] = "확인자";
                                sheet.Cells[1, 10] = "대표이사";

                                sheet.Range["G1", "J7"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                sheet.Range["G1", "J4"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["G1", "J4"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["G1", "J4"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["G1", "J4"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["G1", "J4"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["G1", "J4"].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["I2", "I4"].Borders[Excel.XlBordersIndex.xlDiagonalUp].LineStyle = Excel.XlLineStyle.xlContinuous;
                                break;
                        }

                        sheet.Cells[11, 1] = DOC_TYP_NM;
                        //font
                        sheet.Range["A11", "J11"].Font.Bold = true;

                        sheet.Range["A4", "I7"].Font.Size = 11;
                        sheet.Range["A11", "J11"].Font.Size = 20;
                        #endregion head

                        #endregion 공통
                        switch (DOC_TYPE)
                        {
                            #region 경력/재직증명서
                            case "01":
                            case "02":

                                #region Body
                                //height
                                ((Excel.Range)sheet.Cells[13, 1]).EntireRow.RowHeight = 16.5;
                                ((Excel.Range)sheet.Cells[14, 1]).EntireRow.RowHeight = 16.5;
                                ((Excel.Range)sheet.Cells[15, 1]).EntireRow.RowHeight = 16.5;
                                ((Excel.Range)sheet.Cells[16, 1]).EntireRow.RowHeight = 16.5;
                                ((Excel.Range)sheet.Cells[17, 1]).EntireRow.RowHeight = 22.5;
                                ((Excel.Range)sheet.Cells[18, 1]).EntireRow.RowHeight = 22.5;
                                ((Excel.Range)sheet.Cells[19, 1]).EntireRow.RowHeight = 22.5;
                                ((Excel.Range)sheet.Cells[20, 1]).EntireRow.RowHeight = 22.5;
                                ((Excel.Range)sheet.Cells[21, 1]).EntireRow.RowHeight = 22.5;
                                ((Excel.Range)sheet.Cells[22, 1]).EntireRow.RowHeight = 22.5;
                                ((Excel.Range)sheet.Cells[23, 1]).EntireRow.RowHeight = 22.5;
                                ((Excel.Range)sheet.Cells[24, 1]).EntireRow.RowHeight = 22.5;

                                sheet.Range["A17", "J17"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                for (i = 17; i < 25; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Merge();

                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                    if (i != 23)
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].Merge();

                                        sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                        sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    else
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("D{0}", i)].Merge();
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();

                                        sheet.Range[string.Format("C{0}", i), string.Format("F{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                        sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                }



                                sheet.Cells[17, 1] = "성          명";
                                sheet.Cells[17, 3] = USER_NM;

                                sheet.Cells[18, 1] = "생  년  월  일";
                                sheet.Cells[19, 3] = DTOFactory.UserBirth.ToString();

                                sheet.Cells[19, 1] = "주           소";
                                sheet.Cells[19, 3] = dt_Doc.Rows[e.RowIndex]["ADDR"].ToString();

                                sheet.Cells[20, 1] = "입  사  일  자";
                                sheet.Cells[20, 3] = dt_Doc.Rows[e.RowIndex]["JOIN_DT"].ToString().Substring(0, 4) + "-" + dt_Doc.Rows[e.RowIndex]["JOIN_DT"].ToString().Substring(4, 2) + "-" + dt_Doc.Rows[e.RowIndex]["JOIN_DT"].ToString().Substring(6, 2);

                                sheet.Cells[21, 1] = "근  무  부  서";
                                sheet.Cells[21, 3] = WORK_DESC;

                                sheet.Cells[22, 1] = "직            위";
                                sheet.Cells[22, 3] = GRADE_CD;

                                sheet.Cells[23, 1] = "재  직  기  간";
                                sheet.Cells[23, 3] = "=C20";
                                sheet.Cells[23, 5] = "부터";
                                sheet.Cells[23, 9] = "까지";

                                if (DOC_TYPE == "01")
                                {
                                    sheet.Cells[23, 7] = "현재";
                                    sheet.Cells[30, 5] = "현재";
                                }
                                else
                                {
                                    sheet.Cells[23, 7] = dt_Doc.Rows[e.RowIndex]["RETIRE_DT"].ToString();
                                    sheet.Cells[23, 10] = "=\"(\"&DATEDIF(C23,G23,\"y\")&\"년\"&DATEDIF(C23,G23,\"ym\")&\"개월\"&\")\"";
                                    sheet.Range["J23", "J23"].Font.Size = 10;
                                    sheet.Cells[31, 5] = dt_Doc.Rows[e.RowIndex]["RETIRE_DT"].ToString();
                                }

                                sheet.Cells[24, 1] = "용            도";
                                sheet.Cells[24, 3] = DOC_DESC;

                                #endregion

                                #region Bottom

                                sheet.Range["E29", "F29"].Merge();
                                sheet.Range["G29", "H29"].Merge();
                                sheet.Range["I29", "J29"].Merge();
                                sheet.Range["E30", "G30"].Merge();

                                sheet.Range["E29", "H29"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                sheet.Range["H28", "J31"].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                                sheet.Range["E30", "G30"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                sheet.Cells[29, 5] = "위 사람은";
                                sheet.Cells[29, 7] = "=C20";
                                sheet.Cells[29, 9] = "에 입사하여";


                                if (DOC_TYPE == "01") //재직증명서
                                {
                                    sheet.Cells[30, 5] = "=I7";
                                    sheet.Cells[30, 8] = "현재";
                                    sheet.Cells[31, 10] = "재직 중임을 증명합니다.";
                                }
                                else                  //경력증명서
                                {
                                    sheet.Cells[30, 8] = "까지";
                                    sheet.Cells[31, 10] = "재직한 경력이 있음을 증명합니다.";
                                }
                                sheet.Cells[30, 9] = "=C22";
                                sheet.Cells[30, 10] = "으로";

                                sheet.Range["H34", "H36"].Font.Bold = true;
                                sheet.Range["H34", "H36"].Font.Size = 12;
                                sheet.Cells[34, 8] = "주식회사  엠    와    이    씨";
                                sheet.Cells[36, 8] = "대표이사  지   문   영 ";

                                #region Logo
                                FileInfo StampLogo = new FileInfo(@"C:\Temp\" + DTOFactory.CompStamp.ToString());
                                ImageGet Slogo = new ImageGet(DTOFactory.CompStamp.ToString());

                                using (FileStream stream = new FileStream(StampLogo.FullName, FileMode.Create, FileAccess.Write))
                                {
                                    byte[] buffer = Slogo.GetImageBlock();
                                    stream.Write(buffer, 0, buffer.Length);
                                }

                                sheet.Shapes.AddPicture(StampLogo.FullName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue
                                    , 420, 605, 60, 60);
                                StampLogo.Delete();
                                #endregion

                                #endregion
                                break;
                            #endregion

                            #region 근태신청서
                            case "11":
                            case "12":
                            case "13":
                            case "14":
                            case "15":
                            case "16":
                            case "17":
                            case "18":
                            case "19":
                                #region Head
                                sheet.Cells[11, 1] = "근태 신청서";
                                sheet.Cells[13, 1] = "1. 작성자개요";

                                sheet.Range["A14", "J14"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                for (i = 14; i < 17; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Merge();
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                    sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].Merge();

                                    sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                }

                                sheet.Range["A14", "J16"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J16"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J16"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J16"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Cells[14, 1] = "근무부서";
                                sheet.Cells[14, 3] = WORK_DESC;

                                sheet.Cells[15, 1] = "성     명";
                                sheet.Cells[15, 3] = USER_NM;

                                sheet.Cells[16, 1] = "직     위";
                                sheet.Cells[16, 3] = GRADE_CD;
                                #endregion

                                #region Body
                                sheet.Cells[18, 1] = "2. 근태구분";
                                sheet.Range["A19", "J19"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                for (i = 19; i < 22; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Merge();
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                    sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                }

                                sheet.Range["A19", "J21"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A19", "J21"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A19", "J21"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A19", "J21"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Cells[19, 1] = "출     장";
                                sheet.Cells[19, 3] = "국내출장";
                                sheet.Cells[19, 4] = "(     )";
                                sheet.Cells[19, 6] = "국외출장";
                                sheet.Cells[19, 8] = "(     )";

                                sheet.Cells[20, 1] = "교     육";
                                sheet.Cells[20, 3] = "사외교육";
                                sheet.Cells[20, 4] = "(     )";

                                sheet.Cells[21, 1] = "휴     가";
                                sheet.Cells[21, 3] = "1일(     )";
                                sheet.Cells[21, 4] = "오전 (     )";
                                sheet.Cells[21, 5] = "오후 (     )";
                                sheet.Cells[21, 6] = "병가";
                                sheet.Cells[21, 7] = "(    )";
                                sheet.Cells[21, 8] = "공가(     )";
                                sheet.Cells[21, 9] = "특별(     )";

                                sheet.Cells[23, 1] = "3.세부일정";

                                sheet.Range["A24", "J24"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                for (i = 24; i < 32; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", 2 + i)].Merge();
                                    sheet.Range[string.Format("C{0}", i), string.Format("D{0}", 2 + i)].Merge();
                                    sheet.Range[string.Format("E{0}", i), string.Format("E{0}", 2 + i)].Merge();
                                    sheet.Range[string.Format("F{0}", i), string.Format("H{0}", 2 + i)].Merge();
                                    sheet.Range[string.Format("I{0}", i), string.Format("J{0}", 2 + i)].Merge();

                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", 2 + i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                    sheet.Range[string.Format("C{0}", i), string.Format("D{0}", 2 + i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                    sheet.Range[string.Format("E{0}", i), string.Format("E{0}", 2 + i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                    sheet.Range[string.Format("F{0}", i), string.Format("H{0}", 2 + i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                    sheet.Range[string.Format("I{0}", i), string.Format("J{0}", 2 + i)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", 2 + i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", 2 + i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", 2 + i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", 2 + i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

                                    i += 2;
                                }

                                sheet.Range["A30", "B37"].Merge();
                                sheet.Range["C30", "J37"].Merge();

                                sheet.Range["A30", "B37"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                sheet.Range["C30", "J37"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                sheet.Range["A30", "B37"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A30", "J37"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A30", "J37"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A30", "J37"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

                                sheet.Range["A24", "J37"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A24", "J37"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A24", "J37"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A24", "J37"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Cells[24, 1] = "기   간";
                                sheet.Cells[27, 1] = "시   간\n(반차일경우)";
                                sheet.Cells[30, 1] = "사   유";

                                sheet.Cells[24, 3] = START_DATE;
                                sheet.Cells[24, 5] = "~";
                                sheet.Cells[24, 6] = END_DATE;
                                sheet.Cells[24, 9] = "= \"(\" & DATEDIF(C23, F23, \"D\") + 1 & \" 일간)\"";

                                sheet.Cells[27, 5] = "-";

                                sheet.Cells[30, 3] = DOC_DESC;

                                switch (DOC_TYPE)
                                {
                                    case "11": //국내출장
                                        sheet.Cells[19, 4] = "( ○ )";
                                        break;

                                    case "12": //국외출장
                                        sheet.Cells[19, 8] = "( ○ )";
                                        break;

                                    case "13": //사외교육
                                        sheet.Cells[20, 4] = "( ○ )";
                                        break;

                                    case "14": //1일 휴가
                                        sheet.Cells[21, 3] = "1일( ○ )";
                                        break;

                                    case "15": //오전반차
                                        sheet.Cells[21, 4] = "오전( ○ )";

                                        sheet.Cells[27, 3] = START_TIME;
                                        sheet.Cells[27, 5] = "~";
                                        sheet.Cells[27, 6] = END_TIME;
                                        break;

                                    case "16": //오후반차
                                        sheet.Cells[21, 5] = "오후( ○ )";

                                        sheet.Cells[27, 3] = START_TIME;
                                        sheet.Cells[27, 5] = "~";
                                        sheet.Cells[27, 6] = END_TIME;
                                        break;

                                    case "17": //병가
                                        sheet.Cells[21, 7] = "( ○ )";
                                        break;

                                    case "18": //공가
                                        sheet.Cells[21, 8] = "공가( ○ )";
                                        break;

                                    case "19": //특별
                                        sheet.Cells[21, 9] = "특별( ○ )";
                                        break;

                                }
                                #endregion

                                sheet.Cells[39, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                sheet.Cells[39, 9].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                                sheet.Cells[39, 10].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                                sheet.Cells[39, 8] = "작 성 자";
                                sheet.Cells[39, 9] = USER_NM;
                                sheet.Cells[39, 10] = "(인)";
                                break;
                            #endregion

                            #region 출장 계획서
                            case "21":
                                #region Head
                                sheet.Cells[13, 1] = "1. 출장개요";

                                sheet.Range["A14", "J14"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                for (i = 14; i < 21; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Merge();

                                    if (i != 19)
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].Merge();
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                                        sheet.Range[string.Format("I{0}", i), string.Format("J{0}", i)].Merge();

                                        sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    else
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("D{0}", i)].Merge();
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                                        sheet.Range[string.Format("I{0}", i), string.Format("J{0}", i)].Merge();

                                        sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                }

                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Range["A14", "J20"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                sheet.Cells[14, 1] = "근무부서";
                                sheet.Cells[14, 3] = WORK_DESC;
                                sheet.Cells[15, 1] = "성     명";
                                sheet.Cells[15, 3] = USER_NM;
                                sheet.Cells[16, 1] = "직     위";
                                sheet.Cells[16, 3] = GRADE_CD;
                                sheet.Cells[17, 1] = "동 행 자";
                                sheet.Cells[17, 3] = USER_LVAL;
                                sheet.Cells[18, 1] = "출 장 지";
                                sheet.Cells[18, 3] = SITE_NM;
                                sheet.Cells[19, 1] = "출장기간";
                                sheet.Cells[19, 3] = START_DATE;
                                sheet.Cells[19, 5] = "~";
                                sheet.Cells[19, 7] = END_DATE;
                                sheet.Cells[19, 9] = "= \"(\" & DATEDIF(C19, G19, \"D\") + 1 & \" 일간)\"";
                                sheet.Cells[20, 1] = "출장목적";
                                sheet.Cells[20, 3] = SUBJECT;
                                #endregion

                                #region Body
                                sheet.Cells[22, 1] = "2. 세부일정";

                                sheet.Range["A23", "J23"].Merge();

                                sheet.Range["A23", "J23"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A23", "J23"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A23", "J23"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A23", "J23"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

                                sheet.Range["A23", "J24"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J24"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J24"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Cells[23, 1] = "업무일정";

                                int j = 24;

                                for (i = 24; i < 39; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", j)].Merge();
                                    sheet.Range[string.Format("C{0}", i), string.Format("J{0}", j)].Merge();

                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                                    j += 3;

                                    if (i > 24)
                                    {
                                        i += 2;
                                    }
                                }

                                sheet.Range["A23", "J39"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                sheet.Cells[23, 1] = "업무일정";
                                sheet.Cells[24, 1] = "일    자";
                                sheet.Cells[24, 3] = "업무내용";

                                j = 25;
                                for (i = 0; i < dt_Item.Rows.Count; i++)
                                {
                                    if (dt_Item.Rows[i]["DOC_ID"].ToString() == DOC_ID)
                                    {
                                        sheet.Cells[j, 1] = dt_Item.Rows[i]["GRP_NM"].ToString();
                                        sheet.Cells[j, 3] = dt_Item.Rows[i]["DOC_DESC"].ToString();

                                        j += 3;
                                    }
                                }

                                sheet.Cells[37, 1] = "비고";
                                sheet.Cells[37, 3] = DOC_DESC;

                                sheet.Range["A37", "J37"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Range["A23", "J39"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J39"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J39"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J39"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                #endregion
                                break;
                            #endregion

                            #region 출장 완료 보고서
                            case "22":
                                #region Head
                                sheet.Cells[13, 1] = "1. 출장개요";

                                sheet.Range["A14", "J14"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                for (i = 14; i < 21; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Merge();

                                    if (i != 19)
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].Merge();
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                                        sheet.Range[string.Format("I{0}", i), string.Format("J{0}", i)].Merge();

                                        sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    else
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("D{0}", i)].Merge();
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                                        sheet.Range[string.Format("I{0}", i), string.Format("J{0}", i)].Merge();

                                        sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                }

                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J20"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Range["A14", "J20"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                sheet.Cells[14, 1] = "근무부서";
                                sheet.Cells[14, 3] = WORK_DESC;
                                sheet.Cells[15, 1] = "성     명";
                                sheet.Cells[15, 3] = USER_NM;
                                sheet.Cells[16, 1] = "직     위";
                                sheet.Cells[16, 3] = GRADE_CD;
                                sheet.Cells[17, 1] = "동 행 자";
                                sheet.Cells[17, 3] = USER_LVAL;
                                sheet.Cells[18, 1] = "출 장 지";
                                sheet.Cells[18, 3] = SITE_NM;
                                sheet.Cells[19, 1] = "출장기간";
                                sheet.Cells[19, 3] = START_DATE;
                                sheet.Cells[19, 5] = "~";
                                sheet.Cells[19, 7] = END_DATE;
                                sheet.Cells[19, 9] = "= \"(\" & DATEDIF(C19, G19, \"D\") + 1 & \" 일간)\"";
                                sheet.Cells[20, 1] = "출장목적";
                                sheet.Cells[20, 3] = SUBJECT;
                                #endregion

                                #region Body
                                sheet.Cells[22, 1] = "2. 출장업무사항";

                                sheet.Range["A23", "J23"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                j = 23;

                                for (i = 23; i < 36; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", j)].Merge();
                                    sheet.Range[string.Format("C{0}", i), string.Format("J{0}", j)].Merge();

                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", j)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                                    j += 3;
                                    if (i > 23)
                                    {
                                        i += 2;
                                    }
                                }

                                sheet.Range["A23", "J36"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                sheet.Cells[23, 1] = "일    자";
                                sheet.Cells[23, 3] = "업무내용";

                                j = 24;
                                for (i = 0; i < dt_Item.Rows.Count; i++)
                                {
                                    if (dt_Item.Rows[i]["DOC_ID"].ToString() == DOC_ID)
                                    {
                                        sheet.Cells[j, 1] = dt_Item.Rows[i]["GRP_NM"].ToString();
                                        sheet.Cells[j, 3] = dt_Item.Rows[i]["DOC_DESC"].ToString();

                                        j += 3;
                                    }
                                }

                                sheet.Range["A36", "B36"].Merge();
                                sheet.Range["C36", "J36"].Merge();

                                sheet.Range["A36", "B36"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A36", "J36"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A36", "J36"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A36", "J36"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A36", "J36"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

                                sheet.Cells[36, 1] = "출장경비";
                                sheet.Cells[36, 3] = "(출장비 내역서 별도첨부)";

                                sheet.Range["A23", "J36"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J36"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J36"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A23", "J36"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Range["A38", "A39"].Font.Size = 8;
                                sheet.Cells[38, 1] = "■출장보고서 작성 시 의무사항 : 여비규정에 근거";
                                sheet.Cells[39, 1] = "   출장에서 귀임 3일 이내에 출장완료보고서, 출장비 명세서 및 기타 증빙서류를 첨부하여 보고/정산하여야 한다.";
                                #endregion
                                break;
                            #endregion

                            #region 출장비 내역서
                            case "23":
                                #region Head
                                sheet.Cells[13, 1] = "1. 출장개요";

                                sheet.Range["A14", "J14"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

                                for (i = 14; i < 19; i++)
                                {
                                    sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Merge();

                                    if (i != 18)
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("J{0}", i)].Merge();
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                                        sheet.Range[string.Format("I{0}", i), string.Format("J{0}", i)].Merge();

                                        sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    else
                                    {
                                        sheet.Range[string.Format("C{0}", i), string.Format("D{0}", i)].Merge();
                                        sheet.Range[string.Format("G{0}", i), string.Format("H{0}", i)].Merge();
                                        sheet.Range[string.Format("I{0}", i), string.Format("J{0}", i)].Merge();

                                        sheet.Range[string.Format("A{0}", i), string.Format("B{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    }
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", i), string.Format("J{0}", i)].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                }

                                sheet.Range["A14", "J18"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J18"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J18"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A14", "J18"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Range["A14", "J18"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                sheet.Cells[14, 1] = "근무부서";
                                sheet.Cells[14, 3] = WORK_DESC;
                                sheet.Cells[15, 1] = "성     명";
                                sheet.Cells[15, 3] = USER_NM;
                                sheet.Cells[16, 1] = "직     위";
                                sheet.Cells[16, 3] = GRADE_CD;
                                sheet.Cells[17, 1] = "출 장 지";
                                sheet.Cells[17, 3] = SITE_NM;
                                sheet.Cells[18, 1] = "출장기간";
                                sheet.Cells[18, 3] = START_DATE;
                                sheet.Cells[18, 5] = "~";
                                sheet.Cells[18, 7] = END_DATE;
                                sheet.Cells[18, 9] = "= \"(\" & DATEDIF(C18, G18, \"D\") + 1 & \" 일간)\"";
                                #endregion

                                #region Body
                                sheet.Cells[20, 1] = "2. 출장비 사용내역";

                                sheet.Range["A21", "B22"].Merge();
                                sheet.Range["C21", "H21"].Merge();
                                sheet.Range["C22", "E22"].Merge();
                                sheet.Range["F22", "H22"].Merge();
                                sheet.Range["I21", "J22"].Merge();

                                sheet.Cells[21, 1] = "항목";
                                sheet.Cells[21, 3] = "내역";
                                sheet.Cells[21, 9] = "항목별금액";
                                sheet.Cells[22, 3] = "세부항목";
                                sheet.Cells[22, 6] = "금액";

                                sheet.Range["A21", "J22"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                sheet.Range["A21", "J22"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A21", "J22"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A21", "J22"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A21", "J22"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A21", "J22"].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                                sheet.Range["A21", "J22"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                                j = 23;

                                int START = 23;
                                int END = 0;
                                for (i = 0; i < dt_Item.Rows.Count; i++)
                                {
                                    if (dt_Item.Rows[i]["DOC_ID"].ToString() == DOC_ID)
                                    {
                                        sheet.Range[string.Format("C{0}", j), string.Format("E{0}", j)].Merge();
                                        sheet.Range[string.Format("F{0}", j), string.Format("H{0}", j)].Merge();
                                        sheet.Range[string.Format("F{0}", j), string.Format("J{0}", j)].NumberFormat = "\\ #,##0";
                                        if (i == 0)
                                        {
                                            sheet.Range[string.Format("A{0}", j), string.Format("B{0}", j)].Merge();
                                            sheet.Range[string.Format("I{0}", j), string.Format("J{0}", j)].Merge();
                                        }
                                        else
                                        {
                                            if (dt_Item.Rows[i]["GRP_NM"].ToString() == dt_Item.Rows[i - 1]["GRP_NM"].ToString())
                                            {
                                                END = j;
                                                sheet.Range[string.Format("A{0}", j), string.Format("B{0}", j - 1)].Merge();
                                                sheet.Range[string.Format("I{0}", j), string.Format("J{0}", j - 1)].Merge();
                                            }
                                            else
                                            {
                                                START = j;
                                                END = j;
                                                sheet.Range[string.Format("A{0}", j), string.Format("B{0}", j)].Merge();
                                                sheet.Range[string.Format("I{0}", j), string.Format("J{0}", j)].Merge();
                                            }

                                        }
                                        sheet.Cells[j, 1] = dt_Item.Rows[i]["GRP_NM"].ToString();
                                        sheet.Cells[j, 3] = dt_Item.Rows[i]["SUBJECT"].ToString();
                                        sheet.Cells[j, 6] = dt_Item.Rows[i]["DOC_DESC"].ToString();
                                        sheet.Cells[START, 9] = "=SUM(F" + START + ":H" + END + ")";

                                        sheet.Range[string.Format("A{0}", START), string.Format("J{0}", END)].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                        sheet.Range[string.Format("A{0}", START), string.Format("J{0}", END)].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                        sheet.Range[string.Format("A{0}", START), string.Format("J{0}", END)].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                        sheet.Range[string.Format("A{0}", START), string.Format("J{0}", END)].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                        sheet.Range[string.Format("A{0}", START), string.Format("J{0}", END)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                                        sheet.Range[string.Format("A{0}", START), string.Format("J{0}", END)].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;


                                        j++;
                                    }

                                    int k = 0;

                                    for (k = j; k < 37; k++)
                                    {
                                        sheet.Range[string.Format("A{0}", k), string.Format("B{0}", k)].Merge();
                                        sheet.Range[string.Format("C{0}", k), string.Format("E{0}", k)].Merge();
                                        sheet.Range[string.Format("F{0}", k), string.Format("H{0}", k)].Merge();
                                        sheet.Range[string.Format("I{0}", k), string.Format("J{0}", k)].Merge();
                                    }

                                    sheet.Range[string.Format("A{0}", j), string.Format("J{0}", k)].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                                    sheet.Range[string.Format("A{0}", j), string.Format("J{0}", k)].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;

                                    sheet.Range[string.Format("A{0}", j), string.Format("J{0}", k - 1)].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
                                }

                                sheet.Range["A37", "B37"].Merge();
                                sheet.Range["C37", "J37"].Merge();

                                sheet.Range["A23", "E36"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                sheet.Range["A37", "J37"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                                sheet.Cells[37, 1] = "합  계";
                                sheet.Cells[37, 3] = "=SUM(F22:H36)";
                                sheet.Range["C37", "J37"].NumberFormat = "\\ #,##0\"원\"";

                                sheet.Range["A21", "J37"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A21", "J37"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A21", "J37"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                                sheet.Range["A21", "J37"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                                sheet.Range["A38", "A39"].Font.Size = 8;
                                sheet.Cells[38, 1] = "■출장보고서 작성 시 의무사항 : 여비규정에 근거";
                                sheet.Cells[39, 1] = "   출장에서 귀임 3일 이내에 출장완료보고서, 출장비 명세서 및 기타 증빙서류를 첨부하여 보고/정산하여야 한다.";
                                #endregion
                                break;
                                #endregion
                        }

                        #region 공통 Bottom
                        ((Excel.Range)sheet.Cells[40, 1]).EntireRow.RowHeight = 3;
                        ((Excel.Range)sheet.Cells[41, 1]).EntireRow.RowHeight = 13.5;

                        sheet.Range["A41", "J41"].Merge();
                        sheet.Range["A41", "J41"].Font.Size = 9;
                        sheet.Range["A41", "J41"].Font.Color = Color.White;
                        sheet.Range["A41", "J41"].Interior.Color = Color.FromArgb(87, 87, 87);
                        sheet.Range["A41", "J41"].Font.Bold = true;
                        sheet.Cells[41, 1] = "     SOLUTIONS OF TECHNOLOGY";

                        Excel.PageSetup ps = sheet.PageSetup;
                        ps.LeftMargin = 50.4;
                        ps.RightMargin = 50.4;
                        ps.HeaderMargin = 22.8;
                        ps.FooterMargin = 22.8;
                        ps.TopMargin = 57.3;
                        ps.BottomMargin = 57.3;

                        work.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                        work.Close();
                        app.Quit();

                        System.Diagnostics.Process.Start(path);

                        DTOFactory.Complete();
                        #endregion 공통 Bottom
                    }
                }
            }
        }
    }
}
