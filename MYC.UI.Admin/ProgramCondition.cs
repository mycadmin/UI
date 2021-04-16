using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Admin
{
    public partial class ProgramCondition: MYCControl_noframe
    {
        #region Field
        protected DataTable dtProgram = new DataTable();

        int LinkRow = -1;
        #endregion

        public ProgramCondition()
        {
            InitializeComponent();            
        }

        private void ProgramCondition_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void InitControl()
        {
            SetServiceId("GetProgramList");
            
            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet();
                dtProgram = ds.Tables["ds_program"];
                gd_Program.DataSource = dtProgram;
                gd_Program.SetGridColumn(ds.Tables["ds_program_column"]);
                
                foreach(DataGridViewColumn col in gd_Program.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void RowAdd(object sender, EventArgs e)
        {
            string PGMID = "P" + (int.Parse(dtProgram.Compute("MAX(PGM_ID)", "").ToString().Substring(1)) + 1).ToString("0000");

            DataRow dr = dtProgram.NewRow();
            dr["PGM_ID"] = PGMID;
            dtProgram.Rows.Add(dr);

            gd_Program.Rows[dtProgram.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightPink;
        }

        private void GetPgmInfo(object sender, DataGridViewCellEventArgs e)
        {
                int index = e.RowIndex;
            if (index > -1)
            {
                DataRow row = dtProgram.Rows[index];
                LinkRow = -1;

                txtPGMID.Text = row["PGM_ID"].ToString();
                txtPgmName.Text = row["PGM_NM"].ToString();
                txtClDll.Text = row["PGM_DLL"].ToString();
                txtClCls.Text = row["PGM_CLASS"].ToString();
                txtSvDll.Text = row["PGM_SVR_DLL"].ToString();
                txtSvCls.Text = row["PGM_SVR_CLASS"].ToString();

                LinkRow = index;
            }
        }

        private void DataBind(object sender, EventArgs e)
        {
            if (LinkRow > -1)
            {
                gd_Program.Rows[LinkRow].Cells["PGM_ID"].Value = txtPGMID.Text;
                gd_Program.Rows[LinkRow].Cells["PGM_NM"].Value = txtPgmName.Text;
                gd_Program.Rows[LinkRow].Cells["PGM_DLL"].Value = txtClDll.Text;
                gd_Program.Rows[LinkRow].Cells["PGM_CLASS"].Value = txtClCls.Text;
                gd_Program.Rows[LinkRow].Cells["PGM_SVR_DLL"].Value = txtSvDll.Text;
                gd_Program.Rows[LinkRow].Cells["PGM_SVR_CLASS"].Value = txtSvCls.Text;

                if (gd_Program.Rows[LinkRow].DefaultCellStyle.BackColor == Color.Empty)
                    gd_Program.Rows[LinkRow].DefaultCellStyle.BackColor = Color.Yellow;
                else if (gd_Program.Rows[LinkRow].DefaultCellStyle.BackColor == Color.LightPink)
                    gd_Program.Rows[LinkRow].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void Save(object sender, EventArgs e)
        {
            DataTable dt_input = new DataTable();

            dt_input.Columns.Add("PGM_ID");
            dt_input.Columns.Add("PGM_NM");
            dt_input.Columns.Add("PGM_DLL");
            dt_input.Columns.Add("PGM_CLASS");
            dt_input.Columns.Add("PGM_SVR_DLL");
            dt_input.Columns.Add("PGM_SVR_CLASS");

            foreach (DataGridViewRow row in gd_Program.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Yellow)
                {
                    DataRow dr = dt_input.NewRow();

                    dr["PGM_ID"] = row.Cells["PGM_ID"].Value;
                    dr["PGM_NM"] = row.Cells["PGM_NM"].Value;
                    dr["PGM_DLL"] = row.Cells["PGM_DLL"].Value;
                    dr["PGM_CLASS"] = row.Cells["PGM_CLASS"].Value;
                    dr["PGM_SVR_DLL"] = row.Cells["PGM_SVR_DLL"].Value;
                    dr["PGM_SVR_CLASS"] = row.Cells["PGM_SVR_CLASS"].Value;

                    dt_input.Rows.Add(dr);
                }
            }

            ClearSearchData();
            SetServiceId("SetProgramList");
            DTOFactory.SetDTOTable("ds_list", dt_input);

            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet();
                dtProgram = ds.Tables["ds_program"];
                gd_Program.DataSource = dtProgram;
                gd_Program.SetGridColumn(ds.Tables["ds_program_column"]);

                foreach (DataGridViewColumn col in gd_Program.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                ViewMessage.Info("저장이 완료 되었습니다.");
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
    }
}
