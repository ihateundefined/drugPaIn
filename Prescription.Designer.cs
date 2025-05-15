namespace drugPaIn
{
    partial class Prescription
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.ComboBox comboDrugs;
        private System.Windows.Forms.Button btnPrescribe;

        private void InitializeComponent()
        {
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.comboDrugs = new System.Windows.Forms.ComboBox();
            this.btnPrescribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(30, 30);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(180, 23);
            this.txtSearchName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.AutoSize = true;
            this.lblPatientInfo.Location = new System.Drawing.Point(30, 70);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Size = new System.Drawing.Size(94, 15);
            this.lblPatientInfo.TabIndex = 2;
            this.lblPatientInfo.Text = "환자 정보 출력";
            // 
            // comboDrugs
            // 
            this.comboDrugs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDrugs.FormattingEnabled = true;
            this.comboDrugs.Location = new System.Drawing.Point(30, 110);
            this.comboDrugs.Name = "comboDrugs";
            this.comboDrugs.Size = new System.Drawing.Size(260, 23);
            this.comboDrugs.TabIndex = 3;
            // 
            // btnPrescribe
            // 
            this.btnPrescribe.Location = new System.Drawing.Point(190, 150);
            this.btnPrescribe.Name = "btnPrescribe";
            this.btnPrescribe.Size = new System.Drawing.Size(100, 25);
            this.btnPrescribe.TabIndex = 4;
            this.btnPrescribe.Text = "약물 처방";
            this.btnPrescribe.UseVisualStyleBackColor = true;
            this.btnPrescribe.Click += new System.EventHandler(this.btnPrescribe_Click);
            this.btnPrescribe.Enabled = false;
            // 
            // Prescription
            // 
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPatientInfo);
            this.Controls.Add(this.comboDrugs);
            this.Controls.Add(this.btnPrescribe);
            this.Name = "Prescription";
            this.Text = "약물 처방";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
