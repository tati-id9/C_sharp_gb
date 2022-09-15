Console.Clear();

Console.WriteLine("Список задач:\nЗадача № 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("Задача № 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("Задача № 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine("Задача № 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine("Задача № 62: Напишите программу, которая заполнит спирально массив 4 на 4.");
Console.WriteLine("Введите номер задачи, программу которой необходимо запустить: ");
int task = int.Parse(Console.ReadLine());

if (task == 54) {Task54();}
else if (task == 56) {Task56();}
else if (task == 58) {Task58();}
else if (task == 60) {Task60();}
else if (task == 62) {Task62();}
else {Console.WriteLine("Такой задачи нет");}


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

int RandomCount(int min, int max)
{
    int count = new Random().Next(min, max);
    return count;
}

int[,] RandomArr(int minN, int maxN, int rangeMin, int rangeMax)
{
    int[,] arr = new int[RandomCount(rangeMin, rangeMax), RandomCount(rangeMin, rangeMax)];
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
    int[,] matr = RandomArr(0, 10, 1, 10);
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
    int[,] matr = RandomArr(0, 10, 1, 11);
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

void Task58()
{
    //int[,] matr1 = new int[,] { { 2, 3 }, { 6, 5 } };
    int[,] matr1 = RandomArr(0, 10, 1, 5);
    System.Console.WriteLine("Сформированная матрица 1:");
    ConsoleOutput(matr1);

    //int[,] matr2 = new int[,] { { 8, 9, 7 }, { 5, 3, 5 } };
    int[,] matr2 = RandomArr(0, 10, 1, 5);
    System.Console.WriteLine("Сформированная матрица 2:");
    ConsoleOutput(matr2);

    int[,] resultMatr = MatrixMultiplication(matr1, matr2);
    System.Console.WriteLine("Результирующая матрица:");
    ConsoleOutput(resultMatr);
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}

/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

void Task60()
{
    System.Console.WriteLine("Введите размеры трехмерного массива");
    System.Console.Write("Введите размер по X: ");
    int x = int.Parse(Console.ReadLine());
    System.Console.Write("Введите размер по Y: ");
    int y = int.Parse(Console.ReadLine());
    System.Console.Write("Введите размер по Z: ");
    int z = int.Parse(Console.ReadLine());

    int[,,] matr = new int[x, y, z];
    matr = RandMatrix(matr);
    MatrixConsoleOutput(matr);
}

int[,,] RandMatrix(int[,,] matrix)
{
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = RandomCount(10, 100);

        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = RandomCount(10, 100);
                    j = 0;
                }
            }
        }
    }

    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = temp[count];
                count++;
            }
        }
    }
    return matrix;
}

void MatrixConsoleOutput(int[,,] matrix)
{
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j, z]}({i};{j};{z}) ");
            }
            System.Console.WriteLine();
        }
    }
}

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void Task62()
{
    int[,] matrix = new int[4, 4];
    SpiralMatrConsoleOutput(SpiralMatr(matrix));
}

int[,] SpiralMatr(int[,] matr)
{
    int count = 1;
    int i = 0;
    int j = 0;
    while (count < matr.GetLength(0) * matr.GetLength(1) + 1)
    {
        matr[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1) { j++; }
        else if (i < j && i + j >= matr.GetLength(0) - 1) { i++; }
        else if (i >= j && i + j > matr.GetLength(1) - 1) { j--; }
        else { i--; }
    }
    return matr;
}

void SpiralMatrConsoleOutput(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10) { Console.Write($"0{matr[i, j]} "); }
            else { Console.Write($"{matr[i, j]} "); }

        }
        Console.WriteLine();
    }
}

