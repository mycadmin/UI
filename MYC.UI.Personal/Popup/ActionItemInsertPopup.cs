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
    public partial class ActionItemInsertPopup : MYCForm
    {
        public ActionItemInsertPopup()
        {
            InitializeComponent();
        }

        private void ActionItemInsertPopup_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitControls();

            DTOFactory.Complete();
        }

        private void InitControls()
        {
            cboActType1.Params.Clear();
            cboActType1.Params.Add("strItem", "ACTION_GROUP");
            cboActType1.BindDataSet();

            cboActType2.Params.Clear();

            cboActMember.Params.Clear();
            cboActMember.Params.Add("strCompType", "M");
            cboActMember.BindDataSet();

            cboActConfirm.Params.Clear();
            cboActConfirm.Params.Add("strCompType", "M");
            cboActConfirm.BindDataSet();

            dtActTarget.Value = DateTime.Now.AddDays(7);
        }

        private void GetType2(object sender, EventArgs e)
        {
            if (!"".Equals(cboActType1.Text))
            {
                cboActType2.Params.Clear();
                cboActType2.Params.Add("strItem", "ACTION_GROUP_" + cboActType1.ValueList);
                cboActType2.BindDataSet();
            }
        }

        private void FormClose(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Confirm(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("SUBJECT", txtActSubject.Text);
            SetSearchData("TYPE1", cboActType1.ValueList);
            SetSearchData("TYPE2", cboActType2.ValueList);
            SetSearchData("STATUS", "O");
            SetSearchData("ACT_USER_ID", cboActMember.ValueList);
            SetSearchData("CFM_USER_ID", cboActConfirm.ValueList);
            SetSearchData("USER_ID", DTOFactory.UserId);
            SetSearchData("TGT_TM", dtActTarget.Value.ToString("yyyy-MM-dd"));
            SetSearchData("END_TM", "");
            SetSearchData("DESC", txtMemo.Text);

            SetServiceId("CreateActionList");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                
                if (chkMail.Checked)
                {
                    Mail.Subject = "[업무 협조]" + txtActSubject.Text;
                    Mail.To = DTOFactory.GetDataTable().Rows[0]["EMAIL"].ToString();
                    Mail.IsDirect = true;

                    string strBody = "아래와 같이 업무 협조 요청을 드립니다.<br><hr>";
                    strBody += txtMemo.Text.Replace("\r\n", "<br>");

                    Mail.Send(strBody);
                }
                
                DialogResult = DialogResult.OK;
                ViewMessage.Info("등록이 완료 되었습니다.");
                Close();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);                
            }
        }
    }
}
