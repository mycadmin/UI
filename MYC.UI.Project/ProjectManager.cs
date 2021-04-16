#pragma warning disable IDE1006
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using MYC.Sender;
using MYC.Control;
using MYC.Control.Common;
using MYC.UI.DTO;

namespace MYC.UI.Project
{
    public partial class ProjectManager: MYCControl
    {
        #region Field        
        protected DataTable _dtProject = new DataTable();
        protected DataTable _dtVersion = new DataTable();
        protected DataTable _dtLink = new DataTable();

        protected int ImageIndex = -1;
        #endregion

        #region Init
        public ProjectManager()
        {
            InitializeComponent();
        }

        private void ProjectManager_Load(object sender, EventArgs e)
        {
            DTOFactory.Action();

            InitSpread();
            InitDataTable();
            InitControls();

            DTOFactory.Complete();
        }

        private void InitDataTable()
        {
        }

        private void InitSpread()
        {
            gd_Project.MultiSelect = false;
        }

        private void InitControls()
        {
            #region Project User
            cboMember.Params.Add("strCompType", "M");
            cboMember.BindDataSet();

            cboProjectMember.Params.Add("strCompType", "M");
            cboProjectMember.BindDataSet();
            #endregion Project User

            #region Status
            cboStatus.Params.Add("strItem", "PROJECT_CODE");
            cboStatus.BindDataSet();

            cboProjectStatus.Params.Add("strItem", "PROJECT_CODE");
            cboProjectStatus.BindDataSet();
            #endregion Status

            #region Company
            cboComp.Params.Add("strCompType", "C");
            cboComp.BindDataSet();

            cbockComp.Params.Add("strCompType", "V");
            cbockComp.BindDataSet();
            #endregion Company

            dtFrom.Value = dtTo.Value.AddMonths(-3);
            cboMember.SetItemChecked(DTOFactory.UserId);

            SetBind();
            Search();
        }

        private void AddRow(object sender, EventArgs e)
        {
            DataRow dr = _dtProject.NewRow();

            dr["USER_ID"] = DTOFactory.UserId;
            dr["CRT_TM"] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            _dtProject.Rows.Add(dr);
        }

        private void ViewDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ViewDetail(e.RowIndex);
        }
        #endregion

        #region Event
        private void CheckComboItemUpdate(object sender, EventArgs e)
        {
            cboProjectId.Params.Clear();
            cboProjectId.Params.Add("strFrom", dtFrom.Value.ToString("yyyy-MM-dd"));
            cboProjectId.Params.Add("strTo", dtTo.Value.ToString("yyyy-MM-dd"));
            cboProjectId.Params.Add("strUserId", cboMember.ValueList);
            cboProjectId.Params.Add("strStatus", cboProjectStatus.ValueList);
            cboProjectId.BindDataSet();
        }

        private void Search(object sender, EventArgs e)
        {
            SetBind();
            Search();
        }

        private void Save(object sender, EventArgs e)
        {
            _dtSearch.Clear();

            DataRow dr = _dtSearch.NewRow();
            dr["FIELD"] = "PROJECT_ID";
            dr["DATA"] = txtPGMID.Text;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "PROJECT_NAME";
            dr["DATA"] = txtPgmName.Text;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "COMP_CD";
            dr["DATA"] = cboComp.ValueList;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "VENDOR_LIST";
            dr["DATA"] = cbockComp.ValueList;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "USER_ID";
            dr["DATA"] = cboProjectMember.ValueList;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "STATUS";
            dr["DATA"] = cboStatus.ValueList;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "CREATE_TIME";
            dr["DATA"] = calCrtTm.Value.ToString("yyyy-MM-dd HH:mm:ss");
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "UPT_USER_ID";
            dr["DATA"] = DTOFactory.UserId;
            _dtSearch.Rows.Add(dr);

            SetServiceId("SetProject");

            DTOFactory.Transaction(new ProjectDTO());
            SetBind();
            Search();
        }

