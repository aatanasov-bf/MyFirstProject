class HomeworkLecture5Methods
{
    public static int FindLargestNumberInArray(int[] arrayOfNumbers)
    {
        int largestNumberInArray = arrayOfNumbers.Max();
        return largestNumberInArray;
    }

    public static string ReverseString(string inputString)
    {
        string reversedString;
        if (string.IsNullOrEmpty(inputString))
            return "Empty";
        else
        {
            reversedString = string.Join("", inputString.Reverse().ToArray());
            return reversedString;
        }
    }

    public static long[] GenerateFibonacciSequence(int sequenceLength)
    {
        long[] fibonacciSequence = new long[sequenceLength];

        if (sequenceLength == 1)
        {
            fibonacciSequence[0] = 0;
            return fibonacciSequence;
        }
        else if (sequenceLength == 2)
        {
            fibonacciSequence[0] = 0;
            fibonacciSequence[1] = 1;
            return fibonacciSequence;
        }
        else
        {
            fibonacciSequence[0] = 0;
            fibonacciSequence[1] = 1;
            for (int i = 2; i < sequenceLength; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }
            return fibonacciSequence;
        }
    }

    public static bool IstheNumberPrime(int number)
    {
        bool result = false;
        int devisionCounter = 0;

        for (int i = 1; i <= number; i++)
        {

            if (number % i == 0)
            {
                devisionCounter++;
            }

            if (devisionCounter > 2)
                break;
        }

        if (devisionCounter == 2)
            result = true;

        return result;
    }

    public static int[] sortIntegerArrayAccending(int[] integerArray)
    {
        int temp;
        for (int i = 0; i < integerArray.Length - 1; i++)
        {
            for (int j = 0; j < integerArray.Length - i - 1; j++)
            {

                if (integerArray[j] > integerArray[j + 1])
                {
                    temp = integerArray[j];
                    integerArray[j] = integerArray[j + 1];
                    integerArray[j + 1] = temp;
                }
            }
        }
        return integerArray;
    }

    public static void SwapNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static int[] updateArrayElements(ref int[] intArray, ref int multiplyFactor)
    {
        for (int i = 0; i < intArray.Length; i++)
            intArray[i] *= multiplyFactor;

        return intArray;
    }

    public static void devideTwoNumbers(int firstNumber, int secondNumber, out int quotient, out int reminder)
    {
        if (firstNumber == 0)
        {
            quotient = 0;
            reminder = 0;
        }
        else
        {
            quotient = firstNumber / secondNumber;
            reminder = firstNumber % secondNumber;
        }
    }

    public static void parseStringToNumber(string s, out int convertedNumber)
    {
        int parseResult;
        if (int.TryParse(s, out parseResult))
            convertedNumber = parseResult;
        else
            convertedNumber = 0;
    }
}
