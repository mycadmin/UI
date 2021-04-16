namespace MYC.UI.Account
{
    partial class AccountManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gd_Bank = new Control.MYCGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBank = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gd_Card = new Control.MYCGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Bank)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Card)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gd_Bank);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gd_Card);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1072, 665);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 2;
            // 
            // gd_Bank
            // 
            this.gd_Bank.AllowUserToAddRows = false;
            this.gd_Bank.AllowUserToDeleteRows = false;
            this.gd_Bank.AllowUserToResizeRows = false;
            this.gd_Bank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Bank.Location = new System.Drawing.Point(0, 34);
            this.gd_Bank.Name = "gd_Bank";
            this.gd_Bank.ReadOnly = true;
            this.gd_Bank.RowHeadersVisible = false;
            this.gd_Bank.RowTemplate.Height = 23;
            this.gd_Bank.Size = new System.Drawing.Size(1072, 289);
            this.gd_Bank.TabIndex = 36;
            this.gd_Bank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Card_Search);
            this.gd_Bank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bank_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBank);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 34);
            this.panel1.TabIndex = 3;
            // 
            // btnBank
            // 
            this.btnBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBank.Location = new System.Drawing.Point(983, 4);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(77, 25);
            this.btnBank.TabIndex = 1;
            this.btnBank.Text = "통장 추가";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.BankAdd);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "■ 법인 통장 등록 현황";
            // 
            // gd_Card
            // 
            this.gd_Card.AllowUserToAddRows = false;
            this.gd_Card.AllowUserToDeleteRows = false;
            this.gd_Card.AllowUserToResizeRows = false;
            this.gd_Card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Card.Location = new System.Drawing.Point(0, 34);
            this.gd_Card.Name = "gd_Card";
            this.gd_Card.ReadOnly = true;
            this.gd_Card.RowHeadersVisible = false;
            this.gd_Card.RowTemplate.Height = 23;
            this.gd_Card.Size = new System.Drawing.Size(1072, 304);
            this.gd_Card.TabIndex = 36;
            this.gd_Card.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Card_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCard);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 34);
            this.panel2.TabIndex = 4;
            // 
            // btnCard
            // 
            this.btnCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCard.Location = new System.Drawing.Point(983, 5);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(77, 25);
            this.btnCard.TabIndex = 2;
            this.btnCard.Text = "카드 추가";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.CardAdd);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ 법인 카드 등록 현황";
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AccountManager";
            this.Size = new System.Drawing.Size(1072, 665);
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Bank)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Card)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Control.MYCGrid gd_Bank;
        private Control.MYCGrid gd_Card;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnCard;
    }
}
