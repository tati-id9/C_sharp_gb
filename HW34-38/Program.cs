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
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
    System.Console.WriteLine(hNumber);
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
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
    System.Console.WriteLine(sum);
}

/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

    [3 7 22 2 78] -> 76 */
double[] RandArr(int size, int minN, int maxN)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minN, maxN);
    }
    return arr;
}

    System.Console.WriteLine("Ввведите количество элементов в массиве:");
    int N = int.Parse(Console.ReadLine());
    double[] array = RandArr(N, -100, 100);
   // int diff = 
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
    //System.Console.WriteLine(diff);