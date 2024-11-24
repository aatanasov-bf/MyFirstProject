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
            Console.Write("Available homeworks: 1, 2, 3\nSelect homework: ");
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
                        HomeworkLecture3.CinemaHallTask();
                        HomeworkLecture3.FishingTrip();
                        HomeworkLecture3.SalaryDeduction();
                        HomeworkLecture3.StepsToReachAGoal();
                        HomeworkLecture3.BirthdayCake();
                        HomeworkLecture3.PasswordGenerator();
                        break;
                    }
                    case 3:
                    {
                        HomeworkLecture4.CommonElements();
                        HomeworkLecture4.MaxSequenceOfEqualElements();
                        HomeworkLecture4.Train();
                        HomeworkLecture4.CardsGame();
                        HomeworkLecture4.CountCharsInString();
                        HomeworkLecture4.MinerTask();
                        HomeworkLecture4.BasicStackOperations();
                        HomeworkLecture4.BasicQueueOperations();
                        break;
                    }
            }
            Console.WriteLine();
        }
    }
}
