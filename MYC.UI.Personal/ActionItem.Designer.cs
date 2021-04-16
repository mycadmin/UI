namespace MYC.UI.Personal
{
    partial class ActionItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionItem));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.cboStatus = new MYC.Control.CheckComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboType2 = new MYC.Control.CheckComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboType1 = new MYC.Control.CheckComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMember = new MYC.Control.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdTgt = new System.Windows.Forms.RadioButton();
            this.rdCrt = new System.Windows.Forms.RadioButton();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboMemType = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gd_List = new MYC.Control.MYCGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gd_Item = new MYC.Control.MYCGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboItmExePer = new MYC.Control.CheckComboBox();
            this.cboItmStatus = new MYC.Control.CheckComboBox();
            this.btnItmFile = new System.Windows.Forms.Button();
            this.btnItmSubmit = new System.Windows.Forms.Button();
            this.btnItmRemove = new System.Windows.Forms.Button();
            this.txtItmDesc = new System.Windows.Forms.TextBox();
            this.dtItmClear = new System.Windows.Forms.DateTimePicker();
            this.cboItmPer = new MYC.Control.CheckComboBox();
            this.dtItmTarget = new System.Windows.Forms.DateTimePicker();
            this.txtItmSubject = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Item)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.splitContainer1);
            this.PlMainBody.Size = new System.Drawing.Size(899, 689);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(260, 689);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.Panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(246, 657);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.cboStatus);
            this.Panel2.Controls.Add(this.label6);
            this.Panel2.Controls.Add(this.cboType2);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.cboType1);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.cboMember);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.rdTgt);
            this.Panel2.Controls.Add(this.rdCrt);
            this.Panel2.Controls.Add(this.dtTo);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.dtFrom);
            this.Panel2.Controls.Add(this.label18);
            this.Panel2.Controls.Add(this.btnSearch);
            this.Panel2.Controls.Add(this.cboMemType);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 28);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(246, 263);
            this.Panel2.TabIndex = 86;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.DisplayMember = "ITEM_NM";
            this.cboStatus.DropDownHeight = 1;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.Location = new System.Drawing.Point(78, 204);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboStatus.MultiSelection = false;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboStatus.Params")));
            this.cboStatus.Size = new System.Drawing.Size(160, 20);
            this.cboStatus.Sql = "CommonSearch#getCommonItems";
            this.cboStatus.TabIndex = 108;
            this.cboStatus.Text = "[SELECT]";
            this.cboStatus.ValueMember = "ITEM_CD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 12);
            this.label6.TabIndex = 107;
            this.label6.Text = "진행 상태";
            // 
            // cboType2
            // 
            this.cboType2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType2.DisplayMember = "ITEM_NM";
            this.cboType2.DropDownHeight = 1;
            this.cboType2.FormattingEnabled = true;
            this.cboType2.IntegralHeight = false;
            this.cboType2.Location = new System.Drawing.Point(78, 177);
            this.cboType2.Margin = new System.Windows.Forms.Padding(0);
            this.cboType2.MultiSelection = false;
            this.cboType2.Name = "cboType2";
            this.cboType2.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType2.Params")));
            this.cboType2.Size = new System.Drawing.Size(160, 20);
            this.cboType2.Sql = "CommonSearch#getCommonItems";
            this.cboType2.TabIndex = 106;
            this.cboType2.Text = "[SELECT]";
            this.cboType2.ValueMember = "ITEM_CD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 105;
            this.label5.Text = "상세 구분";
            // 
            // cboType1
            // 
            this.cboType1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType1.DisplayMember = "ITEM_NM";
            this.cboType1.DropDownHeight = 1;
            this.cboType1.FormattingEnabled = true;
            this.cboType1.IntegralHeight = false;
            this.cboType1.Location = new System.Drawing.Point(78, 150);
            this.cboType1.Margin = new System.Windows.Forms.Padding(0);
            this.cboType1.MultiSelection = false;
            this.cboType1.Name = "cboType1";
            this.cboType1.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType1.Params")));
            this.cboType1.Size = new System.Drawing.Size(160, 20);
            this.cboType1.Sql = "CommonSearch#getCommonItems";
            this.cboType1.TabIndex = 104;
            this.cboType1.Text = "[SELECT]";
            this.cboType1.ValueMember = "ITEM_CD";
            this.cboType1.TextChanged += new System.EventHandler(this.GetType2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 103;
            this.label4.Text = "업무 영역";
            // 
            // cboMember
            // 
            this.cboMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMember.DisplayMember = "ITEM_NM";
            this.cboMember.DropDownHeight = 1;
            this.cboMember.FormattingEnabled = true;
            this.cboMember.IntegralHeight = false;
            this.cboMember.Location = new System.Drawing.Point(78, 123);
            this.cboMember.Margin = new System.Windows.Forms.Padding(0);
            this.cboMember.MultiSelection = false;
            this.cboMember.Name = "cboMember";
            this.cboMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboMember.Params")));
            this.cboMember.Size = new System.Drawing.Size(160, 20);
            this.cboMember.Sql = "CommonSearch#getUserList";
            this.cboMember.TabIndex = 102;
            this.cboMember.Text = "[SELECT]";
            this.cboMember.ValueMember = "ITEM_CD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 101;
            this.label2.Text = "구 성 원";
            // 
            // rdTgt
            // 
            this.rdTgt.AutoSize = true;
            this.rdTgt.Location = new System.Drawing.Point(147, 71);
            this.rdTgt.Name = "rdTgt";
            this.rdTgt.Size = new System.Drawing.Size(59, 16);
            this.rdTgt.TabIndex = 100;
            this.rdTgt.Text = "목표일";
            this.rdTgt.UseVisualStyleBackColor = true;
            // 
            // rdCrt
            // 
            this.rdCrt.AutoSize = true;
            this.rdCrt.Checked = true;
            this.rdCrt.Location = new System.Drawing.Point(82, 71);
            this.rdCrt.Name = "rdCrt";
            this.rdCrt.Size = new System.Drawing.Size(59, 16);
            this.rdCrt.TabIndex = 99;
            this.rdCrt.TabStop = true;
            this.rdCrt.Text = "등록일";
            this.rdCrt.UseVisualStyleBackColor = true;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(78, 42);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(160, 21);
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
            this.dtFrom.Size = new System.Drawing.Size(160, 21);
            this.dtFrom.TabIndex = 96;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 12);
            this.label18.TabIndex = 95;
            this.label18.Text = "조회 기간";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 236);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(246, 27);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // cboMemType
            // 
            this.cboMemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMemType.DisplayMember = "ITEM_NM";
            this.cboMemType.DropDownHeight = 1;
            this.cboMemType.FormattingEnabled = true;
            this.cboMemType.IntegralHeight = false;
            this.cboMemType.Location = new System.Drawing.Point(78, 96);
            this.cboMemType.Margin = new System.Windows.Forms.Padding(0);
            this.cboMemType.MultiSelection = false;
            this.cboMemType.Name = "cboMemType";
            this.cboMemType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboMemType.Params")));
            this.cboMemType.Size = new System.Drawing.Size(160, 20);
            this.cboMemType.Sql = "CommonSearch#getCommonItems";
            this.cboMemType.TabIndex = 82;
            this.cboMemType.Text = "[SELECT]";
            this.cboMemType.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "조회 기준";
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(246, 28);
            this.LbModelSearch.TabIndex = 85;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gd_List);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gd_Item);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(899, 689);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.AllowUserToResizeRows = false;
            this.gd_List.BackgroundColor = System.Drawing.Color.White;
            this.gd_List.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.EnableHeadersVisualStyles = false;
            this.gd_List.Location = new System.Drawing.Point(0, 42);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_List.Size = new System.Drawing.Size(899, 257);
            this.gd_List.TabIndex = 8;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewActionDetail);
            this.gd_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActionItemConfirm);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LbTitle);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 42);
            this.panel3.TabIndex = 7;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbTitle.Location = new System.Drawing.Point(3, 11);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(96, 15);
            this.LbTitle.TabIndex = 126;
            this.LbTitle.Text = "■ 업무 목록";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(823, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 21);
            this.btnAdd.TabIndex = 103;
            this.btnAdd.Text = "신규등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.NewActionItem);
            // 
            // gd_Item
            // 
            this.gd_Item.AllowUserToAddRows = false;
            this.gd_Item.AllowUserToDeleteRows = false;
            this.gd_Item.AllowUserToResizeRows = false;
            this.gd_Item.BackgroundColor = System.Drawing.Color.White;
            this.gd_Item.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gd_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Item.EnableHeadersVisualStyles = false;
            this.gd_Item.Location = new System.Drawing.Point(0, 42);
            this.gd_Item.MultiSelect = false;
            this.gd_Item.Name = "gd_Item";
            this.gd_Item.ReadOnly = true;
            this.gd_Item.RowHeadersVisible = false;
            this.gd_Item.RowTemplate.Height = 23;
            this.gd_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_Item.Size = new System.Drawing.Size(558, 344);
            this.gd_Item.TabIndex = 9;
            this.gd_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewActionItemDetail);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboItmExePer);
            this.panel4.Controls.Add(this.cboItmStatus);
            this.panel4.Controls.Add(this.btnItmFile);
            this.panel4.Controls.Add(this.btnItmSubmit);
            this.panel4.Controls.Add(this.btnItmRemove);
            this.panel4.Controls.Add(this.txtItmDesc);
            this.panel4.Controls.Add(this.dtItmClear);
            this.panel4.Controls.Add(this.cboItmPer);
            this.panel4.Controls.Add(this.dtItmTarget);
            this.panel4.Controls.Add(this.txtItmSubject);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(558, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 344);
            this.panel4.TabIndex = 8;
            // 
            // cboItmExePer
            // 
            this.cboItmExePer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboItmExePer.DisplayMember = "ITEM_NM";
            this.cboItmExePer.DropDownHeight = 1;
            this.cboItmExePer.FormattingEnabled = true;
            this.cboItmExePer.IntegralHeight = false;
            this.cboItmExePer.Location = new System.Drawing.Point(60, 87);
            this.cboItmExePer.Margin = new System.Windows.Forms.Padding(0);
            this.cboItmExePer.MultiSelection = false;
            this.cboItmExePer.Name = "cboItmExePer";
            this.cboItmExePer.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboItmExePer.Params")));
            this.cboItmExePer.Size = new System.Drawing.Size(274, 20);
            this.cboItmExePer.Sql = "CommonSearch#getNumList";
            this.cboItmExePer.TabIndex = 137;
            this.cboItmExePer.Text = "[SELECT]";
            this.cboItmExePer.ValueMember = "ITEM_CD";
            // 
            // cboItmStatus
            // 
            this.cboItmStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboItmStatus.DisplayMember = "ITEM_NM";
            this.cboItmStatus.DropDownHeight = 1;
            this.cboItmStatus.FormattingEnabled = true;
            this.cboItmStatus.IntegralHeight = false;
            this.cboItmStatus.Location = new System.Drawing.Point(60, 141);
            this.cboItmStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboItmStatus.MultiSelection = false;
            this.cboItmStatus.Name = "cboItmStatus";
            this.cboItmStatus.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboItmStatus.Params")));
            this.cboItmStatus.Size = new System.Drawing.Size(274, 20);
            this.cboItmStatus.Sql = "CommonSearch#getCommonItems";
            this.cboItmStatus.TabIndex = 136;
            this.cboItmStatus.Text = "[SELECT]";
            this.cboItmStatus.ValueMember = "ITEM_CD";
            // 
            // btnItmFile
            // 
            this.btnItmFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItmFile.Enabled = false;
            this.btnItmFile.Location = new System.Drawing.Point(158, 316);
            this.btnItmFile.Name = "btnItmFile";
            this.btnItmFile.Size = new System.Drawing.Size(70, 21);
            this.btnItmFile.TabIndex = 135;
            this.btnItmFile.Text = "첨부관리";
            this.btnItmFile.UseVisualStyleBackColor = true;
            this.btnItmFile.Click += new System.EventHandler(this.FileProcess);
            // 
            // btnItmSubmit
            // 
            this.btnItmSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItmSubmit.Enabled = false;
            this.btnItmSubmit.Location = new System.Drawing.Point(82, 316);
            this.btnItmSubmit.Name = "btnItmSubmit";
            this.btnItmSubmit.Size = new System.Drawing.Size(70, 21);
            this.btnItmSubmit.TabIndex = 134;
            this.btnItmSubmit.Text = "저 장";
            this.btnItmSubmit.UseVisualStyleBackColor = true;
            this.btnItmSubmit.Click += new System.EventHandler(this.ActionItemSave);
            // 
            // btnItmRemove
            // 
            this.btnItmRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItmRemove.Enabled = false;
            this.btnItmRemove.Location = new System.Drawing.Point(6, 316);
            this.btnItmRemove.Name = "btnItmRemove";
            this.btnItmRemove.Size = new System.Drawing.Size(70, 21);
            this.btnItmRemove.TabIndex = 133;
            this.btnItmRemove.Text = "삭 제";
            this.btnItmRemove.UseVisualStyleBackColor = true;
            this.btnItmRemove.Click += new System.EventHandler(this.RemoveActionItem);
            // 
            // txtItmDesc
            // 
            this.txtItmDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItmDesc.Location = new System.Drawing.Point(60, 172);
            this.txtItmDesc.MaxLength = 4000;
            this.txtItmDesc.Multiline = true;
            this.txtItmDesc.Name = "txtItmDesc";
            this.txtItmDesc.Size = new System.Drawing.Size(274, 138);
            this.txtItmDesc.TabIndex = 132;
            // 
            // dtItmClear
            // 
            this.dtItmClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtItmClear.CustomFormat = "";
            this.dtItmClear.Location = new System.Drawing.Point(60, 114);
            this.dtItmClear.Name = "dtItmClear";
            this.dtItmClear.Size = new System.Drawing.Size(274, 21);
            this.dtItmClear.TabIndex = 130;
            this.dtItmClear.Visible = false;
            // 
            // cboItmPer
            // 
            this.cboItmPer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboItmPer.DisplayMember = "ITEM_NM";
            this.cboItmPer.DropDownHeight = 1;
            this.cboItmPer.FormattingEnabled = true;
            this.cboItmPer.IntegralHeight = false;
            this.cboItmPer.Location = new System.Drawing.Point(60, 60);
            this.cboItmPer.Margin = new System.Windows.Forms.Padding(0);
            this.cboItmPer.MultiSelection = false;
            this.cboItmPer.Name = "cboItmPer";
            this.cboItmPer.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboItmPer.Params")));
            this.cboItmPer.Size = new System.Drawing.Size(274, 20);
            this.cboItmPer.Sql = "CommonSearch#getNumList";
            this.cboItmPer.TabIndex = 129;
            this.cboItmPer.Text = "[SELECT]";
            this.cboItmPer.ValueMember = "ITEM_CD";
            // 
            // dtItmTarget
            // 
            this.dtItmTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtItmTarget.CustomFormat = "";
            this.dtItmTarget.Location = new System.Drawing.Point(60, 33);
            this.dtItmTarget.Name = "dtItmTarget";
            this.dtItmTarget.Size = new System.Drawing.Size(274, 21);
            this.dtItmTarget.TabIndex = 127;
            // 
            // txtItmSubject
            // 
            this.txtItmSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItmSubject.Location = new System.Drawing.Point(60, 6);
            this.txtItmSubject.Name = "txtItmSubject";
            this.txtItmSubject.Size = new System.Drawing.Size(274, 21);
            this.txtItmSubject.TabIndex = 126;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(4, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 138);
            this.label14.TabIndex = 102;
            this.label14.Text = "진  행         사  항";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(4, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 12);
            this.label13.TabIndex = 101;
            this.label13.Text = "결  과";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(4, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 12);
            this.label12.TabIndex = 100;
            this.label12.Text = "완료일";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(4, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 12);
            this.label11.TabIndex = 99;
            this.label11.Text = "진행도";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(4, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 12);
            this.label10.TabIndex = 98;
            this.label10.Text = "비  중";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(4, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 12);
            this.label9.TabIndex = 97;
            this.label9.Text = "목표일";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 12);
            this.label8.TabIndex = 96;
            this.label8.Text = "내  용";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(60, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(274, 21);
            this.textBox1.TabIndex = 138;
            this.textBox1.Text = "미 완료 일정입니다.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 42);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 126;
            this.label7.Text = "■ 상세 정보";
            // 
            // ActionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ActionItem";
            this.Size = new System.Drawing.Size(1163, 689);
            this.Load += new System.EventHandler(this.ActionItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Item)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private Control.CheckComboBox cboStatus;
        private System.Windows.Forms.Label label6;
        private Control.CheckComboBox cboType2;
        private System.Windows.Forms.Label label5;
        private Control.CheckComboBox cboType1;
        private System.Windows.Forms.Label label4;
        private Control.CheckComboBox cboMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdTgt;
        private System.Windows.Forms.RadioButton rdCrt;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboMemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Control.MYCGrid gd_Item;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnItmFile;
        private System.Windows.Forms.Button btnItmSubmit;
        private System.Windows.Forms.Button btnItmRemove;
        private System.Windows.Forms.TextBox txtItmDesc;
        private System.Windows.Forms.DateTimePicker dtItmClear;
        private Control.CheckComboBox cboItmPer;
        private System.Windows.Forms.DateTimePicker dtItmTarget;
        private System.Windows.Forms.TextBox txtItmSubject;
        private Control.CheckComboBox cboItmStatus;
        private Control.CheckComboBox cboItmExePer;
        private System.Windows.Forms.TextBox textBox1;
        private Control.MYCGrid gd_List;
    }
}
