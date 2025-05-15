using System;
using System.Windows.Forms;

namespace drugPaIn
{
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            listBoxPatients.Items.Clear();
            foreach (var p in PatientStorage.Patients)
                listBoxPatients.Items.Add(p.Name);
        }

        private void listBoxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex >= 0)
            {
                var p = PatientStorage.Patients[listBoxPatients.SelectedIndex];
                lblPatientDetail.Text = $"이름: {p.Name}, 나이: {p.Age}, 증상1: {p.Symptom1}, 증상2: {p.Symptom2}, 진단: {p.Diagnosis}, 약물: {p.Medication}";
            }
            else
            {
                lblPatientDetail.Text = "선택된 환자 정보:";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex >= 0)
            {
                PatientStorage.Patients.RemoveAt(listBoxPatients.SelectedIndex);
                LoadPatients();
                lblPatientDetail.Text = "선택된 환자 정보:";
            }
            else
            {
                MessageBox.Show("삭제할 환자를 선택하세요.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex < 0)
            {
                MessageBox.Show("수정할 환자를 선택하세요.");
                return;
            }

            var selectedPatient = PatientStorage.Patients[listBoxPatients.SelectedIndex];

            NewPatient editForm = new NewPatient(selectedPatient);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadPatients();
                listBoxPatients.SelectedIndex = -1;
                lblPatientDetail.Text = "선택된 환자 정보:";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
