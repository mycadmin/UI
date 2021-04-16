using MYC.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYC.UI.Machine.Popup
{
    public partial class DocumentConfirmPopup : MYCForm
    {
        public DataTable dt_list { get; set; }
        public DocumentConfirmPopup()
        {
            InitializeComponent();
        }

        private void DocumentConfirmPopup_Load(object sender, EventArgs e)
        {
            gd_List.DataSource = dt_list;
        }
    }
}
