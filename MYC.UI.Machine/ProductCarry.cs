using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.Control.Method;
using MYC.UI.Machine.Popup;
using MYC.UI.DTO;

namespace MYC.UI.Machine
{
    public partial class ProductCarry : MYCControl
    {
        #region Field
        protected DataTable dt_Eqp = new DataTable();
        protected DataTable dt_Eqp_Column = new DataTable();
        protected List<DataTable> LstEqpTable = new List<DataTable>();
        protected List<DataGridView> LstGrid = new List<DataGridView>();
        #endregion

        public ProductCarry()
        {
            InitializeComponent();
        }

        private void ProductCarry_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            #region Model Type
            cboType.Params.Add("strItem", "MODEL_TYPE");
            cboType.BindDataSet();
            #endregion Model Type

            #region Customer Company
            cboCompany.Params.Add("strCompType", "C");
            cboCompany.BindDataSet();
            #endregion Model Type
        }

        private void ProductCarry_Resize(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("MODEL_TYPE_CD", cboType.ValueList);
            SetSearchData("MODEL_ID", cboModel.ValueList);
            SetSearchData("STAT_CD", "3,4");
            SetServiceId("GetProductSimpleList");
            
            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds_return = DTOFactory.GetDataSet();
                dt_Eqp = ClsDataTable.SetCheckDataTable(ds_return.Tables["ds_eqp"], "CHK");
                dt_Eqp_Column = ds_return.Tables["ds_eqp_column"];
                Gd_Eqp.DataSource = dt_Eqp;

                Gd_Eqp.SetCheckGridColumn(dt_Eqp_Column, "CHK");
                BtnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void Gd_Eqp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt_Eqp.Rows[e.RowIndex][0] = !(bool)dt_Eqp.Rows[e.RowIndex][0];

            int count = int.Parse(dt_Eqp.Compute("COUNT(CHK)", "CHK=true").ToString());

            if (tabCarry.TabCount > 0 && count > 0)
            {
                BtnInsert.Enabled = true;
            }
            else
            {
                BtnInsert.Enabled = false;
            }
        }

        private void Gd_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataTable dt = (DataTable)view.DataSource;

            dt.Rows[e.RowIndex][0] = !(bool)dt.Rows[e.RowIndex][0];

            int count = int.Parse(dt.Compute("COUNT(CHK)", "CHK=true").ToString());

