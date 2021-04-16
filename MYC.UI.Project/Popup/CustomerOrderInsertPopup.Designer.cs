namespace MYC.UI.Project.Popup
{
    partial class CustomerOrderInsertPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderInsertPopup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTarget = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCustomer = new MYC.Control.CheckComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboModel = new MYC.Control.CheckComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gd_List = new Control.MYCGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.checkComboBox1 = new MYC.Control.CheckComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkComboBox2 = new MYC.Control.CheckComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkComboBox3 = new MYC.Control.CheckComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkComboBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkComboBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkComboBox1);
            this.groupBox1.Controls.Add(this.dtTarget);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDeliNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCustomer);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 100);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "발주 정보";
            // 
            // dtTarget
            // 
            this.dtTarget.CustomFormat = "";
            this.dtTarget.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarget.Location = new System.Drawing.Point(346, 16);
            this.dtTarget.Name = "dtTarget";
            this.dtTarget.Size = new System.Drawing.Size(120, 21);
            this.dtTarget.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(260, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 115;
            this.label2.Text = "발주번호";
            // 
            // txtDeliNo
            // 
            this.txtDeliNo.Location = new System.Drawing.Point(346, 43);
            this.txtDeliNo.Name = "txtDeliNo";
            this.txtDeliNo.Size = new System.Drawing.Size(120, 21);
            this.txtDeliNo.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 113;
            this.label1.Text = "고객 담당자";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DisplayMember = "ITEM_NM";
            this.cboCustomer.DropDownHeight = 1;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.IntegralHeight = false;
            this.cboCustomer.Location = new System.Drawing.Point(100, 17);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.cboCustomer.MultiSelection = false;
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCustomer.Params")));
            this.cboCustomer.Size = new System.Drawing.Size(120, 20);
            this.cboCustomer.Sql = "CommonSearch#getCompList";
            this.cboCustomer.TabIndex = 112;
            this.cboCustomer.Text = "[SELECT]";
            this.cboCustomer.ValueMember = "ITEM_CD";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(10, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 12);
            this.label10.TabIndex = 111;
            this.label10.Text = "고객사";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(260, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 12);
            this.label18.TabIndex = 109;
            this.label18.Text = "납기일";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtItemNo);
            this.groupBox2.Controls.Add(this.gd_List);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.cboModel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUnitCost);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 276);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "제품 정보";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(230, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 115;
            this.label3.Text = "수량";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(80, 45);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(120, 21);
            this.txtUnitCost.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 113;
            this.label4.Text = "단가";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 111;
            this.label5.Text = "관리번호";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(230, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 109;
            this.label6.Text = "모델명";
            // 
            // cboModel
            // 
            this.cboModel.DisplayMember = "ITEM_NM";
            this.cboModel.DropDownHeight = 1;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.IntegralHeight = false;
            this.cboModel.Location = new System.Drawing.Point(287, 17);
            this.cboModel.Margin = new System.Windows.Forms.Padding(0);
            this.cboModel.MultiSelection = false;
            this.cboModel.Name = "cboModel";
            this.cboModel.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboModel.Params")));
            this.cboModel.Size = new System.Drawing.Size(120, 20);
            this.cboModel.Sql = "CommonSearch#getCompList";
            this.cboModel.TabIndex = 116;
            this.cboModel.Text = "[SELECT]";
            this.cboModel.ValueMember = "ITEM_CD";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(287, 45);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(120, 21);
            this.txtCount.TabIndex = 117;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(421, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 49);
            this.btnAdd.TabIndex = 118;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToResizeRows = false;
            this.gd_List.Location = new System.Drawing.Point(12, 72);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.Size = new System.Drawing.Size(454, 188);
            this.gd_List.TabIndex = 119;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(258, 407);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 23);
            this.btnClose.TabIndex = 112;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(80, 18);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(120, 21);
            this.txtItemNo.TabIndex = 120;
            // 
            // checkComboBox1
            // 
            this.checkComboBox1.DisplayMember = "ITEM_NM";
            this.checkComboBox1.DropDownHeight = 1;
            this.checkComboBox1.FormattingEnabled = true;
            this.checkComboBox1.IntegralHeight = false;
            this.checkComboBox1.Location = new System.Drawing.Point(100, 44);
            this.checkComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox1.MultiSelection = false;
            this.checkComboBox1.Name = "checkComboBox1";
            this.checkComboBox1.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox1.Params")));
            this.checkComboBox1.Size = new System.Drawing.Size(120, 20);
            this.checkComboBox1.Sql = "CommonSearch#getCompList";
            this.checkComboBox1.TabIndex = 117;
            this.checkComboBox1.Text = "[SELECT]";
            this.checkComboBox1.ValueMember = "ITEM_CD";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 12);
            this.label7.TabIndex = 118;
            this.label7.Text = "발주처";
            // 
            // checkComboBox2
            // 
            this.checkComboBox2.DisplayMember = "ITEM_NM";
            this.checkComboBox2.DropDownHeight = 1;
            this.checkComboBox2.FormattingEnabled = true;
            this.checkComboBox2.IntegralHeight = false;
            this.checkComboBox2.Location = new System.Drawing.Point(100, 71);
            this.checkComboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox2.MultiSelection = false;
            this.checkComboBox2.Name = "checkComboBox2";
            this.checkComboBox2.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox2.Params")));
            this.checkComboBox2.Size = new System.Drawing.Size(120, 20);
            this.checkComboBox2.Sql = "CommonSearch#getCompList";
            this.checkComboBox2.TabIndex = 119;
            this.checkComboBox2.Text = "[SELECT]";
            this.checkComboBox2.ValueMember = "ITEM_CD";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(260, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 12);
            this.label8.TabIndex = 120;
            this.label8.Text = "지불방식";
            // 
            // checkComboBox3
            // 
            this.checkComboBox3.DisplayMember = "ITEM_NM";
            this.checkComboBox3.DropDownHeight = 1;
            this.checkComboBox3.FormattingEnabled = true;
            this.checkComboBox3.IntegralHeight = false;
            this.checkComboBox3.Location = new System.Drawing.Point(346, 71);
            this.checkComboBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkComboBox3.MultiSelection = false;
            this.checkComboBox3.Name = "checkComboBox3";
            this.checkComboBox3.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("checkComboBox3.Params")));
            this.checkComboBox3.Size = new System.Drawing.Size(120, 20);
            this.checkComboBox3.Sql = "CommonSearch#getCompList";
            this.checkComboBox3.TabIndex = 121;
            this.checkComboBox3.Text = "[SELECT]";
            this.checkComboBox3.ValueMember = "ITEM_CD";
            // 
            // CustomerOrderInsertPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 442);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerOrderInsertPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "고객 발주서 등록";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomerOrderInsertPopup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeliNo;
        private System.Windows.Forms.Label label1;
        private Control.CheckComboBox cboCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCount;
        private Control.CheckComboBox cboModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtItemNo;
        private Control.CheckComboBox checkComboBox1;
        private Control.CheckComboBox checkComboBox3;
        private System.Windows.Forms.Label label8;
        private Control.CheckComboBox checkComboBox2;
        private System.Windows.Forms.Label label7;
    }
}