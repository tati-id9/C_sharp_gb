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

int[] nums = { 5, 5, 7, 1, 9, 2 };
 
// сортировка
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
 
// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}