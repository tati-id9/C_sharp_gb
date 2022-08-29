Console.Clear();
Console.WriteLine("Список задач: \n Задача № 19: Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.\n Задача № 21: Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.\n Задача № 23: которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите номер задачи, программу которой необходимо запустить: ");
int task = int.Parse(Console.ReadLine());

if (task == 19)
{
    SearchPalindrome();
}
else if (task == 21)
{
    SearchDistanc();
}
else if (task == 23)
{

}
else
{
    Console.WriteLine("Такой задачи нет");
}

/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void SearchPalindrome()
{
    Console.WriteLine("Ввведите число:");
    int N = int.Parse(Console.ReadLine());
    if (N >= 10000 && N < 100000)
    {
        Palindrome(N);
    }
    else
    {
        Console.WriteLine("Вы ввели не верное число, число должно быть пятизначным");
    }
}

void Palindrome(int number)
{
    if (((number / 10000) == (number % 10)) && ((number / 1000 % 10) == (number % 100 / 10)))
    {
        Console.WriteLine($"Число {number} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} - не является палиндромом");
    }
}

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

void SearchDistanc()
{
    double[,] arrPoint = new double[2, 3];
    arrPoint[0, 0] = Coordinate("x", "A");
    arrPoint[0, 1] = Coordinate("y", "A");
    arrPoint[0, 2] = Coordinate("z", "A");
    arrPoint[1, 0] = Coordinate("x", "B");
    arrPoint[1, 1] = Coordinate("y", "B");
    arrPoint[1, 2] = Coordinate("z", "B");

    Console.Write($"Расстояние между точками А({arrPoint[0, 0]},{arrPoint[0, 1]},{arrPoint[0, 2]}) ");
    Console.Write($"и B({arrPoint[1, 0]},{arrPoint[1, 1]},{arrPoint[1, 2]}) -> {Distance(arrPoint)}");
}

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return int.Parse(Console.ReadLine());
}

double Distance(double[,] array)
{
    double dist = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        dist = dist + Math.Pow((array[1, i] - array[0, i]), 2);
    }
    return Math.Round(Math.Sqrt(dist), 2);
}

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine ("Ввведите число:");
int N = int.Parse(Console.ReadLine());

double[] GetCube (int n)
{
    double[] arr = new double[n];

    for (int i=1; i<=n;i++)
    {
        arr [i-1]= Math.Pow(i,3);
    }
    return arr;
}

Console.Write("Таблица кубов -> ");
foreach (int num in GetCube (N))
{
    Console.Write($"{num} ");
}