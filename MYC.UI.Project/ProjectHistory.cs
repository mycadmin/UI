using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Project
{
    public partial class ProjectHistory : MYCControl
    {
        #region Field        
        protected DataTable _dtModel = new DataTable();
        protected DataTable _dtLink = new DataTable();
        protected DataTable _dtProject = new DataTable();
        protected DataTable _dtActionItem = new DataTable();
        protected DataTable _dtActionDetail = new DataTable();
        #endregion

        #region Init
        public ProjectHistory()
        {
            InitializeComponent();
        }

        private void ProjectHistory_Load(object sender, EventArgs e)
        {
            InitSpread();
            InitDataTable();
            InitControls();
        }

        private void InitDataTable()
        {
        }

        private void InitSpread()
        {
            gd_Project.MultiSelect = false;
        }

        private void InitControls()
        {
            DTOFactory.Action();

            #region CheckComboBox
            cboProjectId.Params.Clear();
            cboProjectId.Params.Add("strUserId", DTOFactory.UserId);
            cboProjectId.Params.Add("strStatus", "O");
            cboProjectId.BindDataSet();

            cboMember.Params.Clear();
            cboMember.Params.Add("strCompType", "M");
            cboMember.BindDataSet();

            cboUser.Params.Clear();
            cboUser.Params.Add("strCompType", "M");
            cboUser.BindDataSet();

            cbockMember.Params.Clear();
            cbockMember.Params.Add("strCompType", "");
            cbockMember.BindDataSet();

            cboActRank.Params.Clear();
            cboActRank.Params.Add("strItem", "RANK_CODE");
            cboActRank.BindDataSet();

            cboActType.Params.Clear();
            cboActType.Params.Add("strItem", "ACTION_TYPE");
            cboActType.BindDataSet();

            cboActMgrComp.Params.Clear();
            cboActMgrComp.Params.Add("strCompType", "");
            cboActMgrComp.BindDataSet();

            cboActComp.Params.Clear();
            cboActComp.Params.Add("strCompType", "");
            cboActComp.BindDataSet();

            cboActCompUser.Params.Clear();
            cboActCompUser.Params.Add("strCompType", "");
            cboActCompUser.BindDataSet();

            cboActClose.Params.Clear();
            cboActClose.Params.Add("strItem", "PROJECT_CODE");
            cboActClose.BindDataSet();
            #endregion

            dtFrom.Value = DateTime.Now.AddMonths(-3);
            dtTo.Value = DateTime.Now;

            DTOFactory.Complete();
        }
        #endregion

        #region Event
        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("PROJECT_ID", cboProjectId);

            SetServiceId("GetProjectList");

            try
            {
                DTOFactory.Transaction(new ProjectDTO());
                DataSet ds = DTOFactory.GetDataSet();

                //2021-01-22 hsh - 재조회 시 Index 오류 발생으로
                gd_Project.ClearSelection();
                gd_ActionList.ClearSelection();

                _dtProject = ds.Tables["ds_project"];
                _dtActionItem = ds.Tables["ds_action"];
                _dtModel = ds.Tables["ds_model"];

                gd_Project.DataSource = _dtProject;
                gd_ActionList.DataSource = _dtActionItem;

                if (!gd_Project.LabelDisplayed)
                {
                    gd_Project.SetGridColumn(ds.Tables["ds_project_column"]);
                    gd_ActionList.SetGridColumn(ds.Tables["ds_action_column"]);

                    //2021-01-22 hsh - 재조회 시 Item 초기화 오류로 위치 변경                    
                    #region ContextMenu
                    ContextMenu menu = new ContextMenu();

                    menu.MenuItems.Add(new MenuItem("문서보기", Menu_Click));
                    menu.MenuItems.Add("-");
                    menu.MenuItems.Add(new MenuItem("추가", Menu_Click));
                    menu.MenuItems.Add(new MenuItem("삭제", Menu_Click));

                    if (_dtModel.Rows.Count > 0)
                    {
                        MenuItem Estimate = new MenuItem("견적서 등록");
                        MenuItem Plan = new MenuItem("도면 등록");
                        MenuItem Document = new MenuItem("문서 등록");

                        Estimate.Name = "견적서 등록";
                        Plan.Name = "도면 등록";
                        Document.Name = "문서 등록";

                        foreach (DataRow row in _dtModel.Rows)
                        {
                            string strmenu = "[" + row["MODEL_ID"] + "] " + row["MODEL_NM"];

                            Estimate.MenuItems.Add(strmenu, Menu_Click);
                            Plan.MenuItems.Add(strmenu, Menu_Click);
                            Document.MenuItems.Add(strmenu, Menu_Click);
                        }

                        menu.MenuItems.Add("-");
                        menu.MenuItems.Add(Estimate);
                        menu.MenuItems.Add(Plan);
                        menu.MenuItems.Add(Document);
                    }

                    LstLink.ContextMenu = menu;
                    #endregion
                }
                SetBackColor();

                btnAdd.Enabled = true;
                btnActionAdd.Enabled = true;
                panel7.Enabled = true;

                cboMember.SetItemChecked("");
                cbockMember.SetItemChecked("");
                txtDesc.Text = "";
                
                cboActRank.SetItemChecked("");
                cboActType.SetItemChecked("");
                cboActMgrComp.SetItemChecked("");
                cboActComp.SetItemChecked("");
                cboActCompUser.SetItemChecked("");
                cboActClose.SetItemChecked("");
                txtActDetail.Text = "";

                //2021-01-22 hsh - 재조회 시 File Link 오류 수정
                LstLink.DataSource = null;
                LstLink.Items.Clear();

                if (_dtProject.Rows.Count > 0)
                    ShowHistory(0);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void Menu_Click(Object sender, EventArgs e)
        {
            MenuItem menu = (MenuItem)sender;

            if ("추가".Equals(menu.Text))
            {
                AddLink(null, null);
            }
            else if ("삭제".Equals(menu.Text))
            {
                RemoveLink(null, null);
            }
            else if ("문서보기".Equals(menu.Text))
            {
                ViewLink(null, null);
            }
            else
            {
                DataRow dr = _dtModel.Rows[menu.Index];
                string LINk_CD;

                switch (menu.Parent.Name)
                {
                    case "도면 등록":
                        LINk_CD = dr["PLAN_CD"].ToString();
                        break;
                    case "견적서 등록":
                        LINk_CD = dr["ESTIMATE_CD"].ToString();
                        break;
                    case "문서 등록":
                        LINk_CD = dr["LINK_CD"].ToString();
                        break;
                    default:
                        LINk_CD = "";
                        break;
                }

                DTOFactory.FileLink(LINk_CD, _dtLink.Rows[LstLink.SelectedIndex]["LINK"].ToString(), _dtLink.Rows[LstLink.SelectedIndex]["FILE_DESC"].ToString());
            }
        }

        private void View(object sender, EventArgs e)
        {
            ViewLink(null, null);
        }

        private void Gd_Project_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ShowHistory(e.RowIndex);
        }

        private void GetActionItem(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ShowAction(e.RowIndex);
        }

        private void HistorySave(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("PROJECT_ID", cboProjectId);
            SetSearchData("WORK_ID", txtWorkId);
            SetSearchData("WORK_DT", calWorkDt, "yyyy-MM-dd");
            SetSearchData("USER_ID", cboMember);
            SetSearchData("USER_LIST", cbockMember);
            SetSearchData("WORK_DESC", txtDesc);
            SetSearchData("LINK_CODE", LstLink.Tag);
            SetSearchData("UPT_USER_ID", DTOFactory.UserId);

            SetServiceId("SetProjectHistory");

            try
            {
                int index = gd_Project.SelectedRows[0].Index;

                DTOFactory.Transaction(new ProjectDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtProject = ds.Tables["ds_project"];
                _dtActionItem = ds.Tables["ds_action"];

                gd_Project.DataSource = _dtProject;
                gd_ActionList.DataSource = _dtActionItem;

                SetBackColor();
                ViewMessage.Info("저장이 완료되었습니다.");

                Gd_Project_CellClick(gd_Project, new DataGridViewCellEventArgs(0, index));
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ActionItemSave(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("PROJECT_ID", cboProjectId);
            SetSearchData("ACTION_NO", gd_ActionList.SelectedRows[0].Cells["ACT_NO"].Value);
            SetSearchData("ACTION_TYPE", cboActType);
            SetSearchData("RANK", cboActRank);
            SetSearchData("MANAGER_COMP_CODE", cboActMgrComp);
            SetSearchData("COMP_CD", cboActComp);
            SetSearchData("USER_ID", cboActCompUser);
            SetSearchData("START_DT", calStartDt, "yyyy-MM-dd");
            SetSearchData("END_DT", calEndDt, "yyyy-MM-dd hh:mm:ss");
            SetSearchData("CLOSE", cboActClose);
            SetSearchData("SUBJECT", txtActDetail);
            SetSearchData("UPT_USER_ID", DTOFactory.UserId);

            SetServiceId("SetActionItem");

            try
            {
                DTOFactory.Transaction(new ProjectDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtProject = ds.Tables["ds_project"];
                _dtActionItem = ds.Tables["ds_action"];

                gd_Project.DataSource = _dtProject;
                gd_ActionList.DataSource = _dtActionItem;

                SetBackColor();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewLink(object sender, EventArgs e)
        {
            if (LstLink.SelectedItems.Count == 1)
            {
                int row = LstLink.SelectedIndex;

                FileGet get = new FileGet(_dtLink.Rows[row]["LINK"].ToString());
                get.Close();
            }
        }

        private void AddLink(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                FileSender snd = new FileSender(LstLink.Tag.ToString(), frm.FileName);

                if ("".Equals(LstLink.Tag.ToString()))
                {
                    LstLink.Tag = snd.GetLinkCode();

                    HistorySave(null, e);
                }

                GetLink(LstLink.Tag.ToString());
            }
        }

        private void RemoveLink(object sender, EventArgs e)
        {
            if (LstLink.SelectedItems.Count == 1)
            {
                if (System.Windows.Forms.MessageBox.Show(
                    _dtLink.Rows[LstLink.SelectedIndex]["FILE_DESC"] + " File을 삭제 하시겠습니까?", "File 제거"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FileSender snd = new FileSender(LstLink.Tag.ToString(), _dtLink.Rows[LstLink.SelectedIndex]["LINK"].ToString(), false);
                    snd.Close();

                    _dtLink.Rows.RemoveAt(LstLink.SelectedIndex);
                }
            }
        }

        private void AddRow(object sender, EventArgs e)
        {
            DataRow dr = _dtProject.NewRow();
            _dtProject.Rows.Add(dr);
        }

        private void AddActionRow(object sender, EventArgs e)
        {
            DataRow dr = _dtActionItem.NewRow();
            dr["ACT_NO"] = _dtActionItem.Rows.Count == 0 ? 1 : (int)_dtActionItem.Compute("MAX(ACT_NO)", "") + 1;
            _dtActionItem.Rows.Add(dr);
        }

        #endregion

        #region Method
        private void ShowHistory(int row)
        {
            if (row > -1)
            {
                DataRow dr = _dtProject.Rows[row];

                txtWorkId.Text = dr["WORK_ID"].ToString();
                string strDate = dr["WORK_DT"].ToString();
                calWorkDt.Value = "".Equals(strDate) ? DateTime.Now : DateTime.Parse(strDate);
                cboMember.SetItemChecked(dr["USER_ID"].ToString());
                cbockMember.SetItemChecked(dr["USER_ID_LVAL"].ToString());
                txtDesc.Text = dr["WORK_DESC"].ToString();
                
                LstLink.Tag = dr["LINK_CD"].ToString();
                GetLink(LstLink.Tag.ToString());
            }
        }

        private void ShowAction(int row)
        {
            if (row > -1)
            {
                DataRow dr = _dtActionItem.Rows[row];

                cboActRank.SetItemChecked(dr["RANK_NO"].ToString());
                cboActType.SetItemChecked(dr["ACT_TYPE_CD"].ToString());
                cboActMgrComp.SetItemChecked(dr["MGR_COMP_CD"].ToString());
                cboActComp.SetItemChecked(dr["PRD_COMP_CD"].ToString());
                cboActCompUser.SetItemChecked(dr["CHK_USER_ID"].ToString());
                string strDate = dr["CRT_DT"].ToString();
                calStartDt.Value = "".Equals(strDate) ? DateTime.Now : DateTime.Parse(strDate);
                strDate = dr["TGT_DT"].ToString();
                calEndDt.Value = "".Equals(strDate) ? DateTime.Now : DateTime.Parse(strDate);
                cboActClose.SetItemChecked(dr["CLOSE_YN"].ToString());
                txtActDetail.Text = dr["SUBJECT"].ToString();
                panel6.Enabled = true;
            }
        }

        private void GetLink(string link)
        {
            ClearSearchData();
            SetSearchData("LINK_CODE", link);
            
            SetServiceId("GetLinkList");

            try
            {
                DTOFactory.Transaction(new ProjectDTO());
                _dtLink = DTOFactory.GetDataTable();

                LstLink.DisplayMember = "FILE_DESC";
                LstLink.DataSource = _dtLink;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void SetBackColor(int row = -1)
        {
            for (int RowIndex = row == -1 ? 0 : row; row > -1 || RowIndex < gd_ActionList.Rows.Count; RowIndex++)
            { 
                if ("C".Equals(gd_ActionList.Rows[RowIndex].Cells["CLOSE_YN"].Value))
                    gd_ActionList.Rows[RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                else if ("H".Equals(gd_ActionList.Rows[RowIndex].Cells["CLOSE_YN"].Value))
                    gd_ActionList.Rows[RowIndex].DefaultCellStyle.BackColor = Color.DarkGray;
                else if ((int)gd_ActionList.Rows[RowIndex].Cells["RANK_NO"].Value == 1)
                    gd_ActionList.Rows[RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        #endregion
    }
}
