using MYC.Control;
using MYC.Control.Common;
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

namespace MYC.UI.Report.Popup
{
    public partial class NewEstimatePopup : MYCForm
    {
        public NewEstimatePopup()
        {
            InitializeComponent();
        }

        private void NewEstimatePopup_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitControls();

            DTOFactory.Complete();
        }

        private void InitControls()
        {
            cboComp.Params.Clear();
            cboComp.Params.Add("strCompType", "C");
            cboComp.BindDataSet();

            cboCashType1.Params.Clear();
            cboCashType1.Params.Add("strItem", "PRICE_TYPE");
            cboCashType1.BindDataSet();

            cboCashType2.Params.Clear();
            cboCashType2.Params.Add("strItem", "CASH_TYPE");
            cboCashType2.BindDataSet();

            cboWarrType.Params.Clear();
            cboWarrType.Params.Add("strItem", "WARRANTY_TYPE");
            cboWarrType.BindDataSet();

            cboProject.Params.Clear();
            cboProject.Params.Add("strProject", "");
            cboProject.Params.Add("strUserId", "");
            cboProject.Params.Add("strStatus", "");
            cboProject.BindDataSet();

            cboSearchComp.Params.Clear();
            cboSearchComp.Params.Add("strCompType", "C");
            cboSearchComp.BindDataSet();

            dtFrom.Value = DateTime.Now.AddDays(-7);
            dtTo.Value = DateTime.Now;
        }

        private void KeyFilter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void SetPrice(object sender, EventArgs e)
        {
            TextBox ctl = (TextBox)sender;

            string strPrice = ctl.Text.Replace(",", "");

            ctl.Text = ClsSpread.GetPriceNum(strPrice);
            ctl.Select(ctl.Text.Length, 1);
        }

        private void SetCstUser(object sender, EventArgs e)
        {
            cboCstUser.Params.Clear();
            cboCstUser.Params.Add("strCompCode", cboComp.ValueList);
            cboCstUser.BindDataSet();
        }

        private void SetDocNM(object sender, EventArgs e)
        {
            cboDocNM.Params.Clear();
            cboDocNM.Params.Add("strStartTime", dtFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00");
            cboDocNM.Params.Add("strEndTime", dtTo.Value.ToString("yyyy-MM-dd") + " 23:59:59");
            cboDocNM.Params.Add("strCompCode", cboSearchComp.ValueList);
            cboDocNM.BindDataSet();

        }
        public void EstimateSave(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("FROM_DT", dtFrom.Value.ToString("yyyy/MM/dd"));
            SetSearchData("TO_DT", dtTo.Value.ToString("yyyy/MM/dd"));
            SetSearchData("CST_COMP_CD", cboComp.ValueList);
            SetSearchData("DOC_ID", "");
            SetSearchData("STATUS", cboDocNM.ValueList);
            SetSearchData("SUBJECT", txtSubject.Text);
            SetSearchData("CST_USER_ID", cboCstUser.ValueList);
            SetSearchData("PRO_ID", cboProject.ValueList);
            SetSearchData("COST", "".Replace(",", ""));
            SetSearchData("VAT", "".Replace(",", ""));
            SetSearchData("CASH_TYP_CD_1", cboCashType1.ValueList);
            SetSearchData("CASH_TYP_CD_2", cboCashType2.ValueList);
            SetSearchData("WARR_TYP_CD", cboWarrType.ValueList);
            SetSearchData("CRT_USER_ID", DTOFactory.UserId);

            SetServiceId("SetEstimateList");
            DTOFactory.Transaction(new ReportDTO());
            DataSet ds = DTOFactory.GetDataSet();

            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
