using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Admin
{
    public partial class UserLevelCondition : MYCControl_noframe
    {
        #region Field
        protected DataTable dtUser = new DataTable();
        protected DataTable dtUserProgram = new DataTable();
        protected DataTable dtProgram = new DataTable();
        #endregion

        public UserLevelCondition()
        {
            InitializeComponent();
        }

        private void UserLevelCondition_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void InitControl()
        {
            SetServiceId("GetUserList");

            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet(); ;

                dtUser = ds.Tables["ds_user"];
                gd_User.DataSource = dtUser;
                gd_User.SetGridColumn(ds.Tables["ds_user_column"]);

                if (dtUser.Rows.Count > 0)
                    GetUserProgram(0);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void GetUserProgram(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                GetUserProgram(e.RowIndex);
        }

        private void GetUserProgram(int row)
        {
            ClearSearchData();
            SetSearchData("USER_ID", dtUser.Rows[row]["USER_ID"]);
            SetServiceId("GetProgramList");

            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet(); ;

                dtUserProgram = ds.Tables["ds_userprogram"];
                dtProgram = ds.Tables["ds_program"];

                gd_UserProgram.DataSource = dtUserProgram;
                gd_Program.DataSource = dtProgram;

                gd_UserProgram.SetGridColumn(ds.Tables["ds_column"]);
                gd_Program.SetGridColumn(ds.Tables["ds_column"]);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void AddProgram(object sender, EventArgs e)
        {
            if (gd_Program.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in gd_Program.SelectedRows)
                {
                    DataRow dr = dtProgram.Rows[row.Index];
                    DataRow ndr = dtUserProgram.NewRow();

                    ndr["MENU_ID"] = dr["MENU_ID"];
                    ndr["MENU_NM"] = dr["MENU_NM"];
                    ndr["MENU_PARENT"] = dr["MENU_PARENT"];

                    dtUserProgram.Rows.Add(ndr);
                    dtProgram.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void RemoveProgram(object sender, EventArgs e)
        {
            if (gd_UserProgram.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in gd_UserProgram.SelectedRows)
                {
                    DataRow dr = dtUserProgram.Rows[row.Index];
                    DataRow ndr = dtProgram.NewRow();

                    ndr["MENU_ID"] = dr["MENU_ID"];
                    ndr["MENU_NM"] = dr["MENU_NM"];
                    ndr["MENU_PARENT"] = dr["MENU_PARENT"];

                    dtProgram.Rows.Add(ndr);
                    dtUserProgram.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void Save(object sender, EventArgs e)
        {
            string MENU_ID = "";
            
            foreach (DataRow row in dtUserProgram.Rows)
            {
                MENU_ID += "," + row["MENU_ID"].ToString();
            }

            int Row = gd_User.SelectedCells[0].RowIndex;

            ClearSearchData();
            SetSearchData("MENU_ID", MENU_ID.Length > 0 ? MENU_ID.Substring(1) : MENU_ID);
            SetSearchData("USER_ID", gd_User.SelectedRows[0].Cells["USER_ID"].Value.ToString());
            SetServiceId("SetPgmList");

            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet(); ;

                ViewMessage.Info("메뉴 저장이 완료 되었습니다.");

                GetUserProgram(gd_User.SelectedRows[0].Index);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
    }
}
