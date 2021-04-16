namespace MYC.UI.Machine
{
    partial class CustomerMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMonitoring));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.cbockCstEquip = new MYC.Control.CheckComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCstModel = new MYC.Control.CheckComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gd_list = new MYC.Control.MYCGrid();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
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
            this.panel3.Controls.Add(this.cbockCstEquip);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cboCstModel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cboComp);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 111);
            this.panel3.TabIndex = 67;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSearch.Location = new System.Drawing.Point(0, 86);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(222, 23);
            this.BtnSearch.TabIndex = 80;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbockCstEquip
            // 
            this.cbockCstEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbockCstEquip.DisplayMember = "ITEM_NM";
            this.cbockCstEquip.DropDownHeight = 1;
            this.cbockCstEquip.FormattingEnabled = true;
            this.cbockCstEquip.IntegralHeight = false;
            this.cbockCstEquip.Location = new System.Drawing.Point(84, 58);
            this.cbockCstEquip.Margin = new System.Windows.Forms.Padding(0);
            this.cbockCstEquip.MultiSelection = true;
            this.cbockCstEquip.Name = "cbockCstEquip";
            this.cbockCstEquip.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockCstEquip.Params")));
            this.cbockCstEquip.Size = new System.Drawing.Size(131, 20);
            this.cbockCstEquip.Sql = "CommonSearch#getCstEquipList";
            this.cbockCstEquip.TabIndex = 79;
            this.cbockCstEquip.Text = "[ALL]";
            this.cbockCstEquip.ValueMember = "ITEM_CD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 78;
            this.label9.Text = "장비번호";
            // 
            // cboCstModel
            // 
            this.cboCstModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCstModel.DisplayMember = "ITEM_NM";
            this.cboCstModel.DropDownHeight = 1;
            this.cboCstModel.FormattingEnabled = true;
            this.cboCstModel.IntegralHeight = false;
            this.cboCstModel.Location = new System.Drawing.Point(84, 31);
            this.cboCstModel.Margin = new System.Windows.Forms.Padding(0);
            this.cboCstModel.MultiSelection = false;
            this.cboCstModel.Name = "cboCstModel";
            this.cboCstModel.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCstModel.Params")));
            this.cboCstModel.Size = new System.Drawing.Size(131, 20);
            this.cboCstModel.Sql = "CommonSearch#getCstModelList";
            this.cboCstModel.TabIndex = 77;
            this.cboCstModel.Text = "[ALL]";
            this.cboCstModel.ValueMember = "ITEM_CD";
            this.cboCstModel.TextChanged += new System.EventHandler(this.CboCstModel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 76;
            this.label4.Text = "생산모델";
            // 
            // cboComp
            // 
            this.cboComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(84, 4);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(131, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 71;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            this.cboComp.TextChanged += new System.EventHandler(this.CboComp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 70;
            this.label5.Text = "고객사";
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
            this.gd_list.BackgroundColor = System.Drawing.Color.White;
            this.gd_list.BackgroundColor2 = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gd_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_list.EnableHeadersVisualStyles = false;
            this.gd_list.Location = new System.Drawing.Point(0, 36);
            this.gd_list.Name = "gd_list";
            this.gd_list.ReadOnly = true;
            this.gd_list.RowHeadersVisible = false;
            this.gd_list.RowTemplate.Height = 23;
            this.gd_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_list.Size = new System.Drawing.Size(824, 637);
            this.gd_list.TabIndex = 13;
            this.gd_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductAction);
            // 
            // CustomerMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomerMonitoring";
            this.Size = new System.Drawing.Size(1066, 673);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
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
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label label9;
        private Control.CheckComboBox cboCstModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Control.CheckComboBox cbockCstEquip;
        private System.Windows.Forms.Button BtnSearch;
        private Control.MYCGrid gd_list;
    }
}
