class HomeworkLecture4
{
    public static void CommonElements()
    {
        Console.WriteLine("Task: Common elements");
        Console.Write("Enter first input: ");
        string[] firstInput = Console.ReadLine().Split(" ");
        Console.Write("Enter second input: ");
        string[] secondInput = Console.ReadLine().Split(" ");

        string[] commonElements = firstInput.Intersect(secondInput).ToArray();

        Console.Write("Common elements are: ");
        foreach (string element in commonElements)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }

    public static void MaxSequenceOfEqualElements()
    {
        Console.WriteLine("Task: Max Sequince of Equal Elements");
        Console.Write("Enter sequince: ");
        int[] initSequince = (Console.ReadLine().Split(" ")).Select(int.Parse).ToArray();

        int currentCount = 1;
        int maxCount = 1;
        int longestNumber = initSequince[0];

        for (int i = 1; i < initSequince.Length; i++)
        {
            if (initSequince[i] == initSequince[i - 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    longestNumber = initSequince[i];
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        int[] longestSequence = new int[maxCount];
        for (int i = 0; i < maxCount; i++)
        {
            longestSequence[i] = longestNumber;
        }

        Console.WriteLine($"Longest sequence is : {string.Join(" ", longestSequence)}");
    }

    public static void Train()
    {
        Console.WriteLine("Task: Train");

        Console.Write("Enter the wagons: ");
        List<int> wagons = (Console.ReadLine().Split(" ")).Select(int.Parse).ToList();

        Console.Write("Enter wagons's max capacity: ");
        int maxCapacity = int.Parse(Console.ReadLine());

        string command;
        do
        {
            Console.Write("Available commands: Add {pasangers}, {pasangers}, end to terminate the programm\nEnter command: ");
            command = Console.ReadLine().ToLower();

            int wagon;
            if (command.Contains("add"))
            {
                wagon = int.Parse(command.Split(" ").ToArray()[1]);
                wagons.Add(wagon);
                continue;
            }
            else if (!command.Equals("end"))
            {
                foreach (int currentPassangerCount in wagons)
                {
                    int passengerCount = int.Parse(command);
                    int newPassangerCount = passengerCount + currentPassangerCount;
                    if (newPassangerCount <= maxCapacity)
                    {
                        wagons[wagons.IndexOf(currentPassangerCount)] = newPassangerCount;
                        break;
                    }
                }
            }
            else if (command.Equals("end"))
            {
                Console.Write("List of wagons: ");
                foreach (int w in wagons)
                {
                    Console.Write($"{w} ");
                }
            }
        }
        while (command != "end");
        Console.WriteLine();
    }

    public static void CardsGame()
    {
        Console.WriteLine("Task: Card Game");

        Console.Write("Enter first player's deck: ");
        List<int> firstPlayerDeck = (Console.ReadLine().Split(" ")).Select(int.Parse).ToList();
        Console.Write("Enter second player's deck: ");
        List<int> secondPlayerDeck = (Console.ReadLine().Split(" ")).Select(int.Parse).ToList();

        bool gameOver = false;
        do
        {
            int firstPlayerCard = firstPlayerDeck[0];
            int secondPlayerCard = secondPlayerDeck[0];

            if (firstPlayerCard == secondPlayerCard)
            {
                firstPlayerDeck.Remove(firstPlayerCard);
                secondPlayerDeck.Remove(secondPlayerCard);
            }
            else if (firstPlayerCard > secondPlayerCard)
            {
                firstPlayerDeck.Remove(firstPlayerCard);
                firstPlayerDeck.Add(firstPlayerCard);
                firstPlayerDeck.Add(secondPlayerCard);
                secondPlayerDeck.Remove(secondPlayerCard);
            }
            else
            {
                secondPlayerDeck.Remove(secondPlayerCard);
                secondPlayerDeck.Add(secondPlayerCard);
                secondPlayerDeck.Add(firstPlayerCard);
                firstPlayerDeck.Remove(firstPlayerCard);
            }

            if (firstPlayerDeck.Count == 0 || secondPlayerDeck.Count == 0)
                gameOver = true;
        }
        while (!gameOver);

        if (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count == 0)
            Console.WriteLine($"First player wins! Score: {firstPlayerDeck.Sum()}");
        else if (secondPlayerDeck.Count > 0 && firstPlayerDeck.Count == 0)
            Console.WriteLine($"Second player wins! Score: {secondPlayerDeck.Sum()}");
        else
            Console.WriteLine("It's a draw! Nobody wins!");
    }

    public static void CountCharsInString()
    {
        Console.WriteLine("Task: Count Chars in a String");

        Console.Write("Enter your string: ");

        char[] chars = (Console.ReadLine()).Replace(" ", "").ToCharArray();
        int charCounter = 0;
        Dictionary<char, int> countedChars = new Dictionary<char, int>();

        for (int i = 0; i < chars.Length; i++)
        {
            char ch = chars[i];
            foreach (char c in chars)
            {
                if (ch == c)
                    charCounter++;
            }
            if (!countedChars.ContainsKey(ch))
                countedChars.Add(ch, charCounter);
            charCounter = 0;
        }

        Console.WriteLine("Counted characters are");
        foreach (KeyValuePair<char, int> cCh in countedChars)
        {
            Console.WriteLine($"{cCh.Key} -> {cCh.Value}");
        }
        Console.WriteLine();
    }

    public static void MinerTask()
    {
        Console.WriteLine("Task: Miner Task");
        string resourceType;
        int resourceQuantity;
        Dictionary<string, int> mine = new Dictionary<string, int>();

        do
        {
            Console.Write("Enter resource type: ");
            resourceType = Console.ReadLine().ToLower();
            if (resourceType.Equals("stop"))
                continue;
            Console.Write("Enter resource quantity: ");
            resourceQuantity = int.Parse(Console.ReadLine().ToLower());
            if (mine.ContainsKey(resourceType))
                mine[resourceType] += resourceQuantity;
            else
                mine.Add(resourceType, resourceQuantity);
        }
        while (!resourceType.Equals("stop"));

        Console.WriteLine("The mine has");
        foreach (KeyValuePair<string, int> resource in mine)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }
        Console.WriteLine();
    }

    public static void BasicStackOperations()
    {
        Console.WriteLine("Task: Basic Stack Operations");

        Console.Write("Enter {pushed elements} {popped elements} {elemnt to search}: ");
        int[] stackOperations = (Console.ReadLine().Split(" ")).Select(int.Parse).ToArray();
        Console.Write("Enter stack elements: ");
        int[] elements = (Console.ReadLine().Split(" ")).Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < stackOperations[0]; i++)
        {
            stack.Push(elements[i]);
        }

        for (int i = 0; i < stackOperations[1]; i++)
        {
            stack.Pop();
        }

        if (stack.Count == 0)
            Console.WriteLine("0");
        else
        {
            bool elFound = false;
            foreach (int i in stack)
            {
                if (stackOperations[2] == i)
                {
                    Console.WriteLine("true");
                    elFound = true;
                    break;
                }
            }
            if (!elFound)
                Console.WriteLine($"Smallest element in the stack is: {stack.Min()}");
        }
        Console.WriteLine();
    }
    public static void BasicQueueOperations()
    {
        Console.WriteLine("Task: Basic Queue Operations");

        Console.Write("Enter {enqueued elements} {dequeued elements} {elemnt to search}: ");
        int[] queueOperations = (Console.ReadLine().Split(" ")).Select(int.Parse).ToArray();
        Console.Write("Enter stack elements: ");
        int[] elements = (Console.ReadLine().Split(" ")).Select(int.Parse).ToArray();

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < queueOperations[0]; i++)
        {
            queue.Enqueue(elements[i]);
        }

        for (int i = 0; i < queueOperations[1]; i++)
        {
            queue.Dequeue();
        }

        if (queue.Count == 0)
            Console.WriteLine("0");
        else
        {
            bool elFound = false;
            foreach (int i in queue)
            {
                if (queueOperations[2] == i)
                {
                    Console.WriteLine("true");
                    elFound = true;
                    break;
                }
            }
            if (!elFound)
                Console.WriteLine($"Smallest element in the queue is: {queue.Min()}");
        }
        Console.WriteLine();
    }
}
