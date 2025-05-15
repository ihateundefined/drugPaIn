namespace drugPaIn
{
    partial class NewPatient
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSymptom1;
        private System.Windows.Forms.Label lblSymptom2;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSymptom1;
        private System.Windows.Forms.TextBox txtSymptom2;

        private System.Windows.Forms.Button btnDiagnose;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblDiagnosisResult;

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSymptom1 = new System.Windows.Forms.Label();
            this.lblSymptom2 = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSymptom1 = new System.Windows.Forms.TextBox();
            this.txtSymptom2 = new System.Windows.Forms.TextBox();

            this.btnDiagnose = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDiagnosisResult = new System.Windows.Forms.Label();

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.Text = "이름:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 23);

            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 70);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 15);
            this.lblAge.Text = "나이:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(100, 67);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(180, 23);

            // 
            // lblSymptom1
            // 
            this.lblSymptom1.AutoSize = true;
            this.lblSymptom1.Location = new System.Drawing.Point(30, 110);
            this.lblSymptom1.Name = "lblSymptom1";
            this.lblSymptom1.Size = new System.Drawing.Size(54, 15);
            this.lblSymptom1.Text = "증상 1:";
            // 
            // txtSymptom1
            // 
            this.txtSymptom1.Location = new System.Drawing.Point(100, 107);
            this.txtSymptom1.Name = "txtSymptom1";
            this.txtSymptom1.Size = new System.Drawing.Size(180, 23);

            // 
            // lblSymptom2
            // 
            this.lblSymptom2.AutoSize = true;
            this.lblSymptom2.Location = new System.Drawing.Point(30, 150);
            this.lblSymptom2.Name = "lblSymptom2";
            this.lblSymptom2.Size = new System.Drawing.Size(54, 15);
            this.lblSymptom2.Text = "증상 2:";
            // 
            // txtSymptom2
            // 
            this.txtSymptom2.Location = new System.Drawing.Point(100, 147);
            this.txtSymptom2.Name = "txtSymptom2";
            this.txtSymptom2.Size = new System.Drawing.Size(180, 23);

            // 
            // btnDiagnose
            // 
            this.btnDiagnose.Location = new System.Drawing.Point(30, 190);
            this.btnDiagnose.Name = "btnDiagnose";
            this.btnDiagnose.Size = new System.Drawing.Size(100, 30);
            this.btnDiagnose.Text = "진단하기";
            this.btnDiagnose.UseVisualStyleBackColor = true;
            this.btnDiagnose.Click += new System.EventHandler(this.btnDiagnose_Click);

            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(180, 190);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.Text = "등록하기";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // 
            // lblDiagnosisResult
            // 
            this.lblDiagnosisResult.AutoSize = true;
            this.lblDiagnosisResult.Location = new System.Drawing.Point(30, 230);
            this.lblDiagnosisResult.Name = "lblDiagnosisResult";
            this.lblDiagnosisResult.Size = new System.Drawing.Size(0, 15);
            this.lblDiagnosisResult.Text = "";

            // 
            // NewPatient
            // 
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblSymptom1);
            this.Controls.Add(this.txtSymptom1);
            this.Controls.Add(this.lblSymptom2);
            this.Controls.Add(this.txtSymptom2);
            this.Controls.Add(this.btnDiagnose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblDiagnosisResult);
            this.Name = "NewPatient";
            this.Text = "신규 환자 진단";
        }
    }
}
