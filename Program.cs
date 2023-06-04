/*Семинар по введению в программирование "сишарп" № 5
ДЗ
// *******

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
while (num2 < 100)
{
    Console.Write("Введите начальное значение массива >= 100 !!!: ");
    num2 = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());
while (num3 > 999)
{
    Console.Write("Введите конечное значение массива <= 999 !!!: ");
    num3 = Convert.ToInt32(Console.ReadLine());
}

int[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
{
    int[] RandomArray = new int[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        RandomArray[i] = rand.Next(MinValue, MaxValue + 1);
    }
    return RandomArray;
}

int EvenNumbers(int[] array)
{
    int Counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Counter++; ;
    }
    return Counter;
}

void PrintRandomArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("] количество четных чисел в массиве равно -> ");
}

int[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);
Console.WriteLine(EvenNumbers(RandomArray));

// ******

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
{
    int[] RandomArray = new int[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        RandomArray[i] = rand.Next(MinValue, MaxValue + 1);
    }
    return RandomArray;
}

int EvenNumbersPosition(int[] array)
{
    int Counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Counter += array[i];
        }
    }
    return Counter;
}

void PrintRandomArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("] сумма элементво на нечетных позициях в массиве равна -> ");
}

int[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);
Console.WriteLine(EvenNumbersPosition(RandomArray));

//*****

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());

double[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
{
    double[] RandomArray = new double[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        RandomArray[i] = Math.Round(rand.Next(MinValue, MaxValue)+rand.NextDouble(), 2);
    }
    return RandomArray;
}

void PrintRandomArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}: ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("] разница между максимальным и минимальным элементами массива равна -> ");
}

double difference(double[] array)
{
    double max = array.Max();
    double min = array.Min();
    double deff = 0;
    return deff = max - min;
}

double[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);
Console.WriteLine(difference(RandomArray));

*/