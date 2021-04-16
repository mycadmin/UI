using System.Drawing;

namespace MYC.UI.Machine
{
    partial class ProductOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOrder));
            this.Doc = new System.Windows.Forms.WebBrowser();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoSelf = new System.Windows.Forms.RadioButton();
            this.rdoCust = new System.Windows.Forms.RadioButton();
            this.lbCust = new System.Windows.Forms.Label();
            this.pnlCust = new System.Windows.Forms.Panel();
            this.cboCompUser = new MYC.Control.CheckComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.cboDocId = new MYC.Control.CheckComboBox();
            this.cboCustomer = new MYC.Control.CheckComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSelf = new System.Windows.Forms.Label();
            this.pnlSelf = new System.Windows.Forms.Panel();
            this.btnSelfSearch = new System.Windows.Forms.Button();
            this.cboModel = new MYC.Control.CheckComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gd_Order = new Control.MYCGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnSample = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCust.SuspendLayout();
            this.pnlSelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Order)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.gd_Order);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Controls.Add(this.Doc);
            this.PlMainBody.Size = new System.Drawing.Size(779, 667);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(224, 667);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.BtnSample);
            this.PlSearchBody.Controls.Add(this.pnlSelf);
            this.PlSearchBody.Controls.Add(this.lbSelf);
            this.PlSearchBody.Controls.Add(this.pnlCust);
            this.PlSearchBody.Controls.Add(this.lbCust);
            this.PlSearchBody.Controls.Add(this.panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(210, 635);
            // 
            // Doc
            // 
            this.Doc.AllowNavigation = false;
            this.Doc.AllowWebBrowserDrop = false;
            this.Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc.IsWebBrowserContextMenuEnabled = false;
            this.Doc.Location = new System.Drawing.Point(0, 0);
            this.Doc.MinimumSize = new System.Drawing.Size(20, 20);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(779, 667);
            this.Doc.TabIndex = 23;
            this.Doc.Visible = false;
            this.Doc.WebBrowserShortcutsEnabled = false;
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(210, 28);
            this.LbModelSearch.TabIndex = 67;
            this.LbModelSearch.Text = "발주 구분";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdoSelf);
            this.panel2.Controls.Add(this.rdoCust);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 48);
            this.panel2.TabIndex = 70;
            // 
            // rdoSelf
            // 
            this.rdoSelf.AutoSize = true;
            this.rdoSelf.Location = new System.Drawing.Point(3, 25);
            this.rdoSelf.Name = "rdoSelf";
            this.rdoSelf.Size = new System.Drawing.Size(75, 16);
            this.rdoSelf.TabIndex = 71;
            this.rdoSelf.Text = "자체 발주";
            this.rdoSelf.UseVisualStyleBackColor = true;
            // 
            // rdoCust
            // 
            this.rdoCust.AutoSize = true;
            this.rdoCust.Checked = true;
            this.rdoCust.Location = new System.Drawing.Point(3, 3);
            this.rdoCust.Name = "rdoCust";
            this.rdoCust.Size = new System.Drawing.Size(103, 16);
            this.rdoCust.TabIndex = 70;
            this.rdoCust.TabStop = true;
            this.rdoCust.Text = "고객 발주 처리";
            this.rdoCust.UseVisualStyleBackColor = true;
            this.rdoCust.CheckedChanged += new System.EventHandler(this.OrderChange);
            // 
            // lbCust
            // 
            this.lbCust.BackColor = System.Drawing.Color.LawnGreen;
            this.lbCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCust.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCust.Location = new System.Drawing.Point(0, 76);
            this.lbCust.Name = "lbCust";
            this.lbCust.Size = new System.Drawing.Size(210, 28);
            this.lbCust.TabIndex = 71;
            this.lbCust.Text = "고객 발주";
            this.lbCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCust
            // 
            this.pnlCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCust.Controls.Add(this.cboCompUser);
            this.pnlCust.Controls.Add(this.label12);
            this.pnlCust.Controls.Add(this.btnCustSearch);
            this.pnlCust.Controls.Add(this.cboDocId);
            this.pnlCust.Controls.Add(this.cboCustomer);
            this.pnlCust.Controls.Add(this.label11);
            this.pnlCust.Controls.Add(this.label10);
            this.pnlCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCust.Location = new System.Drawing.Point(0, 104);
            this.pnlCust.Name = "pnlCust";
            this.pnlCust.Size = new System.Drawing.Size(210, 135);
            this.pnlCust.TabIndex = 72;
            // 
            // cboCompUser
            // 
            this.cboCompUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCompUser.DisplayMember = "ITEM_NM";
            this.cboCompUser.DropDownHeight = 1;
            this.cboCompUser.FormattingEnabled = true;
            this.cboCompUser.IntegralHeight = false;
            this.cboCompUser.Location = new System.Drawing.Point(90, 31);
            this.cboCompUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboCompUser.MultiSelection = false;
            this.cboCompUser.Name = "cboCompUser";
            this.cboCompUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCompUser.Params")));
            this.cboCompUser.Size = new System.Drawing.Size(113, 20);
            this.cboCompUser.Sql = "CommonSearch#getUserList";
            this.cboCompUser.TabIndex = 92;
            this.cboCompUser.Text = "[SELECT]";
            this.cboCompUser.ValueMember = "ITEM_CD";
            this.cboCompUser.TextChanged += new System.EventHandler(this.CboCompUser_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 12);
            this.label12.TabIndex = 91;
            this.label12.Text = "담당자";
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.Location = new System.Drawing.Point(3, 96);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(78, 26);
            this.btnCustSearch.TabIndex = 90;
            this.btnCustSearch.Text = "추가";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            this.btnCustSearch.Click += new System.EventHandler(this.BtnCustSearch_Click);
            // 
            // cboDocId
            // 
            this.cboDocId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDocId.DisplayMember = "ITEM_NM";
            this.cboDocId.DropDownHeight = 1;
            this.cboDocId.FormattingEnabled = true;
            this.cboDocId.IntegralHeight = false;
            this.cboDocId.Location = new System.Drawing.Point(90, 58);
            this.cboDocId.Margin = new System.Windows.Forms.Padding(0);
            this.cboDocId.MultiSelection = false;
            this.cboDocId.Name = "cboDocId";
            this.cboDocId.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboDocId.Params")));
            this.cboDocId.Size = new System.Drawing.Size(113, 20);
            this.cboDocId.Sql = "CommonSearch#getOrderList";
            this.cboDocId.TabIndex = 82;
            this.cboDocId.Text = "[SELECT]";
            this.cboDocId.ValueMember = "ITEM_CD";
            // 
            // cboCustomer
            // 
            this.cboCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCustomer.DisplayMember = "ITEM_NM";
            this.cboCustomer.DropDownHeight = 1;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.IntegralHeight = false;
            this.cboCustomer.Location = new System.Drawing.Point(90, 4);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.cboCustomer.MultiSelection = false;
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCustomer.Params")));
            this.cboCustomer.Size = new System.Drawing.Size(113, 20);
            this.cboCustomer.Sql = "CommonSearch#getCompList";
            this.cboCustomer.TabIndex = 81;
            this.cboCustomer.Text = "[SELECT]";
            this.cboCustomer.ValueMember = "ITEM_CD";
            this.cboCustomer.TextChanged += new System.EventHandler(this.CboCustomer_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(3, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 12);
            this.label11.TabIndex = 80;
            this.label11.Text = "발주번호";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "고객사";
            // 
            // lbSelf
            // 
            this.lbSelf.BackColor = System.Drawing.Color.LawnGreen;
            this.lbSelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelf.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSelf.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSelf.Location = new System.Drawing.Point(0, 239);
            this.lbSelf.Name = "lbSelf";
            this.lbSelf.Size = new System.Drawing.Size(210, 28);
            this.lbSelf.TabIndex = 73;
            this.lbSelf.Text = "자체 발주";
            this.lbSelf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSelf
            // 
            this.pnlSelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelf.Controls.Add(this.btnSelfSearch);
            this.pnlSelf.Controls.Add(this.cboModel);
            this.pnlSelf.Controls.Add(this.label3);
            this.pnlSelf.Controls.Add(this.cboType);
            this.pnlSelf.Controls.Add(this.label5);
            this.pnlSelf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelf.Location = new System.Drawing.Point(0, 267);
            this.pnlSelf.Name = "pnlSelf";
            this.pnlSelf.Size = new System.Drawing.Size(210, 114);
            this.pnlSelf.TabIndex = 74;
            this.pnlSelf.Visible = false;
            // 
            // btnSelfSearch
            // 
            this.btnSelfSearch.Location = new System.Drawing.Point(5, 77);
            this.btnSelfSearch.Name = "btnSelfSearch";
            this.btnSelfSearch.Size = new System.Drawing.Size(78, 26);
            this.btnSelfSearch.TabIndex = 91;
            this.btnSelfSearch.Text = "추가";
            this.btnSelfSearch.UseVisualStyleBackColor = true;
            this.btnSelfSearch.Click += new System.EventHandler(this.BtnSelfSearch);
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
            this.cboModel.Size = new System.Drawing.Size(113, 20);
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
            this.cboType.MultiSelection = true;
            this.cboType.Name = "cboType";
            this.cboType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType.Params")));
            this.cboType.Size = new System.Drawing.Size(113, 20);
            this.cboType.Sql = "CommonSearch#getCommonItems";
            this.cboType.TabIndex = 80;
            this.cboType.Text = "[SELECT]";
            this.cboType.ValueMember = "ITEM_CD";
            this.cboType.TextChanged += new System.EventHandler(this.CboType_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 12);
            this.label5.TabIndex = 79;
            this.label5.Text = "Model Type";
            // 
            // gd_Order
            // 
            this.gd_Order.AllowUserToAddRows = false;
            this.gd_Order.AllowUserToResizeRows = false;
            this.gd_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Order.Location = new System.Drawing.Point(0, 36);
            this.gd_Order.MultiSelect = false;
            this.gd_Order.Name = "gd_Order";
            this.gd_Order.RowHeadersVisible = false;
            this.gd_Order.RowTemplate.Height = 23;
            this.gd_Order.Size = new System.Drawing.Size(779, 631);
            this.gd_Order.TabIndex = 22;
            this.gd_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gd_Order_CellContentClick);
            this.gd_Order.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gd_Order_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 36);
            this.panel1.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(698, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 26);
            this.btnSave.TabIndex = 92;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSample
            // 
            this.BtnSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSample.Location = new System.Drawing.Point(0, 381);
            this.BtnSample.Name = "BtnSample";
            this.BtnSample.Size = new System.Drawing.Size(210, 23);
            this.BtnSample.TabIndex = 96;
            this.BtnSample.Text = "발주 이력 확인";
            this.BtnSample.UseVisualStyleBackColor = true;
            this.BtnSample.Click += new System.EventHandler(this.BtnSample_Click);
            // 
            // ProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "ProductOrder";
            this.Size = new System.Drawing.Size(1007, 667);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCust.ResumeLayout(false);
            this.pnlSelf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel pnlSelf;
        private System.Windows.Forms.Label lbSelf;
        private System.Windows.Forms.Panel pnlCust;
        private System.Windows.Forms.Label lbCust;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoSelf;
        private System.Windows.Forms.RadioButton rdoCust;
        private Control.CheckComboBox cboDocId;
        private Control.CheckComboBox cboCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSelfSearch;
        private Control.CheckComboBox cboModel;
        private System.Windows.Forms.Label label3;
        private Control.CheckComboBox cboType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCustSearch;
        private Control.CheckComboBox cboCompUser;
        private System.Windows.Forms.Label label12;
        private Control.MYCGrid gd_Order;
        private System.Windows.Forms.WebBrowser Doc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnSample;
    }
}
