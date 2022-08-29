/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double [,] arrPoint =new double [2,3];
arrPoint [0,0] = Coordinate("x", "A");
arrPoint [0,1] = Coordinate("y", "A");
arrPoint [0,2] = Coordinate("z", "A");
arrPoint [1,0] = Coordinate("x", "B");
arrPoint [1,1] = Coordinate("y", "B");
arrPoint [1,2] = Coordinate("z", "B");

Console.Write ($"Расстояние между точками А({arrPoint [0,0]},{arrPoint [0,1]},{arrPoint [0,2]}) ");
Console.Write ($"и B({arrPoint [1,0]},{arrPoint [1,1]},{arrPoint [1,2]}) -> {Distance(arrPoint)}");
 
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return int.Parse(Console.ReadLine());
}

double Distance (double [,] array)
{
    double dist=0;
    for(int i=0; i<array.GetLength(1); i++)
    {
         dist = dist + Math.Pow((array[1,i]-array[0,i]), 2);
    }
    return Math.Round (Math.Sqrt(dist), 2);
}

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */