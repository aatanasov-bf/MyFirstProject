using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Exec
    {
        static void Main(string[] args)
        {
            Console.Write("Available homeworks: 1, 2\nSelect homework: ");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        HomeworkLecture2.HomeworkLecture2Tasks();
                        break;
                    }
                    case 2:
                    {
                        HomeworkLecture4.CinemaHallTask();
                        HomeworkLecture4.FishingTrip();
                        HomeworkLecture4.SalaryDeduction();
                        HomeworkLecture4.StepsToReachAGoal();
                        HomeworkLecture4.BirthdayCake();
                        HomeworkLecture4.PasswordGenerator();
                        break;
                    }
            }

        }
    }
}
