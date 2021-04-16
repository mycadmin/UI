namespace MYC.UI.Admin
{
    partial class CodeManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gd_List = new Control.MYCGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLstAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gd_Item = new Control.MYCGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Item)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gd_List);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 648);
            this.panel1.TabIndex = 0;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 54);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.Size = new System.Drawing.Size(270, 594);
            this.gd_List.TabIndex = 26;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLstAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 54);
            this.panel2.TabIndex = 0;
            // 
            // btnLstAdd
            // 
            this.btnLstAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLstAdd.Location = new System.Drawing.Point(185, 14);
            this.btnLstAdd.Name = "btnLstAdd";
            this.btnLstAdd.Size = new System.Drawing.Size(80, 27);
            this.btnLstAdd.TabIndex = 2;
            this.btnLstAdd.Text = "추가";
            this.btnLstAdd.UseVisualStyleBackColor = true;
            this.btnLstAdd.Click += new System.EventHandler(this.AddList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ GROUP";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gd_Item);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(270, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 648);
            this.panel3.TabIndex = 1;
            // 
            // gd_Item
            // 
            this.gd_Item.AllowUserToAddRows = false;
            this.gd_Item.AllowUserToDeleteRows = false;
            this.gd_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Item.Location = new System.Drawing.Point(0, 54);
            this.gd_Item.MultiSelect = false;
            this.gd_Item.Name = "gd_Item";
            this.gd_Item.ReadOnly = true;
            this.gd_Item.RowHeadersVisible = false;
            this.gd_Item.RowTemplate.Height = 23;
            this.gd_Item.Size = new System.Drawing.Size(818, 594);
            this.gd_Item.TabIndex = 27;
            this.gd_Item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnItemAdd);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(818, 54);
            this.panel4.TabIndex = 1;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemAdd.Location = new System.Drawing.Point(733, 14);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(80, 27);
            this.btnItemAdd.TabIndex = 2;
            this.btnItemAdd.Text = "추가";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.AddItem);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "■ ITEM";
            // 
            // CodeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CodeManager";
            this.Size = new System.Drawing.Size(1088, 648);
            this.Load += new System.EventHandler(this.CodeManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Item)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLstAdd;
        private System.Windows.Forms.Label label1;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Label label2;
        private Control.MYCGrid gd_Item;
    }
}
