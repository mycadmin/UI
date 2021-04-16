
namespace MYC.UI.Admin
{
    partial class DocumentConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentConfirm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cboCrtUser = new MYC.Control.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDocType = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gd_List = new Control.MYCGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtLval = new System.Windows.Forms.TextBox();
            this.txtDocDesc = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.gd_Detail = new Control.MYCGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDocType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Detail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.splitContainer1);
            this.PlMainBody.Size = new System.Drawing.Size(773, 600);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(223, 600);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel1);
            this.PlSearchBody.Size = new System.Drawing.Size(209, 568);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbAll);
            this.panel1.Controls.Add(this.cboCrtUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboDocType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.LbModelSearch);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 223);
            this.panel1.TabIndex = 0;
            // 
            // cbAll
            // 
            this.cbAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(130, 100);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(76, 16);
            this.cbAll.TabIndex = 109;
            this.cbAll.Text = "전체 조회";
            this.cbAll.UseVisualStyleBackColor = true;
            // 
            // cboCrtUser
            // 
            this.cboCrtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCrtUser.DisplayMember = "ITEM_NM";
            this.cboCrtUser.DropDownHeight = 1;
            this.cboCrtUser.FormattingEnabled = true;
            this.cboCrtUser.IntegralHeight = false;
            this.cboCrtUser.Location = new System.Drawing.Point(68, 166);
            this.cboCrtUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboCrtUser.MultiSelection = true;
            this.cboCrtUser.Name = "cboCrtUser";
            this.cboCrtUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCrtUser.Params")));
            this.cboCrtUser.Size = new System.Drawing.Size(138, 20);
            this.cboCrtUser.Sql = "CommonSearch#getUserList";
            this.cboCrtUser.TabIndex = 108;
            this.cboCrtUser.Text = "[SELECT]";
            this.cboCrtUser.ValueMember = "ITEM_CD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 107;
            this.label2.Text = "작성자명";
            // 
            // cboDocType
            // 
            this.cboDocType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDocType.DisplayMember = "ITEM_NM";
            this.cboDocType.DropDownHeight = 1;
            this.cboDocType.FormattingEnabled = true;
            this.cboDocType.IntegralHeight = false;
            this.cboDocType.Location = new System.Drawing.Point(68, 133);
            this.cboDocType.Margin = new System.Windows.Forms.Padding(0);
            this.cboDocType.MultiSelection = true;
            this.cboDocType.Name = "cboDocType";
            this.cboDocType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboDocType.Params")));
            this.cboDocType.Size = new System.Drawing.Size(138, 20);
            this.cboDocType.Sql = "CommonSearch#getCommonItems";
            this.cboDocType.TabIndex = 106;
            this.cboDocType.Text = "[SELECT]";
            this.cboDocType.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 105;
            this.label1.Text = "문서명";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 196);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(209, 27);
            this.btnSearch.TabIndex = 104;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(209, 28);
            this.LbModelSearch.TabIndex = 99;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(68, 73);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(138, 21);
            this.dtTo.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 102;
            this.label3.Text = "~";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Location = new System.Drawing.Point(68, 34);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(138, 21);
            this.dtFrom.TabIndex = 101;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(3, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 12);
            this.label18.TabIndex = 100;
            this.label18.Text = "조회 기간";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gd_List);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(773, 600);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // gd_List
            // 
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 38);
            this.gd_List.Name = "gd_List";
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.Size = new System.Drawing.Size(773, 219);
            this.gd_List.TabIndex = 1;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDocumentList);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LbTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 38);
            this.panel2.TabIndex = 0;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbTitle.Location = new System.Drawing.Point(3, 11);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(96, 15);
            this.LbTitle.TabIndex = 127;
            this.LbTitle.Text = "■ 문서 목록";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 38);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtDocType);
            this.splitContainer2.Panel1.Controls.Add(this.txtLval);
            this.splitContainer2.Panel1.Controls.Add(this.txtDocDesc);
            this.splitContainer2.Panel1.Controls.Add(this.txtNote);
            this.splitContainer2.Panel1.Controls.Add(this.txtSite);
            this.splitContainer2.Panel1.Controls.Add(this.txtSub);
            this.splitContainer2.Panel1.Controls.Add(this.dtEnd);
            this.splitContainer2.Panel1.Controls.Add(this.dtStart);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label25);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gd_Detail);
            this.splitContainer2.Size = new System.Drawing.Size(773, 304);
            this.splitContainer2.SplitterDistance = 449;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 2;
            // 
            // txtLval
            // 
            this.txtLval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLval.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLval.Font = new System.Drawing.Font("굴림", 15F);
            this.txtLval.Location = new System.Drawing.Point(143, 197);
            this.txtLval.Name = "txtLval";
            this.txtLval.ReadOnly = true;
            this.txtLval.Size = new System.Drawing.Size(293, 30);
            this.txtLval.TabIndex = 215;
            // 
            // txtDocDesc
            // 
            this.txtDocDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDocDesc.Font = new System.Drawing.Font("굴림", 15F);
            this.txtDocDesc.Location = new System.Drawing.Point(143, 228);
            this.txtDocDesc.Multiline = true;
            this.txtDocDesc.Name = "txtDocDesc";
            this.txtDocDesc.ReadOnly = true;
            this.txtDocDesc.Size = new System.Drawing.Size(293, 68);
            this.txtDocDesc.TabIndex = 213;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNote.Font = new System.Drawing.Font("굴림", 15F);
            this.txtNote.Location = new System.Drawing.Point(143, 104);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(293, 30);
            this.txtNote.TabIndex = 212;
            // 
            // txtSite
            // 
            this.txtSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSite.Font = new System.Drawing.Font("굴림", 15F);
            this.txtSite.Location = new System.Drawing.Point(143, 166);
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            this.txtSite.Size = new System.Drawing.Size(293, 30);
            this.txtSite.TabIndex = 211;
            // 
            // txtSub
            // 
            this.txtSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSub.Font = new System.Drawing.Font("굴림", 15F);
            this.txtSub.Location = new System.Drawing.Point(143, 135);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(293, 30);
            this.txtSub.TabIndex = 210;
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtEnd.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CustomFormat = "yyyy년 MM월 dd일 dddd";
            this.dtEnd.Enabled = false;
            this.dtEnd.Font = new System.Drawing.Font("굴림", 15F);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(143, 73);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(293, 30);
            this.dtEnd.TabIndex = 207;
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtStart.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CustomFormat = "yyyy년 MM월 dd일 dddd";
            this.dtStart.Enabled = false;
            this.dtStart.Font = new System.Drawing.Font("굴림", 15F);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(143, 42);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(293, 30);
            this.dtStart.TabIndex = 206;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 205;
            this.label4.Text = "문서 코드";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 30);
            this.label6.TabIndex = 204;
            this.label6.Text = "종료 일시";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 203;
            this.label5.Text = "시작 일시";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(8, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 30);
            this.label8.TabIndex = 202;
            this.label8.Text = "출장 지역";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(8, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 30);
            this.label9.TabIndex = 201;
            this.label9.Text = "출장 목적";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(8, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 30);
            this.label10.TabIndex = 200;
            this.label10.Text = "추가 인원";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(8, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 30);
            this.label11.TabIndex = 199;
            this.label11.Text = "문서 종류";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(8, 228);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(130, 68);
            this.label25.TabIndex = 198;
            this.label25.Text = "상세 내용\r\n(비고)";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gd_Detail
            // 
            this.gd_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Detail.Location = new System.Drawing.Point(0, 0);
            this.gd_Detail.Name = "gd_Detail";
            this.gd_Detail.RowTemplate.Height = 23;
            this.gd_Detail.Size = new System.Drawing.Size(323, 304);
            this.gd_Detail.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 38);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 127;
            this.label7.Text = "■ 상세 정보";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(705, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(63, 27);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "검토";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.ConfirmPopup);
            // 
            // txtDocType
            // 
            this.txtDocType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDocType.Font = new System.Drawing.Font("굴림", 15F);
            this.txtDocType.Location = new System.Drawing.Point(143, 11);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.ReadOnly = true;
            this.txtDocType.Size = new System.Drawing.Size(293, 30);
            this.txtDocType.TabIndex = 216;
            // 
            // DocumentConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DocumentConfirm";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.DocumentConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Detail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboCrtUser;
        private System.Windows.Forms.Label label2;
        private Control.CheckComboBox cboDocType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtDocDesc;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label25;
        private Control.MYCGrid gd_Detail;
        private System.Windows.Forms.TextBox txtLval;
        private System.Windows.Forms.TextBox txtDocType;
    }
}
