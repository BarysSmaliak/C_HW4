// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int ReadNum (string arg)
{
    int number;
    Console.WriteLine($"Enter {arg}");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It,s not a number");
    }
    return number;
}

void SumDigit(int a)
{
    int result = 0;
    while (a >0)
    {
        result = result + a % 10;
        a = a / 10;
    }
    Console.WriteLine(
    "The sum of the digit of this number is " + result);
}

int sum = ReadNum ("number");
SumDigit (sum);