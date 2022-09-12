Console.Clear();
Console.WriteLine("Список задач:\nЗадача № 47: Задайте двумерный массив размером mxn,заполненный случайными вещественными числами.");
Console.WriteLine("Задача № 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Задача № 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Введите номер задачи, программу которой необходимо запустить: ");
int task = int.Parse(Console.ReadLine());

if (task == 47)
{
    Task47();
}
else if (task == 50)
{
    Task50();
}
else if (task == 52)
{
    Task52();
}
else
{
    Console.WriteLine("Такой задачи нет");
}

/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
//Task47();

double[,] DoubleRandomArr(int sizeM, int sizeN)
{
    double[,] arr = new double[sizeM, sizeN];
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++) // перебор строк
    {
        for (int j = 0; j < arr.GetLength(1); j++) // перебор столбцов
        {
            arr[i, j] = Math.Round(rand.NextDouble(), 2);
        }
    }
    return arr;
}

void Task47()
{
    System.Console.Write("Ввведите количество строк в массиве:");
    int m = int.Parse(Console.ReadLine());
    System.Console.Write("Ввведите количество столбцов в массиве:");
    int n = int.Parse(Console.ReadLine());

    double[,] matrix = DoubleRandomArr(m, n);
    System.Console.WriteLine("Сформированная матрица:");
    ConsoleOutput(matrix);
}

void ConsoleOutput(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

/* Задача 50. Напишите программу,
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */

int RandomCount()
{
    int count = new Random().Next(2, 11);
    return count;
}

double[,] RandomArr(double[,] arr, int minN, int maxN)
{
    for (int i = 0; i < arr.GetLength(0); i++) // перебор строк
    {
        for (int j = 0; j < arr.GetLength(1); j++) // перебор столбцов
        {
            arr[i, j] = new Random().Next(minN, maxN);
        }
    }
    return arr;
}

void Task50()
{
    System.Console.Write("Ввведите позицию элемента по строке в массиве:");
    int m = int.Parse(Console.ReadLine());
    System.Console.Write("Ввведите позицию элемента по столбцу в массиве:");
    int n = int.Parse(Console.ReadLine());

    double[,] matrix = new double[RandomCount(), RandomCount()];
    matrix = RandomArr(matrix, 1, 10);
    System.Console.WriteLine("Сформированная матрица:");
    ConsoleOutput(matrix);

    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Заданный элемент равен: {matrix[m, n]}");
    }
    else
    {
        System.Console.WriteLine("Такого элемента нет в заданном массиве.");
    }
}

/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
    1 4 7 2   
    5 9 2 3   
    8 4 2 4    
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
void Task52()
{
    double[,] matrix = new double[RandomCount(), RandomCount()];
    matrix = RandomArr(matrix, 1, 10);
    System.Console.WriteLine("Сформированная матрица:");
    ConsoleOutput(matrix);
    System.Console.WriteLine($"Среднее арифметическое каждого столбца: -> [{string.Join("; ", Average(matrix))}]");
}

double[] Average(double[,] matr)
{
    double[] arrAverage = new double[matr.GetLength(1)];
    double sum;

    for (int j = 0; j < matr.GetLength(1); j++) // перебор столбцов
    {
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++) // перебор столбцов
        {
            sum += matr[i, j];
        }
        arrAverage[j] = sum / matr.GetLength(0);
    }
    return arrAverage;
}