using System;
using System.Linq;
using System.Windows.Forms;

namespace drugPaIn
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text.Trim();
            var patient = PatientStorage.Patients.FirstOrDefault(p => p.Name == name);

            if (patient == null)
            {
                MessageBox.Show("해당 이름의 환자를 찾을 수 없습니다.");
                return;
            }

            lblPatientInfo.Text = $"이름: {patient.Name}, 나이: {patient.Age}\n진단명: {patient.Diagnosis}";

            comboDrugs.Items.Clear();
            var drugs = DiagnosisMapper.GetDrugs(patient.Diagnosis);
            foreach (var drug in drugs)
            {
                comboDrugs.Items.Add(drug);
            }

            if (comboDrugs.Items.Count > 0)
                comboDrugs.SelectedIndex = 0;

            btnPrescribe.Enabled = true;
        }

        private void btnPrescribe_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text.Trim();
            var patient = PatientStorage.Patients.FirstOrDefault(p => p.Name == name);

            if (patient == null) return;

            string selectedDrug = comboDrugs.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDrug))
            {
                MessageBox.Show("약물을 선택해주세요.");
                return;
            }

            patient.Medication = selectedDrug;
            MessageBox.Show($"'{selectedDrug}' 약물이 '{patient.Name}'에게 처방되었습니다.");
        }
    }
}
