namespace MYC.UI.Machine
{
    partial class ModelManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gd_List = new Control.MYCGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModelAdd = new System.Windows.Forms.Button();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDocument = new System.Windows.Forms.Panel();
            this.LstDocument = new System.Windows.Forms.ListBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnDocumentView = new System.Windows.Forms.Button();
            this.btnDocumentRemove = new System.Windows.Forms.Button();
            this.btnDocumentImport = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlEstimate = new System.Windows.Forms.Panel();
            this.LstEstimate = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEstimateView = new System.Windows.Forms.Button();
            this.btnEstimateRemove = new System.Windows.Forms.Button();
            this.btnEstimateImport = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlPlan = new System.Windows.Forms.Panel();
            this.LstPlan = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPlanView = new System.Windows.Forms.Button();
            this.btnPlanRemove = new System.Windows.Forms.Button();
            this.btnPlanImport = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtModelCode = new System.Windows.Forms.TextBox();
            this.cboProject = new MYC.Control.CheckComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboMaterial = new MYC.Control.CheckComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnModelSave = new System.Windows.Forms.Button();
            this.cboVendor = new MYC.Control.CheckComboBox();
            this.cboProductType = new MYC.Control.CheckComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSpecH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpecD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSpecW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDocument.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlEstimate.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlPlan.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gd_List);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 665);
            this.panel1.TabIndex = 0;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 63);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_List.Size = new System.Drawing.Size(232, 602);
            this.gd_List.TabIndex = 27;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetModelInfo);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnModelAdd);
            this.panel3.Controls.Add(this.cboType);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 63);
            this.panel3.TabIndex = 1;
            // 
            // btnModelAdd
            // 
            this.btnModelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModelAdd.Enabled = false;
            this.btnModelAdd.Location = new System.Drawing.Point(151, 34);
            this.btnModelAdd.Name = "btnModelAdd";
            this.btnModelAdd.Size = new System.Drawing.Size(70, 21);
            this.btnModelAdd.TabIndex = 108;
            this.btnModelAdd.Text = "추가";
            this.btnModelAdd.UseVisualStyleBackColor = true;
            this.btnModelAdd.Click += new System.EventHandler(this.AddModelRow);
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DisplayMember = "ITEM_NM";
            this.cboType.DropDownHeight = 1;
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(97, 9);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.MultiSelection = false;
            this.cboType.Name = "cboType";
            this.cboType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType.Params")));
            this.cboType.Size = new System.Drawing.Size(124, 20);
            this.cboType.Sql = "CommonSearch#getCommonItems";
            this.cboType.TabIndex = 81;
            this.cboType.Text = "[SELECT]";
            this.cboType.ValueMember = "ITEM_CD";
            this.cboType.TextChanged += new System.EventHandler(this.GetModelList);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 80;
            this.label5.Text = "Model Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlDocument);
            this.panel2.Controls.Add(this.pnlEstimate);
            this.panel2.Controls.Add(this.pnlPlan);
            this.panel2.Controls.Add(this.pnlMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 665);
            this.panel2.TabIndex = 1;
            // 
            // pnlDocument
            // 
            this.pnlDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDocument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDocument.Controls.Add(this.LstDocument);
            this.pnlDocument.Controls.Add(this.panel11);
            this.pnlDocument.Controls.Add(this.panel12);
            this.pnlDocument.Enabled = false;
            this.pnlDocument.Location = new System.Drawing.Point(630, 280);
            this.pnlDocument.Name = "pnlDocument";
            this.pnlDocument.Size = new System.Drawing.Size(304, 380);
            this.pnlDocument.TabIndex = 135;
            // 
            // LstDocument
            // 
            this.LstDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstDocument.FormattingEnabled = true;
            this.LstDocument.ItemHeight = 12;
            this.LstDocument.Location = new System.Drawing.Point(0, 24);
            this.LstDocument.Name = "LstDocument";
            this.LstDocument.Size = new System.Drawing.Size(302, 324);
            this.LstDocument.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnDocumentView);
            this.panel11.Controls.Add(this.btnDocumentRemove);
            this.panel11.Controls.Add(this.btnDocumentImport);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 348);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(302, 30);
            this.panel11.TabIndex = 3;
            // 
            // btnDocumentView
            // 
            this.btnDocumentView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocumentView.Location = new System.Drawing.Point(225, 4);
            this.btnDocumentView.Name = "btnDocumentView";
            this.btnDocumentView.Size = new System.Drawing.Size(70, 21);
            this.btnDocumentView.TabIndex = 109;
            this.btnDocumentView.Text = "내용보기";
            this.btnDocumentView.UseVisualStyleBackColor = true;
            this.btnDocumentView.Click += new System.EventHandler(this.ViewLink);
            // 
            // btnDocumentRemove
            // 
            this.btnDocumentRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocumentRemove.Location = new System.Drawing.Point(149, 4);
            this.btnDocumentRemove.Name = "btnDocumentRemove";
            this.btnDocumentRemove.Size = new System.Drawing.Size(70, 21);
            this.btnDocumentRemove.TabIndex = 108;
            this.btnDocumentRemove.Text = "제거";
            this.btnDocumentRemove.UseVisualStyleBackColor = true;
            this.btnDocumentRemove.Click += new System.EventHandler(this.RemoveLink);
            // 
            // btnDocumentImport
            // 
            this.btnDocumentImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocumentImport.Location = new System.Drawing.Point(73, 4);
            this.btnDocumentImport.Name = "btnDocumentImport";
            this.btnDocumentImport.Size = new System.Drawing.Size(70, 21);
            this.btnDocumentImport.TabIndex = 107;
            this.btnDocumentImport.Text = "추가";
            this.btnDocumentImport.UseVisualStyleBackColor = true;
            this.btnDocumentImport.Click += new System.EventHandler(this.AddLink);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(302, 24);
            this.panel12.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 15);
            this.label13.TabIndex = 80;
            this.label13.Text = "■ 참고문서";
            // 
            // pnlEstimate
            // 
            this.pnlEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlEstimate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstimate.Controls.Add(this.LstEstimate);
            this.pnlEstimate.Controls.Add(this.panel8);
            this.pnlEstimate.Controls.Add(this.panel9);
            this.pnlEstimate.Enabled = false;
            this.pnlEstimate.Location = new System.Drawing.Point(320, 280);
            this.pnlEstimate.Name = "pnlEstimate";
            this.pnlEstimate.Size = new System.Drawing.Size(304, 380);
            this.pnlEstimate.TabIndex = 134;
            // 
            // LstEstimate
            // 
            this.LstEstimate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstEstimate.FormattingEnabled = true;
            this.LstEstimate.ItemHeight = 12;
            this.LstEstimate.Location = new System.Drawing.Point(0, 24);
            this.LstEstimate.Name = "LstEstimate";
            this.LstEstimate.Size = new System.Drawing.Size(302, 324);
            this.LstEstimate.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnEstimateView);
            this.panel8.Controls.Add(this.btnEstimateRemove);
            this.panel8.Controls.Add(this.btnEstimateImport);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 348);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(302, 30);
            this.panel8.TabIndex = 3;
            // 
            // btnEstimateView
            // 
            this.btnEstimateView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimateView.Location = new System.Drawing.Point(225, 4);
            this.btnEstimateView.Name = "btnEstimateView";
            this.btnEstimateView.Size = new System.Drawing.Size(70, 21);
            this.btnEstimateView.TabIndex = 109;
            this.btnEstimateView.Text = "내용보기";
            this.btnEstimateView.UseVisualStyleBackColor = true;
            this.btnEstimateView.Click += new System.EventHandler(this.ViewLink);
            // 
            // btnEstimateRemove
            // 
            this.btnEstimateRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimateRemove.Location = new System.Drawing.Point(149, 4);
            this.btnEstimateRemove.Name = "btnEstimateRemove";
            this.btnEstimateRemove.Size = new System.Drawing.Size(70, 21);
            this.btnEstimateRemove.TabIndex = 108;
            this.btnEstimateRemove.Text = "제거";
            this.btnEstimateRemove.UseVisualStyleBackColor = true;
            this.btnEstimateRemove.Click += new System.EventHandler(this.RemoveLink);
            // 
            // btnEstimateImport
            // 
            this.btnEstimateImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimateImport.Location = new System.Drawing.Point(73, 4);
            this.btnEstimateImport.Name = "btnEstimateImport";
            this.btnEstimateImport.Size = new System.Drawing.Size(70, 21);
            this.btnEstimateImport.TabIndex = 107;
            this.btnEstimateImport.Text = "추가";
            this.btnEstimateImport.UseVisualStyleBackColor = true;
            this.btnEstimateImport.Click += new System.EventHandler(this.AddLink);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label12);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(302, 24);
            this.panel9.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 80;
            this.label12.Text = "■ 견적서";
            // 
            // pnlPlan
            // 
            this.pnlPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlan.Controls.Add(this.LstPlan);
            this.pnlPlan.Controls.Add(this.panel7);
            this.pnlPlan.Controls.Add(this.panel6);
            this.pnlPlan.Enabled = false;
            this.pnlPlan.Location = new System.Drawing.Point(10, 280);
            this.pnlPlan.Name = "pnlPlan";
            this.pnlPlan.Size = new System.Drawing.Size(304, 380);
            this.pnlPlan.TabIndex = 133;
            // 
            // LstPlan
            // 
            this.LstPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPlan.FormattingEnabled = true;
            this.LstPlan.ItemHeight = 12;
            this.LstPlan.Location = new System.Drawing.Point(0, 24);
            this.LstPlan.Name = "LstPlan";
            this.LstPlan.Size = new System.Drawing.Size(302, 324);
            this.LstPlan.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPlanView);
            this.panel7.Controls.Add(this.btnPlanRemove);
            this.panel7.Controls.Add(this.btnPlanImport);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 348);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(302, 30);
            this.panel7.TabIndex = 3;
            // 
            // btnPlanView
            // 
            this.btnPlanView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanView.Location = new System.Drawing.Point(225, 4);
            this.btnPlanView.Name = "btnPlanView";
            this.btnPlanView.Size = new System.Drawing.Size(70, 21);
            this.btnPlanView.TabIndex = 109;
            this.btnPlanView.Text = "내용보기";
            this.btnPlanView.UseVisualStyleBackColor = true;
            this.btnPlanView.Click += new System.EventHandler(this.ViewLink);
            // 
            // btnPlanRemove
            // 
            this.btnPlanRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanRemove.Location = new System.Drawing.Point(149, 4);
            this.btnPlanRemove.Name = "btnPlanRemove";
            this.btnPlanRemove.Size = new System.Drawing.Size(70, 21);
            this.btnPlanRemove.TabIndex = 108;
            this.btnPlanRemove.Text = "제거";
            this.btnPlanRemove.UseVisualStyleBackColor = true;
            this.btnPlanRemove.Click += new System.EventHandler(this.RemoveLink);
            // 
            // btnPlanImport
            // 
            this.btnPlanImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanImport.Location = new System.Drawing.Point(73, 4);
            this.btnPlanImport.Name = "btnPlanImport";
            this.btnPlanImport.Size = new System.Drawing.Size(70, 21);
            this.btnPlanImport.TabIndex = 107;
            this.btnPlanImport.Text = "추가";
            this.btnPlanImport.UseVisualStyleBackColor = true;
            this.btnPlanImport.Click += new System.EventHandler(this.AddLink);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(302, 24);
            this.panel6.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 80;
            this.label11.Text = "■ 도면";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.txtModelCode);
            this.pnlMain.Controls.Add(this.cboProject);
            this.pnlMain.Controls.Add(this.label15);
            this.pnlMain.Controls.Add(this.cboMaterial);
            this.pnlMain.Controls.Add(this.label14);
            this.pnlMain.Controls.Add(this.btnModelSave);
            this.pnlMain.Controls.Add(this.cboVendor);
            this.pnlMain.Controls.Add(this.cboProductType);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.txtSpecH);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtSpecD);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.txtSpecW);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtModelName);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtModelId);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 260);
            this.pnlMain.TabIndex = 132;
            // 
            // txtModelCode
            // 
            this.txtModelCode.Location = new System.Drawing.Point(120, 145);
            this.txtModelCode.MaxLength = 2;
            this.txtModelCode.Name = "txtModelCode";
            this.txtModelCode.Size = new System.Drawing.Size(200, 21);
            this.txtModelCode.TabIndex = 170;
            // 
            // cboProject
            // 
            this.cboProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProject.DisplayMember = "ITEM_NM";
            this.cboProject.DropDownHeight = 1;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.IntegralHeight = false;
            this.cboProject.Location = new System.Drawing.Point(120, 200);
            this.cboProject.Margin = new System.Windows.Forms.Padding(0);
            this.cboProject.MultiSelection = false;
            this.cboProject.Name = "cboProject";
            this.cboProject.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProject.Params")));
            this.cboProject.Size = new System.Drawing.Size(200, 20);
            this.cboProject.Sql = "CommonSearch#getProjectList";
            this.cboProject.TabIndex = 169;
            this.cboProject.Text = "[SELECT]";
            this.cboProject.ValueMember = "ITEM_CD";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(6, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 21);
            this.label15.TabIndex = 168;
            this.label15.Text = "연계 Project";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMaterial
            // 
            this.cboMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaterial.DisplayMember = "ITEM_NM";
            this.cboMaterial.DropDownHeight = 1;
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.IntegralHeight = false;
            this.cboMaterial.Location = new System.Drawing.Point(120, 92);
            this.cboMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.cboMaterial.MultiSelection = false;
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboMaterial.Params")));
            this.cboMaterial.Size = new System.Drawing.Size(200, 20);
            this.cboMaterial.Sql = "CommonSearch#getCommonItems";
            this.cboMaterial.TabIndex = 167;
            this.cboMaterial.Text = "[SELECT]";
            this.cboMaterial.ValueMember = "ITEM_CD";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(6, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 21);
            this.label14.TabIndex = 166;
            this.label14.Text = "재질";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModelSave
            // 
            this.btnModelSave.Location = new System.Drawing.Point(7, 230);
            this.btnModelSave.Name = "btnModelSave";
            this.btnModelSave.Size = new System.Drawing.Size(110, 21);
            this.btnModelSave.TabIndex = 165;
            this.btnModelSave.Text = "저장";
            this.btnModelSave.UseVisualStyleBackColor = true;
            this.btnModelSave.Click += new System.EventHandler(this.ModelSave);
            // 
            // cboVendor
            // 
            this.cboVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVendor.DisplayMember = "ITEM_NM";
            this.cboVendor.DropDownHeight = 1;
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.IntegralHeight = false;
            this.cboVendor.Location = new System.Drawing.Point(120, 119);
            this.cboVendor.Margin = new System.Windows.Forms.Padding(0);
            this.cboVendor.MultiSelection = false;
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboVendor.Params")));
            this.cboVendor.Size = new System.Drawing.Size(200, 20);
            this.cboVendor.Sql = "CommonSearch#getCompList";
            this.cboVendor.TabIndex = 163;
            this.cboVendor.Text = "[SELECT]";
            this.cboVendor.ValueMember = "ITEM_CD";
            // 
            // cboProductType
            // 
            this.cboProductType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProductType.DisplayMember = "ITEM_NM";
            this.cboProductType.DropDownHeight = 1;
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.IntegralHeight = false;
            this.cboProductType.Location = new System.Drawing.Point(120, 172);
            this.cboProductType.Margin = new System.Windows.Forms.Padding(0);
            this.cboProductType.MultiSelection = false;
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProductType.Params")));
            this.cboProductType.Size = new System.Drawing.Size(200, 20);
            this.cboProductType.Sql = "CommonSearch#getCommonItems";
            this.cboProductType.TabIndex = 162;
            this.cboProductType.Text = "[SELECT]";
            this.cboProductType.ValueMember = "ITEM_CD";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 21);
            this.label10.TabIndex = 160;
            this.label10.Text = "가공업체";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpecH
            // 
            this.txtSpecH.Location = new System.Drawing.Point(604, 64);
            this.txtSpecH.Name = "txtSpecH";
            this.txtSpecH.Size = new System.Drawing.Size(136, 21);
            this.txtSpecH.TabIndex = 159;
            this.txtSpecH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSpecH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(540, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 21);
            this.label9.TabIndex = 158;
            this.label9.Text = "H";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpecD
            // 
            this.txtSpecD.Location = new System.Drawing.Point(394, 64);
            this.txtSpecD.Name = "txtSpecD";
            this.txtSpecD.Size = new System.Drawing.Size(136, 21);
            this.txtSpecD.TabIndex = 157;
            this.txtSpecD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSpecD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(330, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 156;
            this.label8.Text = "D";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpecW
            // 
            this.txtSpecW.Location = new System.Drawing.Point(184, 64);
            this.txtSpecW.Name = "txtSpecW";
            this.txtSpecW.Size = new System.Drawing.Size(136, 21);
            this.txtSpecW.TabIndex = 155;
            this.txtSpecW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSpecW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(120, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 154;
            this.label7.Text = "W";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 153;
            this.label6.Text = "Size Spec";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 151;
            this.label3.Text = "Product Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 149;
            this.label2.Text = "Model Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(120, 37);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(620, 21);
            this.txtModelName.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 147;
            this.label1.Text = "Model Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModelId
            // 
            this.txtModelId.Location = new System.Drawing.Point(120, 10);
            this.txtModelId.Name = "txtModelId";
            this.txtModelId.ReadOnly = true;
            this.txtModelId.Size = new System.Drawing.Size(200, 21);
            this.txtModelId.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 145;
            this.label4.Text = "Model Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ModelManager";
            this.Size = new System.Drawing.Size(1201, 665);
            this.Load += new System.EventHandler(this.ModelManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlDocument.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.pnlEstimate.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pnlPlan.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Control.CheckComboBox cboType;
        private System.Windows.Forms.Label label5;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Panel pnlMain;
        private Control.CheckComboBox cboVendor;
        private Control.CheckComboBox cboProductType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSpecH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSpecD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpecW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPlan;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPlanView;
        private System.Windows.Forms.Button btnPlanRemove;
        private System.Windows.Forms.Button btnPlanImport;
        private System.Windows.Forms.ListBox LstPlan;
        private System.Windows.Forms.Panel pnlDocument;
        private System.Windows.Forms.ListBox LstDocument;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnDocumentView;
        private System.Windows.Forms.Button btnDocumentRemove;
        private System.Windows.Forms.Button btnDocumentImport;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlEstimate;
        private System.Windows.Forms.ListBox LstEstimate;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnEstimateView;
        private System.Windows.Forms.Button btnEstimateRemove;
        private System.Windows.Forms.Button btnEstimateImport;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnModelAdd;
        private System.Windows.Forms.Button btnModelSave;
        private System.Windows.Forms.Label label14;
        private Control.CheckComboBox cboMaterial;
        private System.Windows.Forms.Label label15;
        private Control.CheckComboBox cboProject;
        private System.Windows.Forms.TextBox txtModelCode;
    }
}
