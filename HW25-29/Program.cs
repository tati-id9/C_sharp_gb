/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Ввведите число:");
int number = int.Parse(Console.ReadLine());
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр = " + sumNumber);

int SumNumber(int numberN)
{

    int count = Convert.ToString(numberN).Length;
    int advance = 0, result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}


/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] GetArray(int N)
{
    int[] arr = new int[N];

    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }

    return arr;
}
System.Console.WriteLine("Ввведите число:");
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine($"[{string.Join(", ", GetArray(N))}]");