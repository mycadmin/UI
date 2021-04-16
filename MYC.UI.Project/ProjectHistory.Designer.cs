namespace MYC.UI.Project
{
    partial class ProjectHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectHistory));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboProjectId = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gd_Project = new Control.MYCGrid();
            this.panel7 = new System.Windows.Forms.Panel();
            this.calWorkDt = new System.Windows.Forms.DateTimePicker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbockMember = new MYC.Control.CheckComboBox();
            this.cboMember = new MYC.Control.CheckComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWorkId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PnlProDoc = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.LstLink = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnActionAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gd_ActionList = new Control.MYCGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnActSave = new System.Windows.Forms.Button();
            this.cboActClose = new MYC.Control.CheckComboBox();
            this.calEndDt = new System.Windows.Forms.DateTimePicker();
            this.cboActCompUser = new MYC.Control.CheckComboBox();
            this.cboActType = new MYC.Control.CheckComboBox();
            this.cboActRank = new MYC.Control.CheckComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.calStartDt = new System.Windows.Forms.DateTimePicker();
            this.txtActDetail = new System.Windows.Forms.TextBox();
            this.cboActComp = new MYC.Control.CheckComboBox();
            this.cboActMgrComp = new MYC.Control.CheckComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Project)).BeginInit();
            this.panel7.SuspendLayout();
            this.PnlProDoc.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_ActionList)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.splitContainer1);
            this.PlMainBody.Controls.Add(this.panel4);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Controls.Add(this.panel3);
            this.PlMainBody.Size = new System.Drawing.Size(833, 648);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(240, 648);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.Panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(226, 616);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.dtTo);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.dtFrom);
            this.Panel2.Controls.Add(this.label18);
            this.Panel2.Controls.Add(this.cboUser);
            this.Panel2.Controls.Add(this.label19);
            this.Panel2.Controls.Add(this.btnSearch);
            this.Panel2.Controls.Add(this.cboProjectId);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 28);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(226, 156);
            this.Panel2.TabIndex = 84;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(78, 42);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(140, 21);
            this.dtTo.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 97;
            this.label3.Text = "~";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Location = new System.Drawing.Point(78, 6);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(140, 21);
            this.dtFrom.TabIndex = 96;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 12);
            this.label18.TabIndex = 95;
            this.label18.Text = "조회기간";
            // 
            // cboUser
            // 
            this.cboUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(78, 69);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(140, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 94;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(1, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 12);
            this.label19.TabIndex = 93;
            this.label19.Text = "담당자";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(226, 27);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // cboProjectId
            // 
            this.cboProjectId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProjectId.DisplayMember = "ITEM_NM";
            this.cboProjectId.DropDownHeight = 1;
            this.cboProjectId.FormattingEnabled = true;
            this.cboProjectId.IntegralHeight = false;
            this.cboProjectId.Location = new System.Drawing.Point(78, 96);
            this.cboProjectId.Margin = new System.Windows.Forms.Padding(0);
            this.cboProjectId.MultiSelection = false;
            this.cboProjectId.Name = "cboProjectId";
            this.cboProjectId.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProjectId.Params")));
            this.cboProjectId.Size = new System.Drawing.Size(140, 20);
            this.cboProjectId.Sql = "CommonSearch#getProjectList";
            this.cboProjectId.TabIndex = 82;
            this.cboProjectId.Text = "[SELECT]";
            this.cboProjectId.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "Project Id";
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(226, 28);
            this.LbModelSearch.TabIndex = 83;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LbTitle);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 42);
            this.panel3.TabIndex = 6;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbTitle.Location = new System.Drawing.Point(3, 11);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(128, 15);
            this.LbTitle.TabIndex = 126;
            this.LbTitle.Text = "■ 프로젝트 이력";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(757, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 21);
            this.btnAdd.TabIndex = 103;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddRow);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gd_Project);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.PnlProDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 217);
            this.panel1.TabIndex = 7;
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
            this.gd_Project.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_Project.Size = new System.Drawing.Size(232, 217);
            this.gd_Project.TabIndex = 7;
            this.gd_Project.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gd_Project_CellClick);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.calWorkDt);
            this.panel7.Controls.Add(this.txtDesc);
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.cbockMember);
            this.panel7.Controls.Add(this.cboMember);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txtWorkId);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(232, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(368, 217);
            this.panel7.TabIndex = 8;
            // 
            // calWorkDt
            // 
            this.calWorkDt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calWorkDt.Location = new System.Drawing.Point(124, 38);
            this.calWorkDt.Name = "calWorkDt";
            this.calWorkDt.Size = new System.Drawing.Size(238, 21);
            this.calWorkDt.TabIndex = 127;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(124, 118);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(238, 65);
            this.txtDesc.TabIndex = 125;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(292, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 20);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.HistorySave);
            // 
            // cbockMember
            // 
            this.cbockMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbockMember.DisplayMember = "ITEM_NM";
            this.cbockMember.DropDownHeight = 1;
            this.cbockMember.FormattingEnabled = true;
            this.cbockMember.IntegralHeight = false;
            this.cbockMember.Location = new System.Drawing.Point(124, 92);
            this.cbockMember.Margin = new System.Windows.Forms.Padding(0);
            this.cbockMember.MultiSelection = true;
            this.cbockMember.Name = "cbockMember";
            this.cbockMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockMember.Params")));
            this.cbockMember.Size = new System.Drawing.Size(238, 20);
            this.cbockMember.Sql = "CommonSearch#getUserList";
            this.cbockMember.TabIndex = 121;
            this.cbockMember.Text = "[SELECT]";
            this.cbockMember.ValueMember = "ITEM_CD";
            // 
            // cboMember
            // 
            this.cboMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMember.DisplayMember = "ITEM_NM";
            this.cboMember.DropDownHeight = 1;
            this.cboMember.FormattingEnabled = true;
            this.cboMember.IntegralHeight = false;
            this.cboMember.Location = new System.Drawing.Point(124, 65);
            this.cboMember.Margin = new System.Windows.Forms.Padding(0);
            this.cboMember.MultiSelection = false;
            this.cboMember.Name = "cboMember";
            this.cboMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboMember.Params")));
            this.cboMember.Size = new System.Drawing.Size(238, 20);
            this.cboMember.Sql = "CommonSearch#getUserList";
            this.cboMember.TabIndex = 118;
            this.cboMember.Text = "[SELECT]";
            this.cboMember.ValueMember = "ITEM_CD";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(10, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 65);
            this.label13.TabIndex = 114;
            this.label13.Text = "상세 내용";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(10, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 107;
            this.label8.Text = "참여인원";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(10, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 105;
            this.label5.Text = "담당자";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label10.Text = "일자";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkId
            // 
            this.txtWorkId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkId.Location = new System.Drawing.Point(124, 10);
            this.txtWorkId.Name = "txtWorkId";
            this.txtWorkId.ReadOnly = true;
            this.txtWorkId.Size = new System.Drawing.Size(238, 21);
            this.txtWorkId.TabIndex = 100;
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
            this.label11.Text = "Work Id";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlProDoc
            // 
            this.PnlProDoc.Controls.Add(this.btnView);
            this.PnlProDoc.Controls.Add(this.btnRemove);
            this.PnlProDoc.Controls.Add(this.btnImport);
            this.PnlProDoc.Controls.Add(this.LstLink);
            this.PnlProDoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlProDoc.Location = new System.Drawing.Point(600, 0);
            this.PnlProDoc.Name = "PnlProDoc";
            this.PnlProDoc.Size = new System.Drawing.Size(233, 217);
            this.PnlProDoc.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(158, 189);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 21);
            this.btnView.TabIndex = 106;
            this.btnView.Text = "내용보기";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.ViewLink);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(83, 189);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 21);
            this.btnRemove.TabIndex = 105;
            this.btnRemove.Text = "제거";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.RemoveLink);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(7, 190);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(70, 21);
            this.btnImport.TabIndex = 104;
            this.btnImport.Text = "추가";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.AddLink);
            // 
            // LstLink
            // 
            this.LstLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstLink.FormattingEnabled = true;
            this.LstLink.ItemHeight = 12;
            this.LstLink.Location = new System.Drawing.Point(7, 11);
            this.LstLink.Name = "LstLink";
            this.LstLink.Size = new System.Drawing.Size(221, 172);
            this.LstLink.TabIndex = 0;
            this.LstLink.DoubleClick += new System.EventHandler(this.View);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnActionAdd);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(833, 42);
            this.panel4.TabIndex = 8;
            // 
            // btnActionAdd
            // 
            this.btnActionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActionAdd.Enabled = false;
            this.btnActionAdd.Location = new System.Drawing.Point(757, 10);
            this.btnActionAdd.Name = "btnActionAdd";
            this.btnActionAdd.Size = new System.Drawing.Size(70, 21);
            this.btnActionAdd.TabIndex = 130;
            this.btnActionAdd.Text = "추가";
            this.btnActionAdd.UseVisualStyleBackColor = true;
            this.btnActionAdd.Click += new System.EventHandler(this.AddActionRow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 126;
            this.label2.Text = "■ Action Item";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 301);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gd_ActionList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Size = new System.Drawing.Size(833, 347);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 9;
            // 
            // gd_ActionList
            // 
            this.gd_ActionList.AllowUserToAddRows = false;
            this.gd_ActionList.AllowUserToDeleteRows = false;
            this.gd_ActionList.AllowUserToResizeRows = false;
            this.gd_ActionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_ActionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_ActionList.Location = new System.Drawing.Point(0, 0);
            this.gd_ActionList.MultiSelect = false;
            this.gd_ActionList.Name = "gd_ActionList";
            this.gd_ActionList.RowHeadersVisible = false;
            this.gd_ActionList.RowTemplate.Height = 23;
            this.gd_ActionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_ActionList.Size = new System.Drawing.Size(228, 347);
            this.gd_ActionList.TabIndex = 8;
            this.gd_ActionList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetActionItem);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnActSave);
            this.panel6.Controls.Add(this.cboActClose);
            this.panel6.Controls.Add(this.calEndDt);
            this.panel6.Controls.Add(this.cboActCompUser);
            this.panel6.Controls.Add(this.cboActType);
            this.panel6.Controls.Add(this.cboActRank);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.calStartDt);
            this.panel6.Controls.Add(this.txtActDetail);
            this.panel6.Controls.Add(this.cboActComp);
            this.panel6.Controls.Add(this.cboActMgrComp);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(601, 347);
            this.panel6.TabIndex = 9;
            // 
            // btnActSave
            // 
            this.btnActSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActSave.Location = new System.Drawing.Point(525, 5);
            this.btnActSave.Name = "btnActSave";
            this.btnActSave.Size = new System.Drawing.Size(70, 20);
            this.btnActSave.TabIndex = 137;
            this.btnActSave.Text = "저장";
            this.btnActSave.UseVisualStyleBackColor = true;
            this.btnActSave.Click += new System.EventHandler(this.ActionItemSave);
            // 
            // cboActClose
            // 
            this.cboActClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActClose.DisplayMember = "ITEM_NM";
            this.cboActClose.DropDownHeight = 1;
            this.cboActClose.FormattingEnabled = true;
            this.cboActClose.IntegralHeight = false;
            this.cboActClose.Location = new System.Drawing.Point(124, 223);
            this.cboActClose.Margin = new System.Windows.Forms.Padding(0);
            this.cboActClose.MultiSelection = false;
            this.cboActClose.Name = "cboActClose";
            this.cboActClose.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActClose.Params")));
            this.cboActClose.Size = new System.Drawing.Size(471, 20);
            this.cboActClose.Sql = "CommonSearch#getCommonItems";
            this.cboActClose.TabIndex = 136;
            this.cboActClose.Text = "[SELECT]";
            this.cboActClose.ValueMember = "ITEM_CD";
            // 
            // calEndDt
            // 
            this.calEndDt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calEndDt.CustomFormat = "yyyy년 MM월 dd일 hh시 mm분";
            this.calEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calEndDt.Location = new System.Drawing.Point(124, 195);
            this.calEndDt.Name = "calEndDt";
            this.calEndDt.Size = new System.Drawing.Size(471, 21);
            this.calEndDt.TabIndex = 135;
            // 
            // cboActCompUser
            // 
            this.cboActCompUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActCompUser.DisplayMember = "ITEM_NM";
            this.cboActCompUser.DropDownHeight = 1;
            this.cboActCompUser.FormattingEnabled = true;
            this.cboActCompUser.IntegralHeight = false;
            this.cboActCompUser.Location = new System.Drawing.Point(124, 142);
            this.cboActCompUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboActCompUser.MultiSelection = false;
            this.cboActCompUser.Name = "cboActCompUser";
            this.cboActCompUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActCompUser.Params")));
            this.cboActCompUser.Size = new System.Drawing.Size(471, 20);
            this.cboActCompUser.Sql = "CommonSearch#getUserList";
            this.cboActCompUser.TabIndex = 134;
            this.cboActCompUser.Text = "[SELECT]";
            this.cboActCompUser.ValueMember = "ITEM_CD";
            // 
            // cboActType
            // 
            this.cboActType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActType.DisplayMember = "ITEM_NM";
            this.cboActType.DropDownHeight = 1;
            this.cboActType.FormattingEnabled = true;
            this.cboActType.IntegralHeight = false;
            this.cboActType.Location = new System.Drawing.Point(124, 61);
            this.cboActType.Margin = new System.Windows.Forms.Padding(0);
            this.cboActType.MultiSelection = false;
            this.cboActType.Name = "cboActType";
            this.cboActType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActType.Params")));
            this.cboActType.Size = new System.Drawing.Size(471, 20);
            this.cboActType.Sql = "CommonSearch#getCommonItems";
            this.cboActType.TabIndex = 133;
            this.cboActType.Text = "[SELECT]";
            this.cboActType.ValueMember = "ITEM_CD";
            // 
            // cboActRank
            // 
            this.cboActRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActRank.DisplayMember = "ITEM_NM";
            this.cboActRank.DropDownHeight = 1;
            this.cboActRank.FormattingEnabled = true;
            this.cboActRank.IntegralHeight = false;
            this.cboActRank.Location = new System.Drawing.Point(124, 34);
            this.cboActRank.Margin = new System.Windows.Forms.Padding(0);
            this.cboActRank.MultiSelection = false;
            this.cboActRank.Name = "cboActRank";
            this.cboActRank.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActRank.Params")));
            this.cboActRank.Size = new System.Drawing.Size(471, 20);
            this.cboActRank.Sql = "CommonSearch#getCommonItems";
            this.cboActRank.TabIndex = 132;
            this.cboActRank.Text = "[SELECT]";
            this.cboActRank.ValueMember = "ITEM_CD";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(10, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 21);
            this.label17.TabIndex = 131;
            this.label17.Text = "진행상태";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(10, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 21);
            this.label16.TabIndex = 130;
            this.label16.Text = "목표일";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(10, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 21);
            this.label15.TabIndex = 129;
            this.label15.Text = "접수일";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(10, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 21);
            this.label14.TabIndex = 128;
            this.label14.Text = "담당자";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calStartDt
            // 
            this.calStartDt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calStartDt.Location = new System.Drawing.Point(124, 168);
            this.calStartDt.Name = "calStartDt";
            this.calStartDt.Size = new System.Drawing.Size(471, 21);
            this.calStartDt.TabIndex = 127;
            // 
            // txtActDetail
            // 
            this.txtActDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActDetail.Location = new System.Drawing.Point(124, 249);
            this.txtActDetail.Multiline = true;
            this.txtActDetail.Name = "txtActDetail";
            this.txtActDetail.Size = new System.Drawing.Size(471, 90);
            this.txtActDetail.TabIndex = 125;
            // 
            // cboActComp
            // 
            this.cboActComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActComp.DisplayMember = "ITEM_NM";
            this.cboActComp.DropDownHeight = 1;
            this.cboActComp.FormattingEnabled = true;
            this.cboActComp.IntegralHeight = false;
            this.cboActComp.Location = new System.Drawing.Point(124, 115);
            this.cboActComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboActComp.MultiSelection = false;
            this.cboActComp.Name = "cboActComp";
            this.cboActComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActComp.Params")));
            this.cboActComp.Size = new System.Drawing.Size(471, 20);
            this.cboActComp.Sql = "CommonSearch#getCompList";
            this.cboActComp.TabIndex = 121;
            this.cboActComp.Text = "[SELECT]";
            this.cboActComp.ValueMember = "ITEM_CD";
            // 
            // cboActMgrComp
            // 
            this.cboActMgrComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActMgrComp.DisplayMember = "ITEM_NM";
            this.cboActMgrComp.DropDownHeight = 1;
            this.cboActMgrComp.FormattingEnabled = true;
            this.cboActMgrComp.IntegralHeight = false;
            this.cboActMgrComp.Location = new System.Drawing.Point(124, 88);
            this.cboActMgrComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboActMgrComp.MultiSelection = false;
            this.cboActMgrComp.Name = "cboActMgrComp";
            this.cboActMgrComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActMgrComp.Params")));
            this.cboActMgrComp.Size = new System.Drawing.Size(471, 20);
            this.cboActMgrComp.Sql = "CommonSearch#getCompList";
            this.cboActMgrComp.TabIndex = 118;
            this.cboActMgrComp.Text = "[SELECT]";
            this.cboActMgrComp.ValueMember = "ITEM_CD";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 90);
            this.label4.TabIndex = 114;
            this.label4.Text = "상세 내용";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(10, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 107;
            this.label6.Text = "수행 업체";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(10, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "관리 업체";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(10, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 101;
            this.label9.Text = "구분";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(10, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 21);
            this.label12.TabIndex = 99;
            this.label12.Text = "중요도";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProjectHistory";
            this.Size = new System.Drawing.Size(1077, 648);
            this.Load += new System.EventHandler(this.ProjectHistory_Load);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Project)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.PnlProDoc.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_ActionList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboProjectId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Control.MYCGrid gd_Project;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Control.MYCGrid gd_ActionList;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSave;
        private Control.CheckComboBox cbockMember;
        private Control.CheckComboBox cboMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWorkId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker calWorkDt;
        private System.Windows.Forms.Button btnActionAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker calStartDt;
        private System.Windows.Forms.TextBox txtActDetail;
        private Control.CheckComboBox cboActComp;
        private Control.CheckComboBox cboActMgrComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Control.CheckComboBox cboActRank;
        private Control.CheckComboBox cboActType;
        private Control.CheckComboBox cboActCompUser;
        private Control.CheckComboBox cboActClose;
        private System.Windows.Forms.DateTimePicker calEndDt;
        private System.Windows.Forms.Button btnActSave;
        private System.Windows.Forms.Panel PnlProDoc;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListBox LstLink;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label18;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label19;
    }
}
