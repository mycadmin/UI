
namespace MYC.UI.Report.Popup
{
    partial class NewEstimatePopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEstimatePopup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDocNM = new MYC.Control.CheckComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSearchComp = new MYC.Control.CheckComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboWarrType = new MYC.Control.CheckComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboProject = new MYC.Control.CheckComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cboCashType2 = new MYC.Control.CheckComboBox();
            this.cboCashType1 = new MYC.Control.CheckComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cboCstUser = new MYC.Control.CheckComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDocNM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSearchComp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 92);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "견적서 품목 복사";
            // 
            // cboDocNM
            // 
            this.cboDocNM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDocNM.DisplayMember = "ITEM_NM";
            this.cboDocNM.DropDownHeight = 1;
            this.cboDocNM.FormattingEnabled = true;
            this.cboDocNM.IntegralHeight = false;
            this.cboDocNM.Location = new System.Drawing.Point(332, 57);
            this.cboDocNM.Margin = new System.Windows.Forms.Padding(0);
            this.cboDocNM.MultiSelection = false;
            this.cboDocNM.Name = "cboDocNM";
            this.cboDocNM.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboDocNM.Params")));
            this.cboDocNM.Size = new System.Drawing.Size(147, 20);
            this.cboDocNM.Sql = "CommonSearch#getCSTEstList";
            this.cboDocNM.TabIndex = 100;
            this.cboDocNM.Text = "[SELECT]";
            this.cboDocNM.ValueMember = "ITEM_CD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 99;
            this.label6.Text = "견적서명";
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(91, 56);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(147, 21);
            this.dtTo.TabIndex = 98;
            this.dtTo.ValueChanged += new System.EventHandler(this.SetDocNM);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 97;
            this.label1.Text = "~";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Location = new System.Drawing.Point(91, 20);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(147, 21);
            this.dtFrom.TabIndex = 96;
            this.dtFrom.ValueChanged += new System.EventHandler(this.SetDocNM);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 95;
            this.label2.Text = "조회기간";
            // 
            // cboSearchComp
            // 
            this.cboSearchComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchComp.DisplayMember = "ITEM_NM";
            this.cboSearchComp.DropDownHeight = 1;
            this.cboSearchComp.FormattingEnabled = true;
            this.cboSearchComp.IntegralHeight = false;
            this.cboSearchComp.Location = new System.Drawing.Point(332, 20);
            this.cboSearchComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboSearchComp.MultiSelection = false;
            this.cboSearchComp.Name = "cboSearchComp";
            this.cboSearchComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboSearchComp.Params")));
            this.cboSearchComp.Size = new System.Drawing.Size(147, 20);
            this.cboSearchComp.Sql = "CommonSearch#getCompList";
            this.cboSearchComp.TabIndex = 94;
            this.cboSearchComp.Text = "[SELECT]";
            this.cboSearchComp.ValueMember = "ITEM_CD";
            this.cboSearchComp.TextChanged += new System.EventHandler(this.SetDocNM);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 93;
            this.label3.Text = "고객사";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 227;
            this.label4.Text = "고객사";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboComp
            // 
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(105, 37);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(150, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 226;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            this.cboComp.TextChanged += new System.EventHandler(this.SetCstUser);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 225;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.EstimateSave);
            // 
            // cboWarrType
            // 
            this.cboWarrType.DisplayMember = "ITEM_NM";
            this.cboWarrType.DropDownHeight = 1;
            this.cboWarrType.FormattingEnabled = true;
            this.cboWarrType.IntegralHeight = false;
            this.cboWarrType.Location = new System.Drawing.Point(105, 87);
            this.cboWarrType.Margin = new System.Windows.Forms.Padding(0);
            this.cboWarrType.MultiSelection = false;
            this.cboWarrType.Name = "cboWarrType";
            this.cboWarrType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboWarrType.Params")));
            this.cboWarrType.Size = new System.Drawing.Size(150, 20);
            this.cboWarrType.Sql = "CommonSearch#getCommonItems";
            this.cboWarrType.TabIndex = 220;
            this.cboWarrType.Text = "[SELECT]";
            this.cboWarrType.ValueMember = "ITEM_CD";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(14, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 219;
            this.label11.Text = "품질보증";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProject
            // 
            this.cboProject.DisplayMember = "ITEM_NM";
            this.cboProject.DropDownHeight = 1;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.IntegralHeight = false;
            this.cboProject.Location = new System.Drawing.Point(355, 87);
            this.cboProject.Margin = new System.Windows.Forms.Padding(0);
            this.cboProject.MultiSelection = true;
            this.cboProject.Name = "cboProject";
            this.cboProject.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProject.Params")));
            this.cboProject.Size = new System.Drawing.Size(150, 20);
            this.cboProject.Sql = "CommonSearch#getProjectList";
            this.cboProject.TabIndex = 218;
            this.cboProject.Text = "[SELECT]";
            this.cboProject.ValueMember = "ITEM_CD";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(264, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 21);
            this.label21.TabIndex = 217;
            this.label21.Text = "프로젝트";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(264, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 21);
            this.label22.TabIndex = 216;
            this.label22.Text = "지불 방식";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCashType2
            // 
            this.cboCashType2.DisplayMember = "ITEM_NM";
            this.cboCashType2.DropDownHeight = 1;
            this.cboCashType2.FormattingEnabled = true;
            this.cboCashType2.IntegralHeight = false;
            this.cboCashType2.Location = new System.Drawing.Point(355, 62);
            this.cboCashType2.Margin = new System.Windows.Forms.Padding(0);
            this.cboCashType2.MultiSelection = false;
            this.cboCashType2.Name = "cboCashType2";
            this.cboCashType2.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCashType2.Params")));
            this.cboCashType2.Size = new System.Drawing.Size(150, 20);
            this.cboCashType2.Sql = "CommonSearch#getCommonItems";
            this.cboCashType2.TabIndex = 215;
            this.cboCashType2.Text = "[SELECT]";
            this.cboCashType2.ValueMember = "ITEM_CD";
            // 
            // cboCashType1
            // 
            this.cboCashType1.DisplayMember = "ITEM_NM";
            this.cboCashType1.DropDownHeight = 1;
            this.cboCashType1.FormattingEnabled = true;
            this.cboCashType1.IntegralHeight = false;
            this.cboCashType1.Location = new System.Drawing.Point(105, 62);
            this.cboCashType1.Margin = new System.Windows.Forms.Padding(0);
            this.cboCashType1.MultiSelection = false;
            this.cboCashType1.Name = "cboCashType1";
            this.cboCashType1.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCashType1.Params")));
            this.cboCashType1.Size = new System.Drawing.Size(150, 20);
            this.cboCashType1.Sql = "CommonSearch#getCommonItems";
            this.cboCashType1.TabIndex = 214;
            this.cboCashType1.Text = "[SELECT]";
            this.cboCashType1.ValueMember = "ITEM_CD";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(14, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 21);
            this.label26.TabIndex = 213;
            this.label26.Text = "지불 조건";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCstUser
            // 
            this.cboCstUser.DisplayMember = "ITEM_NM";
            this.cboCstUser.DropDownHeight = 1;
            this.cboCstUser.FormattingEnabled = true;
            this.cboCstUser.IntegralHeight = false;
            this.cboCstUser.Location = new System.Drawing.Point(355, 37);
            this.cboCstUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboCstUser.MultiSelection = false;
            this.cboCstUser.Name = "cboCstUser";
            this.cboCstUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCstUser.Params")));
            this.cboCstUser.Size = new System.Drawing.Size(150, 20);
            this.cboCstUser.Sql = "CommonSearch#getUserList";
            this.cboCstUser.TabIndex = 212;
            this.cboCstUser.Text = "[SELECT]";
            this.cboCstUser.ValueMember = "ITEM_CD";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(264, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 21);
            this.label27.TabIndex = 211;
            this.label27.Text = "고객 담당자";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(105, 12);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(400, 21);
            this.txtSubject.TabIndex = 209;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label28.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(14, 12);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 21);
            this.label28.TabIndex = 210;
            this.label28.Text = "견적서명";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewEstimatePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboComp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboWarrType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cboCashType2);
            this.Controls.Add(this.cboCashType1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cboCstUser);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label28);
            this.Name = "NewEstimatePopup";
            this.Text = "NewEstimatePopup";
            this.Load += new System.EventHandler(this.NewEstimatePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Button btnSave;
        private Control.CheckComboBox cboWarrType;
        private System.Windows.Forms.Label label11;
        private Control.CheckComboBox cboProject;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Control.CheckComboBox cboCashType2;
        private Control.CheckComboBox cboCashType1;
        private System.Windows.Forms.Label label26;
        private Control.CheckComboBox cboCstUser;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label28;
        private Control.CheckComboBox cboDocNM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private Control.CheckComboBox cboSearchComp;
        private System.Windows.Forms.Label label3;
    }
}