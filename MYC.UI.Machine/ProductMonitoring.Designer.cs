namespace MYC.UI.Machine
{
    partial class ProductMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMonitoring));
            this.txtSerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.cbockProduct = new MYC.Control.CheckComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboStatus = new MYC.Control.CheckComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboModel = new MYC.Control.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gd_list = new Control.MYCGrid();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_list)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.gd_list);
            this.PlMainBody.Controls.Add(this.panel2);
            this.PlMainBody.Size = new System.Drawing.Size(824, 673);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(238, 673);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel3);
            this.PlSearchBody.Controls.Add(this.lbSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(224, 641);
            // 
            // txtSerId
            // 
            this.txtSerId.Location = new System.Drawing.Point(80, 146);
            this.txtSerId.Name = "txtSerId";
            this.txtSerId.Size = new System.Drawing.Size(116, 21);
            this.txtSerId.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "Serial Id";
            // 
            // lbSearch
            // 
            this.lbSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.lbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(224, 28);
            this.lbSearch.TabIndex = 66;
            this.lbSearch.Text = "조회 조건";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.cbockProduct);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cboStatus);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cboType);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboModel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 147);
            this.panel3.TabIndex = 67;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSearch.Location = new System.Drawing.Point(0, 122);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(222, 23);
            this.BtnSearch.TabIndex = 80;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbockProduct
            // 
            this.cbockProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbockProduct.DisplayMember = "ITEM_NM";
            this.cbockProduct.DropDownHeight = 1;
            this.cbockProduct.FormattingEnabled = true;
            this.cbockProduct.IntegralHeight = false;
            this.cbockProduct.Location = new System.Drawing.Point(84, 85);
            this.cbockProduct.Margin = new System.Windows.Forms.Padding(0);
            this.cbockProduct.MultiSelection = true;
            this.cbockProduct.Name = "cbockProduct";
            this.cbockProduct.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockProduct.Params")));
            this.cbockProduct.Size = new System.Drawing.Size(131, 20);
            this.cbockProduct.Sql = "CommonSearch#getEqpList";
            this.cbockProduct.TabIndex = 79;
            this.cbockProduct.Text = "[ALL]";
            this.cbockProduct.ValueMember = "ITEM_CD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 78;
            this.label9.Text = "제품번호";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.DisplayMember = "ITEM_NM";
            this.cboStatus.DropDownHeight = 1;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.Location = new System.Drawing.Point(84, 58);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboStatus.MultiSelection = false;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboStatus.Params")));
            this.cboStatus.Size = new System.Drawing.Size(131, 20);
            this.cboStatus.Sql = "CommonSearch#getCommonItems";
            this.cboStatus.TabIndex = 77;
            this.cboStatus.Text = "[ALL]";
            this.cboStatus.ValueMember = "ITEM_CD";
            this.cboStatus.TextChanged += new System.EventHandler(this.cboStatus_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 76;
            this.label4.Text = "제품상태";
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DisplayMember = "ITEM_NM";
            this.cboType.DropDownHeight = 1;
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(84, 4);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.MultiSelection = false;
            this.cboType.Name = "cboType";
            this.cboType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType.Params")));
            this.cboType.Size = new System.Drawing.Size(131, 20);
            this.cboType.Sql = "CommonSearch#getCommonItems";
            this.cboType.TabIndex = 71;
            this.cboType.Text = "[SELECT]";
            this.cboType.ValueMember = "ITEM_CD";
            this.cboType.TextChanged += new System.EventHandler(this.cboType_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 70;
            this.label5.Text = "Model Type";
            // 
            // cboModel
            // 
            this.cboModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboModel.DisplayMember = "ITEM_NM";
            this.cboModel.DropDownHeight = 1;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.IntegralHeight = false;
            this.cboModel.Location = new System.Drawing.Point(84, 31);
            this.cboModel.Margin = new System.Windows.Forms.Padding(0);
            this.cboModel.MultiSelection = false;
            this.cboModel.Name = "cboModel";
            this.cboModel.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboModel.Params")));
            this.cboModel.Size = new System.Drawing.Size(131, 20);
            this.cboModel.Sql = "CommonSearch#getModelList";
            this.cboModel.TabIndex = 67;
            this.cboModel.Text = "[SELECT]";
            this.cboModel.ValueMember = "ITEM_CD";
            this.cboModel.TextChanged += new System.EventHandler(this.cboModel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 66;
            this.label2.Text = "Model Id";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 36);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ 장비 List";
            // 
            // gd_list
            // 
            this.gd_list.AllowUserToAddRows = false;
            this.gd_list.AllowUserToDeleteRows = false;
            this.gd_list.AllowUserToResizeRows = false;
            this.gd_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_list.Location = new System.Drawing.Point(0, 36);
            this.gd_list.Name = "gd_list";
            this.gd_list.ReadOnly = true;
            this.gd_list.RowTemplate.Height = 23;
            this.gd_list.Size = new System.Drawing.Size(824, 637);
            this.gd_list.TabIndex = 13;
            this.gd_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductAction);
            // 
            // ProductMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProductMonitoring";
            this.Size = new System.Drawing.Size(1066, 673);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private Control.CheckComboBox cboType;
        private System.Windows.Forms.Label label5;
        private Control.CheckComboBox cboModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label label9;
        private Control.CheckComboBox cboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Control.CheckComboBox cbockProduct;
        private System.Windows.Forms.Button BtnSearch;
        private Control.MYCGrid gd_list;
    }
}
