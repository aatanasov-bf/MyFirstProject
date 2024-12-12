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

            Libray libray = new Libray();

            Book book = new Book("It", "Steven King");
            Book book1 = new Book("To kill a mocking bird", "Harper Lee");
            Book book2 = new Book("Don Quixote", "Miguel de Cervantes");
            Magazine magazine = new Magazine("National Geographic", 5);
            Magazine magazine1 = new Magazine("The New Yorker", 44);
            Magazine magazine2 = new Magazine("Vogue", 22);

            libray.AddItemToLibrary(book);
            libray.AddItemToLibrary(book1);
            libray.AddItemToLibrary(book2);
            libray.AddItemToLibrary(magazine);
            libray.AddItemToLibrary(magazine1);
            libray.AddItemToLibrary(magazine2);

            string borrowingPerson = "Atanas Atanasov";
            libray.BorrowItemFromLibrary("It",borrowingPerson, DateTime.Parse("12-31-2024"));
            libray.BorrowItemFromLibrary("To kill a mocking bird", borrowingPerson, DateTime.Parse("12-31-2024"));
            libray.BorrowItemFromLibrary("Don Quixote", borrowingPerson, DateTime.Parse("12-31-2024"));
            libray.BorrowItemFromLibrary("National Geographic", borrowingPerson, DateTime.Parse("12-31-2024"));
            libray.BorrowItemFromLibrary("Vogue", borrowingPerson, DateTime.Parse("12-31-2024"));

            string borrowingPerson1 = "Pavel Pavlov";
            libray.BorrowItemFromLibrary("It", borrowingPerson1, DateTime.Parse("12-31-2024"));
            libray.BorrowItemFromLibrary("National Geographic", borrowingPerson1, DateTime.Parse("12-31-2024"));
            libray.BorrowItemFromLibrary("The New Yorker", borrowingPerson1, DateTime.Parse("12-31-2024"));

            libray.DisplayLibrayItems();

            Console.WriteLine();
            libray.ReturnItemToLibrary("It");
            libray.BorrowItemFromLibrary("Vogue", borrowingPerson, DateTime.Parse("12-31-2024"));

            libray.DisplayLibrayItems();

            Console.WriteLine();
            libray.ExtendItemDueDate("To kill a mocking bird", 29);
            libray.ExtendItemDueDate("Don Quixote", 8);
            libray.ExtendItemDueDate("Vogue", 10);

            libray.DisplayLibrayItems();

            libray.BorrowItemFromLibrary("It", borrowingPerson1, DateTime.Parse("11-30-2024"));

            libray.DisplayLibrayItems();
        }
    }
}
