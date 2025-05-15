namespace drugPaIn
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Symptom1 { get; set; }
        public string Symptom2 { get; set; }
        public string Diagnosis { get; set; }
        public string Medication { get; set; } = "";
    }
}
