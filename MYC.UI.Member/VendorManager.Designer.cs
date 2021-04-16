namespace MYC.UI.Member
{
    partial class VendorManager
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
            this.gd_List = new Control.MYCGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gd_Member = new Control.MYCGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Member)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gd_List);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gd_Member);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 636);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 0;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 40);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_List.Size = new System.Drawing.Size(1045, 217);
            this.gd_List.TabIndex = 26;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetCompInfo);
            this.gd_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetCompInfo);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnCompAdd
            // 
            this.btnCompAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompAdd.Location = new System.Drawing.Point(967, 9);
            this.btnCompAdd.Name = "btnCompAdd";
            this.btnCompAdd.Size = new System.Drawing.Size(72, 25);
            this.btnCompAdd.TabIndex = 3;
            this.btnCompAdd.Text = "업체 추가";
            this.btnCompAdd.UseVisualStyleBackColor = true;
            this.btnCompAdd.Click += new System.EventHandler(this.AddCompRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ 협력사 List";
            // 
            // gd_Member
            // 
            this.gd_Member.AllowUserToAddRows = false;
            this.gd_Member.AllowUserToDeleteRows = false;
            this.gd_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Member.Location = new System.Drawing.Point(0, 40);
            this.gd_Member.MultiSelect = false;
            this.gd_Member.Name = "gd_Member";
            this.gd_Member.ReadOnly = true;
            this.gd_Member.RowHeadersVisible = false;
            this.gd_Member.RowTemplate.Height = 23;
            this.gd_Member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_Member.Size = new System.Drawing.Size(1045, 335);
            this.gd_Member.TabIndex = 27;
            this.gd_Member.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetUserInfo);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMemberAdd);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 40);
            this.panel4.TabIndex = 3;
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMemberAdd.Location = new System.Drawing.Point(967, 9);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(72, 25);
            this.btnMemberAdd.TabIndex = 4;
            this.btnMemberAdd.Text = "인원 추가";
            this.btnMemberAdd.UseVisualStyleBackColor = true;
            this.btnMemberAdd.Click += new System.EventHandler(this.AddMemberRow);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "■ 소속 인원";
            // 
            // VendorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "VendorManager";
            this.Size = new System.Drawing.Size(1045, 636);
            this.Load += new System.EventHandler(this.VendorManager_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Member)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Control.MYCGrid gd_List;
        private Control.MYCGrid gd_Member;
        private System.Windows.Forms.Button btnCompAdd;
        private System.Windows.Forms.Button btnMemberAdd;
    }
}
