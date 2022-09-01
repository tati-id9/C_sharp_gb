/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2 */

int [] RandomArr(int size)
{
     int[] arr = new int[size];
     for (int i=0; i< arr.Length; i++)
     {
        arr[i] = new Random().Next(100,1000);
     }
     return arr;
}

int HonestNumber(int[] arr)
{
    int count = 0;

    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = RandomArr(5);
int hNumber= HonestNumber(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine(hNumber);