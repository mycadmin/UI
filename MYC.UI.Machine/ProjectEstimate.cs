using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.Control.Method;
using MYC.UI.DTO;

namespace MYC.UI.Machine
{
    public partial class ProjectEstimate : MYCControl
    {
        #region Field
        protected DataTable dt_Eqp = new DataTable();
        protected List<DataTable> LstEqpTable = new List<DataTable>();
        protected List<DataGridView> LstGrid = new List<DataGridView>();
        #endregion

        public ProjectEstimate()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            #region Order List
            cboList.Params.Add("strCompId", "01,02");
            cboList.BindDataSet();
            #endregion Model Type

            #region Project List
            cboProject.Params.Add("strProject", "");
            cboProject.BindDataSet();
            #endregion Project List
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("DOC_ID", cboList.ValueList);
            SetSearchData("STAT_CD", "2, 3");
            SetServiceId("GetProductSimpleList");
            
            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds_return = DTOFactory.GetDataSet();
                dt_Eqp = ds_return.Tables["ds_eqp"];
                Gd_Eqp.DataSource = dt_Eqp;

                Gd_Eqp.SetGridColumn(ds_return.Tables["ds_eqp_column"]);
                Gd_Eqp.MultiSelect = true;

                cboUser.Params.Clear();
                cboUser.Params.Add("strCompType", "V");
                cboUser.Params.Add("strCompCode", dt_Eqp.Rows[0]["COMP_CD"].ToString());
                cboUser.BindDataSet();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void CboProject_TextChanged(object sender, EventArgs e)
        {
            cboWork.Params.Clear();
            cboWork.Params.Add("strProject", cboProject.ValueList);
            cboWork.BindDataSet();
        }

