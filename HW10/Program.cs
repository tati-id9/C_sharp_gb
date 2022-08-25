/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* int Func(int namber)
{
    return Math.Abs((namber/10)%10);
}

Console.WriteLine ("Ввведите число:");
int a = int.Parse(Console.ReadLine());

if ((a>=100 && a<1000) || (a<=-100 && a>-1000))
{
    int result = Func(a);
    Console.WriteLine (result);
}
else
{
    Console.WriteLine ("Вы ввели не верное число, число должно быть трехзначным");
} */

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* Console.WriteLine ("Ввведите число:");
int number = Math.Abs(int.Parse(Console.ReadLine()));
string numberS = Convert.ToString(number);

if (number>=100)
{
    string result = Convert.ToString(numberS[2]);
    Console.WriteLine (result);

}
else
{
    Console.WriteLine ("Tретьей цифры нет");
}
 */
/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

void DayWeek (int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Это выходной день недели");
    }
    else if (day>=1 && day<=5)
    {
        Console.WriteLine("Это не выходной день недели");
    }
    else
    {
        Console.WriteLine("Это не день недели");
    }
}

Console.WriteLine ("Ввведите цифру, обозначающую день недели:");
int number = int.Parse(Console.ReadLine());
DayWeek(number);
