using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.Control.Method;
using MYC.UI.DTO;

namespace MYC.UI.Admin
{
    public partial class MenuCondition : MYCControl_noframe
    {
        #region Field
        protected DataTable dtMenu = new DataTable();
        protected DataTable dtMenuProgram = new DataTable();
        protected DataTable dtProgram = new DataTable();
        protected int MaxMenuId = 0;
        #endregion

        public MenuCondition()
        {
            InitializeComponent();            
        }

        private void ProgramCondition_Load(object sender, EventArgs e)
        {
            InitSpread();
            InitControl();
        }

        private void InitSpread()
        {
            gd_Program.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gd_Program.ReadOnly = false;
        }

        private void InitControl()
        {
            SetServiceId("GetItemList");

            try
            {
                DTOFactory.Transaction(new AdminDTO());
                DataSet ds = DTOFactory.GetDataSet();

                menuView.Nodes.Clear();
                
                dtMenu = ds.Tables["ds_menu"];
                if (dtMenu.PrimaryKey.Length == 0)
                {
                    DataColumn[] col = new DataColumn[1];
                    col[0] = dtMenu.Columns["MENU_ID"];
                    dtMenu.PrimaryKey = col;
                }

                GetMenuItem(dtMenu);
                dtProgram = ds.Tables["ds_pgm"];
                gd_ProgramList.DataSource = dtProgram;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void GetMenuItem(DataTable dt)
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "MENU_LEVEL,SEQ_NO";
            dt = dv.ToTable();

            menuView.Nodes.Clear();
            menuView.Nodes.Add("M0000", "Menu List");

            foreach (DataRow row in dt.Rows)
            {
                TreeNode[] node = menuView.Nodes.Find(row["MENU_PARENT"].ToString(), true);

                if (node.Length == 1)
                    node[0].Nodes.Add(row["MENU_ID"].ToString(), row["MENU_NM"].ToString());
            }

            MaxMenuId = int.Parse(dt.Compute("MAX(MENU_ID)", "").ToString().Substring(1));
            menuView.ExpandAll();
        }

        private void NodeMenu(object sender, MouseEventArgs e)
        {
            TreeView view = (TreeView)sender;
            view.SelectedNode = view.GetNodeAt(e.X, e.Y);

            if (view.SelectedNode != null)
            {
                #region 오른쪽 버튼을 통한 Context Menu View
                if (e.Button == MouseButtons.Right)
                {
                    DataRow row = dtMenu.Rows.Find(view.SelectedNode.Name);

                    ContextMenu menu = new ContextMenu();
                    MenuItem item = new MenuItem("Add", AddNode);
                    menu.MenuItems.Add(item);

                    if (row != null)
                    {
                        int seq_no = (int)row["SEQ_NO"];
                        int max_no = int.Parse(dtMenu.Compute("MAX(SEQ_NO)", "MENU_PARENT='" + row["MENU_PARENT"] + "'").ToString());

                        if (seq_no > 0)
                        {
                            item = new MenuItem("Up", MoveNodeUp);
                            menu.MenuItems.Add(item);
                        }

                        if (seq_no < max_no)
                        {
                            item = new MenuItem("Down", MoveNodeDown);
                            menu.MenuItems.Add(item);
                        }
                    }

                    menu.Show(view, e.Location);
                }
                #endregion
                else
                {
                    ClearSearchData();
                    SetSearchData("MENU_PARENT", view.SelectedNode.Name);
                    SetServiceId("GetMenuProgramList");

                    try
                    {
                        DTOFactory.Transaction(new AdminDTO());
                        dtMenuProgram = DTOFactory.GetDataTable();
                        gd_Program.DataSource = dtMenuProgram;
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
            }
        }

        private void AddNode(Object sender, EventArgs e)
        {
            string parent = menuView.SelectedNode.Name;
            DataRow row = dtMenu.Rows.Find(parent);
            int level = 0;

            if (row != null)
                level = int.Parse(row["MENU_LEVEL"].ToString()) + 1;

            string strId = "M" + (++MaxMenuId).ToString("0000");
            DataRow nr = dtMenu.NewRow();
            string strSeq = dtMenu.Compute("MAX(SEQ_NO)", "MENU_PARENT='" + parent + "'").ToString();
            int seq = strSeq.Equals("") ? 0 : int.Parse(strSeq) + 1;

            nr["MENU_ID"] = strId;
            nr["MENU_LEVEL"] = level;
            nr["SEQ_NO"] = seq;
            nr["MENU_PARENT"] = parent;
            nr["MENU_NM"] = "임시메뉴";
            nr["USE_YN"] = "N";

            dtMenu.Rows.Add(nr);
            GetMenuItem(dtMenu);
        }

        private void MoveNodeUp(Object sender, EventArgs e)
        {
            DataRow row = dtMenu.Rows.Find(menuView.SelectedNode.Name);
            int seq_no = (int)row["SEQ_NO"] - 1;

            DataRow[] MRow = dtMenu.Select(string.Format("MENU_PARENT='{0}' AND SEQ_NO={1}", row["MENU_PARENT"], seq_no));

            if (MRow.Length == 1)
            {
                MRow[0]["SEQ_NO"] = seq_no + 1;
                MRow[0]["USE_YN"] = "C";
                row["SEQ_NO"] = seq_no;
            }

            GetMenuItem(dtMenu);
        }

        private void MoveNodeDown(Object sender, EventArgs e)
        {
            DataRow row = dtMenu.Rows.Find(menuView.SelectedNode.Name);
            int seq_no = (int)row["SEQ_NO"] + 1;

            DataRow[] MRow = dtMenu.Select(string.Format("MENU_PARENT='{0}' AND SEQ_NO={1}", row["MENU_PARENT"], seq_no));

            if (MRow.Length == 1)
            {
                MRow[0]["SEQ_NO"] = seq_no - 1;
                MRow[0]["USE_YN"] = "C";
                row["SEQ_NO"] = seq_no;
            }

            GetMenuItem(dtMenu);
        }

        private void MenuTextChanged(object sender, NodeLabelEditEventArgs e)
        {
            if (!e.CancelEdit)
            {
                DataRow row = dtMenu.Rows.Find(e.Node.Name);

                row["MENU_NM"] = e.Label;
                row["USE_YN"] = "N";
            }
        }

        private void AddProgram(object sender, EventArgs e)
        {
            if (gd_ProgramList.SelectedRows.Count > 0 && menuView.SelectedNode != null)
            {
                foreach(DataGridViewRow row in gd_ProgramList.SelectedRows)
                {
                    DataRow dr  = dtProgram.Rows[row.Index];
                    DataRow ndr = dtMenuProgram.NewRow();

                    ndr["MENU_ID"] = dr["PGM_ID"];
                    ndr["MENU_NM"] = dr["PGM_NM"];
                    ndr["SEQ_NO"] = dtMenuProgram.Rows.Count == 0 ? 0 : (int)dtMenuProgram.Compute("MAX(SEQ_NO)","") + 1;
                    ndr["USE_YN"] = "Y";

                    dtMenuProgram.Rows.Add(ndr);
                    dtProgram.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void RemoveProgram(object sender, EventArgs e)
        {
            if (gd_Program.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in gd_Program.SelectedCells)
                {
                    DataRow dr = dtMenuProgram.Rows[cell.RowIndex];
                    DataRow ndr = dtProgram.NewRow();

                    ndr["PGM_ID"] = dr["MENU_ID"];
                    ndr["PGM_NM"] = dr["MENU_NM"];

                    dtProgram.Rows.Add(ndr);
                    dtMenuProgram.Rows.RemoveAt(cell.RowIndex);
                }
            }
        }

        private void MenuSave(object sender, EventArgs e)
        {
            DataRow[] dr = dtMenu.Select("USE_YN <> 'Y'");

            if (dr.Length > 0)
            {
                string MENU_ID = "";
                string MENU_NM = "";
                string MENU_LEVEL = "";
                string SEQ_NO = "";
                string MENU_PARENT = "";

                foreach(DataRow row in dr)
                {
                    MENU_ID += "," + row["MENU_ID"].ToString();
                    MENU_NM += "," + row["MENU_NM"].ToString();
                    MENU_LEVEL += "," + row["MENU_LEVEL"].ToString();
                    SEQ_NO += "," + row["SEQ_NO"].ToString();
                    MENU_PARENT += "," + row["MENU_PARENT"].ToString();
                }

                ClearSearchData();
                SetSearchData("MENU_ID", MENU_ID.Length > 0 ? MENU_ID.Substring(1) : MENU_ID);
                SetSearchData("MENU_NM", MENU_NM.Length > 0 ? MENU_NM.Substring(1) : MENU_NM);
                SetSearchData("MENU_LEVEL", MENU_LEVEL.Length > 0 ? MENU_LEVEL.Substring(1) : MENU_LEVEL);
                SetSearchData("SEQ_NO", SEQ_NO.Length > 0 ? SEQ_NO.Substring(1) : SEQ_NO);
                SetSearchData("MENU_PARENT", MENU_PARENT.Length > 0 ? MENU_PARENT.Substring(1) : MENU_PARENT);
                SetServiceId("SetMenuList");

                try
                {
                    DTOFactory.Transaction(new AdminDTO());
                    DataSet ds = DTOFactory.GetDataSet();
                    ViewMessage.Info("메뉴 저장이 완료 되었습니다.");

                    menuView.Nodes.Clear();

                    dtMenu = ds.Tables["ds_menu"];
                    if (dtMenu.PrimaryKey.Length == 0)
                    {
                        DataColumn[] col = new DataColumn[1];
                        col[0] = dtMenu.Columns["MENU_ID"];
                        dtMenu.PrimaryKey = col;
                    }

                    GetMenuItem(dtMenu);
                    dtProgram = ds.Tables["ds_pgm"];
                    gd_ProgramList.DataSource = dtProgram;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void ProgramSave(object sender, EventArgs e)
        {
            if (dtMenuProgram.Rows.Count > 0)
            {
                string MENU_ID = "";
                string MENU_NM = "";
                string SEQ_NO = "";
                string USE_YN = "";

                foreach (DataRow row in dtMenuProgram.Rows)
                {
                    MENU_ID += "," + row["MENU_ID"].ToString();
                    MENU_NM += "," + row["MENU_NM"].ToString();
                    SEQ_NO += "," + row["SEQ_NO"].ToString();
                    USE_YN += "," + row["USE_YN"].ToString();
                }

                string parent = menuView.SelectedNode.Name;
                DataRow menu = dtMenu.Rows.Find(parent);

                ClearSearchData();
                SetSearchData("MENU_ID", MENU_ID.Length > 0 ? MENU_ID.Substring(1) : MENU_ID);
                SetSearchData("MENU_NM", MENU_NM.Length > 0 ? MENU_NM.Substring(1) : MENU_NM);
                SetSearchData("MENU_LEVEL", int.Parse(menu["MENU_LEVEL"].ToString()) + 1);
                SetSearchData("SEQ_NO", SEQ_NO.Length > 0 ? SEQ_NO.Substring(1) : SEQ_NO);
                SetSearchData("MENU_PARENT", parent);
                SetSearchData("USE_YN", USE_YN.Length > 0 ? USE_YN.Substring(1) : USE_YN);
                SetServiceId("SetPgmList");

                try
                {
                    DTOFactory.Transaction(new AdminDTO());
                    DataSet ds = DTOFactory.GetDataSet();
                    ViewMessage.Info("메뉴 저장이 완료 되었습니다.");

                    menuView.Nodes.Clear();

                    dtMenu = ds.Tables["ds_menu"];
                    if (dtMenu.PrimaryKey.Length == 0)
                    {
                        DataColumn[] col = new DataColumn[1];
                        col[0] = dtMenu.Columns["MENU_ID"];
                        dtMenu.PrimaryKey = col;
                    }

                    GetMenuItem(dtMenu);
                    dtProgram = ds.Tables["ds_pgm"];
                    gd_ProgramList.DataSource = dtProgram;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }
    }
}