        private void ModelView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ModelView(e.RowIndex);
        }

        private void ViewVersion(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ViewVersion(e.RowIndex);
        }

        private void AddVerRow(object sender, EventArgs e)
        {
            if (gd_Model.Rows.Count > 0)
            {
                DataRow dr = _dtVersion.NewRow();
                dr["MODEL_ID"] = gd_Model.SelectedRows[0].Cells["MODEL_ID"].Value;
                dr["SEQ_NO"] = 0;
                _dtVersion.Rows.Add(dr);
            }
            else
            {
                ViewMessage.Info("해당 프로젝트에 등록된 모델이 존재하지 않습니다.");
            }
        }

        private void VerDelete(object sender, EventArgs e)
        {
            int row = gd_VerList.SelectedRows[0].Index;

            if ("0".Equals(_dtVersion.Rows[row]["SEQ_NO"].ToString()))
            {
                _dtVersion.Rows.Remove(_dtVersion.Rows[row]);
            }
            else if (!"".Equals(_dtVersion.Rows[row]["DOC_ID"].ToString()))
            {
                if (System.Windows.Forms.MessageBox.Show(
                    "해당 버전 정보를 삭제 하시겠습니까?", "버전 제거"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dtSearch.Clear();

                    DataRow dr = _dtSearch.NewRow();
                    dr["FIELD"] = "MODEL_ID";
                    dr["DATA"] = _dtVersion.Rows[row]["MODEL_ID"].ToString();
                    _dtSearch.Rows.Add(dr);

                    dr = _dtSearch.NewRow();
                    dr["FIELD"] = "SEQ_NO";
                    dr["DATA"] = _dtVersion.Rows[row]["SEQ_NO"].ToString();
                    _dtSearch.Rows.Add(dr);

                    dr = _dtSearch.NewRow();
                    dr["FIELD"] = "VERSION";
                    dr["DATA"] = txtVer.Text;
                    _dtSearch.Rows.Add(dr);

                    dr = _dtSearch.NewRow();
                    dr["FIELD"] = "SUBJECT";
                    dr["DATA"] = txtVerSubject.Text;
                    _dtSearch.Rows.Add(dr);

                    dr = _dtSearch.NewRow();
                    dr["FIELD"] = "WORK_DESC";
                    dr["DATA"] = txtVerDesc.Text;
                    _dtSearch.Rows.Add(dr);

                    dr = _dtSearch.NewRow();
                    dr["FIELD"] = "LINK_CODE";
                    dr["DATA"] = _dtVersion.Rows[row]["LINK_CD"].ToString();

                    _dtSearch.Rows.Add(dr);
                    dr = _dtSearch.NewRow();
                    dr["FIELD"] = "DEL_YN";
                    dr["DATA"] = "Y";
                    _dtSearch.Rows.Add(dr);

                    dr = _dtSearch.NewRow();
                    dr["FIELD"] = "UPT_USER_ID";
                    dr["DATA"] = DTOFactory.UserId;
                    _dtSearch.Rows.Add(dr);

                    SetServiceId("SetModelVersion");

                    try
                    {
                        DTOFactory.Transaction(new ProjectDTO());
                        DataSet ds = DTOFactory.GetDataSet();

                        gd_Model.DataSource = ds.Tables["ds_ver"];

                        if (gd_Model.Rows.Count > 0)
                            ModelView(0);
                    }
                    catch (Exception ex)
                    {
                        ViewMessage.Error(ex.Message);
                    }
                }
            }
            else
            {
                ViewMessage.Info("해당 버전 정보를 삭제 할 수 없습니다.\r\n정부 사업에서 사용하고 있습니다.");
            }
        }
        #endregion

        #region Method
        private void SetBind()
        {
            _dtSearch.Clear();

            DataRow dr = _dtSearch.NewRow();
            dr["FIELD"] = "FROM_DT";
            dr["DATA"] = dtFrom.Value.ToString("yyyy-MM-dd");
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "TO_DT";
            dr["DATA"] = dtTo.Value.ToString("yyyy-MM-dd");
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "USER_ID";
            dr["DATA"] = cboMember.ValueList;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "STATUS";
            dr["DATA"] = cboProjectStatus.ValueList;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "PROJECT_ID";
            dr["DATA"] = cboProjectId.ValueList;
            _dtSearch.Rows.Add(dr);
        }

        private void Search()
        {
            SetServiceId("GetProjectList");

            try
            {
                DTOFactory.Transaction(new ProjectDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtProject = ds.Tables["ds_project"];
                
                gd_Project.DataSource = _dtProject;
                gd_Project.SetGridColumn(ds.Tables["ds_project_column"]);

                if (_dtProject.Rows.Count > 0)
                    ViewDetail(0);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewDetail(int index)
        {
            DataRow dr = _dtProject.Rows[index];

            txtPGMID.Text = dr["PRO_ID"].ToString();
            txtPgmName.Text = dr["PRO_NM"].ToString();
            calCrtTm.Value = DateTime.Parse(dr["CRT_TM"].ToString());

            cboStatus.SetItemChecked(dr["STAT_CD"].ToString());
            cboComp.SetItemChecked(dr["COMP_CD"].ToString());
            cboProjectMember.SetItemChecked(dr["USER_ID"].ToString());
            cbockComp.SetItemChecked(dr["VENDOR_CD_LVAL"].ToString());

            _dtSearch.Clear();

            DataRow row = _dtSearch.NewRow();
            row["FIELD"] = "PROJECT_ID";
            row["DATA"] = dr["PRO_ID"].ToString();
            _dtSearch.Rows.Add(row);

            SetServiceId("GetModelList");
            
            gd_Model.DataSource = null;
            gd_VerList.DataSource = null;

            try
            {
                DTOFactory.Transaction(new ProjectDTO());
                DataSet ds = DTOFactory.GetDataSet();

                gd_Model.DataSource = ds.Tables["ds_model"];
                gd_Model.SetGridColumn(ds.Tables["ds_column"]);

                if (gd_Model.Rows.Count > 0)
                    ModelView(0);

                txtVer.Text = "";
                txtVerSubject.Text = "";
                txtVerDesc.Text = "";
                PicVer.Image = null;
                _dtLink.Clear();
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ModelView(int index)
        {
            panel6.Enabled = true;
            btnVerDel.Enabled = false;

            PicVer.Image = null;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnImgAdd.Enabled = false;
            btnImgDel.Enabled = false;

            txtVer.Text = "";
            txtVerSubject.Text = "";
            txtVerDesc.Text = "";
            PicVer.Image = null;
            _dtLink.Clear();

            _dtSearch.Clear();

            DataRow dr = _dtSearch.NewRow();
            dr["FIELD"] = "MODEL_ID";
            dr["DATA"] = gd_Model.Rows[index].Cells["MODEL_ID"].Value;
            _dtSearch.Rows.Add(dr);

            SetServiceId("GetModelVerList");

            try
            {
                DTOFactory.Transaction(new ProjectDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtVersion = ds.Tables["ds_ver"];
                gd_VerList.DataSource = _dtVersion;
                gd_VerList.SetGridColumn(ds.Tables["ds_column"]);

                if (gd_VerList.Rows.Count > 0)
                    ViewVersion(0);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewVersion(int index)
        {
            btnVerDel.Enabled = true;
            btnVerSave.Enabled = true;

            txtVer.Text = gd_VerList.Rows[index].Cells["VER_NM"].Value.ToString();
            txtVerSubject.Text = gd_VerList.Rows[index].Cells["SUBJECT"].Value.ToString();
            txtVerDesc.Text = gd_VerList.Rows[index].Cells["CMT_DESC"].Value.ToString();

            if (!"".Equals(gd_VerList.Rows[index].Cells["LINK_CD"].Value.ToString()))
            {
                ImageIndex = -1;
                _dtSearch.Clear();

                DataRow dr = _dtSearch.NewRow();
                dr["FIELD"] = "LINK_CODE";
                dr["DATA"] = gd_VerList.Rows[index].Cells["LINK_CD"].Value.ToString();
                _dtSearch.Rows.Add(dr);

                SetServiceId("GetLinkList");

                try
                {
                    DTOFactory.Transaction(new ProjectDTO());
                    _dtLink = DTOFactory.GetDataTable();

                    if (_dtLink.Rows.Count > 0)
                        ViewImage(0);
                    else
                        PicVer.Image = null;

                    btnFirst.Enabled = true;
                    btnLast.Enabled = true;
                    btnImgAdd.Enabled = true;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
            else
            {
                PicVer.Image = null;
                btnFirst.Enabled = false;
                btnLeft.Enabled = false;
                btnRight.Enabled = false;
                btnLast.Enabled = false;
                btnImgAdd.Enabled = false;
                btnImgDel.Enabled = false;
            }
        }

        #endregion

        private void VersionSave(object sender, EventArgs e)
        {
            int row = gd_VerList.SelectedRows[0].Index;
            _dtSearch.Clear();

            DataRow dr = _dtSearch.NewRow();
            dr["FIELD"] = "MODEL_ID";
            dr["DATA"] = _dtVersion.Rows[row]["MODEL_ID"].ToString();
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "SEQ_NO";
            dr["DATA"] = _dtVersion.Rows[row]["SEQ_NO"].ToString();
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "VERSION";
            dr["DATA"] = txtVer.Text;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "SUBJECT";
            dr["DATA"] = txtVerSubject.Text;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "WORK_DESC";
            dr["DATA"] = txtVerDesc.Text;
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "LINK_CODE";
            dr["DATA"] = _dtVersion.Rows[row]["LINK_CD"].ToString();

            _dtSearch.Rows.Add(dr);
            dr = _dtSearch.NewRow();
            dr["FIELD"] = "DEL_YN";
            dr["DATA"] = "N";
            _dtSearch.Rows.Add(dr);

            dr = _dtSearch.NewRow();
            dr["FIELD"] = "UPT_USER_ID";
            dr["DATA"] = DTOFactory.UserId;
            _dtSearch.Rows.Add(dr);

            SetServiceId("SetModelVersion");

            try
            {
                DTOFactory.Transaction(new ProjectDTO());
                DataSet ds = DTOFactory.GetDataSet();

                _dtVersion = ds.Tables["ds_ver"];
                gd_VerList.DataSource = _dtVersion;
                
                gd_VerList.Rows[row].Selected = true;
                ViewVersion(row);
            }
            catch (Exception ex)
            {
                ViewMessage.Error(ex.Message);
            }
        }

        private void ViewImage(int index)
        {
            try
            {
                ImageIndex = index;
                ImageGet img = new ImageGet(_dtLink.Rows[ImageIndex]["LINK"].ToString());

                PicVer.Image = Image.FromStream(img.GetImageData());

                btnImgDel.Enabled = true;

                btnLeft.Enabled = ImageIndex != 0;
                btnRight.Enabled = ImageIndex != _dtLink.Rows.Count - 1;
            }
            catch(Exception e)
            {
                ViewMessage.Error(e.Message);
            }
        }

        private void ViewPreImage(object sender, EventArgs e)
        {
            ViewImage(ImageIndex - 1);
        }

        private void ViewNextImage(object sender, EventArgs e)
        {
            ViewImage(ImageIndex + 1);
        }

        private void ImageAdd(object sender, EventArgs e)
        {
            int row = gd_VerList.SelectedRows[0].Index;
            OpenFileDialog frm = new OpenFileDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                new FileSender(_dtVersion.Rows[row]["LINK_CD"].ToString(), frm.FileName);
                
                _dtSearch.Clear();

                DataRow dr = _dtSearch.NewRow();
                dr["FIELD"] = "LINK_CODE";
                dr["DATA"] = gd_VerList.Rows[row].Cells["LINK_CD"].Value.ToString();
                _dtSearch.Rows.Add(dr);

                SetServiceId("GetLinkList");

                try
                {
                    DTOFactory.Transaction(new ProjectDTO());
                    _dtLink = DTOFactory.GetDataTable();

                    ViewImage(ImageIndex + 1);

                    btnFirst.Enabled = true;
                    btnLast.Enabled = true;
                    btnImgAdd.Enabled = true;
                }
                catch (Exception ex)
                {
                    ViewMessage.Error(ex.Message);
                }
            }
        }

        private void ImageDelete(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show(
                    _dtLink.Rows[ImageIndex]["FILE_DESC"] + " File을 삭제 하시겠습니까?", "File 제거"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FileSender snd = new FileSender(_dtLink.Rows[ImageIndex]["LINK_CD"].ToString(), _dtLink.Rows[ImageIndex]["LINK"].ToString(), false);
                snd.Close();

                _dtLink.Rows.RemoveAt(ImageIndex--);

                if (ImageIndex > -1)
                    ViewImage(ImageIndex);
                else
                {
                    PicVer.Image = null;
                    btnImgDel.Enabled = false;
                    btnLeft.Enabled = false;
                    btnRight.Enabled = false;
                    btnFirst.Enabled = false;
                    btnLast.Enabled = false;
                }
            }
        }

        private void ViewFirstImage(object sender, EventArgs e)
        {
            ViewImage(0);
        }

        private void ViewLastImage(object sender, EventArgs e)
        {
            ViewImage(_dtLink.Rows.Count - 1);
        }
    }
}