            if (count > 0)
            {
                BtnRemove.Enabled = true;
            }
            else
            {
                BtnRemove.Enabled = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool bCheck = true;

            string[] argment = new string[4];
            argment[0] = "strCompType";
            argment[1] = "C";
            argment[2] = "strUserCode";
            argment[3] = cboUser.ValueList;

            Client client = new Client("MYC.Server.Common"
                               , "CommonSearch"
                               , "getUserInfo"
                               , argment);

            DataTable dt_user = (DataTable)client.GetResult();
            DataRow dr = dt_user.Rows[0];
            client.Close();

            string strText = dr["COMP_NM"].ToString() + "(" + dr["LINE_ID"].ToString() + ")";
            string strCode = dr["USER_ID"].ToString();

            if (tabCarry.TabCount > 0)
            {
                foreach (TabPage page in tabCarry.TabPages)
                {
                    if (strCode.Equals(page.Name))
                        bCheck = false;
                }
            }

            if (bCheck)
            {
                TabPage page = new TabPage()
                {
                    Text = strText,
                    Name = strCode
                };

                DataTable dt_tmp = dt_Eqp.Clone();
                DataGridView gd_tmp = new DataGridView()
                {
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                    Location = new System.Drawing.Point(0, 0),
                    MultiSelect = false,
                    Name = "Gd_Eqp",
                    ReadOnly = true,
                    RowHeadersVisible = false,
                    Dock = DockStyle.Fill,
                    DataSource = dt_tmp
                };

                gd_tmp.CellClick += new DataGridViewCellEventHandler(Gd_List_CellClick);
                Label lb = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    Height = 30,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Text = "담당자 : " + dr["USER_NM"].ToString() + " " + dr["GRADE_CD"].ToString() + "(" + dr["EMAIL"].ToString() + ")"
                };

                Panel panel = new Panel()
                {
                    Dock = DockStyle.Fill
                };

                panel.Controls.Add(gd_tmp);
                panel.Controls.Add(lb);
                page.Controls.Add(panel);

                LstEqpTable.Add(dt_tmp);
                LstGrid.Add(gd_tmp);

                tabCarry.TabPages.Add(page);

                //LstGrid[tabCarry.TabPages.Count - 1].SetCheckGridColumn(dt_Eqp_Column, "CHK");
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtHead = new DataTable();
            
            dtHead.Columns.Add("CODE", typeof(string));
            dtHead.Columns.Add("DATA", typeof(string));
            DataColumn[] col = new DataColumn[1];
            col[0] = dtHead.Columns[0];
            dtHead.PrimaryKey = col;

            DataRow row = dtHead.NewRow();  row["CODE"] = "DOC_ID"; row["DATA"] = "202009000002";   dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "USER_NM"; row["DATA"] = "황석환"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "USER_TEL"; row["DATA"] = "010-9409-0715"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "CASH"; row["DATA"] = "□"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "CARD"; row["DATA"] = "■"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "ETC"; row["DATA"] = "□"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "CRT_DT_DOT"; row["DATA"] = "2020.09.07"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "CRT_DT"; row["DATA"] = "2020년 09월 07일"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "COMP_REG_NO"; row["DATA"] = "392-81-01834"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "MASTER_NM"; row["DATA"] = "지문영"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "COMP_NM"; row["DATA"] = "㈜엔조이라이프"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "COMP_USER_NM"; row["DATA"] = "우지현 대표"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "PRJ_NM"; row["DATA"] = "Program Soft 개발"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "ADDR"; row["DATA"] = "청주 서원 충대로1, 농업창업보윤센터 214호"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "TEL"; row["DATA"] = "010-9080-7937"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "FAX"; row["DATA"] = "&nbsp;"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "COST_TOTAL"; row["DATA"] = ClsSpread.GetPriceNum("11900000"); dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "COST_TOTAL_HAN"; row["DATA"] = ClsSpread.GetPriceNumtoHan("11900000"); dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "LOGO"; row["DATA"] = DTOFactory.BaseDir + "/images/logo.jpg"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "STAMP"; row["DATA"] = DTOFactory.BaseDir + "/images/stamp2.png"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "CMT"; row["DATA"] = "1. 대금 지급조건: 협의에 의함<br>2.유지보수 조건: 요청사항 개발 종료<br>3.Project 담당장: ceo @my-c.kr<br>4.부가세 포함"; dtHead.Rows.Add(row);
            row = dtHead.NewRow(); row["CODE"] = "COST_TOTAL_2";
            string cost = "</span>" + ClsSpread.GetPriceNum("11900000");
            for (int cnt = cost.Length; cnt < 23; cnt++)
                cost = "&nbsp;" + cost;
            row["DATA"] = cost;
            dtHead.Rows.Add(row);

            DataTable dtBody = new DataTable();
            dtBody.Columns.Add("CLASS", typeof(string));
            dtBody.Columns.Add("NO", typeof(string));
            dtBody.Columns.Add("PROD_DESC", typeof(string));
            dtBody.Columns.Add("QTY", typeof(string));
            dtBody.Columns.Add("QTY_CD", typeof(string));
            dtBody.Columns.Add("UNIT_COST", typeof(string));
            dtBody.Columns.Add("COST", typeof(string));
            dtBody.Columns.Add("REMARK", typeof(string));

            row = dtBody.NewRow();
            row["CLASS"] = "body_list_bold"; row["NO"] = "1"; row["PROD_DESC"] = "H/W";
            row["QTY"] = "&nbsp;";  row["UNIT_COST"] = "&nbsp;"; row["COST"] = "&nbsp;"; row["REMARK"] = "&nbsp;";
            dtBody.Rows.Add(row);

            row = dtBody.NewRow();
            row["CLASS"] = "body_list"; row["NO"] = "&nbsp;"; row["PROD_DESC"] = "Kit+Board 연동";
            row["QTY"] = "1"; row["QTY_CD"] = "SET"; row["UNIT_COST"] = "3,600,000";
            cost = "</span>3,600,000";
            for (int cnt = cost.Length; cnt < 23; cnt++)
                cost = "&nbsp;" + cost;
            row["COST"] = "<span style='mso-spacerun:yes'>&nbsp;</span>&#8361;<span style='mso-spacerun:yes'>" + cost;
            row["REMARK"] = "미니카와 테스트 보드 결합";
            dtBody.Rows.Add(row);
            
            row = dtBody.NewRow();
            row["CLASS"] = "body_list_bold"; row["NO"] = "2"; row["PROD_DESC"] = "S/W";
            row["QTY"] = "&nbsp;"; row["UNIT_COST"] = "&nbsp;"; row["COST"] = "&nbsp;"; row["REMARK"] = "&nbsp;";
            dtBody.Rows.Add(row);
            
            row = dtBody.NewRow();
            row["CLASS"] = "body_list"; row["NO"] = "&nbsp;"; row["PROD_DESC"] = "PCB제작";
            row["QTY"] = "1"; row["QTY_CD"] = "EA"; row["UNIT_COST"] = "3,300,000";
            cost = "</span>3,300,000";
            for (int cnt = cost.Length; cnt < 23; cnt++)
                cost = "&nbsp;" + cost;
            row["COST"] = "<span style='mso-spacerun:yes'>&nbsp;</span>&#8361;<span style='mso-spacerun:yes'>" + cost;
            row["REMARK"] = "테스트 보드 제작";
            dtBody.Rows.Add(row);
            
            row = dtBody.NewRow();
            row["CLASS"] = "body_list"; row["NO"] = "&nbsp;"; row["PROD_DESC"] = "PCB설계";
            row["QTY"] = "1"; row["QTY_CD"] = "EA"; row["UNIT_COST"] = "5,000,000";
            cost = "</span>5,000,000";
            for (int cnt = cost.Length; cnt < 23; cnt++)
                cost = "&nbsp;" + cost;
            row["COST"] = "<span style='mso-spacerun:yes'>&nbsp;</span>&#8361;<span style='mso-spacerun:yes'>" + cost;
            row["REMARK"] = "프로그램 설계";
            dtBody.Rows.Add(row);

            Doc.DocumentText = ClsDocument.GetDocSkin("projectestimate01.html", dtHead, dtBody);
        }

