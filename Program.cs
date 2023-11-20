Console.Title = "Simple Calculator Application";
Console.WriteLine("Hello!");
Console.WriteLine("===Welcome to Our Simple Calculator Application===");
Console.WriteLine();

Console.WriteLine("Input the first number:");
var firstNumber = double.Parse(Console.ReadLine()!);
Console.WriteLine("Input the second number:");
var secondNumber = double.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine("What do you want to do?");
Console.WriteLine();

Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
Console.WriteLine();

var userChoice = Console.ReadLine()!;

if(IgnoreCase(userChoice, "A"))
{
    var sum = firstNumber + secondNumber;
    PrintOperationOutput(firstNumber, secondNumber, sum, "+");
}
else if(IgnoreCase(userChoice, "S"))
{
    var difference = firstNumber - secondNumber;
    PrintOperationOutput(firstNumber, secondNumber, difference, "-");
}

else if(IgnoreCase(userChoice, "M"))
{
    var product = firstNumber * secondNumber;
    PrintOperationOutput(firstNumber, secondNumber, product, "*");
}

else
{
    Console.WriteLine("Invalid Operation! Enter Valid Operation.");
}

Console.WriteLine();
Console.WriteLine("Thanks for using Our Calculator. Press any key to close.");
Console.ReadKey();

void PrintOperationOutput(double firstNumber, double secondNumber, double result, string @operator)
{
    Console.WriteLine(firstNumber + " " + @operator + " " + secondNumber + " = " + result);
}

bool IgnoreCase(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}