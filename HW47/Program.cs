/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
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