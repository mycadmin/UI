using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYC.UI.Member.Popup
{
    public partial class FrmInsertGovMember : Form
    {
        public string UserName { get; set; }
        public string Grade { get; set; }
        public string Tel { get; set; }
        public string Line { get; set; }
        public string Work { get; set; }
        public string Mail { get; set; }

        public FrmInsertGovMember()
        {
            InitializeComponent();
        }

        private void Form_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void DataSend(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UserName_TextChange(object sender, EventArgs e)
        {
            UserName = txtUserName.Text;
        }

        private void Grade_TextChange(object sender, EventArgs e)
        {
            Grade = txtGrade.Text;
        }

        private void Work_TextChange(object sender, EventArgs e)
        {
            Work = txtWork.Text;
        }

        private void Tel_TextChange(object sender, EventArgs e)
        {
            Tel = txtTel.Text;
        }

        private void Mail_TextChange(object sender, EventArgs e)
        {
            Mail = txtMail.Text;
        }

        private void Line_TextChange(object sender, EventArgs e)
        {
            Line = txtLine.Text;
        }
    }
}
