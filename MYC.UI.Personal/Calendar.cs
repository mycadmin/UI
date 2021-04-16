using System;
using System.IO;
using System.Net;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;


namespace MYC.UI.Personal
{
    public partial class Calendar: MYCControl_noframe
    {
        protected string[] ArrWeek = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        protected int Year;
        protected int Month;
        protected DateTime cal;
        protected DataTable _dtSelSch = new DataTable();
        
        protected bool bInit = false;

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            cal = DateTime.Parse(string.Format("{0}년 {1}월 01일", DateTime.Now.Year, DateTime.Now.Month));

            InitDataTable();
            InitSpread();
            InitControl();
        }

        private void InitSpread()
        {    
            gd_list.MultiSelect = false;
            
            gd_SchSelection.DataSource = _dtSelSch;
            
            gd_SchSelection.Columns["SCH_TIME"].HeaderText = "시간";
            gd_SchSelection.Columns["SCH_TIME"].Width = 60;            
            gd_SchSelection.Columns["SCH_TYPE"].HeaderText = "구분";
            gd_SchSelection.Columns["SCH_TYPE"].Width = 60;
            gd_SchSelection.Columns["SCH_DESC"].HeaderText = "내용";
            gd_SchSelection.Columns["SCH_DESC"].Width = 160;
        }

        private void InitDataTable()
        {
            _dtSelSch.Columns.Add("SCH_TIME");
            _dtSelSch.Columns.Add("SCH_TYPE");
            _dtSelSch.Columns.Add("SCH_DESC");
        }

        private void InitControl()
        {
            DTOFactory.Action();

            cbockTeam.Params.Clear();
            cbockTeam.Params.Add("strCompId", "");
            cbockTeam.BindDataSet();
            cbockTeam.SetItemChecked(DTOFactory.TeamCode);
            
            cbockPlan.Params.Clear();
            cbockPlan.Params.Add("strItem", "SCH_TYPE");
            cbockPlan.BindDataSet();
            cboItem.DataSource = cbockPlan.DataSource;

            SetCalendar();
            
            DTOFactory.Complete();
        }

