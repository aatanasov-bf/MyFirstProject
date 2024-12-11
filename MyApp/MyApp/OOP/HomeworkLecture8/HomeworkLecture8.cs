namespace MyApp.OOP.HomeworkLecture8
{
    public class HomeworkLecture8
    {
        public static void Task1()
        {
            Dog dog = new Dog();
            Console.Write("Demo Dog:Eat method - ");
            dog.Eat();
            Console.Write("Demo Dog:Bark method - ");
            dog.Bark();
        }

        public static void Task2()
        {
            Puppy puppy = new Puppy();
            Console.Write("Demo Puppy:Eat method - ");
            puppy.Eat();
            Console.Write("Demo Puppy:Bark method - ");
            puppy.Bark();
            Console.Write("Demo Puppy:Weep method - ");
            puppy.Weep();
        }

        public static void Task3()
        {
            Dog dog = new Dog();
            Console.Write("Demo Dog:Eat method - ");
            dog.Eat();
            Console.Write("Demo Dog:Bark method - ");
            dog.Bark();
            Cat cat = new Cat();
            Console.Write("Demo Cat:Eat method - ");
            cat.Eat();
            Console.Write("Demo Cat:Meow method - ");
            cat.Meow();
        }

        public static void Task4()
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine($"Add method with int int: {mo.Add(2, 3).ToString()}");
            Console.WriteLine($"Add method with double  double double: {mo.Add(2.2, 3.3, 5.5).ToString()}");
            Console.WriteLine($"Add method with decimal decimal decimal: {mo.Add(2.2m, 3.3m, 4.4m).ToString()}");
        }

        public static void Task5()
        {
            Animal cat = new Cat("Maria", "Whiskas");
            Animal dog = new Dog("Rex", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
