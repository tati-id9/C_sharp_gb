Console.Clear();
Console.WriteLine("Список задач:\nЗадача № 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Задача № 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Задача № 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("Введите номер задачи, программу которой необходимо запустить: ");
int task = int.Parse(Console.ReadLine());

if (task == 34)
{
    Task34();
}
else if (task == 36)
{
    Task36();
}
else if (task == 38)
{
    Task38();
}
else
{
    Console.WriteLine("Такой задачи нет");
}

/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2 */

int[] RandomArr(int size, int minN, int maxN)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minN, maxN);
    }
    return arr;
}

int HonestNumber(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void Task34()
{
    System.Console.WriteLine("Ввведите количество элементов в массиве:");
    int N = int.Parse(Console.ReadLine());
    int[] array = RandomArr(N, 100, 1000);
    int hNumber = HonestNumber(array);
    System.Console.WriteLine($"Массив -> [{string.Join(", ", array)}]");
    System.Console.WriteLine($"Количество четных чисел -> {hNumber}");
}
/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0 */

int SumElements(int[] arr) //сумма элементов массива, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

void Task36()
{
    System.Console.WriteLine("Ввведите количество элементов в массиве:");
    int N = int.Parse(Console.ReadLine());
    int[] array = RandomArr(N, -100, 1000);
    int sum = SumElements(array);
    System.Console.WriteLine($"Массив ->[{string.Join(", ", array)}]");
    System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях-> {sum}");
}

/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

    [3 7 22 2 78] -> 76 */

double[] DoubleRandomArr(int size)
{
    double[] arr = new double[size];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.NextDouble(), 3);
    }
    return arr;
}

double MaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double MinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

void Task38()
{
    System.Console.WriteLine("Ввведите количество элементов в массиве:");
    int N = int.Parse(Console.ReadLine());
    double[] array = DoubleRandomArr(N);
    double diff = MaxNumber(array) - MinNumber(array);
    System.Console.WriteLine($"Массив -> [{string.Join(", ", array)}]");
    System.Console.WriteLine($"Максимальный элемент-> {MaxNumber(array)}, Минимальный элемент ->{MinNumber(array)}");
    System.Console.WriteLine($"Раздница между максимальным и минимальным элементом -> {diff}");
}