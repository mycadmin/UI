using System.Drawing;

namespace MYC.UI.Machine
{
    partial class ProductCarry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCarry));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Gd_Eqp = new Control.MYCGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.tabCarry = new System.Windows.Forms.TabControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.cboCompany = new MYC.Control.CheckComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.cboModel = new MYC.Control.CheckComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Doc = new System.Windows.Forms.WebBrowser();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gd_Eqp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.splitContainer1);
            this.PlMainBody.Controls.Add(this.Doc);
            this.PlMainBody.Size = new System.Drawing.Size(848, 654);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(245, 654);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel1);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(231, 622);
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
            this.splitContainer1.Panel1.Controls.Add(this.Gd_Eqp);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabCarry);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(848, 654);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 1;
            // 
            // Gd_Eqp
            // 
            this.Gd_Eqp.AllowUserToAddRows = false;
            this.Gd_Eqp.AllowUserToDeleteRows = false;
            this.Gd_Eqp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gd_Eqp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gd_Eqp.Location = new System.Drawing.Point(0, 43);
            this.Gd_Eqp.MultiSelect = false;
            this.Gd_Eqp.Name = "Gd_Eqp";
            this.Gd_Eqp.ReadOnly = true;
            this.Gd_Eqp.RowHeadersVisible = false;
            this.Gd_Eqp.RowTemplate.Height = 23;
            this.Gd_Eqp.Size = new System.Drawing.Size(848, 192);
            this.Gd_Eqp.TabIndex = 17;
            this.Gd_Eqp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gd_Eqp_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnPrint);
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 43);
            this.panel3.TabIndex = 15;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.Location = new System.Drawing.Point(781, 8);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(55, 29);
            this.BtnPrint.TabIndex = 89;
            this.BtnPrint.Text = "인쇄";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(720, 8);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(55, 29);
            this.BtnSave.TabIndex = 88;
            this.BtnSave.Text = "적용";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabCarry
            // 
            this.tabCarry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCarry.Location = new System.Drawing.Point(0, 43);
            this.tabCarry.Name = "tabCarry";
            this.tabCarry.SelectedIndex = 0;
            this.tabCarry.Size = new System.Drawing.Size(848, 372);
            this.tabCarry.TabIndex = 99;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnInsert);
            this.panel4.Controls.Add(this.BtnRemove);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.BtnAdd);
            this.panel4.Controls.Add(this.cboCompany);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cboUser);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 43);
            this.panel4.TabIndex = 98;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Enabled = false;
            this.BtnInsert.Location = new System.Drawing.Point(786, 8);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(35, 29);
            this.BtnInsert.TabIndex = 89;
            this.BtnInsert.Text = "▼";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(733, 8);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(35, 29);
            this.BtnRemove.TabIndex = 88;
            this.BtnRemove.Text = "▲";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(707, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 25);
            this.label6.TabIndex = 87;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(609, 8);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(68, 29);
            this.BtnAdd.TabIndex = 80;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cboCompany
            // 
            this.cboCompany.DisplayMember = "ITEM_NM";
            this.cboCompany.DropDownHeight = 1;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.IntegralHeight = false;
            this.cboCompany.Location = new System.Drawing.Point(100, 11);
            this.cboCompany.Margin = new System.Windows.Forms.Padding(0);
            this.cboCompany.MultiSelection = false;
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCompany.Params")));
            this.cboCompany.Size = new System.Drawing.Size(190, 20);
            this.cboCompany.Sql = "CommonSearch#getCompList";
            this.cboCompany.TabIndex = 79;
            this.cboCompany.Text = "[SELECT]";
            this.cboCompany.ValueMember = "ITEM_CD";
            this.cboCompany.TextChanged += new System.EventHandler(this.CboCompany_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(10, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 78;
            this.label7.Text = "고객사";
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(390, 11);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(190, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 77;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(300, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 76;
            this.label8.Text = "담당자";
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(231, 28);
            this.LbModelSearch.TabIndex = 68;
            this.LbModelSearch.Text = "제품 조회";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.cboModel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 112);
            this.panel1.TabIndex = 69;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(5, 72);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(68, 29);
            this.BtnSearch.TabIndex = 83;
            this.BtnSearch.Text = "조회";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cboModel
            // 
            this.cboModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboModel.DisplayMember = "ITEM_NM";
            this.cboModel.DropDownHeight = 1;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.IntegralHeight = false;
            this.cboModel.Location = new System.Drawing.Point(90, 31);
            this.cboModel.Margin = new System.Windows.Forms.Padding(0);
            this.cboModel.MultiSelection = true;
            this.cboModel.Name = "cboModel";
            this.cboModel.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboModel.Params")));
            this.cboModel.Size = new System.Drawing.Size(135, 20);
            this.cboModel.Sql = "CommonSearch#getModelList";
            this.cboModel.TabIndex = 82;
            this.cboModel.Text = "[SELECT]";
            this.cboModel.ValueMember = "ITEM_CD";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 81;
            this.label3.Text = "Model Id";
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DisplayMember = "ITEM_NM";
            this.cboType.DropDownHeight = 1;
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(90, 4);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.MultiSelection = false;
            this.cboType.Name = "cboType";
            this.cboType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType.Params")));
            this.cboType.Size = new System.Drawing.Size(135, 20);
            this.cboType.Sql = "CommonSearch#getCommonItems";
            this.cboType.TabIndex = 80;
            this.cboType.Text = "[SELECT]";
            this.cboType.ValueMember = "ITEM_CD";
            this.cboType.TextChanged += new System.EventHandler(this.CboType_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 79;
            this.label1.Text = "Model Type";
            // 
            // Doc
            // 
            this.Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc.Location = new System.Drawing.Point(0, 0);
            this.Doc.MinimumSize = new System.Drawing.Size(20, 20);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(848, 654);
            this.Doc.TabIndex = 18;
            this.Doc.Visible = false;
            this.Doc.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Doc_DocumentCompleted);
            // 
            // ProductCarry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "ProductCarry";
            this.Size = new System.Drawing.Size(1097, 654);
            this.Load += new System.EventHandler(this.ProductCarry_Load);
            this.Resize += new System.EventHandler(this.ProductCarry_Resize);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gd_Eqp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Control.MYCGrid Gd_Eqp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TabControl tabCarry;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAdd;
        private Control.CheckComboBox cboCompany;
        private System.Windows.Forms.Label label7;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSearch;
        private Control.CheckComboBox cboModel;
        private System.Windows.Forms.Label label3;
        private Control.CheckComboBox cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.WebBrowser Doc;
    }
}
