namespace MyApp.OOP.HomeworkLecture9.ZooAnimals
{
    public abstract class Animal
    {
        string name;

        public string Name { get { return name; } set { name = value; } }

        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }
}
