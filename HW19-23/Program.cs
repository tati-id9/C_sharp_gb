﻿Console.Clear();
Console.WriteLine ("Список задач: \n Задача № 19: Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.\n Задача № 21: Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.\n Задача № 23: которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine ("Введите номер задачи, программу которой необходимо запустить: ");
int task = int.Parse(Console.ReadLine());

if (task == 19)
{

}
else if (task == 21)
{

}
else if (task == 23)
{

}
else
{
    Console.WriteLine ("Такой задачи нет");
}  

/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */