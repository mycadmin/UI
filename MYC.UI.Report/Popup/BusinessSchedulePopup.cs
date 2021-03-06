﻿using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Sender;
using MYC.UI.DTO;

namespace MYC.UI.Report
{
    public partial class BusinessSchedulePopup : MYCForm
    {

        public string DOC_ID { get; set; }
        public string DOC_NM { get; set; }
        public string USER_ID { get; set; }
        public string SCH_ID { get; set; }
        public string SCH_DESC { get; set; }
        public DateTime DATE { get; set; }
        public bool ScheduleFix { get; set; }
        public BusinessSchedulePopup()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BusinessSchedulePopup_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void InitControl()
        {
            cboUser.Params.Clear();
            cboUser.Params.Add("strCompType", "M");
            cboUser.BindDataSet();

            cboPlan.Params.Clear();
            cboPlan.Params.Add("strItem", "BUSINESS_CODE");
            cboPlan.BindDataSet();

            txtSubject.Text = DOC_NM;

            if (ScheduleFix)
            {
                cboUser.SetItemChecked(USER_ID);
                cboPlan.Text = SCH_DESC;
                dtCreateTime.Value = DATE;
                cboPlan.Enabled = false;
            }
            else
            {
                dtCreateTime.Value = DateTime.Now;
            }
        }

        private void InsertData(object sender, EventArgs e)
        {
            if (ScheduleFix)
            {
                if ("".Equals(cboUser.ValueList))
                {
                    ViewMessage.Info("담당자와 내용을 선택해 주시기 바랍니다.");
                }
                else
                {
                    ClearSearchData();
                    SetSearchData("DOC_ID", DOC_ID);
                    SetSearchData("ACCEPT_TM", DATE.ToString("yyyy-MM-dd HH:mm:ss"));
                    SetSearchData("PROC_TM", dtCreateTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    SetSearchData("USER_ID_LST", cboUser.ValueList);
                    SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                    SetServiceId("SetScheduleManager");

                    DTOFactory.Transaction(new ReportDTO());

                    ViewMessage.Info("일정 수정을 완료 하였습니다.");

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                if ("".Equals(cboUser.ValueList) || "".Equals(cboPlan.ValueList))
                {
                    ViewMessage.Info("담당자와 내용을 선택해 주시기 바랍니다.");
                }
                else
                {

                    ClearSearchData();
                    SetSearchData("DOC_ID", DOC_ID);
                    SetSearchData("ACCEPT_TM", dtCreateTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    SetSearchData("USER_ID_LST", cboUser.ValueList);
                    SetSearchData("DESC", cboPlan.ValueList);
                    SetSearchData("CRT_USER_ID", DTOFactory.UserId);
                    SetServiceId("SetScheduleManager");

                    DTOFactory.Transaction(new ReportDTO());

                    ViewMessage.Info("일정 등록을 완료 하였습니다.");

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
