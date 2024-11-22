class HomeworkLecture3
{
    public static void CinemaHallTask()
    {
        double ticketPrice = 0;
        int rows = 0;
        int columns = 0;
        string screeningType = "";

        Console.WriteLine("Task: Cinema Hall\nTypes of screening: Premiere, Normal, Discount");
        bool correctInput = false;
        do
        {
            Console.Write("Enter type of screening:");
            screeningType = Console.ReadLine().ToLower();

            switch (screeningType)
            {
                case "premiere":
                    ticketPrice = 12.00;
                    correctInput = true;
                    break;
                case "normal":
                    ticketPrice = 7.50;
                    correctInput = true;
                    break;
                case "discount":
                    ticketPrice = 5.00;
                    correctInput = true;
                    break;
                default:
                    Console.WriteLine("Enter correct value");
                    break;
            }
        }
        while (!correctInput);

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        columns = int.Parse(Console.ReadLine());

        Console.WriteLine($"The total revenue of the hall is: {(rows * columns * ticketPrice).ToString("0.00")}\n");
    }

    public static void FishingTrip()
    {
        string season = "";
        int rentalCost = 0;
        int groupSize = 0;
        int discount = 0;
        int addDiscount = 0;
        int budget = 0;
        int numberOfFishermen = 0;
        int totalCost = 0;

        Console.Write("Task: Fishing trip\nEnter your budget: ");
        budget = int.Parse(Console.ReadLine());

        Console.WriteLine("Seasons: Spring, Summer, Autumn, Winter");
        bool correctRentalCostInput = false;
        do
        {
            Console.Write("Enter type of screening: ");
            season = Console.ReadLine().ToLower();

            if (season.Equals("spring"))
            {
                rentalCost = 3000;
                correctRentalCostInput = true;
            }
            else if (season.Equals("summer") || season.Equals("autumn"))
            {
                rentalCost = 4200;
                correctRentalCostInput = true;
            }
            else if (season.Equals("winter"))
            {
                rentalCost = 2600;
                correctRentalCostInput = true;
            }
            else
                Console.WriteLine("Enter correct value");
        }
        while (!correctRentalCostInput);

        Console.Write("Enter group size (number of fishermen): ");
        groupSize = int.Parse(Console.ReadLine());
        if (groupSize <= 6)
            discount = 10;
        else if (groupSize >= 7 && groupSize < 12)
            discount = 15;
        else
            discount = 25;

        if (groupSize % 2 == 0 && !season.Equals("autumn"))
            addDiscount = 5;

        if (addDiscount != 0)
        {
            totalCost = (rentalCost * (100 - discount)) / 100;
            totalCost = (totalCost * (100 - addDiscount)) / 100;
        }

        else
            totalCost = (rentalCost * (100 - discount)) / 100;

        if (budget < totalCost)
            Console.WriteLine($"Sorry no fishing trip. :( \nYour budget is: {budget} but the totals cost is {totalCost}");
        else
            Console.WriteLine("Yeah! Fishing trip!");
        Console.WriteLine();
    }

    public static void SalaryDeduction()
    {
        int salary = 0;
        Console.Write("Task: Salaray Deduction\nEnter your salary: ");
        salary = int.Parse(Console.ReadLine());

        int numberOfTabs = 0;
        Console.Write("Enter the number of oppened tabs: ");
        numberOfTabs = int.Parse(Console.ReadLine());

        string tabWebsite = "";
        bool correctWebsiteInput;
        for (int i = 0; i < numberOfTabs; i++)
        {
            Console.Write("Enter the tab website: ");
            tabWebsite = Console.ReadLine().ToLower();

            if (tabWebsite.Equals("facebook"))
                salary -= 150;
            else if (tabWebsite.Equals("instagram"))
                salary -= 100;
            else if (tabWebsite.Equals("reddit"))
                salary -= 50;
            if (salary <= 0)
                Console.WriteLine("You lost your salary! You are BROKE!");
            else
                Console.WriteLine($"Your remaining salary is: {salary} BGN");
        }
        Console.WriteLine();
    }
    public static void StepsToReachAGoal()
    {
        int goal = 10000;
        string dailySteps = "";
        int stepsToHome = 0;

        Console.WriteLine("Task: Steps to Reach a Goal");

        do
        {
            Console.Write("Enter your daily steps count: ");
            dailySteps = Console.ReadLine().ToLower();

            if (dailySteps.Equals("going home"))
            {
                Console.Write("Enter your steps to home: ");
                stepsToHome = int.Parse(Console.ReadLine());
                goal -= stepsToHome;
                if (goal > 0)
                {
                    Console.WriteLine($"{goal} more steps to reach your goal.");
                    break;
                }
                else
                    Console.WriteLine("Goal reached! Good job!");

            }
            else
            {
                goal -= int.Parse(dailySteps);
                if (goal <= 0)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
        } while (goal > 0);
        Console.WriteLine();
    }

    public static void BirthdayCake()
    {
        Console.WriteLine("Task: Birthday Cake");

        Console.Write("Enter cake's width: ");
        int cakeWidth = int.Parse(Console.ReadLine());
        Console.Write("Enter cake's length: ");
        int cakeLength = int.Parse(Console.ReadLine());

        int numberOfPieces = cakeWidth * cakeLength;

        Console.Write("Enter number of guests: ");
        int numberOfGuests = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfGuests; i++)
        {
            Console.Write("Enter number of taken pieces: ");
            string numberOfTakenPieces = Console.ReadLine().ToLower();
            if (numberOfTakenPieces.Equals("stop") && numberOfPieces > 0)
            {
                Console.WriteLine($"{numberOfPieces} pieces are left");
                break;
            }
            else if (int.Parse(numberOfTakenPieces) > numberOfPieces)
            {
                Console.WriteLine($"No more cake left! You need {int.Parse(numberOfTakenPieces) - numberOfPieces} pieces more.");
                break;
            }
            else
                numberOfPieces -= int.Parse(numberOfTakenPieces);

            if (i == numberOfGuests - 1 && numberOfPieces >= 0)
                Console.WriteLine("Yeah! All guests got cake");
        }
        Console.WriteLine();
    }

    public static void PasswordGenerator()
    {
        Console.WriteLine("Task: Password generator");

        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input l: ");
        int l = int.Parse(Console.ReadLine());

        int symbol1, symbol2, symbol5;
        char symbol3, symbol4;

        for (int i = 1; i <= n; i++)
        {
            symbol1 = i;
            for (int j = 1; j <= n; j++)
            {
                symbol2 = j;
                for (int k = 1; k <= l; k++)
                {
                    symbol3 = (char)(k + 96);
                    for (int m = 1; m <= l; m++)
                    {
                        symbol4 = (char)(m + 96);
                        for (int p  = 1; p <= n; p++)
                        {
                            if (p > symbol1 && p > symbol2 )
                            {
                                symbol5 = p;
                                Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5} ");
                            }
                        }
                    }
                }
            }
        }
    }
}