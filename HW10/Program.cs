Console.Clear();
Console.WriteLine ("Список задач: \n Задача № 10: Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.\n Задача № 13: Программа, которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет. \n Задача № 15: Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine ("Введите номер задачи, программу которой необходимо запустить: ");
int N = int.Parse(Console.ReadLine());

switch(N)
{
    case 10:
        SecondDigitOfTheNumber();
        break;

    case 13:
        ThirdDigitOfTheNumber();
        break;

    case 15:
        DayWeek();
        break;

    default:
        Console.WriteLine ("Такой задачи нет");   ;
        break;
}

/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

void SecondDigitOfTheNumber()
{
    Console.WriteLine ("Ввведите трехзначное число:");
    int sNumber = int.Parse(Console.ReadLine());

    if ((sNumber>=100 && sNumber<1000) || (sNumber<=-100 && sNumber>-1000))
    {
        int result = Func(sNumber);
        Console.WriteLine ($"Вторая цифра числа: {result}");
    }
    else
    {
        Console.WriteLine ("Вы ввели не верное число, число должно быть трехзначным");
    }
}

int Func(int number)
{
    return Math.Abs((number/10)%10);
}

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void ThirdDigitOfTheNumber()
{
    Console.WriteLine ("Ввведите число:");
    int number = Math.Abs(int.Parse(Console.ReadLine()));
    Console.WriteLine ("Способы решения задачи: \n № 1 - поиск по строке, \n № 2 - поиск с помощью математической функции, \n № 3 - поиск с помощью цикла. \n Ввведите номер способа решения задачи:");
    int N = int.Parse(Console.ReadLine());

    switch(N)
    {
        case 1:
            StringSearch(number);
            break;

        case 2:
            SearchFunction(number);
            break;

        case 3:
            SearchWithALoop (number);
            break;

        default:
            Console.WriteLine ("Такого способа решения задачи нет");   ;
            break;
    }
}

//нахождение числа в строке
void StringSearch (int number)
{
    string numberS = Convert.ToString(number);

    if (numberS.Length>2)
    {
        string result = Convert.ToString(numberS[2]);
        Console.WriteLine ($"Третья цифра = {result}");
    }
    else
    {
        Console.WriteLine ("Tретьей цифры нет");
    }
}

//нахождение числа с помощью функции
void SearchFunction (int number)
{
    int k = (int)Math.Log10(number)-2;
    Console.WriteLine(k < 0 ? "Tретьей цифры нет" : $"Третья цифра = {SFunc(number, k)}");
}

int SFunc(int n, int k)
{
    return n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k);
}

//нахождение числа с помощью цикла
void SearchWithALoop (int number)
{
    if (number>=1000)
    {
        while (number>1000)
        {
            number = number/10;  
        }
    Console.WriteLine ($"Третья цифра = {number%10}");
    }
    else if (number>=100 && number<1000)
    {
        Console.WriteLine ($"Третья цифра = {number%10}");
    }
    else
    {
        Console.WriteLine ("Tретьей цифры нет");
    }
}

/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

void DayWeek ()
{
    Console.WriteLine ("Ввведите цифру, обозначающую день недели:");
    int dayNumber = int.Parse(Console.ReadLine());
    
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Это выходной день недели");
    }
    else if (dayNumber>=1 && dayNumber<=5)
    {
        Console.WriteLine("Это не выходной день недели");
    }
    else
    {
        Console.WriteLine("Это не день недели");
    }
}