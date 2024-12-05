namespace MyApp.OOP.HomeworkLecture7
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions(string message) : base(message) { }

        public static void InvalidAgeException(string message)
        {

        }
    }
}
