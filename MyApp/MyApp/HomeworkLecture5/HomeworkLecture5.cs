class HomeworkLecture5
{
    public static void MethodsDemo()
    {
        Console.Write("Select task from Homework Lecture 5 (1-9): ");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                {
                    Console.WriteLine("Task: Find the Largest Number in an Array");
                    Console.Write("Enter the array of numbers: ");
                    string numbersAsString = Console.ReadLine();
                    if (numbersAsString.Length != 0)
                    {
                        int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                        int largestNumber = HomeworkLecture5Methods.FindLargestNumberInArray(numbers);
                        Console.WriteLine($"Largest number in the array is: {largestNumber}");
                    }
                    else
                        Console.WriteLine("The array of numbers was empy!");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Task: Reverse A String");
                    Console.Write("Enter the string");
                    string inputString = Console.ReadLine();
                    string reveresedString = HomeworkLecture5Methods.ReverseString(inputString);
                    Console.WriteLine($"Reveresed String is: {reveresedString}");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Task: Generate Fibonacci Sequence (works from 1 to 93)");
                    Console.Write("Enter Fibonacci Sequence length: ");
                    int fibonacciLength = int.Parse(Console.ReadLine());
                    long[] fibonacciSequence = HomeworkLecture5Methods.GenerateFibonacciSequence(fibonacciLength);
                    Console.WriteLine($"Fibonacci Sequence: {string.Join(" ", fibonacciSequence)}");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Task: Check For Prime Numbers");
                    Console.Write("Enter the number: ");
                    int number = int.Parse(Console.ReadLine());
                    bool checkResult = HomeworkLecture5Methods.IstheNumberPrime(number);
                    if (checkResult)
                        Console.WriteLine($"The number {number} is prime");
                    else
                        Console.WriteLine($"The number {number} is not prime");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Task: Sorting Array without using built-in methods");
                    Console.Write("Enter the array: ");
                    int[] integerArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                    int[] sortedArray = HomeworkLecture5Methods.sortIntegerArrayAccending(integerArray);
                    Console.Write($"Sorter array: {string.Join(" ", sortedArray)}");
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Task: Swap Two Numbers");
                    Console.Write("Enter first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"First number was {firstNumber} and second number was {secondNumber}");
                    HomeworkLecture5Methods.SwapNumbers(ref firstNumber, ref secondNumber);
                    Console.WriteLine($"First number is {firstNumber} and second number is {secondNumber}");
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Task: Update Array ELements");
                    Console.Write("Enter the array: ");
                    int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    Console.Write("Enter multiply factor: ");
                    int multiplyFactor = int.Parse(Console.ReadLine());
                    HomeworkLecture5Methods.updateArrayElements(ref intArray, ref multiplyFactor);
                    string updatedArray = string.Join(" ", intArray);
                    Console.WriteLine($"The updated array is: {updatedArray}");
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Task: Devide Two Numers");
                    Console.Write("Enter first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());
                    if (secondNumber == 0)
                        Console.WriteLine("Not possible! Devision by 0 is not allowed!");
                    else
                    {
                        int q, r;
                        HomeworkLecture5Methods.devideTwoNumbers(firstNumber, secondNumber, out q, out r);
                        Console.WriteLine($"The quotient is {q} and the reminder is {r}");
                    }
                    break;
                }
            case 9:
                {
                    Console.WriteLine("Task: Parse String to Number");
                    Console.Write("Enter the number to convert: ");
                    string numberToConvert = Console.ReadLine();
                    int convertedNumber;
                    HomeworkLecture5Methods.parseStringToNumber(numberToConvert, out convertedNumber);
                    Console.WriteLine($"The result is: {convertedNumber}");
                    break;
                }

        }
    }
}
