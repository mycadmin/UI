using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Member
{
    public partial class CompanyManager : MYCControl_noframe
    {
        #region Field
        protected DataTable _dtComp = new DataTable();
        protected DataTable _dtUser = new DataTable();
        #endregion

        public CompanyManager()
        {
            InitializeComponent();
        }

        private void CompanyManager_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitControl();

            DTOFactory.Complete();
        }

        private void InitControl()
        {
            ClearSearchData();
            SetSearchData("COMP_TYPE", "M");
            SetServiceId("GetCompList");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtComp = ds.Tables["ds_comp"];
                gd_List.DataSource = _dtComp;
                gd_List.SetGridColumn(ds.Tables["ds_comp_column"]);
                
                gd_List.Columns["USER_NM"].Visible = false;
                gd_List.Columns["GRADE_NM"].Visible = false;
                gd_List.Columns["ADDR_CD"].Visible = false;
                gd_List.Columns["ADDR"].Visible = false;
                gd_List.Columns["TEL"].Visible = false;
                gd_List.Columns["FAX"].Visible = false;
                gd_List.Columns["EMAIL"].Visible = false;
                gd_List.Columns["WEB"].Visible = false;
                gd_List.Columns["BNK_CD"].Visible = false;
                gd_List.Columns["BNK_NO"].Visible = false;
                gd_List.Columns["REG_ID"].Visible = false;
                gd_List.Columns["LOGO"].Visible = false;
                gd_List.Columns["STAMP"].Visible = false;
                gd_List.Columns["LINK_CD"].Visible = false;
                gd_List.Columns["FILE_1"].Visible = false;
                gd_List.Columns["FILE_2"].Visible = false;
                gd_List.Columns["FILE_3"].Visible = false;
                gd_List.Columns["FILE_4"].Visible = false;

                //2021-01-26 hsh - 최초 Open시 첫번째 사업장의 정보 표시
                if (gd_List.RowCount > 0)
                    GetCompInfo(gd_List, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void GetCompInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtCompName.Text = _dtComp.Rows[e.RowIndex]["COMP_NM"].ToString();
                txtRegId.Text = _dtComp.Rows[e.RowIndex]["REG_ID"].ToString();
                txtName.Text = _dtComp.Rows[e.RowIndex]["USER_NM"].ToString();
                txtGrade.Text = _dtComp.Rows[e.RowIndex]["GRADE_NM"].ToString();
                txtAddrCode.Text = _dtComp.Rows[e.RowIndex]["ADDR_CD"].ToString();
                txtAddr.Text = _dtComp.Rows[e.RowIndex]["ADDR"].ToString();
                txtTel.Text = _dtComp.Rows[e.RowIndex]["TEL"].ToString();
                txtFax.Text = _dtComp.Rows[e.RowIndex]["FAX"].ToString();
                txtHomePage.Text = _dtComp.Rows[e.RowIndex]["WEB"].ToString();
                txtEmail.Text = _dtComp.Rows[e.RowIndex]["EMAIL"].ToString();

                if (!"".Equals(_dtComp.Rows[e.RowIndex]["LOGO"].ToString()))
                {
                    ImageGet logo = new ImageGet(_dtComp.Rows[e.RowIndex]["LOGO"].ToString());

                    picLogo.Image = Image.FromStream(logo.GetImageData());
                }
                else
                {
                    picLogo.Image = null;
                }

                if (!"".Equals(_dtComp.Rows[e.RowIndex]["LOGO"].ToString()))
                {
                    ImageGet stamp = new ImageGet(_dtComp.Rows[e.RowIndex]["STAMP"].ToString());

                    picStamp.Image = Image.FromStream(stamp.GetImageData());
                }
                else
                {
                    picStamp.Image = null;
                }

                GetUserInfo(e.RowIndex, "재직");
            }
        }

        private void GetUserInfo(int rowindex, string STAT_CD)
        { 
            ClearSearchData();
            SetSearchData("COMP_CODE", _dtComp.Rows[rowindex]["COMP_CD"].ToString());
            SetSearchData("STAT_CD", STAT_CD);
            SetServiceId ("GetUserList");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtUser = ds.Tables["ds_user"];
                gd_Member.Columns.Clear();
                gd_Member.DataSource = _dtUser;

                
                gd_Member.SetGridColumn(ds.Tables["ds_user_column"]);

                gd_Member.SelectionMode = DataGridViewSelectionMode.CellSelect;
                gd_Member.ReadOnly = false;

                gd_Member.Columns["TEL_1"].HeaderText = "연락처";
                gd_Member.Columns["TEL_2"].HeaderText = "내선번호";
                gd_Member.Columns["ADDR_CD"].Visible = false;
                gd_Member.Columns["ADDR"].Visible = false;
                gd_Member.Columns["STAT_CD"].Visible = false;
                gd_Member.Columns["RETIRE_DT"].Visible = false;

                DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                {
                    Text = "저장",
                    HeaderText = "",
                    Name = "SAVE",
                    UseColumnTextForButtonValue = true
                };
                gd_Member.Columns.AddRange(bt);

                //2021-01-26 hsh - 삭제 기능을 제거 후 퇴직 기능 추가
                DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                {
                    Text = "재직".Equals(STAT_CD) ? "퇴직처리" : "전산등록",
                    HeaderText = "",
                    Name = "SUBMIT",
                    UseColumnTextForButtonValue = true,
                    ReadOnly = false
                };
                gd_Member.Columns.AddRange(bt2);

            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void GetSubmitList(object sender, EventArgs e)
        {
            GetUserInfo(gd_List.SelectedRows[0].Index, "신규");
        }

        private void AddCompRow(object sender, EventArgs e)
        {
            _dtComp.Rows.Add();
        }

        private void RemoveCompRow(object sender, EventArgs e)
        {
            if (gd_List.SelectedRows.Count == 1)
            {
                if (!"".Equals(_dtComp.Rows[gd_List.SelectedRows[0].Index]["COMP_CD"].ToString()))
                {
                    if(System.Windows.Forms.MessageBox.Show(
                        _dtComp.Rows[gd_List.SelectedRows[0].Index]["COMP_NM"].ToString() + " 사업장을 삭제 하시겠습니까?", "업체 제거"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearSearchData();
                        SetSearchData("COMP_CODE", _dtComp.Rows[gd_List.SelectedRows[0].Index]["COMP_CD"].ToString());
                        SetServiceId("RemoveComp");

                        try
                        {
                            DTOFactory.Transaction(new MemberDTO());
                            _dtComp.Rows.RemoveAt(gd_List.SelectedRows[0].Index);
                        }
                        catch (Exception ex)
                        {
                            ViewMessage.Error(ex.Message);
                        }
                    }

                }
            }
        }

        private void SaveCompInfo(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("COMP_CODE", gd_List.SelectedRows[0].Cells["COMP_CD"].Value);
            SetSearchData("COMP_NAME", txtCompName.Text);
            SetSearchData("COMP_TYPE", "M");
            SetSearchData("REG_ID", txtRegId.Text);
            SetSearchData("USER_NAME", txtName.Text);
            SetSearchData("GRADE_NM", txtGrade.Text);
            SetSearchData("ADDR_CODE", txtAddrCode.Text);
            SetSearchData("ADDR", txtAddr.Text);
            SetSearchData("TEL_1", txtTel.Text);
            SetSearchData("FAX", txtFax.Text);
            SetSearchData("HOMEPAGE", txtHomePage.Text);
            SetSearchData("EMAIL", txtEmail.Text);
            SetSearchData("UPT_USER_ID", DTOFactory.UserId);
            SetServiceId("SetCompInfo");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtComp = ds.Tables["ds_comp"];
                gd_List.DataSource = _dtComp;
                _dtUser.Clear();

                txtCompName.Text = "";
                txtRegId.Text = "";
                txtName.Text = "";
                txtGrade.Text = "";
                txtAddrCode.Text = "";
                txtAddr.Text = "";
                txtTel.Text = "";
                txtFax.Text = "";
                txtHomePage.Text = "";
                txtEmail.Text = "";

                ViewMessage.Info("저장이 완료되었습니다.");
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void SetUserInfo(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.Rows[e.RowIndex];
            bool bSave = false;

            //2021-01-26 hsh - 퇴직기능 추가
            if ("퇴직처리".Equals(row.Cells[e.ColumnIndex].Value))
            {
                if (!"".Equals(_dtUser.Rows[e.RowIndex]["USER_ID"].ToString()))
                {
                    if (System.Windows.Forms.MessageBox.Show(
                        _dtUser.Rows[e.RowIndex]["USER_NM"].ToString() + " 인원을 퇴직 처리 하시겠습니까?", "퇴직 처리"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        _dtUser.Rows[e.RowIndex]["STAT_CD"] = "퇴직";
                        _dtUser.Rows[e.RowIndex]["RETIRE_DT"] = DateTime.Now.ToString("yyyyMMdd");
                        
                        bSave = true;
                    }

                }
            }
            else if ("전산등록".Equals(row.Cells[e.ColumnIndex].Value))
            {
                ClearSearchData();
                SetSearchData("USER_ID", row.Cells["USER_ID"].Value);
                SetSearchData("USER_NAME", row.Cells["USER_NM"].Value);
                SetSearchData("JOIN_DT", row.Cells["JOIN_DT"].Value);
                SetSearchData("TEL_1", row.Cells["TEL_1"].Value);
                SetSearchData("EMAIL", row.Cells["EMAIL"].Value);
                SetSearchData("ADDR_CODE", row.Cells["ADDR_CD"].Value);
                SetSearchData("ADDR", row.Cells["ADDR"].Value);
                SetServiceId("SetMember");

                try
                {
                    DTOFactory.Transaction(new MemberDTO());

                    row.Cells["STAT_CD"].Value = "재직";

                    Mail.Subject = "전산 등록 신청이 완료 되었습니다.";
                    Mail.To = row.Cells["EMAIL_2"].Value.ToString();
                    Mail.IsDirect = true;

                    string strBody = "안녕하세요. 주식회사 엠와이씨 입니다.<br>";
                    strBody += "아래 내용과 같이 귀하의 전산 사용 등록이 완료 되었습니다.<br>";
                    strBody += "<hr>";
                    strBody += "1. 사번 : " + row.Cells["USER_ID"].Value + "<br>";
                    strBody += "2. 사내메일 : " + row.Cells["EMAIL"].Value + "<br>";
                    strBody += "3. 초기 비밀번호 : 입사일<br>";

                    Mail.Send(strBody);

                    bSave = true;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
           

            if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name) || bSave)
            {
                ClearSearchData();
                SetSearchData("USER_ID", row.Cells["USER_ID"].Value);
                SetSearchData("USER_NAME", row.Cells["USER_NM"].Value);
                SetSearchData("GRADE_NM", row.Cells["GRADE_CD"].Value);
                SetSearchData("COMP_CODE", _dtComp.Rows[gd_List.SelectedCells[0].RowIndex]["COMP_CD"].ToString());
                SetSearchData("COMP_TYPE", "M");
                SetSearchData("USER_TYPE", "1");
                SetSearchData("USER_TYPE", "1");
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
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }

                ViewMessage.Info("처리가 완료 되었습니다.");

                GetUserInfo(gd_List.SelectedRows[0].Index, "재직");
            }
        }

        private void SizeRefresh(object sender, EventArgs e)
        {
            if (gd_List.Columns["COMP_NM"] != null)
                gd_List.Columns["COMP_NM"].Width = panel1.Width - 120;
        }
    }
}