using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Member
{
    public partial class GovManager : MYCControl_noframe
    {
        #region Field
        protected DataTable _dtComp = new DataTable();
        protected DataTable _dtUser = new DataTable();
        #endregion

        public GovManager()
        {
            InitializeComponent();
        }

        private void GovManager_Load(object sender, EventArgs e)
        {
            InitSpread();
            InitControl();
        }

        private void InitControl()
        {
            ClearSearchData();
            SetSearchData("COMP_TYPE", "G");
            SetServiceId("GetCompList");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtComp = ds.Tables["ds_comp"];
                gd_List.DataSource = _dtComp;

                if (!gd_List.LabelDisplayed)
                {
                    gd_List.SetGridColumn(ds.Tables["ds_comp_column"]);
                    gd_List.Columns["COMP_NM"].HeaderText = "기관명";
                    gd_List.Columns["SITE_NM"].Visible = false;
                    gd_List.Columns["USER_NM"].Visible = false;
                    gd_List.Columns["GRADE_NM"].Visible = false;
                    gd_List.Columns["TEL"].Visible = false;
                    gd_List.Columns["FAX"].Visible = false;
                    gd_List.Columns["EMAIL"].Visible = false;
                    gd_List.Columns["REG_ID"].Visible = false;
                    gd_List.Columns["BNK_CD"].Visible = false;
                    gd_List.Columns["BNK_NO"].Visible = false;

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                    {
                        Text = "삭제",
                        HeaderText = "관리",
                        Name = "DEL",
                        UseColumnTextForButtonValue = true
                    };
                    gd_List.Columns.AddRange(bt);
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void InitSpread()
        {
            gd_List.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gd_Member.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void AddCompRow(object sender, EventArgs e)
        {
            var frm = new Popup.FrmInsertGovComp();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = _dtComp.NewRow();

                dr["COMP_NM"] = frm.CompName;
                dr["ADDR_CD"] = frm.AddrCode;
                dr["ADDR"] = frm.Addr;
                dr["WEB"] = frm.HomePage;
                _dtComp.Rows.Add(dr);


                ClearSearchData();
                SetSearchData("COMP_NAME", frm.CompName);
                SetSearchData("COMP_TYPE", "G");
                SetSearchData("ADDR_CODE", frm.AddrCode);
                SetSearchData("ADDR", frm.Addr);
                SetSearchData("HOMEPAGE", frm.HomePage);
                SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                SetServiceId("SetCompInfo");

                try
                {
                    DTOFactory.Transaction(new MemberDTO());
                    DataSet ds = DTOFactory.GetDataSet();

                    ViewMessage.Info("저장이 완료되었습니다.");

                    _dtComp = ds.Tables["ds_comp"];
                    gd_List.DataSource = _dtComp;
                    _dtUser.Rows.Clear();
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void GetUserInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && "DataGridViewTextBoxCell".Equals(gd_List.Columns[e.ColumnIndex].CellType.Name))
            {
                ClearSearchData();
                SetSearchData("COMP_CODE", _dtComp.Rows[e.RowIndex]["COMP_CD"].ToString());
                SetServiceId("GetUserList");

                try
                {
                    DTOFactory.Transaction(new MemberDTO());
                    DataSet ds = DTOFactory.GetDataSet();

                    _dtUser = ds.Tables["ds_user"];
                    gd_Member.DataSource = _dtUser;

                    if (gd_Member.LabelDisplayed)
                    {
                        gd_Member.SetGridColumn(ds.Tables["ds_user_column"]);
                        gd_Member.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        gd_Member.ReadOnly = false;

                        gd_Member.Columns["ADDR_CD"].Visible = false;
                        gd_Member.Columns["ADDR"].Visible = false;
                        gd_Member.Columns["JOIN_DT"].Visible = false;
                        gd_Member.Columns["RETIRE_DT"].Visible = false;
                        gd_Member.Columns["TEL_2"].Visible = false;
                        gd_Member.Columns["STAT_CD"].Visible = false;

                        gd_Member.Columns["LINE_ID"].HeaderText = "담당업무";
                        gd_Member.Columns["TEL_1"].HeaderText = "연락처";

                        DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                        {
                            Text = "저장",
                            HeaderText = "관리",
                            Name = "SAVE",
                            UseColumnTextForButtonValue = true
                        };
                        gd_Member.Columns.AddRange(bt);

                        DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                        {
                            Text = "삭제",
                            HeaderText = "관리",
                            Name = "DEL",
                            UseColumnTextForButtonValue = true
                        };
                        gd_Member.Columns.AddRange(bt2);
                    }
                    btnMemberAdd.Enabled = true;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void AddMemberRow(object sender, EventArgs e)
        {
            var frm = new Popup.FrmInsertGovMember();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = _dtUser.NewRow();

                dr["USER_NM"] = frm.UserName;
                dr["GRADE_CD"] = frm.Grade;
                dr["LINE_ID"] = frm.Line;
                dr["WORK_DESC"] = frm.Work;
                dr["TEL_1"] = frm.Tel;
                dr["EMAIL"] = frm.Mail;
                _dtUser.Rows.Add(dr);

                ClearSearchData();
                SetSearchData("USER_ID", "");
                SetSearchData("USER_NAME", frm.UserName);
                SetSearchData("GRADE_NM", frm.Grade);
                SetSearchData("COMP_CODE", _dtComp.Rows[gd_List.SelectedCells[0].RowIndex]["COMP_CD"].ToString());
                SetSearchData("COMP_TYPE", "G");
                SetSearchData("USER_TYPE", "G");
                SetSearchData("LINE_ID", frm.Line);
                SetSearchData("WORK_DESC", frm.Work);
                SetSearchData("TEL_1", frm.Tel);
                SetSearchData("EMAIL", frm.Mail);
                SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                SetServiceId("SetUserInfo");

                try
                {
                    DTOFactory.Transaction(new MemberDTO());
                    ViewMessage.Info("등록이 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void SetUserInfo(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name))
            {
                DataGridViewRow row = view.Rows[view.SelectedCells[0].RowIndex];

                ClearSearchData();


                SetSearchData("USER_ID", row.Cells["USER_ID"].Value);
                SetSearchData("USER_NAME", row.Cells["USER_NM"].Value);
                SetSearchData("GRADE_NM", row.Cells["GRADE_CD"].Value);
                SetSearchData("COMP_CODE", _dtComp.Rows[gd_List.SelectedCells[0].RowIndex]["COMP_CD"].ToString());
                SetSearchData("COMP_TYPE", "G");
                SetSearchData("USER_TYPE", "G");
                SetSearchData("LINE_ID", row.Cells["LINE_ID"].Value);
                SetSearchData("WORK_DESC", row.Cells["WORK_DESC"].Value);
                SetSearchData("TEL_1", row.Cells["TEL_1"].Value);
                SetSearchData("TEL_2", row.Cells["TEL_2"].Value);                
                SetSearchData("EMAIL", row.Cells["EMAIL"].Value);
                SetSearchData("ADDR_CODE", row.Cells["ADDR_CD"].Value);
                SetSearchData("ADDR", row.Cells["ADDR"].Value);
                SetSearchData("CAR_NO", row.Cells["CAR"].Value);
                SetSearchData("STAT_CD", row.Cells["STAT_CD"].Value);
                SetSearchData("JOIN_DT", row.Cells["JOIN_DT"].Value);
                SetSearchData("RETIRE_DT", row.Cells["RETIRE_DT"].Value);
                SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                SetServiceId("SetUserInfo");

                try
                {
                    DTOFactory.Transaction(new MemberDTO());

                    ViewMessage.Info("저장이 완료 되었습니다.");
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
            else if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
            {
                if (!"".Equals(_dtUser.Rows[e.RowIndex]["USER_ID"].ToString()))
                {
                    if (System.Windows.Forms.MessageBox.Show(
                        _dtUser.Rows[e.RowIndex]["USER_NM"].ToString() + " 인원 정보를 삭제 하시겠습니까?", "인원 제거"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearSearchData();
                        SetSearchData("USER_ID", _dtUser.Rows[e.RowIndex]["USER_ID"].ToString());
                        SetServiceId("RemoveUser");

                        try
                        {
                            DTOFactory.Transaction(new MemberDTO());
                            _dtUser.Rows.RemoveAt(e.RowIndex);

                            ViewMessage.Info("인원 정보가 삭제 되었습니다.");
                        }
                        catch (Exception ex)
                        {
                            ViewMessage.Error(ex.Message);
                        }
                    }

                }
            }
        }

        private void SetCompInfo(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    if (!"".Equals(_dtComp.Rows[e.RowIndex]["COMP_CD"].ToString()))
                    {
                        if (System.Windows.Forms.MessageBox.Show(
                            _dtComp.Rows[e.RowIndex]["COMP_NM"].ToString() + " 업체 정보를 삭제 하시겠습니까?", "기관 제거"
                            , MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ClearSearchData();
                            SetSearchData("COMP_CODE", _dtComp.Rows[e.RowIndex]["COMP_CD"].ToString());
                            SetServiceId("RemoveComp");

                            try
                            {
                                DTOFactory.Transaction(new MemberDTO());
                                _dtComp.Rows.RemoveAt(e.RowIndex);

                                ViewMessage.Info("기관 정보가 삭제 되었습니다.");
                            }
                            catch (Exception ex)
                            {
                                ViewMessage.Error(ex.Message);
                            }
                        }

                    }
                }
            }
        }
    }
}
