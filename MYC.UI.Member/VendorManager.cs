using System;
using System.Data;
using System.Windows.Forms;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Member
{
    public partial class VendorManager : MYCControl_noframe
    {
        #region Field
        protected DataTable _dtComp = new DataTable();
        protected DataTable _dtUser = new DataTable();
        #endregion

        public VendorManager()
        {
            InitializeComponent();
        }

        private void VendorManager_Load(object sender, EventArgs e)
        {
            InitSpread();
            InitControl();
        }

        private void InitControl()
        {
            ClearSearchData();
            SetSearchData("COMP_TYPE", "V");
            SetServiceId("GetCompList");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtComp = ds.Tables["ds_comp"];
                gd_List.DataSource = _dtComp;
                gd_List.SetGridColumn(ds.Tables["ds_comp_column"]);

                gd_List.Columns["COMP_CD"].Frozen = true;
                gd_List.Columns["COMP_NM"].Frozen = true;
                gd_List.Columns["COMP_NM"].DividerWidth = 1;

                DataGridViewButtonColumn bt1 = new DataGridViewButtonColumn()
                {
                    Text = "보기",
                    HeaderText = "사업자등록증",
                    Name = "FILE1",
                    UseColumnTextForButtonValue = true
                };
                gd_List.Columns.AddRange(bt1);

                DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                {
                    Text = "보기",
                    HeaderText = "회사소개서",
                    Name = "FILE2",
                    UseColumnTextForButtonValue = true
                };
                gd_List.Columns.AddRange(bt2);

                DataGridViewButtonColumn bt3 = new DataGridViewButtonColumn()
                {
                    Text = "보기",
                    HeaderText = "통장 사본",
                    Name = "FILE3",
                    UseColumnTextForButtonValue = true
                };
                gd_List.Columns.AddRange(bt3);

                DataGridViewButtonColumn bt4 = new DataGridViewButtonColumn()
                {
                    Text = "보기",
                    HeaderText = "재무제표",
                    Name = "FILE4",
                    UseColumnTextForButtonValue = true
                };
                gd_List.Columns.AddRange(bt4);

                DataGridViewButtonColumn bt5 = new DataGridViewButtonColumn()
                {
                    Text = "수정",
                    HeaderText = "",
                    Name = "MODIFY",
                    UseColumnTextForButtonValue = true
                };
                gd_List.Columns.AddRange(bt5);

                DataGridViewButtonColumn bt6 = new DataGridViewButtonColumn()
                {
                    Text = "삭제",
                    HeaderText = "",
                    Name = "DEL",
                    UseColumnTextForButtonValue = true
                };
                gd_List.Columns.AddRange(bt6);
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

        private void GetCompInfo(object sender, DataGridViewCellEventArgs e)
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

                    if (!gd_Member.LabelDisplayed)
                    {
                        gd_Member.SetGridColumn(ds.Tables["ds_user_column"]);

                        gd_Member.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        gd_Member.ReadOnly = false;

                        gd_Member.Columns["ADDR_CD"].Visible = false;
                        gd_Member.Columns["ADDR"].Visible = false;
                        gd_Member.Columns["JOIN_DT"].Visible = false;
                        gd_Member.Columns["RETIRE_DT"].Visible = false;
                        
                        DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                        {
                            Text = "삭제",
                            HeaderText = "",
                            Name = "DEL",
                            UseColumnTextForButtonValue = true
                        };
                        gd_Member.Columns.AddRange(bt);

                        DataGridViewButtonColumn bt2 = new DataGridViewButtonColumn()
                        {
                            Text = "저장",
                            HeaderText = "",
                            Name = "SAVE",
                            UseColumnTextForButtonValue = true
                        };
                        gd_Member.Columns.AddRange(bt2);
                    }
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void AddCompRow(object sender, EventArgs e)
        {
            var frm = new Popup.FrmInsertVendorComp();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string LINK = "";

                if (!"".Equals(frm.FILE1))
                {
                    FileSender file1 = new FileSender(LINK, frm.FILE1, true, 'M', 1);
                    LINK = file1.GetLinkCode();
                    file1.Close();
                }

                if (!"".Equals(frm.FILE2))
                {
                    FileSender file2 = new FileSender(LINK, frm.FILE2, true, 'M', 2);
                    LINK = file2.GetLinkCode();
                    file2.Close();
                }

                if (!"".Equals(frm.FILE3))
                {
                    FileSender file3 = new FileSender(LINK, frm.FILE3, true, 'M', 3);
                    LINK = file3.GetLinkCode();
                    file3.Close();
                }

                if (!"".Equals(frm.FILE4))
                {
                    FileSender file4 = new FileSender(LINK, frm.FILE4, true, 'M', 4);
                    LINK = file4.GetLinkCode();
                    file4.Close();
                }

                ClearSearchData();
                SetSearchData("COMP_NAME", frm.CompName);                
                SetSearchData("SITE_NAME", frm.SiteName);
                SetSearchData("COMP_TYPE", "V");
                SetSearchData("USER_NAME", frm.UserName);
                SetSearchData("GRADE_NM", frm.Grade);
                SetSearchData("ADDR_CODE", frm.AddrCode);
                SetSearchData("ADDR", frm.Addr);
                SetSearchData("TEL_1", frm.Tel);
                SetSearchData("FAX", frm.Fax);
                SetSearchData("EMAIL", frm.Mail);
                SetSearchData("HOMEPAGE", frm.HomePage);                
                SetSearchData("BANK_CODE", frm.BankCode);                
                SetSearchData("BANK_NO", frm.BankNo);                
                SetSearchData("REG_ID", frm.Regid);
                SetSearchData("LINK_CODE", LINK);
                SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                SetServiceId("SetCompInfo");

                try
                {
                    DTOFactory.Transaction(new MemberDTO());
                    DataSet ds = DTOFactory.GetDataSet();

                    ViewMessage.Info("저장이 완료되었습니다.");

                    _dtComp = ds.Tables["ds_comp"];
                    _dtUser.Rows.Clear();
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void SetCompInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridView view = (DataGridView)sender;
                DataRow row = _dtComp.Rows[e.RowIndex];

                if("FILE1".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    if (!"".Equals(row["FILE_1"].ToString()))
                    {
                        FileGet file = new FileGet(row["FILE_1"].ToString());
                        file.Close();
                    }
                }
                else if ("FILE2".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    if (!"".Equals(row["FILE_2"].ToString()))
                    {
                        FileGet file = new FileGet(row["FILE_2"].ToString());
                        file.Close();
                    }
                }
                else if ("FILE3".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    if (!"".Equals(row["FILE_3"].ToString()))
                    {
                        FileGet file = new FileGet(row["FILE_3"].ToString());
                        file.Close();
                    }
                }
                else if ("FILE4".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    if (!"".Equals(row["FILE_4"].ToString()))
                    {
                        FileGet file = new FileGet(row["FILE_4"].ToString());
                        file.Close();
                    }
                }
                else if ("MODIFY".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    var frm = new Popup.FrmInsertVendorComp()
                    {
                        CompName = row["COMP_NM"].ToString(),
                        SiteName = row["SITE_NM"].ToString(),
                        UserName = row["USER_NM"].ToString(),
                        Grade = row["GRADE_NM"].ToString(),
                        AddrCode = row["ADDR_CD"].ToString(),
                        Addr = row["ADDR"].ToString(),
                        Tel = row["TEL"].ToString(),
                        Fax = row["FAX"].ToString(),
                        Mail = row["EMAIL"].ToString(),
                        HomePage = row["WEB"].ToString(),
                        Regid = row["REG_ID"].ToString(),
                        BankCode = row["BNK_CD"].ToString(),
                        BankNo = row["BNK_NO"].ToString()
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string LINK = row["LINK_CD"].ToString();

                        if (!"".Equals(frm.FILE1))
                        {
                            if (!"".Equals(row["FILE_1"].ToString()))
                            {
                                FileSender del1 = new FileSender(LINK, row["FILE_1"].ToString(), false, 'M');
                                del1.Close();
                            }

                            FileSender file1 = new FileSender(LINK, frm.FILE1, true, 'M', 1);
                            LINK = file1.GetLinkCode();
                            file1.Close();
                        }

                        if (!"".Equals(frm.FILE2))
                        {
                            if (!"".Equals(row["FILE_2"].ToString()))
                            {
                                FileSender del2 = new FileSender(LINK, row["FILE_2"].ToString(), false, 'M');
                                del2.Close();
                            }

                            FileSender file2 = new FileSender(LINK, frm.FILE2, true, 'M', 2);
                            LINK = file2.GetLinkCode();
                            file2.Close();
                        }

                        if (!"".Equals(frm.FILE3))
                        {
                            if (!"".Equals(row["FILE_3"].ToString()))
                            {
                                FileSender del3 = new FileSender(LINK, row["FILE_3"].ToString(), false, 'M');
                                del3.Close();
                            }

                            FileSender file3 = new FileSender(LINK, frm.FILE3, true, 'M', 3);
                            LINK = file3.GetLinkCode();
                            file3.Close();
                        }

                        if (!"".Equals(frm.FILE4))
                        {
                            if (!"".Equals(row["FILE_4"].ToString()))
                            {
                                FileSender del4 = new FileSender(LINK, row["FILE_4"].ToString(), false, 'M');
                                del4.Close();
                            }

                            FileSender file4 = new FileSender(LINK, frm.FILE4, true, 'M', 4);
                            LINK = file4.GetLinkCode();
                            file4.Close();
                        }

                        ClearSearchData();                        
                        SetSearchData("COMP_CODE", row["COMP_CD"]);                        
                        SetSearchData("COMP_NAME", frm.CompName);                        
                        SetSearchData("SITE_NAME", frm.SiteName);                        
                        SetSearchData("COMP_TYPE", "V");                        
                        SetSearchData("USER_NAME", frm.UserName);
                        SetSearchData("GRADE_NM", frm.Grade);
                        SetSearchData("ADDR_CODE", frm.AddrCode);
                        SetSearchData("ADDR", frm.Addr);
                        SetSearchData("TEL_1", frm.Tel);                        
                        SetSearchData("FAX", frm.Fax);
                        SetSearchData("EMAIL", frm.Mail);
                        SetSearchData("HOMEPAGE", frm.HomePage);
                        SetSearchData("BANK_CODE", frm.BankCode);
                        SetSearchData("BANK_NO", frm.BankNo);
                        SetSearchData("REG_ID", frm.Regid);
                        SetSearchData("LINK_CODE", LINK);
                        SetSearchData("UPT_USER_ID", DTOFactory.UserId);
                        SetServiceId("SetCompInfo");

                        try
                        {
                            DTOFactory.Transaction(new MemberDTO());
                            DataSet ds = DTOFactory.GetDataSet();

                            ViewMessage.Info("수정이 완료되었습니다.");

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
                else if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    if (!"".Equals(row["COMP_CD"].ToString()))
                    {
                        if (System.Windows.Forms.MessageBox.Show(
                            row["COMP_NM"].ToString() + " 업체 정보를 삭제 하시겠습니까?", "업체 제거"
                            , MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ClearSearchData();
                            SetSearchData("COMP_CODE", row["COMP_CD"].ToString());
                            SetServiceId("RemoveComp");

                            try
                            {
                                DTOFactory.Transaction(new MemberDTO());
                                _dtComp.Rows.RemoveAt(e.RowIndex);

                                ViewMessage.Info("업체 정보가 삭제 되었습니다.");
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

        private void AddMemberRow(object sender, EventArgs e)
        {
            _dtUser.Rows.Add();
        }

        private void SetUserInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridView view = (DataGridView)sender;
                DataGridViewRow row = view.Rows[view.SelectedCells[0].RowIndex];

                if ("DEL".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    if (!"".Equals(row.Cells["USER_ID"].Value.ToString()))
                    {
                        if (System.Windows.Forms.MessageBox.Show(
                            row.Cells["USER_ID"].Value.ToString() + " 인원 정보를 삭제 하시겠습니까?", "업체 제거"
                            , MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ClearSearchData();
                            SetSearchData("USER_ID", row.Cells["USER_ID"].Value.ToString());
                            SetServiceId("RemoveUser");

                            try
                            {
                                DTOFactory.Transaction(new MemberDTO());
                                _dtUser.Rows.RemoveAt(e.RowIndex);
                            }
                            catch (Exception ex)
                            {
                                ViewMessage.Error(ex.Message);
                            }
                        }

                    }
                }
                else if ("SAVE".Equals(view.Columns[e.ColumnIndex].Name))
                {
                    ClearSearchData();
                    SetSearchData("USER_ID", row.Cells["USER_ID"].Value);                    
                    SetSearchData("USER_NAME", row.Cells["USER_NM"].Value);                   
                    SetSearchData("GRADE_NM", row.Cells["GRADE_CD"].Value);                    
                    SetSearchData("COMP_CODE", _dtComp.Rows[gd_List.SelectedCells[0].RowIndex]["COMP_CD"].ToString());
                    SetSearchData("COMP_TYPE", "V");
                    SetSearchData("USER_TYPE", "V");
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
                }
            }
        }
    }
}
