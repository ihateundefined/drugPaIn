using System.Collections.Generic;

namespace drugPaIn
{
    public static class DiagnosisMapper
    {
        private static readonly Dictionary<string[], string> SymptomToDiagnosis = new Dictionary<string[], string>()
        {
            { new string[] { "기침", "가래" }, "감기" },
            { new string[] { "갈증", "피로" }, "당뇨" },
            { new string[] { "기억력감퇴", "혼란" }, "치매" },
            { new string[] { "과식", "운동부족" }, "비만" },
            { new string[] { "두통", "현기증" }, "고혈압" }
        };

        private static readonly Dictionary<string, List<string>> DiagnosisToDrugs = new Dictionary<string, List<string>>()
        {
            { "감기", new List<string>{ "타이레놀", "판콜", "부루펜" } },
            { "당뇨", new List<string>{ "메트포르민", "글리메피리드", "인슐린" } },
            { "치매", new List<string>{ "도네페질", "메만틴", "갈란타민" } },
            { "비만", new List<string>{ "오르리스타트", "펜터민", "로카세린" } },
            { "고혈압", new List<string>{ "암로디핀", "로사르탄", "텔미사르탄" } }
        };

        // 증상 2개를 받아 진단명 리턴
        public static string GetDiagnosis(string symptom1, string symptom2)
        {
            foreach (var entry in SymptomToDiagnosis)
            {
                var symptoms = entry.Key;
                if ((symptoms[0] == symptom1 && symptoms[1] == symptom2) ||
                    (symptoms[0] == symptom2 && symptoms[1] == symptom1))
                {
                    return entry.Value;
                }
            }
            return "알 수 없음";
        }

        // 진단명으로 약물 리스트 리턴
        public static List<string> GetDrugs(string diagnosis)
        {
            if (DiagnosisToDrugs.ContainsKey(diagnosis))
            {
                return DiagnosisToDrugs[diagnosis];
            }
            return new List<string>();
        }
    }
}
