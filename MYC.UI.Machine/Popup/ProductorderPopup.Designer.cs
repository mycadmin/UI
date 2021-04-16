
namespace MYC.UI.Machine.Popup
{
    partial class ProductorderPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductorderPopup));
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOrder = new MYC.Control.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVendorTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderDt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVendorNm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrtDt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.gd_List = new Control.MYCGrid();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMember = new MYC.Control.CheckComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.pnlOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder.Controls.Add(this.cboMember);
            this.pnlOrder.Controls.Add(this.label10);
            this.pnlOrder.Controls.Add(this.cboYear);
            this.pnlOrder.Controls.Add(this.label1);
            this.pnlOrder.Controls.Add(this.btnSearch);
            this.pnlOrder.Controls.Add(this.label3);
            this.pnlOrder.Controls.Add(this.cboOrder);
            this.pnlOrder.Controls.Add(this.label2);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(850, 57);
            this.pnlOrder.TabIndex = 77;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(71, 30);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(107, 20);
            this.cboYear.TabIndex = 98;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.SetOrderList);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "■ 조회 조건";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(728, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 22);
            this.btnSearch.TabIndex = 96;
            this.btnSearch.Text = "조 회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 95;
            this.label3.Text = "발주년도";
            // 
            // cboOrder
            // 
            this.cboOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrder.DisplayMember = "ITEM_NM";
            this.cboOrder.DropDownHeight = 1;
            this.cboOrder.FormattingEnabled = true;
            this.cboOrder.IntegralHeight = false;
            this.cboOrder.Location = new System.Drawing.Point(468, 30);
            this.cboOrder.Margin = new System.Windows.Forms.Padding(0);
            this.cboOrder.MultiSelection = false;
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboOrder.Params")));
            this.cboOrder.Size = new System.Drawing.Size(241, 20);
            this.cboOrder.Sql = "CommonSearch#getMYCOrderGrpList";
            this.cboOrder.TabIndex = 94;
            this.cboOrder.Text = "[SELECT]";
            this.cboOrder.ValueMember = "ITEM_CD";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(193, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 93;
            this.label2.Text = "담당자";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtVendorTel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtOrderDt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtVendorNm);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCrtDt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDocId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 88);
            this.panel2.TabIndex = 78;
            // 
            // txtVendorTel
            // 
            this.txtVendorTel.Location = new System.Drawing.Point(382, 57);
            this.txtVendorTel.Name = "txtVendorTel";
            this.txtVendorTel.ReadOnly = true;
            this.txtVendorTel.Size = new System.Drawing.Size(180, 21);
            this.txtVendorTel.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(290, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 120;
            this.label8.Text = "연 락 처";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrderDt
            // 
            this.txtOrderDt.Location = new System.Drawing.Point(664, 30);
            this.txtOrderDt.Name = "txtOrderDt";
            this.txtOrderDt.ReadOnly = true;
            this.txtOrderDt.Size = new System.Drawing.Size(180, 21);
            this.txtOrderDt.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(572, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 118;
            this.label9.Text = "납 기 일";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVendorNm
            // 
            this.txtVendorNm.Location = new System.Drawing.Point(100, 57);
            this.txtVendorNm.Name = "txtVendorNm";
            this.txtVendorNm.ReadOnly = true;
            this.txtVendorNm.Size = new System.Drawing.Size(180, 21);
            this.txtVendorNm.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 116;
            this.label5.Text = "공 급 자";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCrtDt
            // 
            this.txtCrtDt.Location = new System.Drawing.Point(382, 30);
            this.txtCrtDt.Name = "txtCrtDt";
            this.txtCrtDt.ReadOnly = true;
            this.txtCrtDt.Size = new System.Drawing.Size(180, 21);
            this.txtCrtDt.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(290, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 114;
            this.label6.Text = "발주일자";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDocId
            // 
            this.txtDocId.Location = new System.Drawing.Point(100, 30);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.ReadOnly = true;
            this.txtDocId.Size = new System.Drawing.Size(180, 21);
            this.txtDocId.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(8, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 112;
            this.label7.Text = "발주번호";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(848, 23);
            this.label4.TabIndex = 98;
            this.label4.Text = "■ 조회 조건";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 50);
            this.panel1.TabIndex = 79;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(389, 9);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(75, 32);
            this.BtnExcel.TabIndex = 0;
            this.BtnExcel.Text = "발행";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToResizeRows = false;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 145);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.Size = new System.Drawing.Size(850, 336);
            this.gd_List.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(405, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 12);
            this.label10.TabIndex = 99;
            this.label10.Text = "발주정보";
            // 
            // cboMember
            // 
            this.cboMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMember.DisplayMember = "ITEM_NM";
            this.cboMember.DropDownHeight = 1;
            this.cboMember.FormattingEnabled = true;
            this.cboMember.IntegralHeight = false;
            this.cboMember.Location = new System.Drawing.Point(246, 30);
            this.cboMember.Margin = new System.Windows.Forms.Padding(0);
            this.cboMember.MultiSelection = false;
            this.cboMember.Name = "cboMember";
            this.cboMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboMember.Params")));
            this.cboMember.Size = new System.Drawing.Size(144, 20);
            this.cboMember.Sql = "CommonSearch#getUserList";
            this.cboMember.TabIndex = 100;
            this.cboMember.Text = "[SELECT]";
            this.cboMember.ValueMember = "ITEM_CD";
            this.cboMember.TextChanged += new System.EventHandler(this.SetOrderList);
            // 
            // ProductorderPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 531);
            this.Controls.Add(this.gd_List);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOrder);
            this.Name = "ProductorderPopup";
            this.Text = "발주 이력 확인";
            this.Load += new System.EventHandler(this.ProductorderPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.pnlOrder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private Control.CheckComboBox cboOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtVendorTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderDt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVendorNm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCrtDt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcel;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Label label10;
        private Control.CheckComboBox cboMember;
    }
}