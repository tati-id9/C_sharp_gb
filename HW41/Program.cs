/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел происходит через Enter, останавливается при введении слова "stop"

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Task41();

void Task41()
{
    System.Console.WriteLine("Введите числа: ");
    string arrS = String.Empty;

    //arrS +=WL();

    System.Console.WriteLine(arrS);
}

string WL()
{
    string s = Console.ReadLine();
    if (s == "stop")
    {
        return " ";
    }
    else
    {
        return WL();
    }
}

int ElementCount (string s) //подсчет элементов в массиве
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


int[] ArrayOfNumbers(string sNew, int count)// функция  создания и заполнения массива из строки
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

int РositiveNumbers (double[] arr) // подсчет чисел больше 0
{
    int count =0;
    for(int i = 0; i < arr.Length ; i++)
    {
        if(arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

//Task43();

void Task43()
{
    double[,] arrСoefficient = new double[2, 2];
    arrСoefficient = Сoefficient();

    System.Console.WriteLine($"Уравение прямой №1 у1 = ({arrСoefficient[0, 0]}) * х + ({arrСoefficient[0, 1]}) ");
    System.Console.WriteLine($"Уравение прямой №2 у2 = ({arrСoefficient[1, 0]}) * х + ({arrСoefficient[1, 1]}) ");
    GetIntersection(arrСoefficient);
}
double[,] Сoefficient() // заполнение коэффициентов уравнений в массив
{
    double[,] arr = new double[2, 2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициент k {i + 1}-го уравнения: ");
        arr[i, 0] = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Введите коэффициент b {i + 1}-го уравнения: ");
        arr[i, 1] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

double[] GetIntersectionPoint(double[,] arrCoeff)// вычисление координат точки пересечения
{
    double[] IntersectionPoint = new double[2];
    IntersectionPoint[0] = (arrCoeff[1, 1] - arrCoeff[0, 1]) / (arrCoeff[0, 0] - arrCoeff[1, 0]);
    IntersectionPoint[1] = IntersectionPoint[0] * arrCoeff[0, 0] + arrCoeff[0, 1];
    return IntersectionPoint;
}

void GetIntersection(double[,] arrCoeff)
{
    if (arrCoeff[0, 0] == arrCoeff[1, 0])
    {
        System.Console.WriteLine("Прямые не имеют точки пересечения");
    }
    else
    {
        double[] pointCoord = new double[2];
        pointCoord = GetIntersectionPoint(arrCoeff);
        System.Console.WriteLine($"Координаты точки пересечения равны ({pointCoord[0]}, {pointCoord[1]})");
    }
}