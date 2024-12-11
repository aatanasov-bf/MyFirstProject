using MyApp.OOP.HomeworkLecture7;
using MyApp.OOP.HomeworkLecture8;
using MyApp.OOP.HomeworkLecture9;

namespace MyApp
{
    class Exec
    {
        static void Main(string[] args)
        {
            Console.Write("Available homeworks: \n" +
                "1. Homework Lecture 2\n" +
                "2. Homework Lecture 3\n" +
                "3. Homewework Lecture 4\n" +
                "4. Homework Lecture 5\n" +
                "5. Homework Lecture 7\n" +
                "6. Homework Lecture 8\n" +
                "7. Homework Lecture 9\n" +
                "Select homework: ");
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
                case 4:
                    {
                        HomeworkLecture5.MethodsDemo();
                        break;
                    }
                case 5:
                    {
                        int choice;
                        do
                        {
                            Console.Write("Select task (1-5) 0 to exit: ");

                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        HomeworkLecture7.Task1();
                                        break;
                                    }
                                case 2:
                                    {
                                        HomeworkLecture7.Task2();
                                        break;
                                    }
                                case 3:
                                    {
                                        HomeworkLecture7.Task3();
                                        break;
                                    }
                                case 4:
                                    {
                                        HomeworkLecture7.Task4();
                                        break;
                                    }
                                case 5:
                                    {
                                        HomeworkLecture7.Task5();
                                        break;
                                    }
                            }
                        } while (choice != 0);
                        break;
                    }
                case 6:
                    {
                        int choice;
                        do
                        {
                            Console.Write("Select task (1-5) 0 to exit: ");

                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        HomeworkLecture8.Task1();
                                        break;
                                    }
                                case 2:
                                    {
                                        HomeworkLecture8.Task2();
                                        break;
                                    }
                                case 3:
                                    {
                                        HomeworkLecture8.Task3();
                                        break;
                                    }
                                case 4:
                                    {
                                        HomeworkLecture8.Task4();
                                        break;
                                    }
                                case 5:
                                    {
                                        HomeworkLecture8.Task5();
                                        break;
                                    }
                            }
                        } while (choice != 0);
                        break;
                    }

                case 7:
                    {
                        int choice;
                        do
                        {
                            Console.Write("Select task (1-4) 0 to exit: ");

                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        HomeworkLecture9.Task1();
                                        break;
                                    }
                                case 2:
                                    {
                                        HomeworkLecture9.Task2();
                                        break;
                                    }
                                case 3:
                                    {
                                        HomeworkLecture9.Task3();
                                        break;
                                    }
                                case 4:
                                    {
                                        HomeworkLecture9.Task4();
                                        break;
                                    }

                            }
                        } while (choice != 0);
                        break;
                    }
            }
            Console.WriteLine();
        }
    }
}
