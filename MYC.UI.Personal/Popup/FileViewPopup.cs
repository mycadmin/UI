using System;
using System.Data;
using System.Windows.Forms;
using MYC.Control;
using MYC.Sender;
using MYC.UI.DTO;

namespace MYC.UI.Personal.Popup
{
    public partial class FileViewPopup : MYCForm
    {
        public bool LOCK { get; set; }
        public string LINK_CD { get; set; }
        protected DataTable dt_file = new DataTable();

        public FileViewPopup()
        {
            InitializeComponent();
        }

        private void FileViewPopup_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = LOCK;
            btnDel.Enabled = LOCK;

            GetFileInfo();
        }

        private void GetFileInfo()
        {
            ClearSearchData();
            SetSearchData("LINK_CD", LINK_CD);
            SetServiceId("GetFileLink");

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                dt_file = DTOFactory.GetDataTable();

                lstFile.DataSource = dt_file;
                lstFile.DisplayMember = "FILE_DESC";
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void AddLink(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();            
            frm.Filter = "";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                FileSender snd = new FileSender(LINK_CD, frm.FileName);
                snd.Close();

                GetFileInfo();
            }
        }

        private void ViewLink(object sender, EventArgs e)
        {
            FileGet get = new FileGet(dt_file.Rows[lstFile.SelectedIndex]["LINK"].ToString());
            get.Close();
        }

        private void RemoveLink(object sender, EventArgs e)
        {
            if (lstFile.SelectedIndex == -1)
                return;

            DataRow row = dt_file.Rows[lstFile.SelectedIndex];

            if (System.Windows.Forms.MessageBox.Show(
                row["FILE_DESC"] + " File을 삭제 하시겠습니까?", "File 제거"
                , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FileSender snd = new FileSender(LINK_CD, row["LINK"].ToString(), false);
                snd.Close();

                dt_file.Rows.RemoveAt(lstFile.SelectedIndex);
            }
        }

        private void FormClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LstFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFile.SelectedIndex > -1)
            {
                btnView.Enabled = true;
            }
        }
    }
}
