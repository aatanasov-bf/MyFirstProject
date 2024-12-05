using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.OOP.HomeworkLecture7
{
    public class AgeValidator
    {

        public static void ValidateAge(int age)
        {
            Console.WriteLine($"Age is {age}");
            if (age < 0)
                throw new InvalidAgeException("Error: Age must not be negative!");
            else if (age == 0)
                throw new InvalidAgeException("Error: Age can not be 0");
            else if (age > 150)
                throw new InvalidAgeException("Error: Age can not be over 150");
            else
                Console.WriteLine("Age is valid");
        }

    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() { }
        public InvalidAgeException(string message) : base(message) { }
    }
}
