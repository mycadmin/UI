namespace MYC.UI.Account
{
    partial class AccountInsert
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
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.tabBody = new System.Windows.Forms.TabControl();
            this.pageCard = new System.Windows.Forms.TabPage();
            this.gd_Card = new Control.MYCGrid();
            this.pageBank = new System.Windows.Forms.TabPage();
            this.gd_Bank = new Control.MYCGrid();
            this.btnExcel = new System.Windows.Forms.Button();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.tabBody.SuspendLayout();
            this.pageCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Card)).BeginInit();
            this.pageBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Bank)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.tabBody);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.PnlSearch);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            // 
            // PnlSearch
            // 
            this.PnlSearch.Controls.Add(this.btnSearch);
            this.PnlSearch.Controls.Add(this.btnInsert);
            this.PnlSearch.Controls.Add(this.dtTo);
            this.PnlSearch.Controls.Add(this.label5);
            this.PnlSearch.Controls.Add(this.dtFrom);
            this.PnlSearch.Controls.Add(this.label4);
            this.PnlSearch.Controls.Add(this.btnExcel);
            this.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSearch.Location = new System.Drawing.Point(0, 28);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(220, 161);
            this.PnlSearch.TabIndex = 91;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 25);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.Location = new System.Drawing.Point(0, 111);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(220, 25);
            this.btnInsert.TabIndex = 93;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.NewAccount);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(80, 40);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(130, 21);
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
            this.dtFrom.Size = new System.Drawing.Size(130, 21);
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
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(220, 28);
            this.LbModelSearch.TabIndex = 90;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabBody
            // 
            this.tabBody.Controls.Add(this.pageCard);
            this.tabBody.Controls.Add(this.pageBank);
            this.tabBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBody.Location = new System.Drawing.Point(0, 0);
            this.tabBody.Name = "tabBody";
            this.tabBody.SelectedIndex = 0;
            this.tabBody.Size = new System.Drawing.Size(814, 595);
            this.tabBody.TabIndex = 0;
            // 
            // pageCard
            // 
            this.pageCard.Controls.Add(this.gd_Card);
            this.pageCard.Location = new System.Drawing.Point(4, 22);
            this.pageCard.Name = "pageCard";
            this.pageCard.Padding = new System.Windows.Forms.Padding(3);
            this.pageCard.Size = new System.Drawing.Size(806, 569);
            this.pageCard.TabIndex = 0;
            this.pageCard.Text = " 현금/카드";
            this.pageCard.UseVisualStyleBackColor = true;
            // 
            // gd_Card
            // 
            this.gd_Card.AllowUserToAddRows = false;
            this.gd_Card.AllowUserToDeleteRows = false;
            this.gd_Card.AllowUserToResizeRows = false;
            this.gd_Card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Card.Location = new System.Drawing.Point(3, 3);
            this.gd_Card.Name = "gd_Card";
            this.gd_Card.ReadOnly = true;
            this.gd_Card.RowHeadersVisible = false;
            this.gd_Card.RowTemplate.Height = 23;
            this.gd_Card.Size = new System.Drawing.Size(800, 563);
            this.gd_Card.TabIndex = 36;
            // 
            // pageBank
            // 
            this.pageBank.Controls.Add(this.gd_Bank);
            this.pageBank.Location = new System.Drawing.Point(4, 22);
            this.pageBank.Name = "pageBank";
            this.pageBank.Padding = new System.Windows.Forms.Padding(3);
            this.pageBank.Size = new System.Drawing.Size(806, 569);
            this.pageBank.TabIndex = 1;
            this.pageBank.Text = " 계좌이체 ";
            this.pageBank.UseVisualStyleBackColor = true;
            // 
            // gd_Bank
            // 
            this.gd_Bank.AllowUserToAddRows = false;
            this.gd_Bank.AllowUserToDeleteRows = false;
            this.gd_Bank.AllowUserToResizeRows = false;
            this.gd_Bank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Bank.Location = new System.Drawing.Point(3, 3);
            this.gd_Bank.Name = "gd_Bank";
            this.gd_Bank.ReadOnly = true;
            this.gd_Bank.RowHeadersVisible = false;
            this.gd_Bank.RowTemplate.Height = 23;
            this.gd_Bank.Size = new System.Drawing.Size(800, 563);
            this.gd_Bank.TabIndex = 37;
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExcel.Location = new System.Drawing.Point(0, 136);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(220, 25);
            this.btnExcel.TabIndex = 94;
            this.btnExcel.Text = "Excel Import";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.Excel_Import);
            // 
            // AccountInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AccountInsert";
            this.Load += new System.EventHandler(this.AccountInsert_Load);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.tabBody.ResumeLayout(false);
            this.pageCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Card)).EndInit();
            this.pageBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Bank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TabControl tabBody;
        private System.Windows.Forms.TabPage pageCard;
        private System.Windows.Forms.TabPage pageBank;
        private Control.MYCGrid gd_Card;
        private Control.MYCGrid gd_Bank;
        private System.Windows.Forms.Button btnExcel;
    }
}
