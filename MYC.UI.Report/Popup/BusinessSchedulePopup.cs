using System;
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

            dtCreateTime.Value = DateTime.Now;

            txtSubject.Text = DOC_NM;
        }

        private void InsertData(object sender, EventArgs e)
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
