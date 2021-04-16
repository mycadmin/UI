namespace MYC.UI.Report
{
    partial class ProjectEstimate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEstimate));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchComp = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gd_List = new MYC.Control.MYCGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gd_Group = new MYC.Control.MYCGrid();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboWarrType = new MYC.Control.CheckComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkVAT = new System.Windows.Forms.CheckBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cboCstUser = new MYC.Control.CheckComboBox();
            this.cboProject = new MYC.Control.CheckComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboCashType1 = new MYC.Control.CheckComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calWorkDt = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCashType2 = new MYC.Control.CheckComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnItemNew = new System.Windows.Forms.Button();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboQtyCode = new MYC.Control.CheckComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboItmModel = new MYC.Control.CheckComboBox();
            this.txtItemVat = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtItemUnitCost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.btnItemSave = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Group)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.gd_List);
            this.PlMainBody.Controls.Add(this.panel5);
            this.PlMainBody.Controls.Add(this.panel3);
            this.PlMainBody.Controls.Add(this.panel4);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Size = new System.Drawing.Size(868, 649);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(251, 649);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.Panel2);
            this.PlSearchBody.Controls.Add(this.LbSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(237, 617);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.btnSearch);
            this.Panel2.Controls.Add(this.btnNew);
            this.Panel2.Controls.Add(this.dtTo);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.dtFrom);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.cboSearchComp);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 28);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(237, 150);
            this.Panel2.TabIndex = 88;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNew.Location = new System.Drawing.Point(0, 129);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(237, 21);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "신 규";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.NewGroup);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(80, 40);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(147, 21);
            this.dtTo.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 91;
            this.label5.Text = "~";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Location = new System.Drawing.Point(80, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(147, 21);
            this.dtFrom.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 86;
            this.label4.Text = "조회기간";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(237, 21);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조 회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // cboSearchComp
            // 
            this.cboSearchComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchComp.DisplayMember = "ITEM_NM";
            this.cboSearchComp.DropDownHeight = 1;
            this.cboSearchComp.FormattingEnabled = true;
            this.cboSearchComp.IntegralHeight = false;
            this.cboSearchComp.Location = new System.Drawing.Point(80, 67);
            this.cboSearchComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboSearchComp.MultiSelection = false;
            this.cboSearchComp.Name = "cboSearchComp";
            this.cboSearchComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboSearchComp.Params")));
            this.cboSearchComp.Size = new System.Drawing.Size(147, 20);
            this.cboSearchComp.Sql = "CommonSearch#getCompList";
            this.cboSearchComp.TabIndex = 82;
            this.cboSearchComp.Text = "[SELECT]";
            this.cboSearchComp.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "고객사";
            // 
            // LbSearch
            // 
            this.LbSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbSearch.Location = new System.Drawing.Point(0, 0);
            this.LbSearch.Name = "LbSearch";
            this.LbSearch.Size = new System.Drawing.Size(237, 28);
            this.LbSearch.TabIndex = 87;
            this.LbSearch.Text = "조회 조건";
            this.LbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 40);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "■ 견적서 List";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 40);
            this.panel3.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "■ 품목";
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.AllowUserToResizeRows = false;
            this.gd_List.BackgroundColor = System.Drawing.Color.White;
            this.gd_List.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.EnableHeadersVisualStyles = false;
            this.gd_List.Location = new System.Drawing.Point(0, 305);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_List.Size = new System.Drawing.Size(314, 344);
            this.gd_List.TabIndex = 31;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewList);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gd_Group);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(868, 225);
            this.panel4.TabIndex = 33;
            // 
            // gd_Group
            // 
            this.gd_Group.AllowUserToAddRows = false;
            this.gd_Group.AllowUserToDeleteRows = false;
            this.gd_Group.AllowUserToResizeRows = false;
            this.gd_Group.BackgroundColor = System.Drawing.Color.White;
            this.gd_Group.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_Group.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gd_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Group.EnableHeadersVisualStyles = false;
            this.gd_Group.Location = new System.Drawing.Point(0, 0);
            this.gd_Group.MultiSelect = false;
            this.gd_Group.Name = "gd_Group";
            this.gd_Group.ReadOnly = true;
            this.gd_Group.RowHeadersVisible = false;
            this.gd_Group.RowTemplate.Height = 23;
            this.gd_Group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_Group.Size = new System.Drawing.Size(314, 225);
            this.gd_Group.TabIndex = 35;
            this.gd_Group.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGroup);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cboWarrType);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.chkVAT);
            this.panel7.Controls.Add(this.txtSubject);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.btnExcel);
            this.panel7.Controls.Add(this.cboCstUser);
            this.panel7.Controls.Add(this.cboProject);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.txtVat);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.txtCost);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.cboCashType1);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.calWorkDt);
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.cboCashType2);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txtDocId);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(314, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(554, 225);
            this.panel7.TabIndex = 33;
            // 
            // cboWarrType
            // 
            this.cboWarrType.DisplayMember = "ITEM_NM";
            this.cboWarrType.DropDownHeight = 1;
            this.cboWarrType.FormattingEnabled = true;
            this.cboWarrType.IntegralHeight = false;
            this.cboWarrType.Location = new System.Drawing.Point(95, 80);
            this.cboWarrType.Margin = new System.Windows.Forms.Padding(0);
            this.cboWarrType.MultiSelection = false;
            this.cboWarrType.Name = "cboWarrType";
            this.cboWarrType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboWarrType.Params")));
            this.cboWarrType.Size = new System.Drawing.Size(180, 20);
            this.cboWarrType.Sql = "CommonSearch#getCommonItems";
            this.cboWarrType.TabIndex = 148;
            this.cboWarrType.Text = "[SELECT]";
            this.cboWarrType.ValueMember = "ITEM_CD";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(4, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 147;
            this.label13.Text = "품질보증";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkVAT
            // 
            this.chkVAT.AutoSize = true;
            this.chkVAT.Location = new System.Drawing.Point(7, 160);
            this.chkVAT.Name = "chkVAT";
            this.chkVAT.Size = new System.Drawing.Size(88, 16);
            this.chkVAT.TabIndex = 146;
            this.chkVAT.Text = "부가세 포함";
            this.chkVAT.UseVisualStyleBackColor = true;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(370, 4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(180, 21);
            this.txtSubject.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(279, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 144;
            this.label18.Text = "견적서명";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(103, 193);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(90, 25);
            this.btnExcel.TabIndex = 143;
            this.btnExcel.Text = "발 행";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.ExportYN);
            // 
            // cboCstUser
            // 
            this.cboCstUser.DisplayMember = "ITEM_NM";
            this.cboCstUser.DropDownHeight = 1;
            this.cboCstUser.FormattingEnabled = true;
            this.cboCstUser.IntegralHeight = false;
            this.cboCstUser.Location = new System.Drawing.Point(370, 30);
            this.cboCstUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboCstUser.MultiSelection = false;
            this.cboCstUser.Name = "cboCstUser";
            this.cboCstUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCstUser.Params")));
            this.cboCstUser.Size = new System.Drawing.Size(180, 20);
            this.cboCstUser.Sql = "CommonSearch#getUserList";
            this.cboCstUser.TabIndex = 142;
            this.cboCstUser.Text = "[SELECT]";
            this.cboCstUser.ValueMember = "ITEM_CD";
            // 
            // cboProject
            // 
            this.cboProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProject.DisplayMember = "ITEM_NM";
            this.cboProject.DropDownHeight = 1;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.IntegralHeight = false;
            this.cboProject.Location = new System.Drawing.Point(95, 130);
            this.cboProject.Margin = new System.Windows.Forms.Padding(0);
            this.cboProject.MultiSelection = true;
            this.cboProject.Name = "cboProject";
            this.cboProject.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProject.Params")));
            this.cboProject.Size = new System.Drawing.Size(455, 20);
            this.cboProject.Sql = "CommonSearch#getProjectList";
            this.cboProject.TabIndex = 141;
            this.cboProject.Text = "[SELECT]";
            this.cboProject.ValueMember = "ITEM_CD";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(4, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 21);
            this.label17.TabIndex = 140;
            this.label17.Text = "프로젝트";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVat
            // 
            this.txtVat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVat.Location = new System.Drawing.Point(370, 104);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(180, 21);
            this.txtVat.TabIndex = 139;
            this.txtVat.TextChanged += new System.EventHandler(this.SetPrice);
            this.txtVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(279, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 21);
            this.label16.TabIndex = 138;
            this.label16.Text = "부가세";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCost.Location = new System.Drawing.Point(95, 104);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(180, 21);
            this.txtCost.TabIndex = 137;
            this.txtCost.TextChanged += new System.EventHandler(this.SetPrice);
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(279, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 21);
            this.label15.TabIndex = 136;
            this.label15.Text = "지불 방식";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCashType1
            // 
            this.cboCashType1.DisplayMember = "ITEM_NM";
            this.cboCashType1.DropDownHeight = 1;
            this.cboCashType1.FormattingEnabled = true;
            this.cboCashType1.IntegralHeight = false;
            this.cboCashType1.Location = new System.Drawing.Point(95, 55);
            this.cboCashType1.Margin = new System.Windows.Forms.Padding(0);
            this.cboCashType1.MultiSelection = false;
            this.cboCashType1.Name = "cboCashType1";
            this.cboCashType1.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCashType1.Params")));
            this.cboCashType1.Size = new System.Drawing.Size(180, 20);
            this.cboCashType1.Sql = "CommonSearch#getCommonItems";
            this.cboCashType1.TabIndex = 135;
            this.cboCashType1.Text = "[SELECT]";
            this.cboCashType1.ValueMember = "ITEM_CD";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(4, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 130;
            this.label9.Text = "합계";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(279, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 128;
            this.label7.Text = "고객 담당자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calWorkDt
            // 
            this.calWorkDt.Location = new System.Drawing.Point(95, 29);
            this.calWorkDt.Name = "calWorkDt";
            this.calWorkDt.Size = new System.Drawing.Size(180, 21);
            this.calWorkDt.TabIndex = 127;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "수 정";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveGroup);
            // 
            // cboCashType2
            // 
            this.cboCashType2.DisplayMember = "ITEM_NM";
            this.cboCashType2.DropDownHeight = 1;
            this.cboCashType2.FormattingEnabled = true;
            this.cboCashType2.IntegralHeight = false;
            this.cboCashType2.Location = new System.Drawing.Point(370, 55);
            this.cboCashType2.Margin = new System.Windows.Forms.Padding(0);
            this.cboCashType2.MultiSelection = false;
            this.cboCashType2.Name = "cboCashType2";
            this.cboCashType2.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCashType2.Params")));
            this.cboCashType2.Size = new System.Drawing.Size(180, 20);
            this.cboCashType2.Sql = "CommonSearch#getCommonItems";
            this.cboCashType2.TabIndex = 121;
            this.cboCashType2.Text = "[SELECT]";
            this.cboCashType2.ValueMember = "ITEM_CD";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(4, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 107;
            this.label8.Text = "지불 조건";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(4, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 101;
            this.label10.Text = "발행일";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDocId
            // 
            this.txtDocId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDocId.Location = new System.Drawing.Point(95, 4);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.ReadOnly = true;
            this.txtDocId.Size = new System.Drawing.Size(180, 21);
            this.txtDocId.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 99;
            this.label11.Text = "발행 코드";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnItemNew);
            this.panel5.Controls.Add(this.txtItemCost);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.cboQtyCode);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtQty);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtItemName);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.cboItmModel);
            this.panel5.Controls.Add(this.txtItemVat);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.txtItemUnitCost);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.txtItemDesc);
            this.panel5.Controls.Add(this.btnItemSave);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.txtNo);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(314, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 344);
            this.panel5.TabIndex = 34;
            // 
            // btnItemNew
            // 
            this.btnItemNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItemNew.Location = new System.Drawing.Point(103, 296);
            this.btnItemNew.Name = "btnItemNew";
            this.btnItemNew.Size = new System.Drawing.Size(90, 25);
            this.btnItemNew.TabIndex = 18;
            this.btnItemNew.Text = "추 가";
            this.btnItemNew.UseVisualStyleBackColor = true;
            this.btnItemNew.Click += new System.EventHandler(this.NewItem);
            // 
            // txtItemCost
            // 
            this.txtItemCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtItemCost.Location = new System.Drawing.Point(95, 179);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.ReadOnly = true;
            this.txtItemCost.Size = new System.Drawing.Size(454, 21);
            this.txtItemCost.TabIndex = 151;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(4, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 21);
            this.label20.TabIndex = 150;
            this.label20.Text = "합계";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboQtyCode
            // 
            this.cboQtyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboQtyCode.DisplayMember = "ITEM_NM";
            this.cboQtyCode.DropDownHeight = 1;
            this.cboQtyCode.FormattingEnabled = true;
            this.cboQtyCode.IntegralHeight = false;
            this.cboQtyCode.Location = new System.Drawing.Point(95, 105);
            this.cboQtyCode.Margin = new System.Windows.Forms.Padding(0);
            this.cboQtyCode.MultiSelection = false;
            this.cboQtyCode.Name = "cboQtyCode";
            this.cboQtyCode.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboQtyCode.Params")));
            this.cboQtyCode.Size = new System.Drawing.Size(455, 20);
            this.cboQtyCode.Sql = "CommonSearch#getCommonItems";
            this.cboQtyCode.TabIndex = 13;
            this.cboQtyCode.Text = "[SELECT]";
            this.cboQtyCode.ValueMember = "ITEM_CD";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(4, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 148;
            this.label12.Text = "단위";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.Location = new System.Drawing.Point(95, 79);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(454, 21);
            this.txtQty.TabIndex = 12;
            this.txtQty.TextChanged += new System.EventHandler(this.PriceChange);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(4, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 21);
            this.label14.TabIndex = 146;
            this.label14.Text = "수량";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Location = new System.Drawing.Point(95, 54);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(455, 21);
            this.txtItemName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(4, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 144;
            this.label6.Text = "제품명";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboItmModel
            // 
            this.cboItmModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboItmModel.DisplayMember = "ITEM_NM";
            this.cboItmModel.DropDownHeight = 1;
            this.cboItmModel.FormattingEnabled = true;
            this.cboItmModel.IntegralHeight = false;
            this.cboItmModel.Location = new System.Drawing.Point(94, 30);
            this.cboItmModel.Margin = new System.Windows.Forms.Padding(0);
            this.cboItmModel.MultiSelection = false;
            this.cboItmModel.Name = "cboItmModel";
            this.cboItmModel.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboItmModel.Params")));
            this.cboItmModel.Size = new System.Drawing.Size(455, 20);
            this.cboItmModel.Sql = "CommonSearch#getCstModelList";
            this.cboItmModel.TabIndex = 11;
            this.cboItmModel.TabStop = false;
            this.cboItmModel.Text = "[SELECT]";
            this.cboItmModel.ValueMember = "ITEM_CD";
            // 
            // txtItemVat
            // 
            this.txtItemVat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemVat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtItemVat.Location = new System.Drawing.Point(95, 154);
            this.txtItemVat.Name = "txtItemVat";
            this.txtItemVat.ReadOnly = true;
            this.txtItemVat.Size = new System.Drawing.Size(454, 21);
            this.txtItemVat.TabIndex = 15;
            this.txtItemVat.TextChanged += new System.EventHandler(this.PriceChange);
            this.txtItemVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(4, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 21);
            this.label19.TabIndex = 138;
            this.label19.Text = "부가세";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemUnitCost
            // 
            this.txtItemUnitCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemUnitCost.Location = new System.Drawing.Point(95, 129);
            this.txtItemUnitCost.Name = "txtItemUnitCost";
            this.txtItemUnitCost.Size = new System.Drawing.Size(454, 21);
            this.txtItemUnitCost.TabIndex = 14;
            this.txtItemUnitCost.TextChanged += new System.EventHandler(this.PriceChange);
            this.txtItemUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(4, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 21);
            this.label23.TabIndex = 130;
            this.label23.Text = "단가";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(3, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 21);
            this.label24.TabIndex = 128;
            this.label24.Text = "고객사 모델";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemDesc.Location = new System.Drawing.Point(95, 204);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(455, 82);
            this.txtItemDesc.TabIndex = 16;
            // 
            // btnItemSave
            // 
            this.btnItemSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItemSave.Location = new System.Drawing.Point(4, 296);
            this.btnItemSave.Name = "btnItemSave";
            this.btnItemSave.Size = new System.Drawing.Size(90, 25);
            this.btnItemSave.TabIndex = 17;
            this.btnItemSave.Text = "수 정";
            this.btnItemSave.UseVisualStyleBackColor = true;
            this.btnItemSave.Click += new System.EventHandler(this.SaveItem);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(4, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 82);
            this.label25.TabIndex = 114;
            this.label25.Text = "상세 내용";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNo
            // 
            this.txtNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNo.Location = new System.Drawing.Point(95, 4);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(454, 21);
            this.txtNo.TabIndex = 10;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.Location = new System.Drawing.Point(4, 4);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 21);
            this.label29.TabIndex = 99;
            this.label29.Text = "No";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProjectEstimate";
            this.Size = new System.Drawing.Size(1123, 649);
            this.Load += new System.EventHandler(this.ProjectEstimate_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Group)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboSearchComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private Control.MYCGrid gd_Group;
        private System.Windows.Forms.Panel panel7;
        private Control.CheckComboBox cboProject;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label15;
        private Control.CheckComboBox cboCashType1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker calWorkDt;
        private System.Windows.Forms.Button btnSave;
        private Control.CheckComboBox cboCashType2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtItemVat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtItemUnitCost;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.Button btnItemSave;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label29;
        private Control.CheckComboBox cboItmModel;
        private Control.CheckComboBox cboCstUser;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private Control.CheckComboBox cboQtyCode;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkVAT;
        private Control.CheckComboBox cboWarrType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnItemNew;
        private System.Windows.Forms.Button btnNew;
    }
}
