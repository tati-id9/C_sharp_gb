Console.Clear();
Console.WriteLine("Список задач:\n Задача № 25: Программа, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Задача № 27: Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Задача № 29: Программа, которая задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine("Введите номер задачи, программу которой необходимо запустить: ");
int task = int.Parse(Console.ReadLine());

if (task == 25)
{
    Exp();
}
else if (task == 27)
{
    GetSum();
}
else if (task == 29)
{
    Console.WriteLine("Введите номер решения задачи:\n 1- задается рандомный массив, \n 2- массив вводится в консоль");
    int task2 = int.Parse(Console.ReadLine());

    if (task2 == 1)
    {
        Task11();
    }
    else if (task2 == 2)
    {
        Task12();
    }
    else
    {
        Console.WriteLine("Такого решения задачи нет");
    }
}
else
{
    Console.WriteLine("Такой задачи нет");
}

/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

void Exp()
{
    Console.Write("Введите число A: ");
    int numberA = int.Parse(Console.ReadLine());
    Console.Write("Введите степень B: ");
    int numberB = int.Parse(Console.ReadLine());

    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine("А в степени B = " + exponentiation);
}

int Exponentiation(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

void GetSum()
{
    Console.WriteLine("Ввведите число:");
    int number = int.Parse(Console.ReadLine());
    int sumNumber = SumNumber(number);
    Console.WriteLine("Сумма цифр = " + sumNumber);
}

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

//Вариант 1
void Task11()
{
    System.Console.WriteLine("Ввведите количество элементов в массиве:");
    int N = int.Parse(Console.ReadLine());
    System.Console.WriteLine($"Массив -> [{string.Join(", ", GetArray(N))}]");
}

int[] GetArray(int N)
{
    int[] arr = new int[N];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }

    return arr;
}

//Вариант 2

void Task12()
{
    Console.Write("Введите ряд чисел, разделенных запятой : ");
    string? strArr = Console.ReadLine();
    strArr = strArr + ",";    // дополнительня запятая для обозначения конца строки

    string strNew = RemovingSpaces(strArr);
    int count = ElementCount(strNew);

    System.Console.WriteLine($"Массив -> [{string.Join(", ", ArrayOfNumbers(strNew, count))}]");
}

// удаления пробелов из строки 
string RemovingSpaces(string s)
{
    string sNew = "";
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] != ' ')
        {
            sNew += s[i];
        }
    }
    return sNew;
}

//подсчет элементов в массиве
int ElementCount (string s)
{
    int count=0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ',')
        {
            count++;
        }
    }
    return count;
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string sNew, int count)
{
    int[] arrayOfNumbers = new int[count];
    int j =0;
    for (int i = 0; i < count; i++)
    {
        string s = "";

        while (sNew[j] != ',' && j < sNew.Length)
        {
            s += sNew[j];
            j++;
        }

        j++;
        arrayOfNumbers[i] = Convert.ToInt32(s);
    }

    return arrayOfNumbers;
}
