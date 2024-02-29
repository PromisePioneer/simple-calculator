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


string choice = Console.ReadLine();



if (EqualCaseSensitive(choice, "A"))
{
    Console.WriteLine($"{number1} + {number2} = {Add(number1, number2)}");
}

if (EqualCaseSensitive(choice, "S"))
{
    Console.WriteLine($"{number1} - {number2} = {Subtract(number1, number2)}");
}

if (EqualCaseSensitive(choice, "M"))
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

bool EqualCaseSensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}