// Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран

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

int ArrayLength = ReadNum ("array length:");
int min = ReadNum ("minimum element size:");
int max = ReadNum ("maximum element size:");

void CreateArroy (int length, int min, int max)
{
    int [] array = new int [length];
    Console.Write ("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new  Random (). Next (min, max+1);
        Console.Write (array[i] + "; ");
    }
    Console.Write ("]");
}

CreateArroy (ArrayLength, min, max);