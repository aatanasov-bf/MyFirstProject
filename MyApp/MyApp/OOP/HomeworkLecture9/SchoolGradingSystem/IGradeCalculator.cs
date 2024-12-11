namespace MyApp.OOP.HomeworkLecture9.SchoolGradingSystem
{
    public interface IGradeCalculator
    {
        public string? GradeType { get; set; }

        public double CalculateGrade();
    }
}
