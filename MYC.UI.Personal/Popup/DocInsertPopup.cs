using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Personal.Popup
{
    public partial class DocInsertPopup : MYCForm
    {
        protected bool Details = false;

        protected DataTable dt_Detail = new DataTable();
        protected DataTable dt_Import = new DataTable();

        public string DOC_TYP_CD { get; set; }
        public DocInsertPopup()
        {
            InitializeComponent();
        }

        private void DocInsertPopup_Load(Object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitControls();

            DTOFactory.Complete();
        }

        private void InitControls()
        {
            cboType.Params.Clear();
            cboType.Params.Add("strItem", "DOC_TYPE");
            cboType.BindDataSet();
            cboType.SetItemChecked(DOC_TYP_CD);

            cboLval.Params.Clear();
            cboLval.Params.Add("strCompType", "M");
            cboLval.BindDataSet();
        }

        private void DocumentSelect()
        {
            cboDocSlt.Params.Clear();
            cboDocSlt.Params.Add("strUserId", DTOFactory.UserId);
            cboDocSlt.Params.Add("strDocType", "21");
            cboDocSlt.Params.Add("strDocType2", cboType.ValueList);
            cboDocSlt.BindDataSet();
        }

        //cboType별 Enable 관리
        private void EnableControls(Object sender, EventArgs e)
        {
            cboDocSlt.Text = "[SELECT]";

            switch (cboType.ValueList)
            {
                #region 재직/경력
                //재직 증명서
                case "01":
                //경력 증명서
                case "02":
                    dtStart.CustomFormat = "yyyy년 MM월 dd일 dddd";
                    dtEnd.CustomFormat = "yyyy년 MM월 dd일 dddd";
                    dtStart.Enabled = false;
                    dtEnd.Enabled = false;
                    cboLval.Enabled = false;
                    txtSite.Enabled = false;
                    txtSub.Enabled = false;
                    btnDetails.Enabled = false;
                    txtDocDesc.Enabled = true;
                    btnSave.Enabled = true;
                    cboDocSlt.Enabled = false;
                    Details = false;

                    txtSite.Text = "";
                    txtSub.Text = "";
                    txtDocDesc.Text = "";
                    break;
                #endregion

                #region 반차
                case "15":
                case "16":
                    dtStart.CustomFormat = "yyyy년 MM월 dd일 HH시";
                    dtEnd.CustomFormat = "yyyy년 MM월 dd일 HH시";
                    dtStart.Enabled = true;
                    dtEnd.Enabled = true;
                    cboLval.Enabled = false;
                    txtSite.Enabled = false;
                    txtSub.Enabled = false;
                    btnDetails.Enabled = false;
                    txtDocDesc.Enabled = true;
                    btnSave.Enabled = true;
                    cboDocSlt.Enabled = false;
                    Details = false;

                    txtSite.Text = "";
                    txtSub.Text = "";
                    txtDocDesc.Text = "";

                    TimeSet();
                    break;
                #endregion

                #region 근태
                //근태 신청서
                case "11":
                case "12":
                case "13":
                case "14":
                case "17":
                case "18":
                case "19":
                    dtStart.CustomFormat = "yyyy년 MM월 dd일 dddd";
                    dtEnd.CustomFormat = "yyyy년 MM월 dd일 dddd";
                    dtStart.Enabled = true;
                    dtEnd.Enabled = true;
                    cboLval.Enabled = false;
                    txtSite.Enabled = false;
                    txtSub.Enabled = false;
                    btnDetails.Enabled = false;
                    txtDocDesc.Enabled = true;
                    btnSave.Enabled = true;
                    cboDocSlt.Enabled = false;
                    Details = false;
                    labAmount.Visible = false;
                    txtAmount.Visible = false;

                    txtSite.Text = "";
                    txtSub.Text = "";
                    txtDocDesc.Text = "";
                    break;
                #endregion

                #region 출장 계획서
                //출장 계획서
                case "21":
                    dtStart.Enabled = true;
                    dtEnd.Enabled = true;
                    cboLval.Enabled = true;
                    txtSite.Enabled = true;
                    txtSub.Enabled = true;
                    btnDetails.Enabled = true;
                    txtDocDesc.Enabled = true;
                    btnSave.Enabled = true;
                    cboDocSlt.Enabled = false;
                    Details = false;

                    txtSite.Text = "";
                    txtSub.Text = "";
                    txtDocDesc.Text = "";

                    //세부항목 visible
                    btnAdd.Visible = true;
                    dtSchedule.Visible = true;
                    labSchedule.Visible = true;
                    labItem.Visible = false;
                    cboItem.Visible = false;
                    labContent.Visible = true;
                    txtDesc.Visible = true;
                    gd_Details.Visible = true;
                    labItem2.Visible = false;
                    txtItem2.Visible = false;

                    btnAdd.Text = "추가";
                    DataTableSet();
                    break;
                #endregion

                #region 출장 완료
                //출장 완료 보고서
                case "22":
                    DocumentSelect();

                    dtStart.Enabled = false;
                    dtEnd.Enabled = false;
                    cboLval.Enabled = false;
                    txtSite.Enabled = false;
                    txtSub.Enabled = false;
                    btnDetails.Enabled = true;
                    txtDocDesc.Enabled = true;
                    btnSave.Enabled = true;
                    cboDocSlt.Enabled = true;
                    Details = false;

                    //세부항목 visible
                    btnAdd.Visible = true;
                    dtSchedule.Visible = true;
                    labSchedule.Visible = true;
                    labItem.Visible = false;
                    cboItem.Visible = false;
                    labContent.Visible = true;
                    txtDesc.Visible = true;
                    gd_Details.Visible = true;
                    labItem2.Visible = false;
                    txtItem2.Visible = false;
                    labAmount.Visible = false;
                    txtAmount.Visible = false;

                    btnAdd.Text = "수정";
                    DataTableSet();

                    break;
                #endregion

                #region 출장비 내역서
                //출장비 내역서
                case "23":
                    DocumentSelect();

                    dtStart.Enabled = false;
                    dtEnd.Enabled = false;
                    cboLval.Enabled = false;
                    txtSite.Enabled = false;
                    txtSub.Enabled = false;
                    btnDetails.Enabled = true;
                    txtDocDesc.Enabled = true;
                    btnSave.Enabled = true;
                    cboDocSlt.Enabled = true;
                    Details = false;

                    //세부항목
                    btnAdd.Visible = true;
                    dtSchedule.Visible = false;
                    labSchedule.Visible = false;
                    labItem.Visible = true;
                    cboItem.Visible = true;

                    cboItem.Items.Add("교통비");
                    cboItem.Items.Add("숙박비");
                    cboItem.Items.Add("식대");
                    cboItem.Items.Add("접대비");
                    cboItem.Items.Add("기타잡비");

                    labContent.Visible = false;
                    txtDesc.Visible = false;
                    gd_Details.Visible = true;
                    labItem2.Visible = true;
                    txtItem2.Visible = true;
                    labAmount.Visible = true;
                    txtAmount.Visible = true;

                    btnAdd.Text = "추가";
                    DataTableSet();
                    break;
                #endregion

                #region Delfault
                //비어있을때
                default:
                    dtStart.Enabled = false;
                    dtEnd.Enabled = false;
                    cboLval.Enabled = false;
                    txtSite.Enabled = false;
                    txtSub.Enabled = false;
                    btnDetails.Enabled = false;
                    txtDocDesc.Enabled = false;
                    btnSave.Enabled = false;
                    cboDocSlt.Enabled = false;
                    Details = false;
                    break;
                    #endregion
            }
            ExpandPopup();
        }

        private void DateTimeSet(object sender, EventArgs e)
        {
            dtEnd.Value = dtStart.Value.AddHours(6);
            dtSchedule.Value = dtStart.Value;
        }

        private void TimeSet()
        {
            if (cboType.ValueList == "15")
            {
                dtStart.Value = new DateTime(int.Parse(DateTime.Now.Year.ToString()), int.Parse(DateTime.Now.Month.ToString()), int.Parse(DateTime.Now.Day.ToString()), 9, 0, 0);
            }
            else if (cboType.ValueList == "16")
            {
                dtStart.Value = new DateTime(int.Parse(DateTime.Now.Year.ToString()), int.Parse(DateTime.Now.Month.ToString()), int.Parse(DateTime.Now.Day.ToString()), 12, 0, 0);
            }
        }

        private void SetdtEnd(object sender, EventArgs e)
        {
            int EndTime = int.Parse(dtEnd.Value.ToString("yyyyMMddHH"));
            int StartTime = int.Parse(dtStart.Value.ToString("yyyyMMddHH"));

            if (EndTime < StartTime)
            {
                dtEnd.Value = dtStart.Value;
                ViewMessage.Error("날짜가 올바르지 않습니다.");
            }
            //else if (cboType.ValueList == "15" || cboType.ValueList == "16")
            //{
            //    ViewMessage.Error("반차에선 불가능한 기능입니다.");
            //}
        }

        //Data보내기
        private void SaveDocument(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("DOC_TYP_CD", cboType.ValueList);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);
            switch (cboType.ValueList)
            {
                case "01":
                case "02":
                    SetSearchData("DOC_DESC", txtDocDesc.Text);
                    break;

                #region 반차
                case "15":
                case "16":
                    SetSearchData("START_TM", dtStart.Value.ToString("yyyy-MM-dd HH"));
                    SetSearchData("END_TM", dtEnd.Value.ToString("yyyy-MM-dd HH"));
                    SetSearchData("DOC_DESC", txtDocDesc.Text);
                    break;
                #endregion

                #region 반차 이외 근태
                case "11":
                case "12":
                case "13":
                case "14":
                case "17":
                case "18":
                case "19":
                    SetSearchData("START_TM", dtStart.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("END_TM", dtEnd.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("DOC_DESC", txtDocDesc.Text);
                    break;
                #endregion

                #region 출장
                case "21":
                    SetSearchData("START_TM", dtStart.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("END_TM", dtEnd.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("SUBJECT", txtSub.Text);
                    SetSearchData("USER_ID_LVAL", cboLval.ValueList);
                    SetSearchData("SITE_NM", txtSite.Text);
                    SetSearchData("DOC_DESC", txtDocDesc.Text);
                    break;
                #endregion

                #region 출장완료
                case "22":
                    SetSearchData("START_TM", dtStart.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("END_TM", dtEnd.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("SUBJECT", txtSub.Text);
                    SetSearchData("USER_ID_LVAL", cboLval.ValueList);
                    SetSearchData("SITE_NM", txtSite.Text);
                    SetSearchData("DOC_DESC", txtDocDesc.Text);
                    SetSearchData("DOC_ID", cboDocSlt.ValueList);
                    break;
                #endregion

                #region 출장비
                case "23":
                    SetSearchData("START_TM", dtStart.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("END_TM", dtEnd.Value.ToString("yyyy-MM-dd"));
                    SetSearchData("SUBJECT", txtSub.Text);
                    SetSearchData("USER_ID_LVAL", cboLval.ValueList);
                    SetSearchData("SITE_NM", txtSite.Text);
                    SetSearchData("DOC_DESC", txtDocDesc.Text);
                    SetSearchData("DOC_ID", cboDocSlt.ValueList);
                    break;
                    #endregion
            }

            switch (cboType.ValueList)
            {
                case "21":
                case "22":
                case "23":
                    DTOFactory.SetDTOTable("ds_list", dt_Detail.Copy());
                    break;

                default:
                    break;
            }
            SetServiceId("SetDocList");

            try
            {
                DTOFactory.Transaction(new DocDTO());

                DialogResult = DialogResult.OK;
                ViewMessage.Info("문서 등록이 완료 되었습니다.");
                Close();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void FormClose(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #region 출장관련 Detail

        #region PopupExand
        private void ShowDetails(object sender, EventArgs e)
        {
            if (!Details)
            {
                Details = true;
            }
            else
            {
                Details = false;
            }
            ExpandPopup();
        }

        private void ExpandPopup()
        {
            if (!Details)
            {
                Width = 570;
            }
            else
            {
                Width = 860;
            }
        }
        #endregion


        //DataTable 구조
        private void DataTableSet()
        {
            dt_Detail.Columns.Clear();
            dt_Detail.Rows.Clear();

            DataColumn col1 = new DataColumn();
            col1.DataType = Type.GetType("System.String");
            col1.ColumnName = "GRP_NM";
            dt_Detail.Columns.Add(col1);

            DataColumn col2 = new DataColumn();
            col2.DataType = Type.GetType("System.String");
            col2.ColumnName = "SUBJECT";
            dt_Detail.Columns.Add(col2);

            DataColumn col3 = new DataColumn();
            col3.DataType = Type.GetType("System.String");
            col3.ColumnName = "DOC_DESC";
            dt_Detail.Columns.Add(col3);

            gd_Details.DataSource = dt_Detail;

            switch (cboType.ValueList)
            {
                //출장 계획서 DT구성
                case "21":
                    gd_Details.Columns[0].HeaderText = "일자";
                    gd_Details.Columns[2].HeaderText = "업무내용";

                    gd_Details.Columns["SUBJECT"].Visible = false;
                    break;

                case "22":
                    dt_Detail.Columns.Clear();
                    break;

                //출장비 내역서 
                case "23":
                    gd_Details.Columns[0].HeaderText = "항목";
                    gd_Details.Columns[1].HeaderText = "세부 항목";
                    gd_Details.Columns[2].HeaderText = "금액";

                    gd_Details.Columns["SUBJECT"].Visible = true;
                    break;
            }
        }


        //문서 참조 text 변경시
        private void DocImport(object sender, EventArgs e)
        {
            if (!"".Equals(cboDocSlt.ValueList))
            {
                ClearSearchData();
                SetSearchData("DOC_ID", cboDocSlt.ValueList.ToString());
                SetSearchData("DOC_TYP_CD", "21");

                SetServiceId("GetDocDetailItem");

                DTOFactory.Transaction(new DocDTO());
                DataSet ds21 = DTOFactory.GetDataSet();

                dt_Import = ds21.Tables["ds_doc"];

                #region 날짜 변환
                DateTime dt_start = new DateTime(int.Parse(dt_Import.Rows[0]["START_TM"].ToString().Substring(0, 4)), int.Parse(dt_Import.Rows[0]["START_TM"].ToString().Substring(5, 2)), int.Parse(dt_Import.Rows[0]["START_TM"].ToString().Substring(8, 2)));
                DateTime dt_end = new DateTime(int.Parse(dt_Import.Rows[0]["END_TM"].ToString().Substring(0, 4)), int.Parse(dt_Import.Rows[0]["END_TM"].ToString().Substring(5, 2)), int.Parse(dt_Import.Rows[0]["END_TM"].ToString().Substring(8, 2)));
                #endregion

                dtStart.Value = dt_start;
                dtEnd.Value = dt_end;
                txtSite.Text = dt_Import.Rows[0]["SITE_NM"].ToString();
                txtSub.Text = dt_Import.Rows[0]["SUBJECT"].ToString();
                txtDocDesc.Text = dt_Import.Rows[0]["DOC_DESC"].ToString();
                cboLval.SetItemChecked(dt_Import.Rows[0]["USER_ID_LVAL"].ToString());

                switch (cboType.ValueList)
                {
                    case "22":
                        txtDocDesc.Text = "";

                        dt_Detail.Columns.Clear();

                        ClearSearchData();
                        SetSearchData("DOC_ID", cboDocSlt.ValueList.ToString());
                        SetSearchData("DOC_TYP_CD", "21");

                        SetServiceId("GetDocDetailItem");

                        DTOFactory.Transaction(new DocDTO());
                        DataSet ds22 = DTOFactory.GetDataSet();

                        dt_Detail = ds22.Tables["ds_list"].Copy();
                        gd_Details.DataSource = dt_Detail;


                        gd_Details.Columns["DOC_ID"].Visible = false;
                        gd_Details.Columns["DOC_TYP_CD"].Visible = false;
                        gd_Details.Columns["SEQ_NO"].Visible = false;
                        gd_Details.Columns["SUBJECT"].Visible = false;

                        gd_Details.Columns[3].HeaderText = "일자";
                        gd_Details.Columns[5].HeaderText = "업무내용";

                        if (gd_Details.Rows.Count > 0)
                            DetailItemSelect(gd_Details, new DataGridViewCellEventArgs(0, 0));
                        break;
                }
            }
        }


        //DataTable 데이터 추가/수정
        private void DataUpdate(object sender, EventArgs e)
        {
            DataRow dr = dt_Detail.NewRow();

            switch (cboType.ValueList)
            {
                //출장 계획 보고서
                case "21":
                    if (dt_Detail.Rows.Count < 4) 
                    {
                        dr["GRP_NM"] = dtSchedule.Value.ToString("yyyy-MM-dd");
                        dr["SUBJECT"] = "";
                        dr["DOC_DESC"] = txtDesc.Text;
                        dt_Detail.Rows.Add(dr);
                        txtDesc.Text = "";
                    }
                    else
                    {
                        ViewMessage.Warning("항목은 4개까지 입력가능합니다.");
                        txtDesc.Text = "";
                    }
                    break;
                //출장 완료 보고서
                case "22":
                    int row = gd_Details.SelectedRows[0].Index;

                    dt_Detail.Rows[row]["GRP_NM"] = dtSchedule.Value.ToString("yyyy-MM-dd");
                    dt_Detail.Rows[row]["DOC_DESC"] = txtDesc.Text;
                    break;

                //출장비 내역서
                case "23":
                    if (dt_Detail.Rows.Count < 14)
                    {
                        dr["GRP_NM"] = cboItem.Text;
                        dr["SUBJECT"] = txtItem2.Text;
                        dr["DOC_DESC"] = txtAmount.Text;
                        dt_Detail.Rows.Add(dr);

                        txtItem2.Text = "";
                        txtAmount.Text = "";
                    }
                    else
                    {
                        ViewMessage.Warning("항목은 14개까지 입력 가능합니다.");
                        txtDesc.Text = "";
                    }

                    break;

            }
        }

        private void DetailItemSelect(object sender, DataGridViewCellEventArgs e)
        {

            if ("22".Equals(cboType.ValueList.ToString()))
            {
                if (e.RowIndex > -1)
                {
                    int row = e.RowIndex;

                    //[row]["GRP_NM"]으로 하면 안먹힘 이유를 모르겠음 row의 형식문제?
                    DateTime dt_Schedule = new DateTime(int.Parse(dt_Detail.Copy().Rows[index: row]["GRP_NM"].ToString().Substring(0, 4)), int.Parse(dt_Detail.Copy().Rows[index: row]["GRP_NM"].ToString().Substring(5, 2)), int.Parse(dt_Detail.Copy().Rows[index: row]["GRP_NM"].ToString().Substring(8, 2)));

                    dtSchedule.Value = dt_Schedule;
                    txtDesc.Text = dt_Detail.Copy().Rows[row]["DOC_DESC"].ToString();
                }
            }
        }
        #endregion
    }
}
