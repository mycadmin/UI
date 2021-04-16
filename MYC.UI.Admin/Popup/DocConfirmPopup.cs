using MYC.Control;
using MYC.UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYC.UI.Admin.Popup
{
    public partial class DocConfirmPopup : MYCForm
    {
        bool CFM = false;

        public string CRT_USER_ID { get; set; }
        public string DOC_TYP_CD { get; set; }
        public string DOC_TYP_NM { get; set; }
        public string CRT_DATE { get; set; }
        public string DOC_ID { get; set; }
        public string EMAIL { get; set; }

        public DocConfirmPopup()
        {
            InitializeComponent();
        }

        public void DocConfirmPopup_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        public void InitControls()
        {
            txtCrtUser.Text = CRT_USER_ID;
            txtDocType.Text = DOC_TYP_NM;

            DateTime crt_date = new DateTime(int.Parse(CRT_DATE.ToString().Substring(0, 4)), int.Parse(CRT_DATE.ToString().Substring(4, 2)), int.Parse(CRT_DATE.ToString().Substring(6, 2)));
            dtCrtDate.Value = crt_date;
        }

        public void Confirm(object sender, EventArgs e)
        {
            if (rdbConfirm.Checked || rdbReturn.Checked)
            {
                if (rdbConfirm.Checked)
                {
                    CFM = true;
                }

                string cfm_YN;
                string cfm_YN2;

                if (CFM == true)
                {
                    cfm_YN = "승인";
                    cfm_YN2 = "Y";
                }
                else
                {
                    cfm_YN = "반려";
                    cfm_YN2 = "N";
                }

                ClearSearchData();
                SetSearchData("STAT_CD", cfm_YN2);
                SetSearchData("DOC_DESC", txtCfm_DESC.Text);
                SetSearchData("DOC_ID", DOC_ID);
                SetSearchData("DOC_TYP_CD", DOC_TYP_CD);
                SetSearchData("USER_ID", "100000");

                SetServiceId("SetConfirmItem");

                try
                {
                    DTOFactory.Transaction(new DocDTO());

                Mail.Subject = "[문서 검토] " + txtDocType.Text + "("+ DOC_ID + ") - " + txtCrtUser.Text;
                Mail.To = EMAIL;
                Mail.IsDirect = true;

                string strBody = "하기의 사유로 문서가 " + cfm_YN + "되었습니다.<br><hr>";
                strBody += txtCfm_DESC.Text.Replace("\r\n", "<br>");

                Mail.Send(strBody);

                DialogResult = DialogResult.OK;
                    ViewMessage.Info("해당 문서가 검토되었습니다.");


            }
                catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }
            else
            {
                ViewMessage.Warning("승인 여부를 선택해주십시오.");
            }
        }

        private void FormClose(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
