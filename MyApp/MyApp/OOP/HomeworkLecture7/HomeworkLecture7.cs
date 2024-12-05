using System.Threading.Tasks.Sources;

namespace MyApp.OOP.HomeworkLecture7
{
    public class HomeworkLecture7
    {
        public static void Task1()
        {
            Console.WriteLine("\nTask1: Create a Product Class\n");

            Product defaultProduct = new Product();
            Product product = new Product("Headphones", 100.50m, 50);

            decimal totalCostParamProduct = product.CalculateTotalCost();

            Console.WriteLine($"The default product data is: \nName: {defaultProduct.Name}, Price: {defaultProduct.Price}, Quantity: {defaultProduct.Quantity}");
            Console.WriteLine();
            Console.WriteLine($"The param product data is: \nName: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            Console.WriteLine();
            Console.WriteLine($"The total cost for the param product is: {totalCostParamProduct}");
        }

        public static void Task2()
        {
            Console.WriteLine("\nTask2: Bank Account Class\n");

            BankAccount bankAccount = new BankAccount("11223344556677", 2000.50m);

            Console.WriteLine($"Bank account details: \nAccount Number: {bankAccount.AccountNumber}, Balance: {bankAccount.Balance}");
            Console.WriteLine();
            decimal depositAmount = 500.40m;
            bankAccount.Deposit(depositAmount);
            Console.WriteLine($"Bank account details afer depositint {depositAmount}: \nAccount Number: {bankAccount.AccountNumber}, Balance: {bankAccount.Balance}");
            Console.WriteLine();
            decimal withdrawalAmount = 500.50m;
            bankAccount.Withdraw(withdrawalAmount);
            Console.WriteLine($"Bank account details after withdrawal: \nAccount Number: {bankAccount.AccountNumber}, Balance: {bankAccount.Balance}");
            bankAccount.Withdraw(4000m);
        }

        public static void Task3()
        {
            Console.WriteLine("\nTask3: Division Calculator\n");
            DivisionCalculator divisionCalculator = new DivisionCalculator(28, 5);
            divisionCalculator.Devide();
            DivisionCalculator divisionCalculator1 = new DivisionCalculator(28, 0);
            divisionCalculator1.Devide();
        }

        public static void Task4()
        {
            Console.WriteLine("\nTask4: Custom Exception\n");

            try
            {
                AgeValidator.ValidateAge(44);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AgeValidator.ValidateAge(-1);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AgeValidator.ValidateAge(0);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AgeValidator.ValidateAge(160);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Task5()
        {
            Console.WriteLine("\nTask5: File Reader with Cleanup\n");

            string correctFilePath = "C:\\mockupFile.txt";
            string incorrectFilePath = "C:\\mockupFile1.txt";

            FileReader.ReadFile(correctFilePath);
            Console.WriteLine();
            FileReader.ReadFile(incorrectFilePath);
            Console.WriteLine();
            FileReader.ReadFileWithStreamer(correctFilePath);
            Console.WriteLine();
            FileReader.ReadFileWithStreamer(incorrectFilePath);
        }
    }
}
