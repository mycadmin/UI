using System;
using System.Data;
using MYC.Control;
using System.Windows.Forms;
using MYC.Control.Common;

namespace MYC.UI.Project.Popup
{
    public partial class CustomerOrderInsertPopup : MYCForm
    {
        protected DataTable _dt = new DataTable();
        
        public CustomerOrderInsertPopup()
        {
            InitializeComponent();
        }

        private void CustomerOrderInsertPopup_Load(object sender, EventArgs e)
        {
            InitDataTable();
            InitSpread();
            InitControls();
        }

        private void InitDataTable()
        {
            _dt.Columns.Add("ITEM_NO");
            _dt.Columns.Add("MODEL_ID");
            _dt.Columns.Add("UNIT_COST");
            _dt.Columns.Add("QTY");
        }

        private void InitSpread()
        {
            gd_List.DataSource = _dt;

            gd_List.Columns[0].HeaderText = "관리번호";
            gd_List.Columns[1].HeaderText = "제품코드";
            gd_List.Columns[2].HeaderText = "단가";
            gd_List.Columns[3].HeaderText = "수량";

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn()
            {
                HeaderText = "관리",
                Name = "DELETE",
                Text = "삭제",
                UseColumnTextForButtonValue = true
            };

            gd_List.Columns.Add(btn1);
        }

        private void InitControls()
        {

        }
    }
}
