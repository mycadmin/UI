using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Personal
{
    public partial class WeekReport : MYCControl
    {
        protected DataTable dt_result = new DataTable();
        private List<Button> lstBtn = new List<Button>();

        public WeekReport()
        {
            InitializeComponent();
        }

        private void WeekReport_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            cbockMember.Params.Clear();
            cbockMember.Params.Add("strCompType", "M");
            cbockMember.BindDataSet();

            cboYear.Items.Clear();
            for(int i=-3;i<=0;i++)
            {
                cboYear.Items.Add(DateTime.Now.AddYears(i).ToString("yyyy"));
            }

            cboYear.SelectedIndex = 3;
            cboPeriod.SelectedIndex = 1;
        }

        private void SetReportTime(object sender, EventArgs e)
        {
            int cnt = cboPeriod.SelectedIndex == 0 ? 12 : 52;

            cboDate.Items.Clear();
            for (int i=1 ; i<=cnt ; i++)
            {
                cboDate.Items.Add(i);
            }
        }

        private void Search(object sender, EventArgs e)
        {
            DateTime t1;
            DateTime t2;

            switch (cboPeriod.Text)
            {
                case "M":
                    t1 = new DateTime(int.Parse(cboYear.Text), int.Parse(cboDate.Text), 1);
                    t2 = t1.AddMonths(1).AddDays(-1);
                    break;
                case "W":
                    t1 = new DateTime(int.Parse(cboYear.Text), 1, 1);
                    int week = int.Parse(cboDate.Text) * 7;
                    week -= (int)t1.DayOfWeek;
                    t1 = t1.AddDays(week);
                    t2 = t1.AddDays(6);
                    break;
                default:
                    t1 = new DateTime(int.Parse(cboYear.Text), 1, 1);
                    t2 = new DateTime(int.Parse(cboYear.Text), 1, 1);
                    break;
            }

            lbWork.Text = "진행 사항 (" + t1.ToString("yyyy-MM-dd") + " ~ " + t2.ToString("yyyy-MM-dd") + ")";

            ClearSearchData();
            SetSearchData("START_TM", t1, "yyyy-MM-dd 00:00:00");
            SetSearchData("END_TM", t2, "yyyy-MM-dd 23:59:59");
            SetSearchData("USER_ID", cbockMember.ValueList);
            SetServiceId("GetActionItem");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                dt_result = DTOFactory.GetDataTable();

                for(int i=0; i < lstBtn.Count; i++)
                {
                    lstBtn[i].Dispose();
                }

                lstBtn.Clear();
                txtWork.Text = "";

                if (dt_result.Rows.Count > 0)
                {
                    string[] col = new string[2] { "ACT_TYP_CD_1", "TYPE_1" };
                    DataTable dt_Group = dt_result.DefaultView.ToTable(true, col);

                    foreach(DataRow row in dt_Group.Rows)
                    {
                        Button btn = new Button()
                        {
                            Name = "btn" + row["ACT_TYP_CD_1"],
                            Text = row["TYPE_1"].ToString(),
                            Size = new System.Drawing.Size(90, 30)
                        };

                        btn.Click += new EventHandler(ViewWorkSheet);

                        lstBtn.Add(btn);
                    }

                    for(int i=0;i<lstBtn.Count;i++)
                    {
                        lstBtn[i].Location = new System.Drawing.Point(8 + i * 100, 8);
                        pnlTop.Controls.Add(lstBtn[i]);
                    }
                }
                else
                {
                    ViewMessage.Info("조회 기간 내 검색된 업무 내용이 없습니다.");
                }
            }
            catch(Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewWorkSheet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string ACT_TYP_CD_1 = btn.Name.Substring(3);
            DataTable dt_type_2 = dt_result.Select(string.Format("ACT_TYP_CD_1='{0}'", ACT_TYP_CD_1)).CopyToDataTable().DefaultView.ToTable(true, "TYPE_2");
            int SUBJECT1 = 1;
            int SUBJECT2;
            int SUBJECT3;

            string[] col = new string[6] { "ACT_ID", "SUBJECT", "ACT_USER_NM", "TGT_TM", "END_TM", "ING_PER" };

            #region RTF 기본 설정
            int x = (int)(txtWork.Width * 14.5);
            int sub1 = x - 400;
            
            string sheet = @"{\rtf1\ansi\ansicpg949\deff0\nouicompat\deflang1033\deflangfe1042{\fonttbl{\f0\fnil\fcharset129 \'b1\'bc\'b8\'b2;}";
            sheet += @"{\f1\fswiss\fcharset0 Calibri;}}";
            sheet += @"{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red255\green0\blue0;\red166\green166\blue166;\red224\green224\blue224; }";
            sheet += @"{\*\generator Riched20 10.0.19041}\viewkind4\uc1";
            sheet += @"\pard\f0\fs23\lang1042";
            #endregion

            #region 구분 항목 생성
            foreach (DataRow type2 in dt_type_2.Rows)
            {
                sheet += @"\trowd\trgraph20\trleft200";
                sheet += @"\clcbpat4\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs\cellx" + x.ToString();
                sheet += @"\pard";
                sheet += @"\intbl";
                sheet += @"{\nowidctlpar\b " + (SUBJECT1++).ToString() + ". " + type2["TYPE_2"] + @"}\cell";
                sheet += @"\row";
                
                sheet += @"\trowd\trgraph20\trleft200";
                sheet += @"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs\cellx" + x.ToString();
                sheet += @"\pard";
                sheet += @"\intbl";
                sheet += @"\par";

                #region Action Item별 목록 생성
                DataTable dt_action = dt_result.Select(string.Format("ACT_TYP_CD_1='{0}' AND TYPE_2='{1}'", ACT_TYP_CD_1, type2["TYPE_2"])).CopyToDataTable()
                                     .DefaultView.ToTable(true, col);

                SUBJECT2 = 1;
                foreach (DataRow act in dt_action.Rows)
                {
                    //action item 제목
                    sheet += @"\pard";
                    sheet += @"\intbl";
                    sheet += @"\itap2";
                    sheet += @"{\nowidctlpar\b " + (SUBJECT2++).ToString() + ". " + act["SUBJECT"] + @"}\nestcell";
                    sheet += @"{\*\nesttableprops\trowd\trgraph20\trleft200";
                    sheet += @"\clcbpat5\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs\cellx" + sub1.ToString();
                    sheet += @"\nestrow}";
                    sheet += @"{\nonesttables\par}";

                    //action item 일정 정보
                    sheet += @"\pard";
                    sheet += @"\intbl";
                    sheet += @"\itap2";
                    sheet += @"  -. 담당자 : " + act["ACT_USER_NM"] + @"\nestcell";
                    sheet += @"  -. 목표일정 : " + act["TGT_TM"] + @"\nestcell";

                    if (!"".Equals(act["END_TM"]))
                        sheet += @"  -. 진행사항 : 완료(" + act["END_TM"] + @")\nestcell";
                    else
                        sheet += @"  -. 진행사항 : 진행중(" + act["ING_PER"] + @"%)\nestcell";

                    sheet += @"{\*\nesttableprops\trowd\trgraph20\trleft200";
                    for (int i = 1; i <= 3; i++)
                    {

                        sheet += @"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs\cellx" + (i * (sub1 / 3)).ToString();
                    }
                    sheet += @"\nestrow}";
                    sheet += @"{\nonesttables\par}";

                    #region 세부 목록 생성
                    sheet += @"\pard";
                    sheet += @"\intbl";
                    sheet += @"\itap2";                    
                    sheet += @"{\nowidctlpar";
                    
                    DataRow[] rows = dt_result.Select(string.Format("ACT_ID = '{0}'", act["ACT_ID"]));

                    SUBJECT3 = 1;
                    foreach(DataRow row in rows)
                    {
                        sheet += @"\par ";
                        sheet += @"{\nowidctlpar\b " + (SUBJECT3++).ToString() + ". " + row["ITEM_SUBJECT"];

                        if (!"".Equals(row["ITEM_END_TM"]))
                        {
                            sheet += "( " + row["ITEM_END_TM"] + " / 완료";
                        }
                        else
                        {
                            sheet += "( ~ " + row["ITEM_TGT_TM"] + " / " + row["ITEM_PER"] + @"%)";
                        }

                        sheet += @"}\par     ";
                        sheet += row["ITM_DESC"].ToString().Replace("\r\n", @"\par     ");
                    }
                    #endregion

                    sheet += @"\par ";
                    sheet += @" }\nestcell";
                    sheet += @"{\*\nesttableprops\trowd\trgraph20\trleft200";
                    sheet += @"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs\cellx" + sub1.ToString();
                    sheet += @"\nestrow}";
                    sheet += @"{\nonesttables\par}";
                    
                    #endregion
                }
            }

            sheet += @"\par";
            sheet += @"\cell";
            sheet += @"\row";
            sheet += @"\pard";
            #endregion


            sheet += @"}";

            txtWork.Rtf = sheet;
        }

        private void ViewSchedule(object sender, EventArgs e)
        {
            DateTime t1;
            DateTime t2;

            switch (cboPeriod.Text)
            {
                case "M":
                    t1 = new DateTime(int.Parse(cboYear.Text), int.Parse(cboDate.Text), 1);
                    t2 = t1.AddMonths(1).AddDays(-1);
                    t1 = t1.AddDays(-(int)t1.DayOfWeek);
                    break;
                case "W":
                    t1 = new DateTime(int.Parse(cboYear.Text), 1, 1);
                    int week = int.Parse(cboDate.Text) * 7;
                    week -= (int)t1.DayOfWeek;
                    t1 = t1.AddDays(week).AddDays(-42);
                    t2 = t1.AddDays(41);
                    break;
                default:
                    t1 = new DateTime(int.Parse(cboYear.Text), 1, 1);
                    t2 = new DateTime(int.Parse(cboYear.Text), 1, 1);
                    break;
            }
        }
    }
}
