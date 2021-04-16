namespace MYC.UI.Machine
{
    partial class ProductDeliver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDeliver));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboStatus = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbockModel = new MYC.Control.CheckComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.PnlSearch1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gd_List = new Control.MYCGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gd_Item = new Control.MYCGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gd_DeliModel = new Control.MYCGrid();
            this.gd_Model = new Control.MYCGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtDesc2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PnlSearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Item)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_DeliModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Model)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.splitContainer1);
            this.PlMainBody.Size = new System.Drawing.Size(899, 680);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(260, 680);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel4);
            this.PlSearchBody.Controls.Add(this.label19);
            this.PlSearchBody.Controls.Add(this.PnlSearch1);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(246, 648);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboStatus);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.cbockModel);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.cboComp);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 151);
            this.panel4.TabIndex = 88;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.DisplayMember = "ITEM_NM";
            this.cboStatus.DropDownHeight = 1;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.Location = new System.Drawing.Point(70, 60);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboStatus.MultiSelection = false;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboStatus.Params")));
            this.cboStatus.Size = new System.Drawing.Size(171, 20);
            this.cboStatus.Sql = "CommonSearch#getCommonItems";
            this.cboStatus.TabIndex = 90;
            this.cboStatus.Text = "[SELECT]";
            this.cboStatus.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 89;
            this.label1.Text = "진행상태";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(246, 29);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(246, 29);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.AddItem);
            // 
            // cbockModel
            // 
            this.cbockModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbockModel.DisplayMember = "ITEM_NM";
            this.cbockModel.DropDownHeight = 1;
            this.cbockModel.FormattingEnabled = true;
            this.cbockModel.IntegralHeight = false;
            this.cbockModel.Location = new System.Drawing.Point(70, 33);
            this.cbockModel.Margin = new System.Windows.Forms.Padding(0);
            this.cbockModel.MultiSelection = true;
            this.cbockModel.Name = "cbockModel";
            this.cbockModel.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockModel.Params")));
            this.cbockModel.Size = new System.Drawing.Size(171, 20);
            this.cbockModel.Sql = "CommonSearch#getModelList";
            this.cbockModel.TabIndex = 87;
            this.cbockModel.Text = "[SELECT]";
            this.cbockModel.ValueMember = "ITEM_CD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(3, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 86;
            this.label14.Text = "MODEL";
            // 
            // cboComp
            // 
            this.cboComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(70, 6);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(171, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 84;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 12);
            this.label16.TabIndex = 83;
            this.label16.Text = "고객사";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LawnGreen;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(0, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(246, 28);
            this.label19.TabIndex = 87;
            this.label19.Text = "조회 조건";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlSearch1
            // 
            this.PnlSearch1.Controls.Add(this.label4);
            this.PnlSearch1.Controls.Add(this.dtTo);
            this.PnlSearch1.Controls.Add(this.dtFrom);
            this.PnlSearch1.Controls.Add(this.label18);
            this.PnlSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSearch1.Location = new System.Drawing.Point(0, 28);
            this.PnlSearch1.Name = "PnlSearch1";
            this.PnlSearch1.Size = new System.Drawing.Size(246, 64);
            this.PnlSearch1.TabIndex = 86;
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
            this.dtTo.Size = new System.Drawing.Size(171, 21);
            this.dtTo.TabIndex = 102;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Location = new System.Drawing.Point(70, 6);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(171, 21);
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
            this.LbModelSearch.Text = "조회 기간";
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
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(899, 680);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // gd_List
            // 
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 24);
            this.gd_List.Name = "gd_List";
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.Size = new System.Drawing.Size(899, 275);
            this.gd_List.TabIndex = 2;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDetail);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(899, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "■ 납품 목록";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gd_Item);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(899, 377);
            this.splitContainer2.SplitterDistance = 385;
            this.splitContainer2.TabIndex = 0;
            // 
            // gd_Item
            // 
            this.gd_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Item.Location = new System.Drawing.Point(0, 0);
            this.gd_Item.Name = "gd_Item";
            this.gd_Item.RowTemplate.Height = 23;
            this.gd_Item.Size = new System.Drawing.Size(385, 377);
            this.gd_Item.TabIndex = 3;
            this.gd_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewModel);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 377);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave1);
            this.tabPage1.Controls.Add(this.txtDesc1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gd_DeliModel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "발주현황";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave2);
            this.tabPage2.Controls.Add(this.txtDesc2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.gd_Model);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "재고현황";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gd_DeliModel
            // 
            this.gd_DeliModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_DeliModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gd_DeliModel.Location = new System.Drawing.Point(3, 3);
            this.gd_DeliModel.Name = "gd_DeliModel";
            this.gd_DeliModel.RowTemplate.Height = 23;
            this.gd_DeliModel.Size = new System.Drawing.Size(496, 296);
            this.gd_DeliModel.TabIndex = 5;
            // 
            // gd_Model
            // 
            this.gd_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Model.Dock = System.Windows.Forms.DockStyle.Top;
            this.gd_Model.Location = new System.Drawing.Point(3, 3);
            this.gd_Model.Name = "gd_Model";
            this.gd_Model.RowTemplate.Height = 23;
            this.gd_Model.Size = new System.Drawing.Size(496, 273);
            this.gd_Model.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "반품사유";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDesc1
            // 
            this.txtDesc1.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDesc1.Location = new System.Drawing.Point(76, 299);
            this.txtDesc1.Multiline = true;
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(325, 49);
            this.txtDesc1.TabIndex = 7;
            // 
            // btnSave1
            // 
            this.btnSave1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave1.Location = new System.Drawing.Point(401, 299);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(98, 49);
            this.btnSave1.TabIndex = 89;
            this.btnSave1.Text = "처리";
            this.btnSave1.UseVisualStyleBackColor = true;
            // 
            // btnSave2
            // 
            this.btnSave2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave2.Location = new System.Drawing.Point(401, 276);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(98, 72);
            this.btnSave2.TabIndex = 92;
            this.btnSave2.Text = "처리";
            this.btnSave2.UseVisualStyleBackColor = true;
            // 
            // txtDesc2
            // 
            this.txtDesc2.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDesc2.Location = new System.Drawing.Point(76, 276);
            this.txtDesc2.Multiline = true;
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.Size = new System.Drawing.Size(325, 72);
            this.txtDesc2.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 72);
            this.label5.TabIndex = 90;
            this.label5.Text = "납품내용";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductDeliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProductDeliver";
            this.Size = new System.Drawing.Size(1163, 680);
            this.Resize += new System.EventHandler(this.ProductDeliver_Resize);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PnlSearch1.ResumeLayout(false);
            this.PnlSearch1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Item)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_DeliModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Model)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private Control.CheckComboBox cbockModel;
        private System.Windows.Forms.Label label14;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel PnlSearch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LbModelSearch;
        private Control.CheckComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Control.MYCGrid gd_Item;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Control.MYCGrid gd_DeliModel;
        private System.Windows.Forms.TabPage tabPage2;
        private Control.MYCGrid gd_Model;
        private System.Windows.Forms.TextBox txtDesc1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TextBox txtDesc2;
        private System.Windows.Forms.Label label5;
    }
}