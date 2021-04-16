using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.UI.DTO;

namespace MYC.UI.Member.Popup
{
    public partial class FrmInsertGovComp : MYCForm
    {
        public string CompName { get; set; }
        public string AddrCode { get; set; }
        public string Addr { get; set; }
        public string HomePage { get; set; }

        public FrmInsertGovComp()
        {
            InitializeComponent();
        }

        private void FrmInsertGovComp_Load(object sender, EventArgs e)
        {
            InitDataTable();
        }

        private void InitDataTable()
        {
        }

        private void CompCheck(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("COMP_NAME", txtCompName);
            SetSearchData("COMP_TYPE", "G");

            SetServiceId("GetCompInfo");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataTable dt = DTOFactory.GetDataTable("ds_comp");

                if (dt.Rows.Count > 0)
                {
                    ViewMessage.Info("이미 등록된 기관명 입니다.");
                }
                else
                {
                    ViewMessage.Info("등록이 가능한 기관명 입니다.");
                    btnInsert.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void CompName_TextChanged(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
        }

        private void AddCompInfo(object sender, EventArgs e)
        {
            CompName = txtCompName.Text;
            AddrCode = txtAddrCode.Text;
            Addr = txtAddr.Text;
            HomePage = txtHomePage.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
