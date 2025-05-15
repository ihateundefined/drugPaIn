using System;
using System.Windows.Forms;

namespace drugPaIn
{
    public partial class NewPatient : Form
    {
        private Patient editingPatient = null;

        public NewPatient()
        {
            InitializeComponent();
            btnRegister.Enabled = false; // 진단 전 등록 비활성화
        }

        // 수정용 생성자
        public NewPatient(Patient patientToEdit) : this()
        {
            editingPatient = patientToEdit;
            txtName.Text = editingPatient.Name;
            txtAge.Text = editingPatient.Age.ToString();
            txtSymptom1.Text = editingPatient.Symptom1;
            txtSymptom2.Text = editingPatient.Symptom2;

            string diagnosis = DiagnosisMapper.GetDiagnosis(txtSymptom1.Text.Trim(), txtSymptom2.Text.Trim());
            lblDiagnosisResult.Text = $"진단 결과: {diagnosis}";
            btnRegister.Enabled = true; // 수정 시 등록 버튼 활성화
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            string symptom1 = txtSymptom1.Text.Trim();
            string symptom2 = txtSymptom2.Text.Trim();

            if (string.IsNullOrEmpty(symptom1) || string.IsNullOrEmpty(symptom2))
            {
                MessageBox.Show("두 개의 증상을 입력해주세요.");
                return;
            }

            string diagnosis = DiagnosisMapper.GetDiagnosis(symptom1, symptom2);
            lblDiagnosisResult.Text = $"진단 결과: {diagnosis}";
            btnRegister.Enabled = true; // 진단 후 등록 버튼 활성화
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (!int.TryParse(txtAge.Text.Trim(), out int age))
            {
                MessageBox.Show("나이를 숫자로 입력해주세요.");
                return;
            }

            string symptom1 = txtSymptom1.Text.Trim();
            string symptom2 = txtSymptom2.Text.Trim();
            string diagnosis = DiagnosisMapper.GetDiagnosis(symptom1, symptom2);

            if (editingPatient != null)
            {
                // 기존 환자 정보 수정
                editingPatient.Name = name;
                editingPatient.Age = age;
                editingPatient.Symptom1 = symptom1;
                editingPatient.Symptom2 = symptom2;
                editingPatient.Diagnosis = diagnosis;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Patient newPatient = new Patient
                {
                    Name = name,
                    Age = age,
                    Symptom1 = symptom1,
                    Symptom2 = symptom2,
                    Diagnosis = diagnosis
                };

                PatientStorage.Patients.Add(newPatient);
                MessageBox.Show("환자 정보가 등록되었습니다.");
                Close();
            }
        }
    }
}
