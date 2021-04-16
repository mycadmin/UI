namespace MYC.UI.Admin
{
    partial class UserLevelCondition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gd_User = new MYC.Control.MYCGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gd_UserProgram = new MYC.Control.MYCGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.gd_Program = new MYC.Control.MYCGrid();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPgmSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_User)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_UserProgram)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Program)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gd_User);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 663);
            this.panel1.TabIndex = 0;
            // 
            // gd_User
            // 
            this.gd_User.AllowUserToAddRows = false;
            this.gd_User.AllowUserToDeleteRows = false;
            this.gd_User.AllowUserToResizeColumns = false;
            this.gd_User.AllowUserToResizeRows = false;
            this.gd_User.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gd_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_User.EnableHeadersVisualStyles = false;
            this.gd_User.Location = new System.Drawing.Point(0, 44);
            this.gd_User.MultiSelect = false;
            this.gd_User.Name = "gd_User";
            this.gd_User.ReadOnly = true;
            this.gd_User.RowHeadersVisible = false;
            this.gd_User.RowTemplate.Height = 23;
            this.gd_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_User.Size = new System.Drawing.Size(308, 619);
            this.gd_User.TabIndex = 20;
            this.gd_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetUserProgram);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 44);
            this.panel4.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ 사용자 List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gd_UserProgram);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gd_Program);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(308, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 663);
            this.panel2.TabIndex = 1;
            // 
            // gd_UserProgram
            // 
            this.gd_UserProgram.AllowUserToAddRows = false;
            this.gd_UserProgram.AllowUserToDeleteRows = false;
            this.gd_UserProgram.AllowUserToResizeColumns = false;
            this.gd_UserProgram.AllowUserToResizeRows = false;
            this.gd_UserProgram.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_UserProgram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gd_UserProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_UserProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_UserProgram.EnableHeadersVisualStyles = false;
            this.gd_UserProgram.Location = new System.Drawing.Point(0, 44);
            this.gd_UserProgram.Name = "gd_UserProgram";
            this.gd_UserProgram.ReadOnly = true;
            this.gd_UserProgram.RowHeadersVisible = false;
            this.gd_UserProgram.RowTemplate.Height = 23;
            this.gd_UserProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_UserProgram.Size = new System.Drawing.Size(350, 619);
            this.gd_UserProgram.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnImport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(350, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 619);
            this.panel3.TabIndex = 20;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(4, 318);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(41, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "▶";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.RemoveProgram);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(4, 273);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(41, 34);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "◀";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.AddProgram);
            // 
            // gd_Program
            // 
            this.gd_Program.AllowUserToAddRows = false;
            this.gd_Program.AllowUserToDeleteRows = false;
            this.gd_Program.AllowUserToResizeColumns = false;
            this.gd_Program.AllowUserToResizeRows = false;
            this.gd_Program.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_Program.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gd_Program.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Program.Dock = System.Windows.Forms.DockStyle.Right;
            this.gd_Program.EnableHeadersVisualStyles = false;
            this.gd_Program.Location = new System.Drawing.Point(399, 44);
            this.gd_Program.Name = "gd_Program";
            this.gd_Program.ReadOnly = true;
            this.gd_Program.RowHeadersVisible = false;
            this.gd_Program.RowTemplate.Height = 23;
            this.gd_Program.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_Program.Size = new System.Drawing.Size(350, 619);
            this.gd_Program.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnPgmSave);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(749, 44);
            this.panel5.TabIndex = 23;
            // 
            // btnPgmSave
            // 
            this.btnPgmSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPgmSave.Location = new System.Drawing.Point(660, 4);
            this.btnPgmSave.Name = "btnPgmSave";
            this.btnPgmSave.Size = new System.Drawing.Size(80, 30);
            this.btnPgmSave.TabIndex = 2;
            this.btnPgmSave.Text = "저장";
            this.btnPgmSave.UseVisualStyleBackColor = true;
            this.btnPgmSave.Click += new System.EventHandler(this.Save);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "■ 프로그램 구성";
            // 
            // UserLevelCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserLevelCondition";
            this.Size = new System.Drawing.Size(1057, 663);
            this.Load += new System.EventHandler(this.UserLevelCondition_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_User)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_UserProgram)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Program)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Control.MYCGrid gd_User;
        private System.Windows.Forms.Panel panel2;
        private Control.MYCGrid gd_UserProgram;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImport;
        private Control.MYCGrid gd_Program;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPgmSave;
        private System.Windows.Forms.Label label2;
    }
}
