Console.WriteLine("hello");
Console.WriteLine("Input The First Number");

string userInputNumber1 = Console.ReadLine();

int number1 = int.Parse(userInputNumber1);

Console.WriteLine("Input The Second Number");

string userInputNumber2 = Console.ReadLine();

int number2 = int.Parse(userInputNumber2);


Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");


string userInput = Console.ReadLine();



if (userInput == "A" || userInput == "a")
{
    Console.WriteLine($"{number1} + {number2} = {Add(number1, number2)}");
}

if (userInput == "S" || userInput == "s")
{
    Console.WriteLine($"{number1} - {number2} = {Subtract(number1, number2)}");
}

if (userInput == "M" || userInput == "m")
{
    Console.WriteLine($"{number1} * {number2} = {Subtract(number1, number2)}");
}


Console.WriteLine("Press any key to close");
Console.ReadKey();


int Add(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b)
{
    return a * b;
}