Console.Clear();
System.Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine("\nСписок задач: ");
System.Console.WriteLine("Задача 64: Вывести все натуральные числа в промежутке от M до N.");
System.Console.WriteLine("Задача 66: Найти сумму натуральных элементов в промежутке от M до N.");
System.Console.WriteLine("Задача 68: Вычеслить функцию Аккермана A(m,n). \n");

System.Console.Write("Введите номер задачи, которую необходимо решить: ");
int numberTask = int.Parse(Console.ReadLine());
System.Console.WriteLine();

if (m<0 || n<0) 
{
    System.Console.WriteLine("Вы ввели отрицательные числа");
}
else if (numberTask == 64)
{
    System.Console.WriteLine($"Ряд натуральных чисел: \"{OutputNaturalNumbers(m,n)}\" ");
}
else if (numberTask == 66) 
{
    System.Console.WriteLine($"Сумма натуральных элементов = {SumRes(m,n)}");
}
else if (numberTask == 68) 
{
    System.Console.WriteLine($"Функция Аккермана = {AckermannFunction(m,n)}");
}
else {System.Console.WriteLine("Такой задачи нет");}

/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 5, 6, 7, 8"" */

string OutputNaturalNumbers(int m, int n)
{
if (m == n) return Convert.ToString(n);
return m + ", " + OutputNaturalNumbers(m + 1, n);
}

/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumRes(int m, int n)
{
    if (m>n) return 0;
    else return m + SumRes(m+1, n);
}

/* Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

int AckermannFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermannFunction(m - 1, 1);
  else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}