//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int ReadNum (string arg)
{
    int number;
    Console.WriteLine($"Input {arg}:");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine($"It,s not a {arg}");
    }
    return number;
}

int num = ReadNum("number");
int power = ReadNum("power of number");

double PowerNum (int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

double result = PowerNum(num, power);
Console.WriteLine("Result is " + result);