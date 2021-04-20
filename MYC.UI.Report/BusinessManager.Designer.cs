namespace MYC.UI.Report
{
    partial class BusinessManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbSearch = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cboCompUser = new MYC.Control.CheckComboBox();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboBusiness = new MYC.Control.CheckComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gd_List = new MYC.Control.MYCGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMyMemo = new System.Windows.Forms.TabPage();
            this.txtMyMemo = new System.Windows.Forms.TextBox();
            this.tabMemo = new System.Windows.Forms.TabPage();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDocumentNew = new System.Windows.Forms.Button();
            this.gd_Document = new MYC.Control.MYCGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gd_schedule = new MYC.Control.MYCGrid();
            this.btnScheduleAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMyMemo.SuspendLayout();
            this.tabMemo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Document)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.splitContainer1);
            this.PlMainBody.Controls.Add(this.panel4);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Size = new System.Drawing.Size(929, 665);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(268, 665);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel);
            this.PlSearchBody.Controls.Add(this.lbSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(254, 633);
            // 
            // lbSearch
            // 
            this.lbSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.lbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(254, 28);
            this.lbSearch.TabIndex = 85;
            this.lbSearch.Text = "조회 조건";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cboCompUser);
            this.panel.Controls.Add(this.cboComp);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.cboBusiness);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.btnAdd);
            this.panel.Controls.Add(this.dtTo);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.dtFrom);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.cboUser);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(254, 235);
            this.panel.TabIndex = 89;
            // 
            // cboCompUser
            // 
            this.cboCompUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCompUser.DisplayMember = "ITEM_NM";
            this.cboCompUser.DropDownHeight = 1;
            this.cboCompUser.FormattingEnabled = true;
            this.cboCompUser.IntegralHeight = false;
            this.cboCompUser.Location = new System.Drawing.Point(80, 94);
            this.cboCompUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboCompUser.MultiSelection = false;
            this.cboCompUser.Name = "cboCompUser";
            this.cboCompUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCompUser.Params")));
            this.cboCompUser.Size = new System.Drawing.Size(164, 20);
            this.cboCompUser.Sql = "CommonSearch#getUserList";
            this.cboCompUser.TabIndex = 99;
            this.cboCompUser.Text = "[SELECT]";
            this.cboCompUser.ValueMember = "ITEM_CD";
            // 
            // cboComp
            // 
            this.cboComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(80, 67);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(164, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 98;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            this.cboComp.TextChanged += new System.EventHandler(this.CompUserUpdate);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 97;
            this.label10.Text = "기관 담당자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 96;
            this.label9.Text = "기관명";
            // 
            // cboBusiness
            // 
            this.cboBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusiness.DisplayMember = "ITEM_NM";
            this.cboBusiness.DropDownHeight = 1;
            this.cboBusiness.FormattingEnabled = true;
            this.cboBusiness.IntegralHeight = false;
            this.cboBusiness.Location = new System.Drawing.Point(80, 148);
            this.cboBusiness.Margin = new System.Windows.Forms.Padding(0);
            this.cboBusiness.MultiSelection = false;
            this.cboBusiness.Name = "cboBusiness";
            this.cboBusiness.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboBusiness.Params")));
            this.cboBusiness.Size = new System.Drawing.Size(164, 20);
            this.cboBusiness.Sql = "CommonSearch#getBusinessList";
            this.cboBusiness.TabIndex = 95;
            this.cboBusiness.Text = "[SELECT]";
            this.cboBusiness.ValueMember = "ITEM_CD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 94;
            this.label6.Text = "사업명";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(0, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(254, 24);
            this.btnAdd.TabIndex = 93;
            this.btnAdd.Text = "사업추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.InsertBusiness);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(80, 40);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(164, 21);
            this.dtTo.TabIndex = 92;
            this.dtTo.ValueChanged += new System.EventHandler(this.SearchBusiness);
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
            this.dtFrom.Location = new System.Drawing.Point(80, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(164, 21);
            this.dtFrom.TabIndex = 90;
            this.dtFrom.ValueChanged += new System.EventHandler(this.SearchBusiness);
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
            this.btnSearch.Location = new System.Drawing.Point(0, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(254, 24);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.GetBusinessHistory);
            // 
            // cboUser
            // 
            this.cboUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(80, 121);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(164, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 82;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            this.cboUser.TextChanged += new System.EventHandler(this.SearchBusiness);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "담당자";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gd_List);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 300);
            this.panel1.TabIndex = 159;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.AllowUserToResizeRows = false;
            this.gd_List.BackgroundColor = System.Drawing.Color.White;
            this.gd_List.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.EnableHeadersVisualStyles = false;
            this.gd_List.Location = new System.Drawing.Point(0, 24);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_List.Size = new System.Drawing.Size(929, 276);
            this.gd_List.TabIndex = 27;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetItemInfo);
            this.gd_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusinessFix);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(929, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "■ 사업 목록";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 505);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(929, 160);
            this.panel4.TabIndex = 163;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabMyMemo);
            this.tabControl.Controls.Add(this.tabMemo);
            this.tabControl.Location = new System.Drawing.Point(3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(816, 147);
            this.tabControl.TabIndex = 95;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.BtnEnableControl);
            // 
            // tabMyMemo
            // 
            this.tabMyMemo.Controls.Add(this.txtMyMemo);
            this.tabMyMemo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabMyMemo.Location = new System.Drawing.Point(4, 22);
            this.tabMyMemo.Name = "tabMyMemo";
            this.tabMyMemo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyMemo.Size = new System.Drawing.Size(808, 121);
            this.tabMyMemo.TabIndex = 0;
            this.tabMyMemo.Text = "My Memo";
            this.tabMyMemo.UseVisualStyleBackColor = true;
            // 
            // txtMyMemo
            // 
            this.txtMyMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMyMemo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMyMemo.Location = new System.Drawing.Point(3, 3);
            this.txtMyMemo.Multiline = true;
            this.txtMyMemo.Name = "txtMyMemo";
            this.txtMyMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMyMemo.Size = new System.Drawing.Size(802, 115);
            this.txtMyMemo.TabIndex = 0;
            // 
            // tabMemo
            // 
            this.tabMemo.Controls.Add(this.txtMemo);
            this.tabMemo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabMemo.Location = new System.Drawing.Point(4, 22);
            this.tabMemo.Name = "tabMemo";
            this.tabMemo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemo.Size = new System.Drawing.Size(693, 121);
            this.tabMemo.TabIndex = 1;
            this.tabMemo.Text = "사업 Memo";
            this.tabMemo.UseVisualStyleBackColor = true;
            // 
            // txtMemo
            // 
            this.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMemo.Location = new System.Drawing.Point(3, 3);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemo.Size = new System.Drawing.Size(687, 115);
            this.txtMemo.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(825, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 126);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.MemoSave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDocumentNew);
            this.panel3.Controls.Add(this.gd_Document);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 205);
            this.panel3.TabIndex = 165;
            // 
            // btnDocumentNew
            // 
            this.btnDocumentNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocumentNew.Location = new System.Drawing.Point(428, 1);
            this.btnDocumentNew.Name = "btnDocumentNew";
            this.btnDocumentNew.Size = new System.Drawing.Size(70, 22);
            this.btnDocumentNew.TabIndex = 97;
            this.btnDocumentNew.Text = "문서 추가";
            this.btnDocumentNew.UseVisualStyleBackColor = true;
            this.btnDocumentNew.Click += new System.EventHandler(this.AddNewDocument);
            // 
            // gd_Document
            // 
            this.gd_Document.AllowUserToAddRows = false;
            this.gd_Document.AllowUserToDeleteRows = false;
            this.gd_Document.AllowUserToResizeRows = false;
            this.gd_Document.BackgroundColor = System.Drawing.Color.White;
            this.gd_Document.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_Document.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gd_Document.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Document.EnableHeadersVisualStyles = false;
            this.gd_Document.Location = new System.Drawing.Point(0, 24);
            this.gd_Document.MultiSelect = false;
            this.gd_Document.Name = "gd_Document";
            this.gd_Document.ReadOnly = true;
            this.gd_Document.RowHeadersVisible = false;
            this.gd_Document.RowTemplate.Height = 23;
            this.gd_Document.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_Document.Size = new System.Drawing.Size(498, 181);
            this.gd_Document.TabIndex = 96;
            this.gd_Document.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentControl);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(498, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "■ 첨부 문서";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gd_schedule);
            this.panel2.Controls.Add(this.btnScheduleAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 205);
            this.panel2.TabIndex = 166;
            // 
            // gd_schedule
            // 
            this.gd_schedule.AllowUserToAddRows = false;
            this.gd_schedule.AllowUserToDeleteRows = false;
            this.gd_schedule.AllowUserToResizeRows = false;
            this.gd_schedule.BackgroundColor = System.Drawing.Color.White;
            this.gd_schedule.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gd_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_schedule.EnableHeadersVisualStyles = false;
            this.gd_schedule.Location = new System.Drawing.Point(0, 24);
            this.gd_schedule.MultiSelect = false;
            this.gd_schedule.Name = "gd_schedule";
            this.gd_schedule.ReadOnly = true;
            this.gd_schedule.RowHeadersVisible = false;
            this.gd_schedule.RowTemplate.Height = 23;
            this.gd_schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_schedule.Size = new System.Drawing.Size(427, 181);
            this.gd_schedule.TabIndex = 95;
            this.gd_schedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetSchedule);
            // 
            // btnScheduleAdd
            // 
            this.btnScheduleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScheduleAdd.Location = new System.Drawing.Point(351, 1);
            this.btnScheduleAdd.Name = "btnScheduleAdd";
            this.btnScheduleAdd.Size = new System.Drawing.Size(70, 22);
            this.btnScheduleAdd.TabIndex = 94;
            this.btnScheduleAdd.Text = "일정 추가";
            this.btnScheduleAdd.UseVisualStyleBackColor = true;
            this.btnScheduleAdd.Click += new System.EventHandler(this.InsertSchedule);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "■ 사업 일정";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 300);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(929, 205);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 167;
            // 
            // BusinessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BusinessManager";
            this.Size = new System.Drawing.Size(1201, 665);
            this.Load += new System.EventHandler(this.BusinessManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMyMemo.ResumeLayout(false);
            this.tabMyMemo.PerformLayout();
            this.tabMemo.ResumeLayout(false);
            this.tabMemo.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Document)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_schedule)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private Control.CheckComboBox cboBusiness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private Control.MYCGrid gd_Document;
        private System.Windows.Forms.Panel panel2;
        private Control.MYCGrid gd_schedule;
        private System.Windows.Forms.Button btnScheduleAdd;
        private System.Windows.Forms.Label label2;
        private Control.CheckComboBox cboCompUser;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDocumentNew;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMyMemo;
        private System.Windows.Forms.TabPage tabMemo;
        private System.Windows.Forms.TextBox txtMyMemo;
        private System.Windows.Forms.TextBox txtMemo;
    }
}
