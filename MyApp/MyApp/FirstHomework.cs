//Task 1: Convert and Add Two Numbers
string firstNumber, secondNumber;

Console.WriteLine("Task 1: Convert and Add Two Numbers");
Console.Write("Enter first number: ");
firstNumber = System.Console.ReadLine();
Console.Write("Enter second number: ");
secondNumber = System.Console.ReadLine();
int.TryParse(firstNumber, out int firstNumberIntValue);
int.TryParse(secondNumber, out int secondNumberIntValue);
Console.WriteLine($"Number are: {firstNumber} and {secondNumber}");
Console.WriteLine($"The sum of the numbers is: {firstNumberIntValue + secondNumberIntValue}");


//Task 2: Format a Full Name
string firstName, lastName;

Console.WriteLine("\nTask 2: Format a Full Name");
Console.Write("Enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Enter your last name: ");
lastName = Console.ReadLine();
Console.WriteLine($"My name is: {lastName}, {firstName}");


//Task 3: Extract and Modify Substring
string sentence, startIndex, numberOfLetters;

Console.WriteLine("\nTask 3: Extract and Modify Substring");
Console.Write("Enter your sentence: ");
sentence = Console.ReadLine();
Console.WriteLine($"Your sentence is: {sentence}");
Console.Write("Enter the starting position: ");
startIndex = Console.ReadLine();
Console.Write("Enter the number of letters: ");
numberOfLetters = Console.ReadLine();
int.TryParse(startIndex, out int startIndexIntValue);
int.TryParse(numberOfLetters, out int numberOfLettersIntValue);
Console.WriteLine($"Extracted word is: {sentence.Substring(startIndexIntValue - 1, numberOfLettersIntValue).ToUpper()}");


//Task 4: Validate Age Input
string radius;
const double PI = 3.14;

Console.WriteLine("\nTask 4: Calculate the Area of a Circle");
Console.Write("Enter the radius of the circle: ");
radius = Console.ReadLine();
double.TryParse(radius, out double radiusDoubleValue);
Console.WriteLine($"The area of the circle is: {PI * radiusDoubleValue * radiusDoubleValue}");


//Task 5: Validate Age Input
string age;

Console.WriteLine("\nTask 5: Validate Age Input");
Console.Write("Enter your age: ");
age = Console.ReadLine();
if(!int.TryParse(age, out int ageIntValue))
{
    Console.WriteLine("Invalid input. Please enter an integer value for your age."); 
}
else if (ageIntValue<0)
{
    Console.WriteLine("Invalid input. Please enter a positive integer value for your age.");
}
else
{
    Console.WriteLine($"Your age is {ageIntValue}");
}