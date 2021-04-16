using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MYC.Control;
using System.Windows.Forms;

namespace MYC.UI.Personal
{
    public partial class WorkStatus : MYCControl
    {
        public WorkStatus()
        {
            InitializeComponent();
        }

        private void WorkStatus_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            cboYear.Items.Clear();

            for(int year = 2020;year <= DateTime.Now.Year;year++)
            {
                cboYear.Items.Add(year);
            }

            cboYear.SelectedIndex = cboYear.Items.Count - 1;
        }
    }
}
