using MyApp.OOP.HomeworkLecture9.EComerceSystem;
using MyApp.OOP.HomeworkLecture9.SchoolGradingSystem;
using MyApp.OOP.HomeworkLecture9.ZooAnimals;
using MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem;

namespace MyApp.OOP.HomeworkLecture9
{
    public class HomeworkLecture9
    {
        public static void Task1()
        {

            List<Animal> animals = new List<Animal>();

            Animal dog = new Dog();
            Animal dog1 = new Dog();
            Animal cat = new Cat();
            Animal cat1 = new Cat();

            animals.Add(dog);
            animals.Add(dog1);
            animals.Add(cat);
            animals.Add(cat1);

            dog.Name = "Rex";
            dog1.Name = "Pluto";
            cat.Name = "Princess";
            cat1.Name = "Snowball";

            Console.WriteLine("Task 1: Zoo Animals");

            foreach (Animal animal in animals)
            {
                Console.Write($"{animal.Name} is ");
                animal.MakeSound();
                animal.Eat();
                Console.WriteLine();
            }
        }

        public static void Task2()
        {
            List<IGradeCalculator> gradeCalculator = new List<IGradeCalculator>();
            Assignement assignement = new Assignement();
            Assignement assignement1 = new Assignement();
            Exam exam = new Exam();
            Exam exam1 = new Exam();

            gradeCalculator.Add(assignement);
            gradeCalculator.Add(assignement1);
            gradeCalculator.Add(exam);
            gradeCalculator.Add(exam1);

            assignement.GradeType = "assignment";
            assignement.MaxScore = 200;
            assignement.ScoreAchieved = 187;
            assignement1.GradeType = "assignment";
            assignement1.MaxScore = 555;
            assignement1.ScoreAchieved = 345;

            exam.GradeType = "exam";
            exam.MaxMarks = 54;
            exam.MarksObtained = 45;
            exam1.GradeType = "exam";
            exam1.MaxMarks = 123;
            exam1.MarksObtained = 111;

            Console.WriteLine("Task 2: School Gradin System");

            foreach (IGradeCalculator element in gradeCalculator)
            {

                if (element.GradeType.Equals("assignment"))
                    Console.WriteLine($"Assignment Grade: {element.CalculateGrade().ToString("0.00")}%");
                else
                    Console.WriteLine($"Exam Grade: {element.CalculateGrade().ToString("0.00")}%");

            }
        }

        public static void Task3()
        {
            List<Product> products = new List<Product>();

            Product electronics = new Electronics();
            Product electronics1 = new Electronics();
            Product clothing = new Clothing();
            Product clothing1 = new Clothing();

            products.Add(electronics);
            products.Add(electronics1);
            products.Add(clothing);
            products.Add(clothing1);

            electronics.Name = "DVD Player";
            electronics.Price = 100;
            electronics1.Name = "Smartphone";
            electronics1.Price = 2345;
            clothing.Name = "T-shirt";
            clothing.Price = 34;
            clothing1.Name = "Hat";
            clothing1.Price = 56;

            Console.WriteLine("Task 3: E-Commerce System");
            foreach (Product product in products)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }
        }

        public static void Task4()
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
            {
                new Book("It","Steven King"),
                new Book("To kill a mocking bird", "Harper Lee"),
                new Book("Don Quixote", "Miguel de Cervantes"),
                new Magazine("National Geographic", 5),
                new Magazine("The New Yorker", 44),
                new Magazine("Vogue", 22)
            };

            string borrowingPerson = "Atanas Atanasov";
            try
            {
                IsTheBorrowingLimitReached(borrowingPerson, libraryItems);
                ((Book)libraryItems[0]).Borrow(borrowingPerson, DateTime.Parse("12-31-2024"));
            }
            catch (BorrowingLimiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IsTheBorrowingLimitReached(borrowingPerson, libraryItems);
                ((Book)libraryItems[1]).Borrow(borrowingPerson, DateTime.Parse("12-31-2024"));
            }
            catch (BorrowingLimiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IsTheBorrowingLimitReached(borrowingPerson, libraryItems);
                ((Book)libraryItems[2]).Borrow(borrowingPerson, DateTime.Parse("12-31-2024"));
            }
            catch (BorrowingLimiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IsTheBorrowingLimitReached(borrowingPerson, libraryItems);
                ((Magazine)libraryItems[3]).Borrow(borrowingPerson, DateTime.Parse("12-31-2024"));
            }
            catch (BorrowingLimiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            string borrowingPerson1 = "Pavel Pavlov";
            try
            {
                IsTheBorrowingLimitReached(borrowingPerson1, libraryItems);
                ((Magazine)libraryItems[3]).Borrow(borrowingPerson1, DateTime.Parse("12-31-2024"));
            }
            catch (BorrowingLimiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IsTheBorrowingLimitReached(borrowingPerson1, libraryItems);
                ((Magazine)libraryItems[4]).Borrow(borrowingPerson1, DateTime.Parse("12-31-2024"));
            }
            catch (BorrowingLimiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Library inventar status after some borrowings:");
            foreach (LibraryItem libraryItem in libraryItems)
            {
                libraryItem.CheckStatus();
            }

            Console.WriteLine();
            ((Book)libraryItems[0]).Return();

            try
            {
                IsTheBorrowingLimitReached(borrowingPerson, libraryItems);
                ((Magazine)libraryItems[5]).Borrow(borrowingPerson, DateTime.Parse("12-31-2024"));
            }
            catch (BorrowingLimiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Library inventar status after some returns and borrowings:");
            foreach (LibraryItem libraryItem in libraryItems)
            {
                libraryItem.CheckStatus();
            }

            Console.WriteLine();
            ((Book)libraryItems[0]).ExtendDueDate(5);
            ((Book)libraryItems[1]).ExtendDueDate(5);
            ((Book)libraryItems[2]).ExtendDueDate(8);
            ((Magazine)libraryItems[5]).ExtendDueDate(10);

            Console.WriteLine("Library inventar status after some date changes:");
            foreach (LibraryItem libraryItem in libraryItems)
            {
                libraryItem.CheckStatus();
            }

        }

        private static void IsTheBorrowingLimitReached(string borrower, List<LibraryItem> libraryItems)
        {
            int borrowingLimit = 0;
            foreach (LibraryItem libraryItem in libraryItems)
            {

                if (libraryItem.Borrower != null && libraryItem.Borrower.Replace(" ", "").ToLower().Equals(borrower.Replace(" ", "").ToLower()))
                    borrowingLimit++;
                if (borrowingLimit >= 3)
                    throw new BorrowingLimiteException("Borrowng limit was reached! No more borrowings allowed\n");
            }
        }
    }

    public class BorrowingLimiteException : Exception
    {
        public BorrowingLimiteException(string message) : base(message) { }
    }
}
