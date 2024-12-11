namespace MyApp.OOP.HomeworkLecture8
{
    public class Puppy : Dog
    {
        public Puppy() { }

        public Puppy(string name, string favouriteFood) : base(name, favouriteFood) { }

        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
}
