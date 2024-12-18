﻿namespace MyApp.OOP.HomeworkLecture8
{
    public class Dog : Animal
    {
        public Dog() { }
        public Dog(string name, string favouriteFood) : base(name, favouriteFood) { }

        public void Bark()
        {
            Console.WriteLine("Barking...");
        }

        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}\nDJAAF";
        }

    }
}
