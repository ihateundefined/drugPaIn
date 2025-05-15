namespace drugPaIn
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnViewPatients;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.btnViewPatients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(50, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "환자 관리 프로그램";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(100, 90);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(200, 30);
            this.btnNewPatient.TabIndex = 1;
            this.btnNewPatient.Text = "신규 환자 진단";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.Location = new System.Drawing.Point(100, 130);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(200, 30);
            this.btnPrescription.TabIndex = 2;
            this.btnPrescription.Text = "약물 처방";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // btnViewPatients
            // 
            this.btnViewPatients.Location = new System.Drawing.Point(100, 170);
            this.btnViewPatients.Name = "btnViewPatients";
            this.btnViewPatients.Size = new System.Drawing.Size(200, 30);
            this.btnViewPatients.TabIndex = 3;
            this.btnViewPatients.Text = "진단 및 처방 내역 확인";
            this.btnViewPatients.UseVisualStyleBackColor = true;
            this.btnViewPatients.Click += new System.EventHandler(this.btnViewPatients_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.btnViewPatients);
            this.Name = "MainForm";
            this.Text = "환자 관리 프로그램";
            this.ResumeLayout(false);
        }
    }
}
