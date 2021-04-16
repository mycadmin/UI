using System;
using System.Data;
using System.Windows.Forms;

namespace MYC.UI.Member.Popup
{
    public partial class FrmInsertVendorComp : Form
    {
        public string CompName { get; set; }
        public string Regid { get; set; }
        public string UserName { get; set; }
        public string Grade { get; set; }
        public string CompType { get; set; }
        public string SiteName { get; set; }
        public string AddrCode { get; set; }
        public string Addr { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public string Mail { get; set; }
        public string BankCode { get; set; }
        public string BankNo { get; set; }
        public string FILE1 { get; set; }
        public string FILE2 { get; set; }
        public string FILE3 { get; set; }
        public string FILE4 { get; set; }


        protected DataTable _dtSearch = new DataTable();

        public FrmInsertVendorComp()
        {
            InitializeComponent();
        }

        private void FrmInsertVendorComp_Load(object sender, System.EventArgs e)
        {
            InitDataTable();
            InitControl();
        }

        private void InitDataTable()
        {
            _dtSearch.Columns.Add("FIELD");
            _dtSearch.Columns.Add("DATA");
        }

        private void InitControl()
        {
            txtCompName.Text = CompName;
            txtRegId.Text = Regid;
            txtUserName.Text = UserName;
            txtGrade.Text = Grade;
            txtCompType.Text = CompType;
            txtSite.Text = SiteName;
            txtAddrCode.Text = AddrCode;
            txtAddr.Text = Addr;
            txtTel.Text = Tel;
            txtFax.Text = Fax;
            txtHomePage.Text = HomePage;
            txtMail.Text = Mail;
            txtBankCode.Text = BankCode;
            txtBankNo.Text = BankNo;

            FILE1 = "";
            FILE2 = "";
            FILE3 = "";
            FILE4 = "";
        }

        private void AddCompInfo(object sender, EventArgs e)
        {
            CompName = txtCompName.Text;
            Regid = txtRegId.Text;
            UserName = txtUserName.Text;
            Grade = txtGrade.Text;
            CompType = txtCompType.Text;
            SiteName = txtSite.Text;
            AddrCode = txtAddrCode.Text;
            Addr = txtAddr.Text;
            Tel = txtTel.Text;
            Fax = txtFax.Text;
            HomePage = txtHomePage.Text;
            Mail = txtMail.Text;
            BankCode = txtBankCode.Text;
            BankNo = txtBankNo.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void File_1_Open(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                FILE1 = frm.FileName;
            }
        }

        private void File_2_Open(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                FILE2 = frm.FileName;
            }
        }

        private void File_3_Open(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                FILE3 = frm.FileName;
            }
        }

        private void File_4_Open(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                FILE4 = frm.FileName;
            }
        }
    }
}