        private void CboList_TextChanged(object sender, EventArgs e)
        {
            if (!"".Equals(cboList.ValueList))
            {
                ClearSearchData();
                SetSearchData("DOC_ID", cboList.ValueList);
                SetServiceId("GetOrder");

                try
                {
                    DTOFactory.Transaction(new MachineDTO());
                    GetInspResult(DTOFactory.GetDataTable());
                }
                catch (Exception e1)
                {
                    ViewMessage.Error(e1.Message);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string strSerId = "";
            for (int i=0;i< Gd_Eqp.SelectedRows.Count;i++)
            {
                if ("".Equals(dt_Eqp.Rows[Gd_Eqp.SelectedRows[i].Index]["IPT_DT"].ToString()))
                    strSerId += "," + dt_Eqp.Rows[Gd_Eqp.SelectedRows[i].Index]["SER_ID"].ToString();
            }

            ClearSearchData();
            SetSearchData("SERIAL_ID", strSerId.Length > 0 ? strSerId.Substring(1) : strSerId);
            SetSearchData("STAT_CD", '3');
            SetSearchData("USER_ID", DTOFactory.UserId);
            SetSearchData("COMP_USER_ID", cboUser.ValueList);
            SetSearchData("COMP_CD", dt_Eqp.Rows[0]["COMP_CD"].ToString());
            SetSearchData("WORK_ID", cboWork.ValueList);
            SetSearchData("LINK_CODE", "");
            SetSearchData("DESC", txtDesc.Text);
            SetSearchData("DOC_ID", cboList.ValueList);
            SetServiceId("SetInputRequest");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                DataSet ds_return = DTOFactory.GetDataSet();
                dt_Eqp = ds_return.Tables["ds_eqp"];
                Gd_Eqp.DataSource = dt_Eqp;

                Gd_Eqp.SetGridColumn(ds_return.Tables["ds_eqp_column"]);
                Gd_Eqp.MultiSelect = true;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void BtnInsp_Click(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("DOC_ID", cboList.ValueList);
            SetSearchData("USER_ID", DTOFactory.UserId);
            SetServiceId("SetInspectionRequest");

            try
            {
                DTOFactory.Transaction(new MachineDTO());
                GetInspResult(DTOFactory.GetDataTable());
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void GetInspResult(DataTable dt_Order)
        {
            string[] Column = new string[17];
            Column[0] = "DOC_ID";
            Column[1] = "USER_NM";
            Column[2] = "USER_TEL";
            Column[3] = "CASH";
            Column[4] = "CARD";
            Column[5] = "ETC";
            Column[6] = "CRT_DT_DOT";
            Column[7] = "CRT_DT";
            Column[8] = "COMP_REG_NO";
            Column[9] = "MASTER_NM";
            Column[10] = "COMP_NM";
            Column[11] = "COMP_USER_NM";
            Column[12] = "PRJ_NM";
            Column[13] = "ADDR";
            Column[14] = "TEL";
            Column[15] = "FAX";
            Column[16] = "CMT";

            DataTable dt = dt_Order.DefaultView.ToTable(true, Column);

            DataTable dtDoc = new DataTable();
            dtDoc.Columns.Add("CODE", typeof(string));
            dtDoc.Columns.Add("DATA", typeof(string));
            DataColumn[] col = new DataColumn[1];
            col[0] = dtDoc.Columns[0];
            dtDoc.PrimaryKey = col;

            foreach (DataColumn column in dt.Columns)
            {
                DataRow row = dtDoc.NewRow();
                row["CODE"] = column;
                row["DATA"] = dt.Rows[0][column].ToString();
                dtDoc.Rows.Add(row);
            }

            DataRow dr = dtDoc.NewRow(); dr["CODE"] = "LOGO"; dr["DATA"] = DTOFactory.BaseDir + "/images/logo.jpg"; dtDoc.Rows.Add(dr);
            dr = dtDoc.NewRow(); dr["CODE"] = "STAMP"; dr["DATA"] = DTOFactory.BaseDir + "/images/stamp2.png"; dtDoc.Rows.Add(dr);
            
            string cost_total = dt_Order.Compute("SUM(COST)", "").ToString();
            dr = dtDoc.NewRow(); dr["CODE"] = "COST_TOTAL"; dr["DATA"] = ClsSpread.GetPriceNum(cost_total); dtDoc.Rows.Add(dr);
            dr = dtDoc.NewRow(); dr["CODE"] = "COST_TOTAL_HAN"; dr["DATA"] = ClsSpread.GetPriceNumtoHan(cost_total); dtDoc.Rows.Add(dr);
            dr = dtDoc.NewRow(); dr["CODE"] = "COST_TOTAL_2";
            string cost = "</span>" + ClsSpread.GetPriceNum(cost_total);
            for (int cnt = cost.Length; cnt < 23; cnt++)
                cost = "&nbsp;" + cost;
            dr["DATA"] = cost;            dtDoc.Rows.Add(dr);


            DataTable dtBody = new DataTable();
            dtBody.Columns.Add("CLASS", typeof(string));
            dtBody.Columns.Add("NO", typeof(string));
            dtBody.Columns.Add("PROD_DESC", typeof(string));
            dtBody.Columns.Add("QTY", typeof(string));
            dtBody.Columns.Add("QTY_CD", typeof(string));
            dtBody.Columns.Add("UNIT_COST", typeof(string));
            dtBody.Columns.Add("COST", typeof(string));
            dtBody.Columns.Add("REMARK", typeof(string));

            int no = 0;
            for (int i = 0; i < dt_Order.Rows.Count; i++)
            {
                DataRow row = dt_Order.Rows[i];
                dr = dtBody.NewRow();
                
                foreach (DataColumn column in dtBody.Columns)
                {
                    switch(column.ColumnName)
                    {
                        case "CLASS":
                            dr[column.ColumnName] = "0".Equals(row["QTY"].ToString()) ? "body_list_bold" : "body_list";
                            break;
                        case "NO":
                            dr[column.ColumnName] = "0".Equals(row["QTY"].ToString()) ? (++no).ToString() : "&nbsp;";
                            break;
                        case "QTY":
                        case "UNIT_COST":
                            dr[column.ColumnName] = "0".Equals(row["QTY"].ToString()) ? "&nbsp;" : row[column.ColumnName].ToString();
                            break;
                        case "COST":
                            if ("0".Equals(row["QTY"].ToString()))
                                dr[column.ColumnName] = "&nbsp;";
                            else
                            {
                                cost = "</span>" + ClsSpread.GetPriceNum(row[column.ColumnName].ToString());
                                for (int cnt = cost.Length; cnt < 23; cnt++)
                                    cost = "&nbsp;" + cost;
                                dr[column.ColumnName] = "<span style='mso-spacerun:yes'>&nbsp;</span>&#8361;<span style='mso-spacerun:yes'>" + cost;
                            }
                            break;
                        default:
                            dr[column.ColumnName] = row[column.ColumnName];
                            break;
                    }
                }

                dtBody.Rows.Add(dr);
            }

            Doc.DocumentText = ClsDocument.GetDocSkin("projectestimate01.html", dtDoc, dtBody);
        }

        private void Doc_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser web = (WebBrowser)sender;
            Clipboard.SetText(web.DocumentText);
            web.ShowPrintPreviewDialog();            
        }
    }
}
