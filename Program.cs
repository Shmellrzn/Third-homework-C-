/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/



//Console.WriteLine("Введите число, что бы узнать, является ли оно палиндромом: ");
//int num = Convert.ToInt32(Console.ReadLine());




/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


/*double dim (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double A = Math.Pow(xB - xA, 2);
    double B = Math.Pow(yB - yA, 2);
    double C = Math.Pow(zB - zA, 2);
    double res = A + B + C;
    double toret = Math.Sqrt(res);
    return Math.Round(toret,3);
}

Console.WriteLine("Введите координату Х первого числа: ");
Double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y  первого числа: ");
Double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z  первого числа: ");
Double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Х  второго числа: ");
Double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второго числа: ");
Double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z  второго числа: ");
Double zB = Convert.ToDouble(Console.ReadLine());

double fineres=dim(xA, xB, yA, yB, zA, zB);
Console.WriteLine($"Расстояние равно {fineres}");*/





/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void cube (int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        if (count != num) Console.Write(";"); 
        count++;
    }
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Куб чисел от 1 до {N} равен ");
cube(N);


