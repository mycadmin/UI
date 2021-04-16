using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Personal
{
    public partial class ActionItem : MYCControl
    {
        protected DataTable dt_item = new DataTable();

        public ActionItem()
        {
            InitializeComponent();
        }

        private void ActionItem_Load(object sender, EventArgs e)
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

            cboMemType.Params.Clear();
            cboMemType.Params.Add("strItem", "ACTION_CHECK");
            cboMemType.BindDataSet();
            cboMemType.SetItemCheckState(1, CheckState.Checked);

            cboMember.Params.Clear();
            cboMember.Params.Add("strCompType", "M");
            cboMember.BindDataSet();

            cboType1.Params.Clear();
            cboType1.Params.Add("strItem", "ACTION_GROUP");
            cboType1.BindDataSet();

            cboType2.Params.Clear();

            cboStatus.Params.Clear();
            cboStatus.Params.Add("strItem", "PROJECT_CODE");
            cboStatus.BindDataSet();
            #endregion

            #region Item 영역
            cboItmPer.Params.Clear();

            cboItmExePer.Params.Clear();
            cboItmExePer.Params.Add("strFirst", "0");
            cboItmExePer.Params.Add("strCount", "5");
            cboItmExePer.Params.Add("strPer", "100");
            cboItmExePer.BindDataSet();

            cboItmStatus.Params.Clear();
            cboItmStatus.Params.Add("strItem", "ACTION_RESULT");
            cboItmStatus.BindDataSet();
            #endregion
        }

        private void NewActionItem(object sender, EventArgs e)
        {
            var frm = new Popup.ActionItemInsertPopup();
            frm.ShowDialog();
        }

        private void GetType2(object sender, EventArgs e)
        {
            if (!"".Equals(cboType1.Text))
            {
                cboType2.Params.Clear();
                cboType2.Params.Add("strItem", "ACTION_GROUP_" + cboType1.ValueList);
                cboType2.BindDataSet();
            }
        }

        private void Search(object sender, EventArgs e)
        {
            ClearSearchData();
            SetSearchData("START_TM", dtFrom.Value.ToString("yyyy-MM-dd"));
            SetSearchData("END_TM", dtTo.Value.ToString("yyyy-MM-dd"));
            SetSearchData("TGT_TM", rdCrt.Checked ? "0" : "1");
            SetSearchData("TYPE1", cboType1.ValueList);
            SetSearchData("TYPE2", cboType2.ValueList);
            SetSearchData("STATUS", cboStatus.ValueList);

            switch (cboMemType.ValueList)
            {
                case "01":
                    SetSearchData("USER_ID", cboMember.ValueList);
                    break;
                case "02":
                    SetSearchData("ACT_USER_ID", cboMember.ValueList);
                    break;
                case "03":
                    SetSearchData("CFM_USER_ID", cboMember.ValueList);
                    break;
                default:
                    break;
            }

            SetServiceId("GetActionList");

            DTOFactory.Action();

            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                gd_List.DataSource = ds.Tables["ds_list"];

                if (!gd_List.LabelDisplayed)
                {
                    gd_List.SetGridColumn(ds.Tables["ds_column"]);

                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn()
                    {
                        Text = "검토완료",
                        HeaderText = "관리",
                        Name = "CONFIRM",
                        UseColumnTextForButtonValue = true
                    };
                    gd_List.Columns.AddRange(bt);
                }

                foreach (DataGridViewRow row in gd_List.Rows)
                {
                    row.Cells["NO"].Value = row.Index + 1;
                    string tgt = row.Cells["TGT_TM"].Value.ToString();
                    DateTime target = new DateTime(int.Parse(tgt.Substring(0, 4)), int.Parse(tgt.Substring(5, 2)), int.Parse(tgt.Substring(8, 2)));

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (DateTime.Now > target)
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            cell.Style.ForeColor = Color.Black;
                        }

                        if ("종료".Equals(row.Cells["ACT_STATUS"].Value))
                        {
                            cell.Style.BackColor = Color.LightGray;
                        }
                    }
                }
                if (gd_List.Rows.Count > 0)
                    ViewActionDetail(gd_List, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }

            DTOFactory.Complete();
        }

        private void ActionItemConfirm(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                if ("검토완료".Equals(row.Cells[e.ColumnIndex].Value))
                {
                    if ("종료".Equals(row.Cells["ACT_STATUS"].Value))
                    {
                        ViewMessage.Warning("이미 검토가 끝난 항목 입니다.");
                    }
                    else if (!DTOFactory.UserId.Equals(row.Cells["CFM_USER_ID"].Value))
                    {
                        ViewMessage.Warning("해당 Action Item에 대한 검토 권한이 없습니다.");
                    }
                    else
                    {
                        ClearSearchData();
                        SetSearchData("WORK_CD", row.Cells["ACT_ID"].Value);
                        SetSearchData("END_TM", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        SetSearchData("STATUS", "C");
                        SetSearchData("USER_ID", DTOFactory.UserId);

                        SetServiceId("SetActionItemConfirm");

                        try
                        {
                            DTOFactory.Action();
                            DTOFactory.Transaction(new MemberDTO());

                            Mail.Subject = "[검토 완료]" + row.Cells["SUBJECT"].Value;
                            Mail.To = row.Cells["EMAIL"].Value.ToString();
                            Mail.IsDirect = true;

                            string strBody = "해당 건에 대한 검토가 완료 되었습니다.<br>수고하셨습니다.";
                            Mail.Send(strBody);

                            row.Cells["ACT_STATUS"].Value = "종료";
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.Style.BackColor = Color.LightGray;
                                cell.Style.ForeColor = Color.Black;
                            }

                            DTOFactory.Complete();
                            ViewMessage.Info("Action Item검토가 완료 되었습니다.");
                        }
                        catch (Exception ex)
                        {
                            DTOFactory.Complete();
                            ViewMessage.Error(ex.Message);
                        }
                    }
                }
            }
        }

        private void ViewActionDetail(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                if (!"검토완료".Equals(row.Cells[e.ColumnIndex].Value))
                {
                    ClearSearchData();
                    SetSearchData("WORK_CD", row.Cells["ACT_ID"].Value);

                    SetServiceId("GetActionItem");

                    SetItemGrid();
                }
            }
        }

        private void SetItemGrid()
        {
            try
            {
                DTOFactory.Transaction(new MemberDTO());
                DataSet ds = DTOFactory.GetDataSet();

                dt_item = ds.Tables["ds_list"];
                gd_Item.DataSource = dt_item;

                if (!gd_Item.LabelDisplayed)
                {
                    gd_Item.SetGridColumn(ds.Tables["ds_column"]);
                }

                foreach (DataGridViewRow row in gd_Item.Rows)
                {
                    row.Cells["NO"].Value = row.Index + 1;
                    string tgt = row.Cells["TGT_TM"].Value.ToString();
                    DateTime target = "".Equals(tgt) ? DateTime.Now : new DateTime(int.Parse(tgt.Substring(0, 4)), int.Parse(tgt.Substring(5, 2)), int.Parse(tgt.Substring(8, 2)));

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (DateTime.Now > target)
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            cell.Style.ForeColor = Color.Black;
                        }

                        if (!"ING".Equals(row.Cells["STAT_CD"].Value))
                        {
                            cell.Style.BackColor = Color.LightGray;
                        }
                        
                        if ("FAIL".Equals(row.Cells["STAT_CD"].Value))
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                    }
                }
                ViewActionItemDetail(gd_Item, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewActionItemDetail(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = view.Rows[e.RowIndex];

                txtItmSubject.Text = row.Cells["SUBJECT"].Value.ToString();
                dtItmTarget.Value = !"".Equals(row.Cells["TGT_TM"].Value.ToString()) ? new DateTime(int.Parse(row.Cells["TGT_TM"].Value.ToString().Substring(0, 4)), int.Parse(row.Cells["TGT_TM"].Value.ToString().Substring(5, 2)), int.Parse(row.Cells["TGT_TM"].Value.ToString().Substring(8, 2))) : DateTime.Now;
                dtItmClear.Value = !"".Equals(row.Cells["END_TM"].Value.ToString()) ? new DateTime(int.Parse(row.Cells["END_TM"].Value.ToString().Substring(0, 4)), int.Parse(row.Cells["END_TM"].Value.ToString().Substring(5, 2)), int.Parse(row.Cells["END_TM"].Value.ToString().Substring(8, 2))) : DateTime.Now;
                dtItmClear.Visible = !"".Equals(row.Cells["END_TM"].Value.ToString());
                cboItmStatus.SetItemChecked(row.Cells["STAT_CD"].Value.ToString());
                txtItmDesc.Text = row.Cells["ITM_DESC"].Value.ToString();

                int total = 100;
                foreach (DataGridViewRow r in view.Rows)
                {
                    if (!"".Equals(r.Cells["IMP_PER"].Value) && r != row)
                    {
                        total -= int.Parse(r.Cells["IMP_PER"].Value.ToString());
                    }
                }

                cboItmPer.Params.Clear();
                cboItmPer.Params.Add("strFirst", "0");
                cboItmPer.Params.Add("strCount", "5");
                cboItmPer.Params.Add("strPer", total.ToString());
                cboItmPer.BindDataSet();

                cboItmPer.SetItemChecked(row.Cells["IMP_PER"].Value.ToString());
                cboItmExePer.SetItemChecked(row.Cells["ING_PER"].Value.ToString());

                btnItmRemove.Enabled = !"".Equals(row.Cells["ITM_ID"].Value.ToString());
                btnItmSubmit.Enabled = DTOFactory.UserId.Equals(gd_List.Rows[gd_List.SelectedCells[0].RowIndex].Cells["ACT_USER_ID"].Value);
                btnItmFile.Enabled = true;

                //개별 처리 완료 또는 검토 완료일 경우 저장 / 삭제 불가
                if (!"ING".Equals(row.Cells["STAT_CD"].Value.ToString()) || "종료".Equals(gd_List.Rows[gd_List.SelectedCells[0].RowIndex].Cells["ACT_STATUS"].Value))
                {
                    btnItmRemove.Enabled = false;
                    btnItmSubmit.Enabled = false;
                }
            }
        }

        private void RemoveActionItem(object sender, EventArgs e)
        {
            DataGridViewRow row = gd_Item.SelectedRows[0];

            ClearSearchData();
            SetSearchData("WORK_CD", row.Cells["ACT_ID"].Value);
            SetSearchData("ITEM_CD", row.Cells["ITM_ID"].Value);

            SetServiceId("RemoveActionItem");

            SetItemGrid();

            DataTable ds_link = DTOFactory.GetDataTable("ds_link");

        }

        private void ActionItemSave(object sender, EventArgs e)
        {
            DataGridViewRow row = gd_Item.SelectedRows[0];

            ClearSearchData();
            SetSearchData("WORK_CD", row.Cells["ACT_ID"].Value);
            SetSearchData("ITEM_CD", row.Cells["ITM_ID"].Value);
            SetSearchData("STATUS", cboItmStatus.ValueList);
            SetSearchData("USER_ID", DTOFactory.UserId);
            SetSearchData("PER1", cboItmPer.ValueList);
            SetSearchData("PER2", cboItmExePer.ValueList);
            SetSearchData("TGT_TM", dtItmTarget.Value.ToString("yyyy-MM-dd"));
            SetSearchData("SUBJECT", txtItmSubject.Text);
            SetSearchData("DESC", txtItmDesc.Text);

            SetServiceId("SetActionItem");

            SetItemGrid();
        }

        private void FileProcess(object sender, EventArgs e)
        {
            var frm = new Popup.FileViewPopup()
            {
                LOCK = btnItmRemove.Enabled,
                LINK_CD = gd_Item.SelectedRows[0].Cells["LINK_CD"].Value.ToString()
            };

            frm.ShowDialog();
        }
    }
}
