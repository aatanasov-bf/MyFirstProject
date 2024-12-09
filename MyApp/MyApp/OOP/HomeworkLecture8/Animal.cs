using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.OOP.HomeworkLecture8
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal() { }

        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual string ExplainSelf()
        {
            string text = $"I am {name} and my favourite food is {favouriteFood}";

            return text;
        }
    }
}
