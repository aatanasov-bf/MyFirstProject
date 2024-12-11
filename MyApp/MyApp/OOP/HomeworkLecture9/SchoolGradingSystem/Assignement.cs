namespace MyApp.OOP.HomeworkLecture9.SchoolGradingSystem
{
    public class Assignement : IGradeCalculator
    {
        public string? GradeType { get; set; }
        public double MaxScore { get; set; }
        public double ScoreAchieved { get; set; }

        public double CalculateGrade()
        {
            double percentageScore = ScoreAchieved / MaxScore * 100;
            return percentageScore;
        }
    }
}
