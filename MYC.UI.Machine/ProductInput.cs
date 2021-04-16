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
    public partial class ProductInput : MYCControl
    {
        #region Field
        protected DataTable dt_Eqp = new DataTable();
        protected List<DataTable> LstEqpTable = new List<DataTable>();
        protected List<DataGridView> LstGrid = new List<DataGridView>();
        #endregion

        public ProductInput()
        {
            InitializeComponent();
            InitControls();
        }
        private void InitControls()
        {
            #region Order List
            cboOrder.Params.Add("strOrderId", "");
            cboOrder.BindDataSet();
            #endregion Model Type

            #region Project List
            cboProject.Params.Add("strProject", "");
            cboProject.BindDataSet();
            #endregion Project List
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("DOC_ID", cboOrder.ValueList);
            SetSearchData("STAT_CD", "2,3");
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
            SetSearchData("STAT_CD", "3");
            SetSearchData("USER_ID", DTOFactory.UserId);
            SetSearchData("COMP_USER_ID", cboUser.ValueList);
            SetSearchData("COMP_CD", dt_Eqp.Rows[0]["COMP_CD"].ToString());
            SetSearchData("WORK_ID", cboWork.ValueList);
            SetSearchData("LINK_CD", "");
            SetSearchData("DESC", txtDesc.Text);
            SetSearchData("DOC_ID", cboOrder.ValueList);
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
            SetSearchData("DOC_ID", cboOrder.ValueList);
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
            string[] Column = new string[9];
            Column[0] = "DOC_ID";
            Column[1] = "CRT_DT";
            Column[2] = "ORDER_DT";
            Column[3] = "COMP_NM";
            Column[4] = "ADDR";
            Column[5] = "INSP_DT";
            Column[6] = "INSP_TEAM";
            Column[7] = "INSP_GRADE_NM";
            Column[8] = "INSP_NM";

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

            DataRow dr = dtDoc.NewRow(); dr["CODE"] = "IMG"; dr["DATA"] = DTOFactory.BaseDir + "/images/logo.jpg"; dtDoc.Rows.Add(dr);
            dr = dtDoc.NewRow(); dr["CODE"] = "STAMP"; dr["DATA"] = DTOFactory.BaseDir + "/images/stamp.png"; dtDoc.Rows.Add(dr);
            dr = dtDoc.NewRow(); dr["CODE"] = "QTY_SUM"; dr["DATA"] = ClsSpread.GetPriceNum(dt_Order.Compute("SUM(QTY)","").ToString()); dtDoc.Rows.Add(dr);
            dr = dtDoc.NewRow(); dr["CODE"] = "COST_SUM"; dr["DATA"] = ClsSpread.GetPriceNum(dt_Order.Compute("SUM(COST)", "").ToString()); dtDoc.Rows.Add(dr);

            DataTable dtBody = new DataTable();
            dtBody.Columns.Add("IN_DT", typeof(string));
            dtBody.Columns.Add("MODEL_ID", typeof(string));
            dtBody.Columns.Add("SPEC_VAL", typeof(string));
            dtBody.Columns.Add("UNIT_COST", typeof(string));
            dtBody.Columns.Add("IN_USER_NM", typeof(string));
            dtBody.Columns.Add("IN_GRADE_NM", typeof(string));
            dtBody.Columns.Add("SER_ID", typeof(string));
            dtBody.Columns.Add("MODEL_NM", typeof(string));
            dtBody.Columns.Add("QTY", typeof(string));
            dtBody.Columns.Add("QTY_CD", typeof(string));
            dtBody.Columns.Add("COST", typeof(string));
            dtBody.Columns.Add("IN_DESC", typeof(string));

            for (int i = 0; i < dt_Order.Rows.Count; i++)
            {
                DataRow row = dt_Order.Rows[i];
                dr = dtBody.NewRow();

                foreach (DataColumn column in dtBody.Columns)
                {
                    if (column.ColumnName.IndexOf("COST") > -1)
                    {
                        dr[column.ColumnName] = ClsSpread.GetPriceNum(row[column.ColumnName].ToString());
                    }
                    else if ("SER_ID".Equals(column.ColumnName.ToString()))
                    {
                        if (" ".Equals(row[column.ColumnName].ToString()))
                        {
                            dr[column.ColumnName] = row["GRP_ID"].ToString();
                        }
                        else
                        {
                            dr[column.ColumnName] = row[column.ColumnName].ToString();
                        }
                    }
                    else
                    {
                        dr[column.ColumnName] = row[column.ColumnName];
                    }
                }

                dtBody.Rows.Add(dr);
            }

            Doc.DocumentText = ClsDocument.GetDocSkin("InspectionReport03.html", dtDoc, dtBody);
        }

        private void Doc_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser web = (WebBrowser)sender;
            Clipboard.SetText(web.DocumentText);
            web.ShowPrintPreviewDialog();            
        }
    }
}
