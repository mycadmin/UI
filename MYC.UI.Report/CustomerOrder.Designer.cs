namespace MYC.UI.Report
{
    partial class CustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrder));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gd_detail = new Control.MYCGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gd_List = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkComboBox3 = new MYC.Control.CheckComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkComboBox2 = new MYC.Control.CheckComboBox();
            this.checkComboBox1 = new MYC.Control.CheckComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calWorkDt = new System.Windows.Forms.DateTimePicker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbockMember = new MYC.Control.CheckComboBox();
            this.cboMember = new MYC.Control.CheckComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWorkId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkComboBox4 = new MYC.Control.CheckComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkComboBox5 = new MYC.Control.CheckComboBox();
            this.checkComboBox6 = new MYC.Control.CheckComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkComboBox7 = new MYC.Control.CheckComboBox();
            this.checkComboBox8 = new MYC.Control.CheckComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.checkComboBox9 = new MYC.Control.CheckComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_detail)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.gd_detail);
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
            this.PlSearchBody.Controls.Add(this.panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(237, 617);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtTo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtFrom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.cboComp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 139);
            this.panel2.TabIndex = 88;
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
            this.btnSearch.Location = new System.Drawing.Point(5, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.cboComp.Size = new System.Drawing.Size(147, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 82;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
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
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(237, 28);
            this.LbModelSearch.TabIndex = 87;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 40);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(791, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 86;
            this.button1.Text = "신규";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "■ 발주 List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 40);
            this.panel3.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(791, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 86;
            this.button2.Text = "신규";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "■ 발주 품목";
            // 
            // gd_detail
            // 
            this.gd_detail.AllowUserToAddRows = false;
            this.gd_detail.AllowUserToDeleteRows = false;
            this.gd_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_detail.Location = new System.Drawing.Point(0, 325);
            this.gd_detail.MultiSelect = false;
            this.gd_detail.Name = "gd_detail";
            this.gd_detail.ReadOnly = true;
            this.gd_detail.RowHeadersVisible = false;
            this.gd_detail.RowTemplate.Height = 23;
            this.gd_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_detail.Size = new System.Drawing.Size(414, 324);
            this.gd_detail.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gd_List);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(868, 245);
            this.panel4.TabIndex = 33;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 0);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_List.Size = new System.Drawing.Size(414, 245);
            this.gd_List.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.checkComboBox3);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.checkComboBox2);
            this.panel7.Controls.Add(this.checkComboBox1);
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.calWorkDt);
            this.panel7.Controls.Add(this.txtDesc);
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.cbockMember);
            this.panel7.Controls.Add(this.cboMember);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txtWorkId);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(414, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 245);
            this.panel7.TabIndex = 33;
            // 
            // checkComboBox3
            // 
            this.checkComboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox3.DisplayMember = "ITEM_NM";
            this.checkComboBox3.DropDownHeight = 1;
            this.checkComboBox3.FormattingEnabled = true;
            this.checkComboBox3.IntegralHeight = false;
            this.checkComboBox3.Location = new System.Drawing.Point(95, 125);
            this.checkComboBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox3.MultiSelection = true;
            this.checkComboBox3.Name = "checkComboBox3";
            this.checkComboBox3.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox3.Params")));
            this.checkComboBox3.Size = new System.Drawing.Size(355, 20);
            this.checkComboBox3.Sql = "CommonSearch#getUserList";
            this.checkComboBox3.TabIndex = 141;
            this.checkComboBox3.Text = "[SELECT]";
            this.checkComboBox3.ValueMember = "ITEM_CD";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(4, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 21);
            this.label17.TabIndex = 140;
            this.label17.Text = "프로젝트";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(320, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 21);
            this.textBox3.TabIndex = 139;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(229, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 21);
            this.label16.TabIndex = 138;
            this.label16.Text = "부가세";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 21);
            this.textBox2.TabIndex = 137;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(229, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 21);
            this.label15.TabIndex = 136;
            this.label15.Text = "지불 방식";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkComboBox2
            // 
            this.checkComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox2.DisplayMember = "ITEM_NM";
            this.checkComboBox2.DropDownHeight = 1;
            this.checkComboBox2.FormattingEnabled = true;
            this.checkComboBox2.IntegralHeight = false;
            this.checkComboBox2.Location = new System.Drawing.Point(95, 77);
            this.checkComboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox2.MultiSelection = false;
            this.checkComboBox2.Name = "checkComboBox2";
            this.checkComboBox2.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox2.Params")));
            this.checkComboBox2.Size = new System.Drawing.Size(130, 20);
            this.checkComboBox2.Sql = "CommonSearch#getUserList";
            this.checkComboBox2.TabIndex = 135;
            this.checkComboBox2.Text = "[SELECT]";
            this.checkComboBox2.ValueMember = "ITEM_CD";
            // 
            // checkComboBox1
            // 
            this.checkComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox1.DisplayMember = "ITEM_NM";
            this.checkComboBox1.DropDownHeight = 1;
            this.checkComboBox1.FormattingEnabled = true;
            this.checkComboBox1.IntegralHeight = false;
            this.checkComboBox1.Location = new System.Drawing.Point(320, 53);
            this.checkComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox1.MultiSelection = false;
            this.checkComboBox1.Name = "checkComboBox1";
            this.checkComboBox1.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox1.Params")));
            this.checkComboBox1.Size = new System.Drawing.Size(130, 20);
            this.checkComboBox1.Sql = "CommonSearch#getUserList";
            this.checkComboBox1.TabIndex = 134;
            this.checkComboBox1.Text = "[SELECT]";
            this.checkComboBox1.ValueMember = "ITEM_CD";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker1.TabIndex = 133;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(229, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 21);
            this.label14.TabIndex = 132;
            this.label14.Text = "납품일";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(229, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 131;
            this.label12.Text = "납품 장소";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(4, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 130;
            this.label9.Text = "합계";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(229, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 128;
            this.label7.Text = "고객사 코드";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calWorkDt
            // 
            this.calWorkDt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calWorkDt.Location = new System.Drawing.Point(95, 28);
            this.calWorkDt.Name = "calWorkDt";
            this.calWorkDt.Size = new System.Drawing.Size(130, 21);
            this.calWorkDt.TabIndex = 127;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(95, 148);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(355, 65);
            this.txtDesc.TabIndex = 125;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(4, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cbockMember
            // 
            this.cbockMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbockMember.DisplayMember = "ITEM_NM";
            this.cbockMember.DropDownHeight = 1;
            this.cbockMember.FormattingEnabled = true;
            this.cbockMember.IntegralHeight = false;
            this.cbockMember.Location = new System.Drawing.Point(320, 77);
            this.cbockMember.Margin = new System.Windows.Forms.Padding(0);
            this.cbockMember.MultiSelection = true;
            this.cbockMember.Name = "cbockMember";
            this.cbockMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockMember.Params")));
            this.cbockMember.Size = new System.Drawing.Size(130, 20);
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
            this.cboMember.Location = new System.Drawing.Point(95, 53);
            this.cboMember.Margin = new System.Windows.Forms.Padding(0);
            this.cboMember.MultiSelection = false;
            this.cboMember.Name = "cboMember";
            this.cboMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboMember.Params")));
            this.cboMember.Size = new System.Drawing.Size(130, 20);
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
            this.label13.Location = new System.Drawing.Point(4, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 65);
            this.label13.TabIndex = 114;
            this.label13.Text = "상세 내용";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(4, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 107;
            this.label8.Text = "지불 조건";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(4, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 105;
            this.label6.Text = "납품 업체";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(4, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 101;
            this.label10.Text = "발주일";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkId
            // 
            this.txtWorkId.Location = new System.Drawing.Point(95, 4);
            this.txtWorkId.Name = "txtWorkId";
            this.txtWorkId.ReadOnly = true;
            this.txtWorkId.Size = new System.Drawing.Size(130, 21);
            this.txtWorkId.TabIndex = 100;
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
            this.panel5.Controls.Add(this.checkComboBox9);
            this.panel5.Controls.Add(this.checkComboBox4);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.checkComboBox5);
            this.panel5.Controls.Add(this.checkComboBox6);
            this.panel5.Controls.Add(this.dateTimePicker2);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.dateTimePicker3);
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.checkComboBox7);
            this.panel5.Controls.Add(this.checkComboBox8);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.textBox8);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(414, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 324);
            this.panel5.TabIndex = 34;
            // 
            // checkComboBox4
            // 
            this.checkComboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox4.DisplayMember = "ITEM_NM";
            this.checkComboBox4.DropDownHeight = 1;
            this.checkComboBox4.FormattingEnabled = true;
            this.checkComboBox4.IntegralHeight = false;
            this.checkComboBox4.Location = new System.Drawing.Point(95, 125);
            this.checkComboBox4.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox4.MultiSelection = true;
            this.checkComboBox4.Name = "checkComboBox4";
            this.checkComboBox4.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox4.Params")));
            this.checkComboBox4.Size = new System.Drawing.Size(355, 20);
            this.checkComboBox4.Sql = "CommonSearch#getUserList";
            this.checkComboBox4.TabIndex = 141;
            this.checkComboBox4.Text = "[SELECT]";
            this.checkComboBox4.ValueMember = "ITEM_CD";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(4, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 140;
            this.label18.Text = "프로젝트";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(320, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 21);
            this.textBox4.TabIndex = 139;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(229, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 21);
            this.label19.TabIndex = 138;
            this.label19.Text = "부가세";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 100);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 21);
            this.textBox5.TabIndex = 137;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(229, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 21);
            this.label20.TabIndex = 136;
            this.label20.Text = "지불 방식";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkComboBox5
            // 
            this.checkComboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox5.DisplayMember = "ITEM_NM";
            this.checkComboBox5.DropDownHeight = 1;
            this.checkComboBox5.FormattingEnabled = true;
            this.checkComboBox5.IntegralHeight = false;
            this.checkComboBox5.Location = new System.Drawing.Point(95, 77);
            this.checkComboBox5.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox5.MultiSelection = false;
            this.checkComboBox5.Name = "checkComboBox5";
            this.checkComboBox5.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox5.Params")));
            this.checkComboBox5.Size = new System.Drawing.Size(130, 20);
            this.checkComboBox5.Sql = "CommonSearch#getUserList";
            this.checkComboBox5.TabIndex = 135;
            this.checkComboBox5.Text = "[SELECT]";
            this.checkComboBox5.ValueMember = "ITEM_CD";
            // 
            // checkComboBox6
            // 
            this.checkComboBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox6.DisplayMember = "ITEM_NM";
            this.checkComboBox6.DropDownHeight = 1;
            this.checkComboBox6.FormattingEnabled = true;
            this.checkComboBox6.IntegralHeight = false;
            this.checkComboBox6.Location = new System.Drawing.Point(320, 53);
            this.checkComboBox6.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox6.MultiSelection = false;
            this.checkComboBox6.Name = "checkComboBox6";
            this.checkComboBox6.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox6.Params")));
            this.checkComboBox6.Size = new System.Drawing.Size(130, 20);
            this.checkComboBox6.Sql = "CommonSearch#getUserList";
            this.checkComboBox6.TabIndex = 134;
            this.checkComboBox6.Text = "[SELECT]";
            this.checkComboBox6.ValueMember = "ITEM_CD";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(229, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 21);
            this.label22.TabIndex = 131;
            this.label22.Text = "납품 장소";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(4, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 21);
            this.label23.TabIndex = 130;
            this.label23.Text = "합계";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(229, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 21);
            this.label24.TabIndex = 128;
            this.label24.Text = "고객사 모델";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker3.Location = new System.Drawing.Point(95, 28);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker3.TabIndex = 127;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(95, 148);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(355, 65);
            this.textBox7.TabIndex = 125;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(4, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 124;
            this.button3.Text = "저장";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkComboBox7
            // 
            this.checkComboBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox7.DisplayMember = "ITEM_NM";
            this.checkComboBox7.DropDownHeight = 1;
            this.checkComboBox7.FormattingEnabled = true;
            this.checkComboBox7.IntegralHeight = false;
            this.checkComboBox7.Location = new System.Drawing.Point(320, 77);
            this.checkComboBox7.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox7.MultiSelection = true;
            this.checkComboBox7.Name = "checkComboBox7";
            this.checkComboBox7.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox7.Params")));
            this.checkComboBox7.Size = new System.Drawing.Size(130, 20);
            this.checkComboBox7.Sql = "CommonSearch#getUserList";
            this.checkComboBox7.TabIndex = 121;
            this.checkComboBox7.Text = "[SELECT]";
            this.checkComboBox7.ValueMember = "ITEM_CD";
            // 
            // checkComboBox8
            // 
            this.checkComboBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox8.DisplayMember = "ITEM_NM";
            this.checkComboBox8.DropDownHeight = 1;
            this.checkComboBox8.FormattingEnabled = true;
            this.checkComboBox8.IntegralHeight = false;
            this.checkComboBox8.Location = new System.Drawing.Point(95, 53);
            this.checkComboBox8.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox8.MultiSelection = false;
            this.checkComboBox8.Name = "checkComboBox8";
            this.checkComboBox8.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox8.Params")));
            this.checkComboBox8.Size = new System.Drawing.Size(130, 20);
            this.checkComboBox8.Sql = "CommonSearch#getUserList";
            this.checkComboBox8.TabIndex = 118;
            this.checkComboBox8.Text = "[SELECT]";
            this.checkComboBox8.ValueMember = "ITEM_CD";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(4, 148);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 65);
            this.label25.TabIndex = 114;
            this.label25.Text = "상세 내용";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(4, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 21);
            this.label26.TabIndex = 107;
            this.label26.Text = "지불 조건";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(4, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 21);
            this.label27.TabIndex = 105;
            this.label27.Text = "납품 업체";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label28.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(4, 28);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 21);
            this.label28.TabIndex = 101;
            this.label28.Text = "발주일";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(95, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(130, 21);
            this.textBox8.TabIndex = 100;
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
            // checkComboBox9
            // 
            this.checkComboBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComboBox9.DisplayMember = "ITEM_NM";
            this.checkComboBox9.DropDownHeight = 1;
            this.checkComboBox9.FormattingEnabled = true;
            this.checkComboBox9.IntegralHeight = false;
            this.checkComboBox9.Location = new System.Drawing.Point(320, 5);
            this.checkComboBox9.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox9.MultiSelection = false;
            this.checkComboBox9.Name = "checkComboBox9";
            this.checkComboBox9.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox9.Params")));
            this.checkComboBox9.Size = new System.Drawing.Size(130, 20);
            this.checkComboBox9.Sql = "CommonSearch#getUserList";
            this.checkComboBox9.TabIndex = 142;
            this.checkComboBox9.Text = "[SELECT]";
            this.checkComboBox9.ValueMember = "ITEM_CD";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(320, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker2.TabIndex = 133;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(229, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 21);
            this.label21.TabIndex = 132;
            this.label21.Text = "납품일";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomerOrder";
            this.Size = new System.Drawing.Size(1123, 649);
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_detail)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private Control.MYCGrid gd_detail;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView gd_List;
        private System.Windows.Forms.Panel panel7;
        private Control.CheckComboBox checkComboBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private Control.CheckComboBox checkComboBox2;
        private Control.CheckComboBox checkComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker calWorkDt;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSave;
        private Control.CheckComboBox cbockMember;
        private Control.CheckComboBox cboMember;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWorkId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private Control.CheckComboBox checkComboBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label20;
        private Control.CheckComboBox checkComboBox5;
        private Control.CheckComboBox checkComboBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private Control.CheckComboBox checkComboBox7;
        private Control.CheckComboBox checkComboBox8;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label29;
        private Control.CheckComboBox checkComboBox9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label21;
    }
}
