using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.OOP.HomeworkLecture8
{
    public class Cat : Animal
    {
        public Cat() { }
        public Cat(string name, string favouriteFood) : base(name,favouriteFood) { }

        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }

        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}\nMEEOW";
        }
    }
}