        private void CboType_TextChanged(object sender, EventArgs e)
        {
            cboModel.Params.Clear();
            cboModel.Params.Add("strModel", cboType.ValueList);
            cboModel.BindDataSet();
        }

        private void CboCompany_TextChanged(object sender, EventArgs e)
        {
            cboUser.Params.Clear();
            cboUser.Params.Add("strCompType", "C");
            cboUser.Params.Add("strCompCode", cboCompany.ValueList);
            cboUser.BindDataSet();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int index = tabCarry.SelectedIndex;

            for (int row = dt_Eqp.Rows.Count - 1; row >= 0; row--)
            {
                if ((bool)dt_Eqp.Rows[row]["CHK"])
                {
                    DataRow dr = LstEqpTable[index].NewRow();

                    foreach (DataColumn col in LstEqpTable[index].Columns)
                    {
                        if ("CHK".Equals(col.ColumnName))
                            dr[col.ColumnName] = false;
                        else
                            dr[col.ColumnName] = dt_Eqp.Rows[row][col.ColumnName];
                    }

                    LstEqpTable[index].Rows.Add(dr);

                    dt_Eqp.Rows[row].Delete();
                }
            }

            BtnInsert.Enabled = false;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int index = tabCarry.SelectedIndex;

            for (int row = LstEqpTable[index].Rows.Count - 1; row >= 0; row--)
            {
                if ((bool)LstEqpTable[index].Rows[row]["CHK"])
                {
                    DataRow dr = dt_Eqp.NewRow();

                    foreach (DataColumn col in dt_Eqp.Columns)
                    {
                        if ("CHK".Equals(col.ColumnName))
                            dr[col.ColumnName] = false;
                        else
                            dr[col.ColumnName] = LstEqpTable[index].Rows[row][col.ColumnName];
                    }

                    dt_Eqp.Rows.Add(dr);

                    LstEqpTable[index].Rows[row].Delete();
                }
            }

            BtnRemove.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DataTable dt_result = new DataTable();

            for (int page=0; page < tabCarry.TabPages.Count; page++)
            {
                if (LstEqpTable[page].Rows.Count > 0)
                {
                    DataRow[] drs = LstEqpTable[page].Select();
                    string strSerList = "";
                    foreach(DataRow sr in drs)
                    {
                        strSerList += "," + sr["SER_ID"].ToString();
                    }
                    
                    SetSearchData("USER_ID", Parent.Parent.Parent.GetType().GetMethod("GetUserId").Invoke(Parent.Parent.Parent, null).ToString());
                    SetSearchData("COMP_USER_ID", tabCarry.TabPages[page].Name);
                    SetSearchData("SERIAL_ID", strSerList.Length > 0 ? strSerList.Substring(1) : "");
                    SetServiceId("SetCarryRequest");

                    DTOFactory.Transaction(new MachineDTO());
                    DataTable dt = DTOFactory.GetDataTable();

                    if (dt_result.Rows.Count == 0)
                    {
                        dt_result = dt.Copy();
                    }
                    else
                    {
                        dt_result.Merge(dt);
                    }
                }
            }

            var frm = new DocumentConfirmPopup()
            {
                dt_list = dt_result
            };

            frm.ShowDialog();
        }

        private void Doc_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser web = (WebBrowser)sender;
            web.ShowPrintPreviewDialog();
        }
    }
}
