namespace MYC.UI.Machine
{
    partial class CustomerModelManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModelManager));
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gd_List = new Control.MYCGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabSpec = new System.Windows.Forms.TabControl();
            this.tabSpec1 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCompCode = new MYC.Control.CheckComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbockModel = new MYC.Control.CheckComboBox();
            this.txtModelDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModelId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabSpec2 = new System.Windows.Forms.TabPage();
            this.gd_Spec = new Control.MYCGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSpecDesc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSpecDel = new System.Windows.Forms.Button();
            this.btnSpecSave = new System.Windows.Forms.Button();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrp2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGrp1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabSpec3 = new System.Windows.Forms.TabPage();
            this.gd_Est = new Control.MYCGrid();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEstNew = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cboQtyType = new MYC.Control.CheckComboBox();
            this.btnEstDel = new System.Windows.Forms.Button();
            this.btnEstSave = new System.Windows.Forms.Button();
            this.txtEstDesc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEstUnitCost = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEstSubject = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEstNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabSpec.SuspendLayout();
            this.tabSpec1.SuspendLayout();
            this.tabSpec2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Spec)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabSpec3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Est)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.gd_List);
            this.PlMainBody.Controls.Add(this.panel3);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Size = new System.Drawing.Size(929, 665);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(268, 665);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.pnlSearch);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(254, 633);
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(254, 28);
            this.LbModelSearch.TabIndex = 69;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.cboComp);
            this.pnlSearch.Controls.Add(this.BtnSearch);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 28);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(254, 62);
            this.pnlSearch.TabIndex = 70;
            // 
            // cboComp
            // 
            this.cboComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(58, 3);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(188, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 82;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSearch.Location = new System.Drawing.Point(0, 37);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(252, 23);
            this.BtnSearch.TabIndex = 80;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.Search);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 70;
            this.label3.Text = "고객사";
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 35);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_List.Size = new System.Drawing.Size(361, 630);
            this.gd_List.TabIndex = 143;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetModelInfo);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tabSpec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(361, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 630);
            this.panel3.TabIndex = 142;
            // 
            // tabSpec
            // 
            this.tabSpec.Controls.Add(this.tabSpec1);
            this.tabSpec.Controls.Add(this.tabSpec2);
            this.tabSpec.Controls.Add(this.tabSpec3);
            this.tabSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSpec.Location = new System.Drawing.Point(0, 0);
            this.tabSpec.Name = "tabSpec";
            this.tabSpec.SelectedIndex = 0;
            this.tabSpec.Size = new System.Drawing.Size(566, 628);
            this.tabSpec.TabIndex = 174;
            // 
            // tabSpec1
            // 
            this.tabSpec1.Controls.Add(this.btnDel);
            this.tabSpec1.Controls.Add(this.btnSave);
            this.tabSpec1.Controls.Add(this.cboCompCode);
            this.tabSpec1.Controls.Add(this.label6);
            this.tabSpec1.Controls.Add(this.label5);
            this.tabSpec1.Controls.Add(this.cbockModel);
            this.tabSpec1.Controls.Add(this.txtModelDesc);
            this.tabSpec1.Controls.Add(this.label9);
            this.tabSpec1.Controls.Add(this.txtModelId);
            this.tabSpec1.Controls.Add(this.label10);
            this.tabSpec1.Location = new System.Drawing.Point(4, 22);
            this.tabSpec1.Name = "tabSpec1";
            this.tabSpec1.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpec1.Size = new System.Drawing.Size(558, 602);
            this.tabSpec1.TabIndex = 0;
            this.tabSpec1.Text = "제품 Spec";
            this.tabSpec1.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(124, 125);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 30);
            this.btnDel.TabIndex = 183;
            this.btnDel.Text = "삭 제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.ModelDelete);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 182;
            this.btnSave.Text = "저 장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ModelSave);
            // 
            // cboCompCode
            // 
            this.cboCompCode.DisplayMember = "ITEM_NM";
            this.cboCompCode.DropDownHeight = 1;
            this.cboCompCode.Enabled = false;
            this.cboCompCode.FormattingEnabled = true;
            this.cboCompCode.IntegralHeight = false;
            this.cboCompCode.Location = new System.Drawing.Point(141, 12);
            this.cboCompCode.Margin = new System.Windows.Forms.Padding(0);
            this.cboCompCode.MultiSelection = false;
            this.cboCompCode.Name = "cboCompCode";
            this.cboCompCode.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCompCode.Params")));
            this.cboCompCode.Size = new System.Drawing.Size(403, 20);
            this.cboCompCode.Sql = "CommonSearch#getCompList";
            this.cboCompCode.TabIndex = 181;
            this.cboCompCode.Text = "[SELECT]";
            this.cboCompCode.ValueMember = "ITEM_CD";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 180;
            this.label6.Text = "고객사 code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 179;
            this.label5.Text = "등록 모델";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbockModel
            // 
            this.cbockModel.DisplayMember = "ITEM_NM";
            this.cbockModel.DropDownHeight = 1;
            this.cbockModel.FormattingEnabled = true;
            this.cbockModel.IntegralHeight = false;
            this.cbockModel.Location = new System.Drawing.Point(141, 93);
            this.cbockModel.Margin = new System.Windows.Forms.Padding(0);
            this.cbockModel.MultiSelection = true;
            this.cbockModel.Name = "cbockModel";
            this.cbockModel.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockModel.Params")));
            this.cbockModel.Size = new System.Drawing.Size(403, 20);
            this.cbockModel.Sql = "CommonSearch#getModelList";
            this.cbockModel.TabIndex = 175;
            this.cbockModel.Text = "[SELECT]";
            this.cbockModel.ValueMember = "ITEM_CD";
            // 
            // txtModelDesc
            // 
            this.txtModelDesc.Location = new System.Drawing.Point(141, 66);
            this.txtModelDesc.Name = "txtModelDesc";
            this.txtModelDesc.Size = new System.Drawing.Size(403, 21);
            this.txtModelDesc.TabIndex = 174;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(8, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 21);
            this.label9.TabIndex = 172;
            this.label9.Text = "제품명";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModelId
            // 
            this.txtModelId.Location = new System.Drawing.Point(141, 39);
            this.txtModelId.Name = "txtModelId";
            this.txtModelId.Size = new System.Drawing.Size(403, 21);
            this.txtModelId.TabIndex = 171;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(8, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 170;
            this.label10.Text = "고객사 등록모델";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSpec2
            // 
            this.tabSpec2.Controls.Add(this.gd_Spec);
            this.tabSpec2.Controls.Add(this.panel6);
            this.tabSpec2.Location = new System.Drawing.Point(4, 22);
            this.tabSpec2.Name = "tabSpec2";
            this.tabSpec2.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpec2.Size = new System.Drawing.Size(558, 602);
            this.tabSpec2.TabIndex = 1;
            this.tabSpec2.Text = "제품 Spec";
            this.tabSpec2.UseVisualStyleBackColor = true;
            // 
            // gd_Spec
            // 
            this.gd_Spec.AllowUserToAddRows = false;
            this.gd_Spec.AllowUserToDeleteRows = false;
            this.gd_Spec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Spec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Spec.Location = new System.Drawing.Point(3, 3);
            this.gd_Spec.MultiSelect = false;
            this.gd_Spec.Name = "gd_Spec";
            this.gd_Spec.ReadOnly = true;
            this.gd_Spec.RowHeadersVisible = false;
            this.gd_Spec.RowTemplate.Height = 23;
            this.gd_Spec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_Spec.Size = new System.Drawing.Size(552, 356);
            this.gd_Spec.TabIndex = 145;
            this.gd_Spec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetSpec);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.txtSpecDesc);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.btnSpecDel);
            this.panel6.Controls.Add(this.btnSpecSave);
            this.panel6.Controls.Add(this.txtSpec);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtItm);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtGrp2);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txtGrp1);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 359);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(552, 240);
            this.panel6.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 180;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ModelSpecNew);
            // 
            // txtSpecDesc
            // 
            this.txtSpecDesc.Location = new System.Drawing.Point(122, 156);
            this.txtSpecDesc.MaxLength = 400;
            this.txtSpecDesc.Multiline = true;
            this.txtSpecDesc.Name = "txtSpecDesc";
            this.txtSpecDesc.Size = new System.Drawing.Size(424, 42);
            this.txtSpecDesc.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(6, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 42);
            this.label11.TabIndex = 179;
            this.label11.Text = "세부설명";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSpecDel
            // 
            this.btnSpecDel.Location = new System.Drawing.Point(238, 203);
            this.btnSpecDel.Name = "btnSpecDel";
            this.btnSpecDel.Size = new System.Drawing.Size(110, 30);
            this.btnSpecDel.TabIndex = 7;
            this.btnSpecDel.Text = "삭제";
            this.btnSpecDel.UseVisualStyleBackColor = true;
            this.btnSpecDel.Click += new System.EventHandler(this.ModelSpecDelete);
            // 
            // btnSpecSave
            // 
            this.btnSpecSave.Location = new System.Drawing.Point(122, 203);
            this.btnSpecSave.Name = "btnSpecSave";
            this.btnSpecSave.Size = new System.Drawing.Size(110, 30);
            this.btnSpecSave.TabIndex = 6;
            this.btnSpecSave.Text = "저장";
            this.btnSpecSave.UseVisualStyleBackColor = true;
            this.btnSpecSave.Click += new System.EventHandler(this.ModelSpecSave);
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(122, 108);
            this.txtSpec.MaxLength = 400;
            this.txtSpec.Multiline = true;
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(424, 42);
            this.txtSpec.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 42);
            this.label2.TabIndex = 174;
            this.label2.Text = "Spec";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItm
            // 
            this.txtItm.Location = new System.Drawing.Point(122, 60);
            this.txtItm.MaxLength = 200;
            this.txtItm.Multiline = true;
            this.txtItm.Name = "txtItm";
            this.txtItm.Size = new System.Drawing.Size(424, 42);
            this.txtItm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 42);
            this.label4.TabIndex = 172;
            this.label4.Text = "항목";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGrp2
            // 
            this.txtGrp2.Location = new System.Drawing.Point(396, 12);
            this.txtGrp2.MaxLength = 40;
            this.txtGrp2.Multiline = true;
            this.txtGrp2.Name = "txtGrp2";
            this.txtGrp2.Size = new System.Drawing.Size(150, 42);
            this.txtGrp2.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(280, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 42);
            this.label14.TabIndex = 170;
            this.label14.Text = "구분2";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGrp1
            // 
            this.txtGrp1.Location = new System.Drawing.Point(122, 12);
            this.txtGrp1.MaxLength = 40;
            this.txtGrp1.Multiline = true;
            this.txtGrp1.Name = "txtGrp1";
            this.txtGrp1.Size = new System.Drawing.Size(150, 42);
            this.txtGrp1.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(6, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 42);
            this.label15.TabIndex = 148;
            this.label15.Text = "구분1";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSpec3
            // 
            this.tabSpec3.Controls.Add(this.gd_Est);
            this.tabSpec3.Controls.Add(this.panel7);
            this.tabSpec3.Location = new System.Drawing.Point(4, 22);
            this.tabSpec3.Name = "tabSpec3";
            this.tabSpec3.Size = new System.Drawing.Size(558, 602);
            this.tabSpec3.TabIndex = 2;
            this.tabSpec3.Text = "견적서 Form";
            this.tabSpec3.UseVisualStyleBackColor = true;
            // 
            // gd_Est
            // 
            this.gd_Est.AllowUserToAddRows = false;
            this.gd_Est.AllowUserToDeleteRows = false;
            this.gd_Est.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Est.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Est.Location = new System.Drawing.Point(0, 0);
            this.gd_Est.MultiSelect = false;
            this.gd_Est.Name = "gd_Est";
            this.gd_Est.ReadOnly = true;
            this.gd_Est.RowHeadersVisible = false;
            this.gd_Est.RowTemplate.Height = 23;
            this.gd_Est.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_Est.Size = new System.Drawing.Size(558, 457);
            this.gd_Est.TabIndex = 145;
            this.gd_Est.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetEst);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnEstNew);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.cboQtyType);
            this.panel7.Controls.Add(this.btnEstDel);
            this.panel7.Controls.Add(this.btnEstSave);
            this.panel7.Controls.Add(this.txtEstDesc);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.txtEstUnitCost);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.txtEstSubject);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.txtEstNo);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 457);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(558, 145);
            this.panel7.TabIndex = 1;
            // 
            // btnEstNew
            // 
            this.btnEstNew.Location = new System.Drawing.Point(6, 109);
            this.btnEstNew.Name = "btnEstNew";
            this.btnEstNew.Size = new System.Drawing.Size(110, 30);
            this.btnEstNew.TabIndex = 184;
            this.btnEstNew.Text = "추가";
            this.btnEstNew.UseVisualStyleBackColor = true;
            this.btnEstNew.Click += new System.EventHandler(this.ModelEstNew);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(280, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 21);
            this.label12.TabIndex = 183;
            this.label12.Text = "단 가";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboQtyType
            // 
            this.cboQtyType.DisplayMember = "ITEM_NM";
            this.cboQtyType.DropDownHeight = 1;
            this.cboQtyType.FormattingEnabled = true;
            this.cboQtyType.IntegralHeight = false;
            this.cboQtyType.Location = new System.Drawing.Point(122, 40);
            this.cboQtyType.Margin = new System.Windows.Forms.Padding(0);
            this.cboQtyType.MultiSelection = false;
            this.cboQtyType.Name = "cboQtyType";
            this.cboQtyType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboQtyType.Params")));
            this.cboQtyType.Size = new System.Drawing.Size(150, 20);
            this.cboQtyType.Sql = "CommonSearch#getCommonItems";
            this.cboQtyType.TabIndex = 182;
            this.cboQtyType.Text = "[SELECT]";
            this.cboQtyType.ValueMember = "ITEM_CD";
            // 
            // btnEstDel
            // 
            this.btnEstDel.Location = new System.Drawing.Point(238, 109);
            this.btnEstDel.Name = "btnEstDel";
            this.btnEstDel.Size = new System.Drawing.Size(110, 30);
            this.btnEstDel.TabIndex = 178;
            this.btnEstDel.Text = "삭제";
            this.btnEstDel.UseVisualStyleBackColor = true;
            this.btnEstDel.Click += new System.EventHandler(this.ModelEstDelete);
            // 
            // btnEstSave
            // 
            this.btnEstSave.Location = new System.Drawing.Point(122, 109);
            this.btnEstSave.Name = "btnEstSave";
            this.btnEstSave.Size = new System.Drawing.Size(110, 30);
            this.btnEstSave.TabIndex = 176;
            this.btnEstSave.Text = "저장";
            this.btnEstSave.UseVisualStyleBackColor = true;
            this.btnEstSave.Click += new System.EventHandler(this.ModelEstSave);
            // 
            // txtEstDesc
            // 
            this.txtEstDesc.Location = new System.Drawing.Point(122, 66);
            this.txtEstDesc.Multiline = true;
            this.txtEstDesc.Name = "txtEstDesc";
            this.txtEstDesc.Size = new System.Drawing.Size(424, 38);
            this.txtEstDesc.TabIndex = 175;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(6, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 38);
            this.label16.TabIndex = 174;
            this.label16.Text = "비 고";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstUnitCost
            // 
            this.txtEstUnitCost.Location = new System.Drawing.Point(396, 39);
            this.txtEstUnitCost.Name = "txtEstUnitCost";
            this.txtEstUnitCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEstUnitCost.Size = new System.Drawing.Size(150, 21);
            this.txtEstUnitCost.TabIndex = 173;
            this.txtEstUnitCost.TextChanged += new System.EventHandler(this.SetPrice);
            this.txtEstUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(6, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 21);
            this.label17.TabIndex = 172;
            this.label17.Text = "단 위";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstSubject
            // 
            this.txtEstSubject.Location = new System.Drawing.Point(396, 12);
            this.txtEstSubject.Name = "txtEstSubject";
            this.txtEstSubject.Size = new System.Drawing.Size(150, 21);
            this.txtEstSubject.TabIndex = 171;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(280, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 21);
            this.label18.TabIndex = 170;
            this.label18.Text = "내 용";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstNo
            // 
            this.txtEstNo.Location = new System.Drawing.Point(122, 12);
            this.txtEstNo.MaxLength = 4;
            this.txtEstNo.Name = "txtEstNo";
            this.txtEstNo.Size = new System.Drawing.Size(150, 21);
            this.txtEstNo.TabIndex = 169;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(6, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 21);
            this.label19.TabIndex = 148;
            this.label19.Text = "번 호";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 35);
            this.panel1.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ 등록 제품 List";
            // 
            // CustomerModelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomerModelManager";
            this.Size = new System.Drawing.Size(1201, 665);
            this.Load += new System.EventHandler(this.CustomerModelManager_Load);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabSpec.ResumeLayout(false);
            this.tabSpec1.ResumeLayout(false);
            this.tabSpec1.PerformLayout();
            this.tabSpec2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Spec)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabSpec3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Est)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label3;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabSpec;
        private System.Windows.Forms.TabPage tabSpec1;
        private System.Windows.Forms.Label label5;
        private Control.CheckComboBox cbockModel;
        private System.Windows.Forms.TextBox txtModelDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModelId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabSpec2;
        private Control.MYCGrid gd_Spec;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSpecSave;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrp2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGrp1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabSpec3;
        private Control.MYCGrid gd_Est;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnEstDel;
        private System.Windows.Forms.Button btnEstSave;
        private System.Windows.Forms.TextBox txtEstDesc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEstUnitCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEstSubject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEstNo;
        private System.Windows.Forms.Label label19;
        private Control.CheckComboBox cboCompCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSpecDesc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSpecDel;
        private System.Windows.Forms.Button btnDel;
        private Control.CheckComboBox cboQtyType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEstNew;
        private System.Windows.Forms.Button button1;
    }
}
