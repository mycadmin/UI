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
    public partial class AssignHistory : MYCControl
    {
        #region Field        
        protected DataTable _dtList = new DataTable();
        #endregion

        #region Init
        public AssignHistory()
        {
            InitializeComponent();
        }

        private void AssignHistory_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            cboComp.Params.Clear();
            cboComp.Params.Add("strCompType", "C");
            cboComp.BindDataSet();

            cboCstUser.Params.Clear();
            cboCstUser.Params.Add("strCompType", "C");
            cboCstUser.BindDataSet();

            cbockVisitUser.Params.Clear();
            cbockVisitUser.Params.Add("strCompType", "");
            cbockVisitUser.BindDataSet();

            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;
        }
        #endregion

        private void GetVisitHistory(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("FROM_DT", dtFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00");
            SetSearchData("TO_DT", dtTo.Value.ToString("yyyy-MM-dd") + " 23:59:59");
            SetSearchData("CST_COMP_CD", cboComp.ValueList);
            SetServiceId("GetVisitHistory");

            cboCstUser.SetItemChecked("");
            cbockVisitUser.SetItemChecked("");

            txtSubject.Text = "";
            txtSite.Text = "";
            txtProduct.Text = "";
            txtDesc.Text = "";

            CalStartTm.Value = DateTime.Now;
            CalEndTm.Value = DateTime.Now;

            try
            {
                DTOFactory.Transaction(new ReportDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                _dtList = ds_return.Tables["ds_history"];
                gd_List.DataSource = _dtList;
                gd_List.SetGridColumn(ds_return.Tables["ds_column"]);

                panel1.Enabled = true;
                panel2.Enabled = true;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void GetVisitHistoryItem(object sender, DataGridViewCellEventArgs e)
        {
            int row = gd_List.SelectedRows[0].Index;

            txtSubject.Text = _dtList.Rows[row]["SUBJECT"].ToString();
            txtSite.Text = _dtList.Rows[row]["SITE_NM"].ToString();
            txtProduct.Text = _dtList.Rows[row]["PRD_NM"].ToString();
            txtDesc.Text = _dtList.Rows[row]["CMT_DESC"].ToString();

            cboCstUser.SetItemChecked(_dtList.Rows[row]["CST_USER_ID"].ToString());
            cbockVisitUser.SetItemChecked(_dtList.Rows[row]["VISIT_USER_ID_LVAL"].ToString());
            CalStartTm.Value = DateTime.Parse(_dtList.Rows[row]["START_TM"].ToString());
            CalEndTm.Value = DateTime.Parse(_dtList.Rows[row]["END_TM"].ToString());
        }

        private void SetVisitHistoryItem(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("CST_COMP_CD", cboComp.ValueList);
            SetSearchData("CST_USER_ID", cboCstUser.ValueList);
            SetSearchData("SUBJECT", txtSubject.Text);
            SetSearchData("FROM_DT", CalStartTm.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            SetSearchData("TO_DT", CalEndTm.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            SetSearchData("SITE_NM", txtSite.Text);
            SetSearchData("PRD_NM", txtProduct.Text);
            SetSearchData("USER_ID_LST", cbockVisitUser.ValueList);
            SetSearchData("DESC", txtDesc.Text);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);
            SetServiceId("SetVisitHistory");

            try
            {
                DTOFactory.Transaction(new ReportDTO());

                DataRow row = _dtList.Rows[gd_List.SelectedRows[0].Index];
                row["SUBJECT"] = txtSubject.Text;
                row["SITE_NM"] = txtSite.Text;
                row["PRD_NM"] = txtProduct.Text;
                row["CMT_DESC"] = txtDesc.Text;
                row["CST_USER_ID"] = cboCstUser.ValueList;
                row["VISIT_USER_ID_LVAL"] = cbockVisitUser.ValueList;
                row["START_TM"] = CalStartTm.Value.ToString("yyyy-MM-dd HH:mm:ss");
                row["END_TM"] = CalEndTm.Value.ToString("yyyy-MM-dd HH:mm:ss");

                ViewMessage.Info("저장이 완료 되었습니다.");

                if (dtTo.Value < CalEndTm.Value)
                    dtTo.Value = CalEndTm.Value;

                GetVisitHistory(btnSearch, null);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ExcelExport(object sender, EventArgs e)
        {
            try
            {
                //2021-01-07 hsh 파일명 규칙에 어긋나는 문자열 제거 (초기버전)
                string path = @"c:\temp\" + txtSubject.Text.Replace("/", "_").Replace(@"\", "_") + ".xlsx";

                Excel.Application app = new Excel.Application();
                Excel.Workbook work = app.Workbooks.Add();
                Excel._Worksheet sheet = (Excel._Worksheet)app.ActiveSheet;
                app.ActiveWindow.DisplayGridlines = false;

                CheckComboBox cbo = new CheckComboBox()
                {
                    Sql = "CommonSearch#getUserGrade"
                };
                cbo.MultiSelection = true;
                cbo.Params.Clear();
                cbo.Params.Add("strCompType","");
                cbo.Params.Add("strCompCode", "");
                cbo.BindDataSet();

                #region Width / Height 정의
                ((Excel.Range)sheet.Cells[1, 1]).EntireColumn.ColumnWidth = 2;
                ((Excel.Range)sheet.Cells[1, 2]).EntireColumn.ColumnWidth = 2;
                ((Excel.Range)sheet.Cells[1, 3]).EntireColumn.ColumnWidth = 10.25;
                ((Excel.Range)sheet.Cells[1, 4]).EntireColumn.ColumnWidth = 21.63;
                ((Excel.Range)sheet.Cells[1, 5]).EntireColumn.ColumnWidth = 23.63;
                ((Excel.Range)sheet.Cells[1, 6]).EntireColumn.ColumnWidth = 2;

                ((Excel.Range)sheet.Cells[1, 1]).EntireRow.RowHeight = 17.25;
                ((Excel.Range)sheet.Cells[2, 1]).EntireRow.RowHeight = 16.5;
                ((Excel.Range)sheet.Cells[3, 1]).EntireRow.RowHeight = 26.25;
                ((Excel.Range)sheet.Cells[4, 1]).EntireRow.RowHeight = 16.5;
                ((Excel.Range)sheet.Cells[5, 1]).EntireRow.RowHeight = 16.5;
                ((Excel.Range)sheet.Cells[6, 1]).EntireRow.RowHeight = 16.5;
                ((Excel.Range)sheet.Cells[7, 1]).EntireRow.RowHeight = 16.5;
                ((Excel.Range)sheet.Cells[8, 1]).EntireRow.RowHeight = 216;
                ((Excel.Range)sheet.Cells[9, 1]).EntireRow.RowHeight = 16.5;
                ((Excel.Range)sheet.Cells[10, 1]).EntireRow.RowHeight = 16.5;
                ((Excel.Range)sheet.Cells[11, 1]).EntireRow.RowHeight = 17.25;
                #endregion

                #region 외곽선 정의
                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                sheet.Range["B2", "F11"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThin;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThin;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlBorderWeight.xlThin;
                sheet.Range["C5", "E10"].Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = Excel.XlBorderWeight.xlThin;
                #endregion

                #region Merge & Font 정의
                sheet.Range["C3", "E10"].Font.Name = "맑은 고딕";
                sheet.Range["C5", "E10"].Font.Size = 11;
                sheet.Range["C3", "E3"].Font.Size = 18;
                sheet.Range["C3", "E10"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range["C3", "E10"].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                sheet.Range["D8", "E8"].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                sheet.Range["D8", "E8"].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;

                sheet.Range["C3", "E3"].Merge();
                sheet.Range["D5", "E5"].Merge();
                sheet.Range["D6", "E6"].Merge();
                sheet.Range["D7", "E7"].Merge();
                sheet.Range["D8", "E8"].Merge();
                sheet.Range["D9", "E9"].Merge();
                #endregion

                #region 내용 입력                
                sheet.Cells[3, 3] = "장비 Assign 요청서";

                sheet.Cells[5, 3] = "일 시";
                sheet.Cells[6, 3] = "장 소";
                sheet.Cells[7, 3] = "대 상";
                sheet.Cells[8, 3] = "목 적";
                sheet.Cells[9, 3] = "출입인원";
                sheet.Cells[10, 3] = "주 관";

                TimeSpan delay = CalEndTm.Value - CalStartTm.Value;

                string strTime = CalStartTm.Value.ToString("yyyy년 MM월 dd일 HH:mm") + " ~ ";

                if (delay.Days < 1)
                {
                    strTime += CalEndTm.Value.ToString("HH:mm");
                }
                else
                {
                    strTime += CalEndTm.Value.ToString("yyyy년 MM월 dd일 HH:mm");
                }

                strTime += " (" + delay.Hours.ToString() + "시간";

                if (delay.Minutes > 0)
                    strTime += " " + delay.Minutes.ToString() + "분";

                strTime += ")";

                sheet.Cells[5, 4] = strTime;
                sheet.Cells[6, 4] = txtSite.Text;
                sheet.Cells[7, 4] = txtProduct.Text;
                sheet.Cells[8, 4] = txtDesc.Text;

                cbo.SetItemChecked(cbockVisitUser.ValueList);
                sheet.Cells[9, 4] = cbo.Text.Trim();
                sheet.Cells[10, 4] = "(주)MYC";

                cbo.SetItemChecked(cboCstUser.ValueList);
                sheet.Cells[10, 5] = cboComp.Text.Substring(cboComp.Text.IndexOf(']') + 1).Trim() + ":" + cbo.Text.Trim();

                FileInfo file = new FileInfo(path);
                if (file.Exists)
                    file.Delete();

                work.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                work.Close();
                app.Quit();

                System.Diagnostics.Process.Start(path);
                #endregion
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
    }
}