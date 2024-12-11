namespace MyApp.OOP.HomeworkLecture9.SchoolGradingSystem
{
    public class Exam : IGradeCalculator
    {
        public string? GradeType { get; set; }
        public double MaxMarks { get; set; }
        public double MarksObtained { get; set; }

        public double CalculateGrade()
        {
            double percantageScore = MarksObtained / MaxMarks * 100;
            return percantageScore;
        }
    }
}
