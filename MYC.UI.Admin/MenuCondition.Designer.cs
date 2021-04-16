namespace MYC.UI.Admin
{
    partial class MenuCondition
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.gd_ProgramList = new Control.MYCGrid();
            this.gd_Program = new Control.MYCGrid();
            this.menuView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenuSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPgmSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_ProgramList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Program)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(350, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 622);
            this.panel2.TabIndex = 5;
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
            // gd_ProgramList
            // 
            this.gd_ProgramList.AllowUserToAddRows = false;
            this.gd_ProgramList.AllowUserToDeleteRows = false;
            this.gd_ProgramList.AllowUserToResizeColumns = false;
            this.gd_ProgramList.AllowUserToResizeRows = false;
            this.gd_ProgramList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_ProgramList.Dock = System.Windows.Forms.DockStyle.Right;
            this.gd_ProgramList.Location = new System.Drawing.Point(399, 44);
            this.gd_ProgramList.Name = "gd_ProgramList";
            this.gd_ProgramList.ReadOnly = true;
            this.gd_ProgramList.RowHeadersVisible = false;
            this.gd_ProgramList.RowTemplate.Height = 23;
            this.gd_ProgramList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd_ProgramList.Size = new System.Drawing.Size(350, 622);
            this.gd_ProgramList.TabIndex = 12;
            // 
            // gd_Program
            // 
            this.gd_Program.AllowUserToAddRows = false;
            this.gd_Program.AllowUserToDeleteRows = false;
            this.gd_Program.AllowUserToResizeColumns = false;
            this.gd_Program.AllowUserToResizeRows = false;
            this.gd_Program.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Program.Location = new System.Drawing.Point(0, 44);
            this.gd_Program.Name = "gd_Program";
            this.gd_Program.RowHeadersVisible = false;
            this.gd_Program.RowTemplate.Height = 23;
            this.gd_Program.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_Program.Size = new System.Drawing.Size(350, 622);
            this.gd_Program.TabIndex = 15;
            // 
            // menuView
            // 
            this.menuView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuView.LabelEdit = true;
            this.menuView.Location = new System.Drawing.Point(0, 44);
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(421, 622);
            this.menuView.TabIndex = 16;
            this.menuView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.MenuTextChanged);
            this.menuView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NodeMenu);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuView);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 666);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnMenuSave);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 44);
            this.panel4.TabIndex = 18;
            // 
            // btnMenuSave
            // 
            this.btnMenuSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuSave.Location = new System.Drawing.Point(334, 4);
            this.btnMenuSave.Name = "btnMenuSave";
            this.btnMenuSave.Size = new System.Drawing.Size(80, 30);
            this.btnMenuSave.TabIndex = 1;
            this.btnMenuSave.Text = "저장";
            this.btnMenuSave.UseVisualStyleBackColor = true;
            this.btnMenuSave.Click += new System.EventHandler(this.MenuSave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ 메뉴 구성";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gd_Program);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.gd_ProgramList);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 666);
            this.panel3.TabIndex = 18;
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
            this.panel5.TabIndex = 19;
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
            this.btnPgmSave.Click += new System.EventHandler(this.ProgramSave);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(421, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(749, 666);
            this.panel6.TabIndex = 20;
            // 
            // MenuCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "MenuCondition";
            this.Size = new System.Drawing.Size(1170, 666);
            this.Load += new System.EventHandler(this.ProgramCondition_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_ProgramList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Program)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImport;
        private Control.MYCGrid gd_ProgramList;
        private Control.MYCGrid gd_Program;
        private System.Windows.Forms.TreeView menuView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMenuSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPgmSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
    }
}
