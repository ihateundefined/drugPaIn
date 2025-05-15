using System;
using System.Windows.Forms;

namespace drugPaIn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            NewPatient newPatientForm = new NewPatient();
            newPatientForm.ShowDialog();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            Prescription prescriptionForm = new Prescription();
            prescriptionForm.ShowDialog();
        }

        private void btnViewPatients_Click(object sender, EventArgs e)
        {
            PatientList patientListForm = new PatientList();
            patientListForm.ShowDialog();
        }
    }
}
