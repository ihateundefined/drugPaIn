# 💊 환자 관리 프로그램 - drugPaIn

C# WinForms로 만든 **간단한 환자 진단 및 약물 처방 관리 애플리케이션**입니다.  
신규 환자 등록부터 진단 결과에 따른 약물 처방, 기존 환자 정보의 확인·수정·삭제까지  
모두 한눈에 관리할 수 있는 **오프라인 데스크탑 앱**입니다.

---

### 📽️ 시연 영상 (Demo Video)

🎬 **프로젝트 시연 영상을 보시려면 아래 링크를 클릭하세요:**

[▶️ 시연 영상 보기 (Google Drive)](https://drive.google.com/file/d/1YzYDIM3AfjivXI7eYqawlsRCKh924XBv/view?usp=sharing)

> 📝 *해당 링크는 Google Drive로 연결되며, 영상 재생 또는 다운로드가 가능합니다.*

---

## ✨ 주요 기능

### 🩺 신규 환자 진단 및 등록  
- 이름, 나이, 증상 2가지 입력  
- 증상 기반 자동 진단  
- 진단 결과 확인 후에만 `등록하기` 버튼 활성화  
- 진단명과 함께 환자 정보 등록

### 💊 약물 처방  
- 진단명 선택 시, 자동으로 해당 진단에 맞는 약물 추천  
- 사용자가 직접 처방 내용 입력 가능 (향후 약물 DB 연동 가능)

### 📋 진단 및 처방 내역 확인  
- 환자 리스트를 통해 기존 환자 확인  
- 환자 선택 시 상세 정보 표시  
- 수정 및 삭제 버튼으로 정보 관리 가능

---

## 🧪 증상 → 진단명 → 약물 매핑 테이블
환자의 증상을 입력하면, 진단을 하고, 약을 추천합니

| 🧠 진단명 | 🩹 주요 증상 (3개)             | 💊 추천 약물 (3개)                     |
|----------|------------------------------|----------------------------------------|
| 감기     | 기침, 가래, 열                | 타이레놀, 판콜, 쌍화탕                  |
| 당뇨     | 갈증, 다뇨, 체중감소           | 메트포르민, 인슐린, 글리벤클라미드      |
| 치매     | 기억력감퇴, 혼돈, 방향감각상실  | 도네페질, 리바스티그민, 메만틴          |
| 비만     | 과식, 운동부족, 피로           | 오르리스타트, 메트포르민, 펜터민         |
| 고혈압   | 두통, 어지러움, 심계항진       | 암로디핀, 로사르탄, 히드로클로로티아지드 |

---

## 💻 실행 방법

1. [Releases](https://github.com/ihateundefined/drugPaIn/releases) 페이지로 이동합니다  
2. 최신 버전의 `.zip` 또는 `.exe` 파일을 다운로드합니다  
3. 다운로드한 `.zip` 파일의 압축을 해제한 후,  
   `.exe` 파일을 더블 클릭하여 실행합니다

> 별도의 설치 과정 없이 바로 실행 가능합니다  
> Windows SmartScreen 경고가 나올 경우, "추가 정보" > "실행"을 눌러주세요

---

## 🧭 화면 구성

- `NewPatient.cs` - 신규 환자 등록 및 진단 화면  
- `Prescription.cs` - 진단 기반 약물 처방 입력 화면  
- `PatientList.cs` - 진단 및 처방 내역 확인, 수정/삭제 화면  
- `MainForm.cs` - 세 기능을 연결하는 홈 화면

---

## 🧱 프로젝트 구조

```
drugPaIn/
├── drugPaIn.sln
└── drugPaIn/
├── Program.cs
├── MainForm.cs / .Designer.cs
├── NewPatient.cs / .Designer.cs
├── Prescription.cs / .Designer.cs
├── PatientList.cs / .Designer.cs
├── Patient.cs
├── PatientStorage.cs
├── DiagnosisMapper.cs
```

---

## 🛠️ 기술 스택

| Layer      | Tech                        |
|------------|-----------------------------|
| Frontend   | C# WinForms (.NET Framework) |
| Backend    | 메모리 기반 데이터 저장 구조 |
| 기타       | Visual Studio IDE, Windows 전용 |

---

## 📌 참고 사항

- 현재 환자 데이터는 메모리에만 저장되며, 앱 종료 시 초기화됩니다.  
- 파일 저장, 데이터베이스 연동은 추후 버전에서 지원 예정입니다.  
- `DiagnosisMapper.cs` 내에서 증상 → 진단명 → 약물 추천 로직을 커스터마이징할 수 있습니다.  

---

## 🚧 향후 계획

- [ ] 파일 기반 데이터 저장 기능 추가  
- [ ] Oracle 또는 MySQL 기반 DB 연동  
- [ ] 진단 및 약물 리스트 API 활용  
- [ ] 증상 자동완성 및 UI 개선  
- [ ] 다국어 지원  

---

## 📫 문의

> 😅 당분간 문의 자제 요망..
> 사용 중 오류나 버그를 발견했다면 카톡주세요, 칭찬해드립니다! 🎉 
>  
> **깃허브**: [drugPaIn GitHub](https://github.com/ihateundefined/drugPaIn)  
> **이메일**: ihateundefined@gmail.com

---
© 2025 drugPaIn Project. Enjoy healing! 🧬
