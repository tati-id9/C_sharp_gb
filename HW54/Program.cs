Console.Clear();

void ConsoleOutput(int[,] matr)
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

int RandomCount()
{
    int count = new Random().Next(2, 6);
    return count;
}

int[,] RandomArr(int minN, int maxN)
{
    int[,] arr = new int[RandomCount(), RandomCount()];
    for (int i = 0; i < arr.GetLength(0); i++) // перебор строк
    {
        for (int j = 0; j < arr.GetLength(1); j++) // перебор столбцов
        {
            arr[i, j] = new Random().Next(minN, maxN);
        }
    }
    return arr;
}

/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

void Task54()
{
    int[,] matr = RandomArr(0, 10);
    System.Console.WriteLine("Сформированная матрица:");
    ConsoleOutput(matr);
    System.Console.WriteLine("Итоговая матрица:");
    ConsoleOutput(Sorting(matr));
}

// сортировка
int[,] Sorting(int[,] matrix)
{
    int temp;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[m, i] < matrix[m, j])
                {
                    temp = matrix[m, i];
                    matrix[m, i] = matrix[m, j];
                    matrix[m, j] = temp;
                }
            }
        }
    }
    return matrix;
}

/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2     ->14
5 9 2 3     ->19
8 4 2 4     ->18
5 2 6 7     ->20
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void Task56()
{
    int[,] matr = RandomArr(0, 10);
    System.Console.WriteLine("Сформированная матрица:");
    ConsoleOutput(matr);
    int[] arraySum = ArrSum(matr);
    System.Console.WriteLine($"Массив сумм: -> [{string.Join("; ", arraySum)}]");
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: -> {IndexMinimumValue(arraySum) + 1}");
}

int[] ArrSum(int[,] matrix)
{
    int[] arrRes = new int[matrix.GetLength(0)];
    int sum;
    for (int i = 0; i < matrix.GetLength(0); i++) // перебор строк
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) // перебор столбцов
        {
            sum += matrix[i, j];
        }
        arrRes[i] = sum;
    }
    return arrRes;
}

int IndexMinimumValue(int[] arr)
{
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[minIndex] > arr[i])
        {
            minIndex = i;
        }
    }
    return minIndex;
}

/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] matr1 = new int [,] {{2,3}, {6,5}};
//int[,] matr1 = RandomArr(0, 10);
System.Console.WriteLine("Сформированная матрица1:");
ConsoleOutput(matr1);

//int[,] matr2 = RandomArr(0, 10);
int[,] matr2 = new int [,] {{8,9,7}, {5,3,5}};
System.Console.WriteLine("Сформированная матрица2:");
ConsoleOutput(matr2);


int[,] resultMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
for (int i=0; i < matr1.GetLength(0); i++) 
{
    for (int j = 0; j < matr2.GetLength(1); j++)
    {
        for (int k = 0; k < matr2.GetLength(0); k++)
        {
            resultMatr[i, j] += matr1[i, k] * matr2[k, j];
        }
    }
}
System.Console.WriteLine("Результирующая матрица:");
ConsoleOutput(resultMatr);