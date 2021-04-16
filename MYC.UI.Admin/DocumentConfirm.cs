using MYC.Control;
using MYC.UI.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace MYC.UI.Admin
{
    public partial class DocumentConfirm : MYCControl
    {
        protected DataTable dt_Detail = new DataTable();
        protected DataTable dt_Grid = new DataTable();

        public DocumentConfirm()
        {
            InitializeComponent();
        }

        private void DocumentConfirm_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitSpread();
            InitControls();
            Search(null, null);

            DTOFactory.Complete();
        }

        private void InitSpread()
        {
            gd_List.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void InitControls()
        {
            #region 조회 조건
            dtFrom.Value = DateTime.Now.AddDays(-7);
            dtTo.Value = DateTime.Now;

            cboDocType.Params.Clear();
            cboDocType.Params.Add("strItem", "DOC_TYPE");
            cboDocType.BindDataSet();

            cboCrtUser.Params.Clear();
            cboCrtUser.Params.Add("strCompType", "M");
            cboCrtUser.BindDataSet();
            #endregion
        }

        private void Search(object sender, EventArgs e)
        {
            if (cbAll.Checked == false)
            {
                ClearSearchData();
                SetSearchData("USER_ID", "100000");
                SetSearchData("START_TM", dtFrom.Value.ToString("yyyy-MM-dd"));
                SetSearchData("END_TM", dtTo.Value.ToString("yyyy-MM-dd"));
                SetSearchData("DOC_TYP_CD", cboDocType.ValueList);
                SetSearchData("CRT_USER_ID", cboCrtUser.ValueList);
            }
            else
            {
                ClearSearchData();
                SetSearchData("USER_ID", "100000");
                SetSearchData("DOC_TYP_CD", cboDocType.ValueList);
                SetSearchData("CRT_USER_ID", cboCrtUser.ValueList);
            }

            SetServiceId("GetConfirmList");

            DTOFactory.Action();

            try
            {
                DTOFactory.Transaction(new DocDTO());
                DataSet ds = DTOFactory.GetDataSet();

                gd_List.DataSource = ds.Tables["ds_list"];

                gd_List.SetGridColumn(ds.Tables["ds_column"]);

                if (gd_List.Rows.Count > 0)
                    ViewDocumentList(gd_List, new DataGridViewCellEventArgs(0, 0));

            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }

            DTOFactory.Complete();
        }

        private void ViewDocumentList(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                ClearSearchData();
                SetSearchData("USER_ID", "100000");
                SetSearchData("DOC_ID", row.Cells["DOC_ID"].Value);
                SetSearchData("DOC_TYP_CD", row.Cells["DOC_TYP_CD"].Value);

                SetServiceId("GetConfirmItem");

                DTOFactory.Transaction(new DocDTO());
                DataSet ds = DTOFactory.GetDataSet();

                dt_Detail = ds.Tables["ds_list"];

                txtDocType.Text = dt_Detail.Rows[0]["DOC_TYP_NM"].ToString();
                dtStart.Value = !"".Equals(dt_Detail.Rows[0]["START_TM"].ToString()) ? new DateTime(int.Parse(dt_Detail.Rows[0]["START_TM"].ToString().Substring(0, 4)), int.Parse(dt_Detail.Rows[0]["START_TM"].ToString().Substring(5, 2)), int.Parse(dt_Detail.Rows[0]["START_TM"].ToString().Substring(8, 2))) : DateTime.Now;
                dtEnd.Value = !"".Equals(dt_Detail.Rows[0]["END_TM"].ToString()) ? new DateTime(int.Parse(dt_Detail.Rows[0]["END_TM"].ToString().Substring(0, 4)), int.Parse(dt_Detail.Rows[0]["END_TM"].ToString().Substring(5, 2)), int.Parse(dt_Detail.Rows[0]["END_TM"].ToString().Substring(8, 2))) : DateTime.Now;
                txtNote.Text = dt_Detail.Rows[0]["DOC_ID"].ToString();
                txtSub.Text = dt_Detail.Rows[0]["SUBJECT"].ToString();
                txtSite.Text = dt_Detail.Rows[0]["SITE_NM"].ToString();
                txtLval.Text = dt_Detail.Rows[0]["USER_ID_LVAL"].ToString();
                txtDocDesc.Text = dt_Detail.Rows[0]["DOC_DESC"].ToString();

                ClearSearchData();
                SetSearchData("USER_ID", "100000");
                SetSearchData("DOC_ID", row.Cells["DOC_ID"].Value);
                SetSearchData("DOC_TYP_CD", row.Cells["DOC_TYP_CD"].Value);

                SetServiceId("GetConfirmItem");

                DTOFactory.Transaction(new DocDTO());
                DataSet ds2 = DTOFactory.GetDataSet();

                dt_Grid = ds2.Tables["ds_item"].Copy();
                gd_Detail.DataSource = dt_Grid;

                switch (dt_Detail.Rows[0]["DOC_TYP_CD"])
                {
                    case "21":
                    case "22":
                        gd_Detail.Columns[0].HeaderText = "일자";
                        gd_Detail.Columns[2].HeaderText = "업무내용";

                        gd_Detail.Columns[1].Visible = false;
                        break;

                    case "23":
                        gd_Detail.Columns[0].HeaderText = "항목";
                        gd_Detail.Columns[1].HeaderText = "세부항목";
                        gd_Detail.Columns[2].HeaderText = "금액";

                        gd_Detail.Columns[1].Visible = true;
                        break;
                }
            }
        }

        private void ConfirmPopup(object sender, EventArgs e)
        {
            var frm = new Popup.DocConfirmPopup()
            {
                CRT_USER_ID = dt_Detail.Rows[0]["USER_NM"].ToString(),
                DOC_TYP_CD = dt_Detail.Rows[0]["DOC_TYP_CD"].ToString(),
                DOC_TYP_NM = dt_Detail.Rows[0]["DOC_TYP_NM"].ToString(),
                CRT_DATE = int.Parse(dt_Detail.Rows[0]["DOC_ID"].ToString().Substring(0, 8)).ToString(),
                DOC_ID = dt_Detail.Rows[0]["DOC_ID"].ToString(),
                EMAIL = dt_Detail.Rows[0]["EMAIL"].ToString()
            };
            frm.ShowDialog();

            Search(null, null);
        }
    }
}