        private void SetCalendar()
        {
            Year = cal.Year;
            Month = cal.Month;

            LbYear.Text = string.Format("{0}년", Year);
            LbMonth.Text = string.Format("{0}월", Month);

            int day = 0;
            /*
            string url = "http://apis.data.go.kr/B090041/openapi/service/SpcdeInfoService/getHoliDeInfo";
            url += "?ServiceKey=zSOf6jfG8qs8CoCVQmKc3zgUToUModQ%2F3s9%2FuiTxJrW3CE9UisxDHSabmp7f96p7wZ%2BJSGEf97BHt5gjAlRwPg%3D%3D";
            url += "&pageNo=1";
            url += "&numOfRows=10";
            url += "&solYear=" + Year.ToString();
            url += "&solMonth=" + Month.ToString("00");

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(results);
            XmlNodeList nodes = doc.SelectNodes("/response/body/items/item");
            int index = 0;
            */
            ClearSearchData();
            SetSearchData("SCH_MONTH", Year.ToString() + "-" + Month.ToString("00"));
            SetSearchData("WORK_CD",  cbockTeam.ValueList);
            SetSearchData("USER_ID",  cbockUser.ValueList);
            SetSearchData("PLAN_CD", cbockPlan.ValueList);
            SetSearchData("OWNER", DTOFactory.UserId);
            SetServiceId("GetSchedule");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                DataTable ds_schedule = ds.Tables["ds_schedule"];
                
                gd_list.Columns.Clear();
                gd_list.DataSource = ds_schedule;
                gd_list.SetGridColumn(ds.Tables["ds_column"]);

                //당월 일정을 볼 경우에는 아래와 같이 Row 색을 처리
                //일정이 지나갔을 경우 : 회색
                //오늘 일정 : 밝은 파란색
                //2시간 이내 일정 : 노란색 
                //기타 : 흰색
                DateTime chkTime = DateTime.Now;
                if (chkTime.Year == Year && chkTime.Month == Month)
                {
                    foreach (DataGridViewRow gv in gd_list.Rows)
                    {
                        DateTime gvTime = DateTime.Parse(gv.Cells["SCH_TM"].Value.ToString());
                        
                        if (gvTime < chkTime)
                            gv.DefaultCellStyle.BackColor = Color.LightGray;
                        else if (gvTime.AddHours(2) < chkTime)
                            gv.DefaultCellStyle.BackColor = Color.Yellow;
                        else if (gvTime.Day == chkTime.Day)
                            gv.DefaultCellStyle.BackColor = Color.LightCyan;
                        else
                            gv.DefaultCellStyle.BackColor = Color.White;

                        if ("Y".Equals(gv.Cells["DEL_YN"]))
                        {
                            gv.DefaultCellStyle.Font = new Font("맑은 고딕", 9F, FontStyle.Strikeout, GraphicsUnit.Point, 129);
                        }
                    }
                }

                int indexTable = 0;

                switch (cal.ToString("ddd"))
                {
                    case "일":
                        day = 0;
                        break;
                    case "월":
                        day = 1;
                        break;
                    case "화":
                        day = 2;
                        break;
                    case "수":
                        day = 3;
                        break;
                    case "목":
                        day = 4;
                        break;
                    case "금":
                        day = 5;
                        break;
                    case "토":
                        day = 6;
                        break;
                }

                for (int w = 1; w < 6; w++)
                {
                    for (int d = 0; d < 7; d++)
                    {
                        DateTime now = cal.AddDays(d + (w - 1) * 7 - day);
                        string ControlName = string.Format("Week_{0}_{1}", w, ArrWeek[d]);
                        Panel panel = (Panel)PnlCalendar.Controls[ControlName];

                        panel.Controls.Clear();                        

                        panel.BackColor = Color.White;
                        Color TextColor = Color.Black;

                        if (now.ToString("MM").Equals(cal.ToString("MM")))
                        {
                            if (d == 0)
                                TextColor = Color.Red;
                            else if (d == 6)
                                TextColor = Color.Blue;
                        }
                        else
                        {
                            TextColor = Color.Gray;
                        }

                        Label DateDisplay = new Label()
                        {
                            Text = now.ToString("dd"),
                            Font = new Font("굴림", 9, FontStyle.Bold),
                            ForeColor = TextColor,
                            AutoSize = false,
                            Location = new Point(0, 1),
                            Size = new Size(20, 20),
                            Name = "DateDisplay"
                        };

                        Label FullString = new Label()
                        {
                            Text = now.ToString("yyyy-MM-dd"),
                            Visible = false,
                            Name = "FullString"
                        };

                        panel.Controls.Add(FullString);
                        panel.Controls.Add(DateDisplay);

                        #region 특수일 체크
                        /*
                        if (index < nodes.Count)
                        {
                            if (now.ToString("yyyyMMdd").Equals(nodes[index].SelectSingleNode("locdate").InnerText))
                            {
                                if ("Y".Equals(nodes[index].SelectSingleNode("isHoliday").InnerText))
                                {
                                    DateDisplay.ForeColor = Color.Red;
                                    TextColor = Color.Red;
                                }

                                Label SubjectDisplay = new Label()
                                {
                                    Text = nodes[index].SelectSingleNode("dateName").InnerText,
                                    Font = new Font("굴림", 9, FontStyle.Bold),
                                    ForeColor = TextColor,
                                    AutoSize = false,
                                    Location = new Point(20, 1),
                                    Size = new Size(80, 40)
                                };

                                panel.Controls.Add(SubjectDisplay);

                                index++;
                            }
                        }
                        */
                        #endregion

                        #region 사업 일정 체크
                        int count = 0;

                        while (indexTable < ds_schedule.Rows.Count && now.ToString("yyyy-MM-dd").Equals(ds_schedule.Rows[indexTable]["SCH_DT"].ToString()))
                        {
                            DataRow row = ds_schedule.Rows[indexTable];

                            Label ScheduleDisplay = new Label()
                            {
                                Text = row["SCH_TYPE_CD"].ToString().Substring(0, 1),
                                Font = new Font("굴림", 9, FontStyle.Bold),
                                ForeColor = TextColor,
                                BackColor = ClsSpread.lstColor[cbockPlan.GetItemIndex(row["SCH_TYPE_CD"].ToString())],
                                AutoSize = false,
                                BorderStyle = BorderStyle.FixedSingle,
                                Location = new Point((count % 5) * 20 + 10, (count / 5) * 20 + 40),
                                Size = new Size(20, 20),
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            if ("Y".Equals(row["DEL_YN"].ToString()))
                            {
                                ScheduleDisplay.Font = new Font("굴림", 9, FontStyle.Strikeout);
                                ScheduleDisplay.ForeColor = Color.Gray;
                            }

                            panel.Controls.Add(ScheduleDisplay);
                            panel.BackColor = Color.FromArgb(230, 230, 230);

                            indexTable++;
                            count++;
                        }

                        if (now.ToString("yyyy-MM-dd").Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                        {
                            panel.BackColor = Color.FromArgb(218, 227, 243);
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
            bInit = true;
        }

        private void BtnPreYear_Click(object sender, EventArgs e)
        {
            cal = cal.AddYears(-1);

            SetCalendar();
        }

        private void BtnNextYear_Click(object sender, EventArgs e)
        {
            cal = cal.AddYears(1);

            SetCalendar();
        }

        private void BtnPreMonth_Click(object sender, EventArgs e)
        {
            cal = cal.AddMonths(-1);

            SetCalendar();
        }

        private void BtnNextMonth_Click(object sender, EventArgs e)
        {
            cal = cal.AddMonths(1);

            SetCalendar();
        }

        private void SetTeamInfo(object sender, EventArgs e)
        {
            cbockUser.Params.Clear();
            cbockUser.Params.Add("strCompType", "M");
            cbockUser.Params.Add("strTeamCode", cbockTeam.ValueList);
            cbockUser.BindDataSet();

            cbockUser.SetItemChecked(DTOFactory.UserId);
        }

        private void SetUSerInfo(object sender, EventArgs e)
        {
            SetCalendar();
        }

        private void Calendar_Resize(object sender, EventArgs e)
        {
            int width = PnlCalendar.Width / 7;
            int height = (PnlCalendar.Height - 50) / 5;

            for (int i = 0; i < 7; i++)
            {
                PnlCalendar.Controls[string.Format("Lb{0}", ArrWeek[i])].Width = width;
                PnlCalendar.Controls[string.Format("Lb{0}", ArrWeek[i])].Location = new Point(i * width, 30);

                for (int j=1; j <= 5; j++)
                {
                    PnlCalendar.Controls[string.Format("Week_{0}_{1}", j, ArrWeek[i])].Width = width;
                    PnlCalendar.Controls[string.Format("Week_{0}_{1}", j, ArrWeek[i])].Height = height;
                    PnlCalendar.Controls[string.Format("Week_{0}_{1}", j, ArrWeek[i])].Location = new Point(i * width, (j - 1) * height + 50);
                }
            }
        }

        private void SetSchedule(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            string date = pnl.Controls["FullString"].Text;

            int x = pnl.Location.X + 50 + pnlSetSchedule.Width > PnlCalendar.Width ? PnlCalendar.Width - pnlSetSchedule.Width - 10 : pnl.Location.X + 50;
            
            pnlSetSchedule.Location = new Point(x, pnl.Location.Y + 10);
            dtTime.Value = DateTime.Parse(date + DateTime.Now.AddHours(1).ToString(" HH:00:00"));
            cboItem.SetItemChecked("");
            txtDesc.Text = "";

            _dtSelSch.Rows.Clear();

            foreach (DataGridViewRow row in gd_list.Rows)
            {
                if (row.Cells["SCH_TM"].Value.ToString().Substring(0, 10).Equals(date))
                {
                    DataRow dr = _dtSelSch.NewRow();

                    dr["SCH_TIME"] = row.Cells["SCH_TM"].Value.ToString().Substring(10);
                    dr["SCH_TYPE"] = row.Cells["SCH_TYPE_CD"].Value.ToString();
                    dr["SCH_DESC"] = row.Cells["SCH_DESC"].Value.ToString();

                    _dtSelSch.Rows.Add(dr);
                }
            }

            pnlSetSchedule.Visible = true;
        }

        private void BtnClose(object sender, EventArgs e)
        {
            pnlSetSchedule.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ClearSearchData();

            if ("".Equals(cboItem.ValueList))
            {
                ViewMessage.Info("항목을 선택하시기 바랍니다.");
            }
            else
            {
                bool bNew = true;
                string chkTime = dtTime.Value.ToString("HH:mm:ss");

                foreach (DataRow row in _dtSelSch.Rows)
                {
                    if (chkTime.Equals(row["SCH_TIME"].ToString().Trim()))
                        bNew = false;
                }

                if (bNew)
                {
                    SetSearchData("USER_ID", DTOFactory.UserId);
                    SetSearchData("SCH_TM", dtTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    SetSearchData("PLAN_CD", cboItem.ValueList);                    
                    SetSearchData("DESC", txtDesc.Text);
                    SetServiceId("SetSchedule");

                    try
                    {
                        DTOFactory.Transaction(new MemberDTO());

                        ViewMessage.Info("일정을 등록하였습니다.");
                        pnlSetSchedule.Visible = false;

                        SetCalendar();
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
                else
                {
                    ViewMessage.Warning("동일한 시간에 일정이 등록되어 있습니다.");
                }
            }
        }

        private void SetMenu(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit;

            if (e.Button == MouseButtons.Right)
            {
                hit = gd_list.HitTest(e.X, e.Y);

                int row = hit.RowIndex < 0 ? 0 : hit.RowIndex;

                gd_list.Rows[row].Selected = true;

                ContextMenuStrip m = new ContextMenuStrip();

                m.Items.Add("일정 수정");
                m.Items.Add("일정 취소");

                m.ItemClicked += new ToolStripItemClickedEventHandler(ScheduleUpdate);

                m.Show(gd_list, new Point(e.X, e.Y));
            }
        }

        private void ScheduleUpdate(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "일정 수정":
                    string desc = Microsoft.VisualBasic.Interaction.InputBox("변경할 일정 내용을 입력 하시오.", "일정 수정", gd_list.SelectedRows[0].Cells["SCH_DESC"].Value.ToString());

                    if (!"".Equals(desc))
                    {
                        ClearSearchData();
                        SetSearchData("USER_ID", DTOFactory.UserId);
                        SetSearchData("SCH_TM", gd_list.SelectedRows[0].Cells["SCH_TM"].Value);
                        SetSearchData("WORK_CD", gd_list.SelectedRows[0].Cells["DEL_YN"].Value);
                        SetSearchData("DESC", desc);
                        SetServiceId("UpdateSchedule");

                        try
                        {
                            DTOFactory.Transaction(new MemberDTO());

                            ViewMessage.Info("일정 내용을 수정 하였습니다.");
                            SetCalendar();
                        }
                        catch (Exception ex)
                        {
                            ViewMessage.Error(ex.Message);
                        }
                    }
                    break;
                case "일정 취소":
                    if (System.Windows.Forms.MessageBox.Show(
                    "해당 일정을 취소 하시겠습니까?\r\n(타인의 일정은 취소 할 수 없습니다.)", "일정 취소"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearSearchData();
                        SetSearchData("USER_ID", DTOFactory.UserId);
                        SetSearchData("SCH_TM", gd_list.SelectedRows[0].Cells["SCH_TM"].Value);
                        SetServiceId("DisableSchedule");

                        try
                        {
                            DTOFactory.Transaction(new MemberDTO());

                            ViewMessage.Info("일정을 취소 하였습니다.");
                            SetCalendar();
                        }
                        catch(Exception ex)
                        {
                            ViewMessage.Error(ex.Message);
                        }
                    }
                    break;
            }
        }

        private void ViewToday(object sender, EventArgs e)
        {
            cal = DateTime.Parse(string.Format("{0}년 {1}월 01일", DateTime.Now.Year, DateTime.Now.Month));

            SetCalendar();
        }
    }
}
