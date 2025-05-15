namespace drugPaIn
{
    partial class PatientList
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Label lblPatientDetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.lblPatientDetail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();

            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.ItemHeight = 15;
            this.listBoxPatients.Location = new System.Drawing.Point(12, 12);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(200, 304);
            this.listBoxPatients.TabIndex = 0;
            this.listBoxPatients.SelectedIndexChanged += new System.EventHandler(this.listBoxPatients_SelectedIndexChanged);

            // 
            // lblPatientDetail
            // 
            this.lblPatientDetail.AutoSize = true;
            this.lblPatientDetail.Location = new System.Drawing.Point(230, 12);
            this.lblPatientDetail.Name = "lblPatientDetail";
            this.lblPatientDetail.Size = new System.Drawing.Size(95, 15);
            this.lblPatientDetail.TabIndex = 1;
            this.lblPatientDetail.Text = "선택된 환자 정보:";

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(230, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(230, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // PatientList
            // 
            this.ClientSize = new System.Drawing.Size(350, 330);
            this.Controls.Add(this.listBoxPatients);
            this.Controls.Add(this.lblPatientDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Name = "PatientList";
            this.Text = "진단 및 처방 내역 확인";
        }
    }
}
