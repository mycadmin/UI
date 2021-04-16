namespace MYC.UI.Project
{
    partial class ProjectManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManager));
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calCrtTm = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbockComp = new MYC.Control.CheckComboBox();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.cboStatus = new MYC.Control.CheckComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboProjectMember = new MYC.Control.CheckComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPgmName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPGMID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlProjectList = new System.Windows.Forms.Panel();
            this.gd_Project = new Control.MYCGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboProjectStatus = new MYC.Control.CheckComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboMember = new MYC.Control.CheckComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboProjectId = new MYC.Control.CheckComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnImgDel = new System.Windows.Forms.Button();
            this.btnImgAdd = new System.Windows.Forms.Button();
            this.PicVer = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.txtVerDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVerSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerSave = new System.Windows.Forms.Button();
            this.btnVerDel = new System.Windows.Forms.Button();
            this.btnVerAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gd_Model = new Control.MYCGrid();
            this.gd_VerList = new Control.MYCGrid();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.btn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlProjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Project)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_VerList)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.panel2);
            this.PlMainBody.Controls.Add(this.panel6);
            this.PlMainBody.Controls.Add(this.panel5);
            this.PlMainBody.Controls.Add(this.pnlProjectList);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Size = new System.Drawing.Size(794, 900);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(229, 900);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel4);
            this.PlSearchBody.Controls.Add(this.label19);
            this.PlSearchBody.Controls.Add(this.btn);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(215, 868);
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(215, 28);
            this.LbModelSearch.TabIndex = 81;
            this.LbModelSearch.Text = "조회 기간";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn
            // 
            this.btn.Controls.Add(this.label4);
            this.btn.Controls.Add(this.dtTo);
            this.btn.Controls.Add(this.dtFrom);
            this.btn.Controls.Add(this.label18);
            this.btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn.Location = new System.Drawing.Point(0, 28);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(215, 64);
            this.btn.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 12);
            this.label4.TabIndex = 103;
            this.label4.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(70, 33);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(140, 21);
            this.dtTo.TabIndex = 102;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Location = new System.Drawing.Point(70, 6);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(140, 21);
            this.dtFrom.TabIndex = 100;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(3, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 12);
            this.label18.TabIndex = 99;
            this.label18.Text = "From";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 42);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "■ 프로젝트 목록";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(708, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddRow);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.calCrtTm);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.cbockComp);
            this.panel3.Controls.Add(this.cboComp);
            this.panel3.Controls.Add(this.cboStatus);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cboProjectMember);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtPgmName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtPGMID);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(428, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 252);
            this.panel3.TabIndex = 5;
            // 
            // calCrtTm
            // 
            this.calCrtTm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calCrtTm.CustomFormat = "";
            this.calCrtTm.Enabled = false;
            this.calCrtTm.Location = new System.Drawing.Point(124, 118);
            this.calCrtTm.Name = "calCrtTm";
            this.calCrtTm.Size = new System.Drawing.Size(225, 21);
            this.calCrtTm.TabIndex = 125;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 30);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // cbockComp
            // 
            this.cbockComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbockComp.DisplayMember = "ITEM_NM";
            this.cbockComp.DropDownHeight = 1;
            this.cbockComp.FormattingEnabled = true;
            this.cbockComp.IntegralHeight = false;
            this.cbockComp.Location = new System.Drawing.Point(125, 173);
            this.cbockComp.Margin = new System.Windows.Forms.Padding(0);
            this.cbockComp.MultiSelection = true;
            this.cbockComp.Name = "cbockComp";
            this.cbockComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockComp.Params")));
            this.cbockComp.Size = new System.Drawing.Size(225, 20);
            this.cbockComp.Sql = "CommonSearch#getCompList";
            this.cbockComp.TabIndex = 123;
            this.cbockComp.Text = "[SELECT]";
            this.cbockComp.ValueMember = "ITEM_CD";
            // 
            // cboComp
            // 
            this.cboComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(125, 146);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(225, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 121;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.DisplayMember = "ITEM_NM";
            this.cboStatus.DropDownHeight = 1;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.Location = new System.Drawing.Point(124, 65);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboStatus.MultiSelection = false;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboStatus.Params")));
            this.cboStatus.Size = new System.Drawing.Size(225, 20);
            this.cboStatus.Sql = "CommonSearch#getCommonItems";
            this.cboStatus.TabIndex = 120;
            this.cboStatus.Text = "[SELECT]";
            this.cboStatus.ValueMember = "ITEM_CD";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(10, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 21);
            this.label15.TabIndex = 119;
            this.label15.Text = "상태";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProjectMember
            // 
            this.cboProjectMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProjectMember.DisplayMember = "ITEM_NM";
            this.cboProjectMember.DropDownHeight = 1;
            this.cboProjectMember.FormattingEnabled = true;
            this.cboProjectMember.IntegralHeight = false;
            this.cboProjectMember.Location = new System.Drawing.Point(124, 92);
            this.cboProjectMember.Margin = new System.Windows.Forms.Padding(0);
            this.cboProjectMember.MultiSelection = false;
            this.cboProjectMember.Name = "cboProjectMember";
            this.cboProjectMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProjectMember.Params")));
            this.cboProjectMember.Size = new System.Drawing.Size(225, 20);
            this.cboProjectMember.Sql = "CommonSearch#getUserList";
            this.cboProjectMember.TabIndex = 118;
            this.cboProjectMember.Text = "[SELECT]";
            this.cboProjectMember.ValueMember = "ITEM_CD";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(10, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 21);
            this.label13.TabIndex = 114;
            this.label13.Text = "참여 업체";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(10, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 107;
            this.label8.Text = "고객사";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(10, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 106;
            this.label6.Text = "생성일";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 105;
            this.label5.Text = "담당자";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPgmName
            // 
            this.txtPgmName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPgmName.Location = new System.Drawing.Point(124, 37);
            this.txtPgmName.Name = "txtPgmName";
            this.txtPgmName.Size = new System.Drawing.Size(225, 21);
            this.txtPgmName.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(10, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 101;
            this.label10.Text = "프로젝트 명";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPGMID
            // 
            this.txtPGMID.Location = new System.Drawing.Point(124, 10);
            this.txtPGMID.Name = "txtPGMID";
            this.txtPGMID.ReadOnly = true;
            this.txtPGMID.Size = new System.Drawing.Size(225, 21);
            this.txtPGMID.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 21);
            this.label11.TabIndex = 99;
            this.label11.Text = "Project Id";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProjectList
            // 
            this.pnlProjectList.Controls.Add(this.panel3);
            this.pnlProjectList.Controls.Add(this.gd_Project);
            this.pnlProjectList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjectList.Location = new System.Drawing.Point(0, 42);
            this.pnlProjectList.Name = "pnlProjectList";
            this.pnlProjectList.Size = new System.Drawing.Size(794, 252);
            this.pnlProjectList.TabIndex = 7;
            // 
            // gd_Project
            // 
            this.gd_Project.AllowUserToAddRows = false;
            this.gd_Project.AllowUserToDeleteRows = false;
            this.gd_Project.AllowUserToResizeRows = false;
            this.gd_Project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Project.Location = new System.Drawing.Point(0, 0);
            this.gd_Project.MultiSelect = false;
            this.gd_Project.Name = "gd_Project";
            this.gd_Project.RowHeadersVisible = false;
            this.gd_Project.RowTemplate.Height = 23;
            this.gd_Project.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_Project.Size = new System.Drawing.Size(794, 252);
            this.gd_Project.TabIndex = 6;
            this.gd_Project.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDetail);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboProjectStatus);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.cboMember);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.cboProjectId);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 127);
            this.panel4.TabIndex = 84;
            // 
            // cboProjectStatus
            // 
            this.cboProjectStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProjectStatus.DisplayMember = "ITEM_NM";
            this.cboProjectStatus.DropDownHeight = 1;
            this.cboProjectStatus.FormattingEnabled = true;
            this.cboProjectStatus.IntegralHeight = false;
            this.cboProjectStatus.Location = new System.Drawing.Point(70, 33);
            this.cboProjectStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboProjectStatus.MultiSelection = false;
            this.cboProjectStatus.Name = "cboProjectStatus";
            this.cboProjectStatus.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProjectStatus.Params")));
            this.cboProjectStatus.Size = new System.Drawing.Size(140, 20);
            this.cboProjectStatus.Sql = "CommonSearch#getCommonItems";
            this.cboProjectStatus.TabIndex = 87;
            this.cboProjectStatus.Text = "[SELECT]";
            this.cboProjectStatus.ValueMember = "ITEM_CD";
            this.cboProjectStatus.TextChanged += new System.EventHandler(this.CheckComboItemUpdate);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(3, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 12);
            this.label14.TabIndex = 86;
            this.label14.Text = "상태";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(215, 29);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // cboMember
            // 
            this.cboMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMember.DisplayMember = "ITEM_NM";
            this.cboMember.DropDownHeight = 1;
            this.cboMember.FormattingEnabled = true;
            this.cboMember.IntegralHeight = false;
            this.cboMember.Location = new System.Drawing.Point(70, 6);
            this.cboMember.Margin = new System.Windows.Forms.Padding(0);
            this.cboMember.MultiSelection = false;
            this.cboMember.Name = "cboMember";
            this.cboMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboMember.Params")));
            this.cboMember.Size = new System.Drawing.Size(140, 20);
            this.cboMember.Sql = "CommonSearch#getUserList";
            this.cboMember.TabIndex = 84;
            this.cboMember.Text = "[SELECT]";
            this.cboMember.ValueMember = "ITEM_CD";
            this.cboMember.TextChanged += new System.EventHandler(this.CheckComboItemUpdate);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 12);
            this.label16.TabIndex = 83;
            this.label16.Text = "담당자";
            // 
            // cboProjectId
            // 
            this.cboProjectId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProjectId.DisplayMember = "ITEM_NM";
            this.cboProjectId.DropDownHeight = 1;
            this.cboProjectId.FormattingEnabled = true;
            this.cboProjectId.IntegralHeight = false;
            this.cboProjectId.Location = new System.Drawing.Point(70, 60);
            this.cboProjectId.Margin = new System.Windows.Forms.Padding(0);
            this.cboProjectId.MultiSelection = true;
            this.cboProjectId.Name = "cboProjectId";
            this.cboProjectId.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProjectId.Params")));
            this.cboProjectId.Size = new System.Drawing.Size(140, 20);
            this.cboProjectId.Sql = "CommonSearch#getProjectList";
            this.cboProjectId.TabIndex = 82;
            this.cboProjectId.Text = "[SELECT]";
            this.cboProjectId.ValueMember = "ITEM_CD";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(3, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 12);
            this.label17.TabIndex = 81;
            this.label17.Text = "Project Id";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LawnGreen;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(0, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(215, 28);
            this.label19.TabIndex = 83;
            this.label19.Text = "조회 조건";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(794, 42);
            this.panel5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "■ 프로젝트 제품 관리";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLast);
            this.panel6.Controls.Add(this.btnFirst);
            this.panel6.Controls.Add(this.btnImgDel);
            this.panel6.Controls.Add(this.btnImgAdd);
            this.panel6.Controls.Add(this.PicVer);
            this.panel6.Controls.Add(this.btnRight);
            this.panel6.Controls.Add(this.btnLeft);
            this.panel6.Controls.Add(this.txtVerDesc);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtVerSubject);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtVer);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnVerSave);
            this.panel6.Controls.Add(this.btnVerDel);
            this.panel6.Controls.Add(this.btnVerAdd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(221, 336);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(573, 564);
            this.panel6.TabIndex = 9;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Location = new System.Drawing.Point(466, 532);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(90, 25);
            this.btnLast.TabIndex = 139;
            this.btnLast.Text = "▶|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.ViewLastImage);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(11, 532);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(90, 25);
            this.btnFirst.TabIndex = 138;
            this.btnFirst.Text = "|◀";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.ViewFirstImage);
            // 
            // btnImgDel
            // 
            this.btnImgDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgDel.Location = new System.Drawing.Point(284, 532);
            this.btnImgDel.Name = "btnImgDel";
            this.btnImgDel.Size = new System.Drawing.Size(90, 25);
            this.btnImgDel.TabIndex = 137;
            this.btnImgDel.Text = "삭제";
            this.btnImgDel.UseVisualStyleBackColor = true;
            this.btnImgDel.Click += new System.EventHandler(this.ImageDelete);
            // 
            // btnImgAdd
            // 
            this.btnImgAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgAdd.Location = new System.Drawing.Point(193, 532);
            this.btnImgAdd.Name = "btnImgAdd";
            this.btnImgAdd.Size = new System.Drawing.Size(90, 25);
            this.btnImgAdd.TabIndex = 136;
            this.btnImgAdd.Text = "추가";
            this.btnImgAdd.UseVisualStyleBackColor = true;
            this.btnImgAdd.Click += new System.EventHandler(this.ImageAdd);
            // 
            // PicVer
            // 
            this.PicVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PicVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicVer.Location = new System.Drawing.Point(11, 277);
            this.PicVer.Name = "PicVer";
            this.PicVer.Size = new System.Drawing.Size(546, 249);
            this.PicVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicVer.TabIndex = 135;
            this.PicVer.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.Location = new System.Drawing.Point(375, 532);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(90, 25);
            this.btnRight.TabIndex = 134;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.ViewNextImage);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.Location = new System.Drawing.Point(102, 532);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(90, 25);
            this.btnLeft.TabIndex = 133;
            this.btnLeft.Text = "◀";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.ViewPreImage);
            // 
            // txtVerDesc
            // 
            this.txtVerDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerDesc.Location = new System.Drawing.Point(125, 92);
            this.txtVerDesc.MaxLength = 200;
            this.txtVerDesc.Multiline = true;
            this.txtVerDesc.Name = "txtVerDesc";
            this.txtVerDesc.Size = new System.Drawing.Size(432, 305);
            this.txtVerDesc.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 305);
            this.label7.TabIndex = 131;
            this.label7.Text = "상세 설명";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVerSubject
            // 
            this.txtVerSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerSubject.Location = new System.Drawing.Point(125, 68);
            this.txtVerSubject.MaxLength = 40;
            this.txtVerSubject.Name = "txtVerSubject";
            this.txtVerSubject.Size = new System.Drawing.Size(432, 21);
            this.txtVerSubject.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 129;
            this.label3.Text = "버전 설명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVer
            // 
            this.txtVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVer.Location = new System.Drawing.Point(125, 44);
            this.txtVer.MaxLength = 20;
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(432, 21);
            this.txtVer.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 127;
            this.label2.Text = "버전";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerSave
            // 
            this.btnVerSave.Location = new System.Drawing.Point(163, 6);
            this.btnVerSave.Name = "btnVerSave";
            this.btnVerSave.Size = new System.Drawing.Size(70, 30);
            this.btnVerSave.TabIndex = 126;
            this.btnVerSave.Text = "저장";
            this.btnVerSave.UseVisualStyleBackColor = true;
            this.btnVerSave.Click += new System.EventHandler(this.VersionSave);
            // 
            // btnVerDel
            // 
            this.btnVerDel.Location = new System.Drawing.Point(87, 6);
            this.btnVerDel.Name = "btnVerDel";
            this.btnVerDel.Size = new System.Drawing.Size(70, 30);
            this.btnVerDel.TabIndex = 125;
            this.btnVerDel.Text = "삭제";
            this.btnVerDel.UseVisualStyleBackColor = true;
            this.btnVerDel.Click += new System.EventHandler(this.VerDelete);
            // 
            // btnVerAdd
            // 
            this.btnVerAdd.Location = new System.Drawing.Point(11, 6);
            this.btnVerAdd.Name = "btnVerAdd";
            this.btnVerAdd.Size = new System.Drawing.Size(70, 30);
            this.btnVerAdd.TabIndex = 1;
            this.btnVerAdd.Text = "추가";
            this.btnVerAdd.UseVisualStyleBackColor = true;
            this.btnVerAdd.Click += new System.EventHandler(this.AddVerRow);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gd_VerList);
            this.panel2.Controls.Add(this.gd_Model);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 564);
            this.panel2.TabIndex = 12;
            // 
            // gd_Model
            // 
            this.gd_Model.AllowUserToAddRows = false;
            this.gd_Model.AllowUserToDeleteRows = false;
            this.gd_Model.AllowUserToResizeRows = false;
            this.gd_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Model.Dock = System.Windows.Forms.DockStyle.Top;
            this.gd_Model.Location = new System.Drawing.Point(0, 0);
            this.gd_Model.MultiSelect = false;
            this.gd_Model.Name = "gd_Model";
            this.gd_Model.RowHeadersVisible = false;
            this.gd_Model.RowTemplate.Height = 23;
            this.gd_Model.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_Model.Size = new System.Drawing.Size(221, 261);
            this.gd_Model.TabIndex = 11;
            this.gd_Model.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModelView);
            // 
            // gd_VerList
            // 
            this.gd_VerList.AllowUserToAddRows = false;
            this.gd_VerList.AllowUserToDeleteRows = false;
            this.gd_VerList.AllowUserToResizeRows = false;
            this.gd_VerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_VerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_VerList.Location = new System.Drawing.Point(0, 261);
            this.gd_VerList.MultiSelect = false;
            this.gd_VerList.Name = "gd_VerList";
            this.gd_VerList.RowHeadersVisible = false;
            this.gd_VerList.RowTemplate.Height = 23;
            this.gd_VerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_VerList.Size = new System.Drawing.Size(221, 303);
            this.gd_VerList.TabIndex = 12;
            this.gd_VerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewVersion);
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProjectManager";
            this.Size = new System.Drawing.Size(1027, 900);
            this.Load += new System.EventHandler(this.ProjectManager_Load);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.btn.ResumeLayout(false);
            this.btn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlProjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Project)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVer)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_VerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPgmName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPGMID;
        private System.Windows.Forms.Label label11;
        private Control.MYCGrid gd_Project;
        private System.Windows.Forms.Label label13;
        private Control.CheckComboBox cboProjectMember;
        private Control.CheckComboBox cboStatus;
        private System.Windows.Forms.Label label15;
        private Control.CheckComboBox cbockComp;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private Control.CheckComboBox cboProjectStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboMember;
        private System.Windows.Forms.Label label16;
        private Control.CheckComboBox cboProjectId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker calCrtTm;
        private System.Windows.Forms.Panel pnlProjectList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnImgDel;
        private System.Windows.Forms.Button btnImgAdd;
        private System.Windows.Forms.PictureBox PicVer;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox txtVerDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVerSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerSave;
        private System.Windows.Forms.Button btnVerDel;
        private System.Windows.Forms.Button btnVerAdd;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel panel2;
        private Control.MYCGrid gd_Model;
        private Control.MYCGrid gd_VerList;
    }
}
