namespace GeniyIdiot.Common
{
    public class DiagnosisCalculator
    {
        static string[] GetDiagnoses()
        {
            var diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";

            return diagnoses;
        }
        public static string Calculate(int countQuestions, int countRightAnswers)
        {
            var diagnoses = GetDiagnoses();

            var percentRightAnswers = countRightAnswers * 100 / countQuestions;

            return diagnoses[percentRightAnswers / 20];
        }
    }
}
