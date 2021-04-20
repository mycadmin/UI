using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYC.Control;
using MYC.Sender;
using MYC.Control.Common;
using MYC.UI.DTO;


namespace MYC.UI.Report
{
    public partial class BusinessManager : MYCControl
    {
        #region Field        
        protected DataTable _dtList = new DataTable();

        protected DataTable _dtUser = new DataTable();

        protected DataTable _dtMemo = new DataTable();

        protected bool BF = false;
        protected bool SF= false;
        protected bool btnBool = false;
        #endregion

        #region Init
        public BusinessManager()
        {
            InitializeComponent();
        }

        private void BusinessManager_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitSpread();
            InitControls();
            MemoLoad();

            DTOFactory.Complete();
        }

        private void MemoLoad()
        {
            ClearSearchData();
            SetSearchData("USER_ID_LST", DTOFactory.UserId);
            SetServiceId("GetPgmMemo");

            try
            {
                DTOFactory.Transaction(new ReportDTO());
                DataTable dt = DTOFactory.GetDataTable();

                _dtMemo = dt;

                if (dt.Rows.Count > 0)
                    txtMyMemo.Text = dt.Rows[0]["PGM_DESC"].ToString();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void InitSpread()
        {
            gd_List.Columns.Clear();
            gd_List.Columns.Add("CREATE_DT","공고일");
            gd_List.Columns.Add("SUBJECT", "지원사업명");
            gd_List.Columns.Add("COMP_CD", "기관");
            gd_List.Columns.Add("COMP_USER_NM", "담당자");
            gd_List.Columns.Add("COMP_TEL", "연락처");
            gd_List.Columns.Add("PERIOD", "사업기간");
            gd_List.Columns.Add("COST", "지원금액\r\n(천원)");
            gd_List.Columns.Add("PRO_ID", "연계 프로젝트");
            gd_List.Columns.Add("USER_NM", "진행자");

            gd_List.Columns[0].Width = 120;
            gd_List.Columns[1].Width = 260;
            gd_List.Columns[2].Width = 160;
            gd_List.Columns[3].Width = 120;
            gd_List.Columns[4].Width = 140;
            gd_List.Columns[5].Width = 160;
            gd_List.Columns[6].Width = 120;
            gd_List.Columns[7].Width = 260;
            gd_List.Columns[8].Width = 120;

            gd_schedule.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gd_schedule.Columns.Clear();
            gd_schedule.Columns.Add("SCH_TM", "일 시");
            gd_schedule.Columns.Add("USER_NM", "담당자");
            gd_schedule.Columns.Add("SUBJECT", "내 용");

            gd_schedule.Columns[0].Width = 180;
            gd_schedule.Columns[1].Width = 160;
            gd_schedule.Columns[2].Width = 260;

            gd_Document.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gd_Document.Columns.Clear();
            gd_Document.Columns.Add("FILE_DESC", "문서명");
            gd_Document.Columns.Add("REV_NO", "REV");
            gd_Document.Columns.Add("USER_NM", "작성자");
            gd_Document.Columns.Add("CRT_TM", "작성일시");

            gd_Document.Columns[0].Width = 220;
            gd_Document.Columns[1].Width = 100;
            gd_Document.Columns[2].Width = 120;
            gd_Document.Columns[3].Width = 160;

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn()
            {
                HeaderText = "관리",
                Name = "CREATE",
                Text = "문서등록",
                UseColumnTextForButtonValue = true
            };

            gd_Document.Columns.Add(btn1);
        }

        private void InitControls()
        {
            DTOFactory.Action();

            dtFrom.Value = DateTime.Now.AddMonths(-3);
            dtTo.Value = DateTime.Now;

            cboComp.Params.Clear();
            cboComp.Params.Add("strCompType", "G");
            cboComp.BindDataSet();

            cboCompUser.Params.Clear();
            cboCompUser.Params.Add("strCompType", "G");
            cboCompUser.BindDataSet();

            cboUser.Params.Clear();
            cboUser.Params.Add("strCompType", "M");
            cboUser.BindDataSet();
            _dtUser = cboUser.DataSource;

            cboBusiness.Params.Clear();
            cboBusiness.Params.Add("strFrom", "");
            cboBusiness.Params.Add("strTo", "");
            cboBusiness.Params.Add("strUserId", "");
            cboBusiness.BindDataSet();

            gd_schedule.Rows.Clear();
            gd_Document.Rows.Clear();
            txtMemo.Text = "";
            btnScheduleAdd.Enabled = false;
            btnDocumentNew.Enabled = false;
            btnSave.Enabled = true;

            DTOFactory.Complete();
        }
        #endregion

        private void GetBusinessHistory(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("FROM_DT", dtFrom.Value.ToString("yyyy-MM-dd"));
            SetSearchData("TO_DT", dtTo.Value.ToString("yyyy-MM-dd"));
            SetSearchData("CST_COMP_CD", cboComp.ValueList);
            SetSearchData("CST_USER_ID", cboCompUser.ValueList);
            SetSearchData("USER_ID_LST", cboUser.ValueList);
            SetSearchData("DOC_ID", cboBusiness.ValueList);
            SetServiceId("GetBusinessList");

            try
            {
                DTOFactory.Transaction(new ReportDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtList = ds.Tables["ds_list"];
                gd_List.DataSource = null;
                gd_List.Columns.Clear();
                gd_List.DataSource = _dtList;
                gd_List.SetGridColumn(ds.Tables["ds_column"]);

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn()
                {
                    HeaderText = "관리",
                    Name = "Fix",
                    Text = "사업 수정",
                    UseColumnTextForButtonValue = true
                };
                gd_List.Columns.AddRange(btn);

                gd_schedule.DataSource = null;
                gd_Document.DataSource = null;
                gd_schedule.Rows.Clear();
                gd_Document.Rows.Clear();
                txtMemo.Text = "";
                btnScheduleAdd.Enabled = false;
                btnDocumentNew.Enabled = false;
                btnBool = false;
                BtnEnableControl(null, null);

            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void InsertBusiness(object sender, EventArgs e)
        {
            var frm = new BusinessSheetPopup();

            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BusinessFix(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if ("Fix".Equals(view.Columns[e.ColumnIndex].Name))
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = view.Rows[e.RowIndex];

                    BF = true;
                    DateTime AcceptTime = "".Equals(row.Cells["ACCEPT_DT"].Value.ToString()) 
                        ? DateTime.Now : DateTime.Parse(row.Cells["ACCEPT_DT"].Value.ToString());

                    var frm = new BusinessSheetPopup()
                    {
                        DOC_ID = row.Cells["DOC_ID"].Value.ToString(),
                        SUBJECT = row.Cells["SUBJECT"].Value.ToString(),
                        COMP_CD = row.Cells["COMP_CD"].Value.ToString(),
                        COMP_USER_ID = row.Cells["COMP_USER_ID"].Value.ToString(),
                        ACCEPT_DT = AcceptTime,
                        USER_ID = row.Cells["USER_ID"].Value.ToString(),
                        COST = row.Cells["COST"].Value.ToString(),
                        PROJECT_ID = row.Cells["PRO_ID"].Value.ToString(),

                        BF = BF
                    };

                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        GetBusinessHistory(gd_List, null);
                        BF = false;
                    }
                }
            }
        }

        private void SearchBusiness(object sender, EventArgs e)
        {
            cboBusiness.Params.Clear();
            cboBusiness.Params.Add("strFrom", dtFrom.Value.ToString("yyyy-MM-dd"));
            cboBusiness.Params.Add("strTo", dtTo.Value.ToString("yyyy-MM-dd"));
            cboBusiness.Params.Add("strUserId", cboUser.ValueList);
        }

        private void CompUserUpdate(object sender, EventArgs e)
        {
            cboCompUser.Params.Clear();
            cboCompUser.Params.Add("strCompType", "G");
            cboCompUser.Params.Add("strCompCode", cboComp.ValueList);
            cboCompUser.BindDataSet();
        }

        private void GetItemInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (_dtList != null && _dtList.Rows.Count > 0)
            {
                ClearSearchData();
                SetSearchData("DOC_ID", gd_List.GetSelectString("DOC_ID"));
                SetServiceId("GetBusinessItem");

                try
                {
                    DTOFactory.Transaction(new ReportDTO());
                    DataSet ds_return = DTOFactory.GetDataSet();

                    #region 일정 관리
                    gd_schedule.DataSource = null;
                    gd_schedule.Columns.Clear();
                    gd_schedule.DataSource = ds_return.Tables["ds_list"];

                    gd_schedule.SetGridColumn(ds_return.Tables["ds_column"]);
                    gd_schedule.ReadOnly = false;
                    gd_schedule.Columns["SCH_TM"].ReadOnly = true;
                    gd_schedule.Columns["SCH_DESC"].ReadOnly = true;
                    gd_schedule.Columns["SCH_DESC"].Width = 100;

                    //DataGridViewComboBoxColumn cbo = new DataGridViewComboBoxColumn()
                    //{
                    //    ValueType = typeof(DataTable),
                    //    DataSource = _dtUser,
                    //    DisplayMember = "ITEM_NM",
                    //    ValueMember = "ITEM_CD",
                    //    HeaderText = "담당자",
                    //    DataPropertyName = "USER_ID",
                    //    Name = "USER_ID",
                    //    Width = 160
                    //};
                    //int index = gd_schedule.Columns["USER_ID"].DisplayIndex;
                    //gd_schedule.Columns.Remove(gd_schedule.Columns["USER_ID"]);
                    //gd_schedule.Columns.AddRange(cbo);
                    //cbo.DisplayIndex = index;

                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn()
                    {
                        HeaderText = "",
                        Name = "VIEW",
                        Text = "문서보기",
                        UseColumnTextForButtonValue = true
                    };
                    gd_schedule.Columns.AddRange(btn1);

                    DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn()
                    {
                        HeaderText = "",
                        Name = "SAVE",
                        Text = "일정수정",
                        UseColumnTextForButtonValue = true
                    };
                    gd_schedule.Columns.AddRange(btn2);

                    btnScheduleAdd.Enabled = true;
                    #endregion

                    #region 문서 관리
                    gd_Document.DataSource = null;
                    gd_Document.Columns.Clear();
                    gd_Document.DataSource = ds_return.Tables["ds_doc"];

                    gd_Document.SetGridColumn(ds_return.Tables["ds_column2"]);
                    gd_Document.ReadOnly = false;
                    gd_Document.Columns["FILE_DESC"].ReadOnly = true;
                    gd_Document.Columns["REV_NO"].ReadOnly = true;
                    gd_Document.Columns["USER_NM"].ReadOnly = true;
                    gd_Document.Columns["CRT_TM"].ReadOnly = true;

                    DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn()
                    {
                        HeaderText = "관리",
                        Name = "CREATE",
                        Text = "문서등록",
                        UseColumnTextForButtonValue = true
                    };
                    gd_Document.Columns.AddRange(btn3);

                    btnDocumentNew.Enabled = true;
                    #endregion

                    #region 메모
                    txtMemo.Text = gd_List.GetSelectString("BSN_DESC");
                    btnBool = true;
                    BtnEnableControl(null, null);
                    #endregion
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }
        //담당자 변경
        private void SetSchedule(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (e.RowIndex > -1)
            {
                if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    DateTime date = DateTime.Parse(gd_schedule.GetSelectString("SCH_TM").ToString());
                    SF = true;

                    var frm = new BusinessSchedulePopup()
                    {
                        DOC_NM = gd_List.GetSelectString("SUBJECT"),
                        DOC_ID = gd_List.GetSelectString("DOC_ID"),
                        USER_ID = gd_schedule.GetSelectString("USER_ID"),
                        SCH_ID = gd_schedule.GetSelectString("SCH_ID"),
                        SCH_DESC = gd_schedule.GetSelectString("SCH_DESC"),
                        DATE = date,
                        ScheduleFix = SF
                    };
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        GetItemInfo(gd_List, null);
                        SF = false;
                    }
                    //ClearSearchData();
                    //SetSearchData("DOC_ID", gd_schedule.Rows[e.RowIndex].Cells["SCH_ID"].Value);
                    //SetSearchData("ACCEPT_TM", gd_schedule.Rows[e.RowIndex].Cells["SCH_TM"].Value);
                    //SetSearchData("USER_ID_LST", gd_schedule.Rows[e.RowIndex].Cells["USER_ID"].Value);
                    //SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                    //SetServiceId("SetScheduleManager");

                    //DTOFactory.Action();

                    //try
                    //{
                    //    DTOFactory.Transaction(new ReportDTO());

                    //    GetItemInfo(gd_List, null);
                    //}
                    //catch (Exception ex)
                    //{
                    //    ViewMessage.Error(ex.Message);
                    //}

                    //DTOFactory.Complete();
                }
                else if("VIEW".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    GetDocumentList(e.RowIndex);
                }
            }
        }

        private void AddNewDocument(object sender, EventArgs e)
        {
            string link_code = gd_List.GetSelectString("LINK_CD");
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                new FileSender(link_code, frm.FileName);

                ClearSearchData();

                SetSearchData("LINK_CODE", link_code);
                SetSearchData("GRP_NO", gd_schedule.SelectedCells.Count > 0 ? gd_schedule.Rows[gd_schedule.SelectedCells[0].RowIndex].Cells["SCH_DESC"].Value : "사업 접수");
                SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                SetServiceId("InsertBusinessDocument");

                try
                {
                    DTOFactory.Transaction(new ReportDTO());

                    ViewMessage.Info("문서 등록이 완료 되었습니다.");
                    gd_Document.DataSource = DTOFactory.GetDataTable();
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }
        //문서 수정
        private void DocumentControl(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (e.RowIndex > -1)
            {
                if ("FILE_DESC".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    FileGet get = new FileGet(view.Rows[e.RowIndex].Cells["LINK_DESC"].Value.ToString());
                    get.Close();
                }
                else if ("CREATE".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    OpenFileDialog frm = new OpenFileDialog();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string desc = Microsoft.VisualBasic.Interaction.InputBox("File 변경사항을 입력하시오.", "문서 등록");
                        new FileSender(view.Rows[e.RowIndex].Cells["LINK_CD"].Value.ToString(), frm.FileName + "*" + view.Rows[e.RowIndex].Cells["FILE_DESC"].Value.ToString());

                        ClearSearchData();
                        SetSearchData("LINK_CODE", view.Rows[e.RowIndex].Cells["LINK_CD"].Value.ToString());
                        SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                        SetSearchData("DESC", desc);
                        SetSearchData("SEQ_NO", (float.Parse(view.Rows[e.RowIndex].Cells["REV_NO"].Value.ToString()) + 0.1).ToString());
                        SetSearchData("GRP_NO", gd_schedule.SelectedCells.Count > 0 ? gd_schedule.Rows[gd_schedule.SelectedCells[0].RowIndex].Cells["SCH_DESC"].Value : "사업 접수");
                        SetServiceId("InsertBusinessDocument");

                        try
                        {
                            DTOFactory.Transaction(new ReportDTO());

                            ViewMessage.Info("문서 등록이 완료 되었습니다.");
                            gd_Document.DataSource = DTOFactory.GetDataTable();
                        }
                        catch (Exception ex)
                        {
                            ViewMessage.Error(ex.Message);
                        }
                    }
                }
            }
        }

        //사업추가
        private void InsertSchedule(object sender, EventArgs e)
        {
            BusinessSchedulePopup frm = new BusinessSchedulePopup()
            {
                DOC_NM = gd_List.GetSelectString("SUBJECT"),
                DOC_ID = gd_List.GetSelectString("DOC_ID")
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetItemInfo(gd_List, null);
            }
        }

        private void MemoSave(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                ClearSearchData();
                SetSearchData("DESC", txtMyMemo.Text);
                SetSearchData("USER_ID_LST", DTOFactory.UserId);
                SetServiceId("SetPgmMemo");

                try
                {
                    DTOFactory.Transaction(new ReportDTO());
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
            else if (tabControl.SelectedIndex == 1)
            {
                ClearSearchData();
                SetSearchData("DOC_ID", gd_List.GetSelectString("DOC_ID"));
                SetSearchData("DESC", txtMemo.Text);
                SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                SetServiceId("SetBusinessItemMemo");

                try
                {
                    DTOFactory.Transaction(new ReportDTO());

                    _dtList.Rows[gd_List.SelectedCells[0].RowIndex]["BSN_DESC"] = txtMemo.Text;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void GetDocumentList(int row)
        {
            ClearSearchData();
            SetSearchData("DOC_ID", gd_schedule.Rows[row].Cells["SCH_ID"].Value);
            SetSearchData("GRP_NO", gd_schedule.Rows[row].Cells["SCH_DESC"].Value);
            SetServiceId("GetBusinessDocument");

            try
            {
                DTOFactory.Transaction(new ReportDTO());
                DataSet ds_return = DTOFactory.GetDataSet();

                gd_Document.DataSource = null;
                gd_Document.Columns.Clear();
                gd_Document.DataSource = ds_return.Tables["ds_doc"];

                gd_Document.SetGridColumn(ds_return.Tables["ds_column2"]);
                gd_Document.ReadOnly = false;
                gd_Document.Columns["FILE_DESC"].ReadOnly = true;
                gd_Document.Columns["REV_NO"].ReadOnly = true;
                gd_Document.Columns["USER_NM"].ReadOnly = true;
                gd_Document.Columns["CRT_TM"].ReadOnly = true;

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn()
                {
                    HeaderText = "관리",
                    Name = "CREATE",
                    Text = "문서등록",
                    UseColumnTextForButtonValue = true
                };
                gd_Document.Columns.AddRange(btn2);

                btnDocumentNew.Enabled = true;
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void BtnEnableControl(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                btnSave.Enabled = true;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                if (btnBool)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
            }
        }
    }
}