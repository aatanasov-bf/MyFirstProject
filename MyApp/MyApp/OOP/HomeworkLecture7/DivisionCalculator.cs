namespace MyApp.OOP.HomeworkLecture7
{
    public class DivisionCalculator
    {
        int FirstNumber;
        int SecondNumber;

        public DivisionCalculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }

        public DivisionCalculator(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public void Devide()
        {
            Console.WriteLine($"Deviding {FirstNumber} by {SecondNumber}");
            decimal devisionResult;
            try
            {
                devisionResult = FirstNumber / SecondNumber;
                Console.WriteLine($"Result is: {devisionResult.ToString("0.00")}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Devision by 0 is not allowed!");
            }
        }
    }
}
