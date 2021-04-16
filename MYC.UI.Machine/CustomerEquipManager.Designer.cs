namespace MYC.UI.Machine
{
    partial class CustomerEquipManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEquipManager));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.gd_list = new Control.MYCGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_list)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.gd_list);
            this.PlMainBody.Size = new System.Drawing.Size(929, 665);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(268, 665);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.btnAdd);
            this.PlSearchBody.Controls.Add(this.panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(254, 633);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnSearch);
            this.panel2.Controls.Add(this.cboComp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 62);
            this.panel2.TabIndex = 69;
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
            this.cboComp.Size = new System.Drawing.Size(161, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 71;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 70;
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
            this.LbModelSearch.Size = new System.Drawing.Size(254, 28);
            this.LbModelSearch.TabIndex = 68;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gd_list
            // 
            this.gd_list.AllowUserToAddRows = false;
            this.gd_list.AllowUserToDeleteRows = false;
            this.gd_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_list.Location = new System.Drawing.Point(0, 0);
            this.gd_list.Name = "gd_list";
            this.gd_list.ReadOnly = true;
            this.gd_list.RowTemplate.Height = 23;
            this.gd_list.Size = new System.Drawing.Size(929, 665);
            this.gd_list.TabIndex = 0;
            this.gd_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAction);
            this.gd_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConTextMenu);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(0, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(254, 23);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.RowAdd);
            // 
            // CustomerEquipManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomerEquipManager";
            this.Size = new System.Drawing.Size(1201, 665);
            this.Load += new System.EventHandler(this.CustomerEquipManager_Load);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private Control.MYCGrid gd_list;
        private System.Windows.Forms.Button btnAdd;
    }
}
