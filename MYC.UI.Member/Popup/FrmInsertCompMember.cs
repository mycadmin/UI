using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MYC.Control;

namespace MYC.UI.Member.Popup
{
    public partial class FrmInsertCompMember : MYCForm
    {
        public string UserName { get; set; }
        public string Grade { get; set; }
        public string Tel { get; set; }
        public string Line { get; set; }
        public string Work { get; set; }
        public string Mail { get; set; }

        public FrmInsertCompMember()
        {
            InitializeComponent();
        }

        private void Form_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void DataSend(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://www.my-c.kr/bbs/get_browser_info.php");
            request.Method = "POST";
            string postData = string.Format("mb_password={0}&browser=MYC", "입사일");

            byte[] postArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(postArray, 0, postArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();

            string responseFromServer = "";
            using (dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }
            response.Close();

            if (responseFromServer == null)
                responseFromServer = "";

            //responseFromServer; << 비밀번호

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
