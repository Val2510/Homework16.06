/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да 

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите пятизначное число: ");

void Palindrome (int number)
{
    int center = number / 10000;
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;

    
    if(num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine("Да, это палиндром");
    }
    else
    {
        Console.WriteLine("Нет, это не палиндром");
    }
   
}

Palindrome (num);
*/

/*Задача 21
Напишите программу, 
которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 

double InputNum (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double Distance (double a1, double a2, double a3, double b1, double b2, double b3)
{
double sum = Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2) + Math.Pow((a3 - b3), 2);
double res = Math.Sqrt(sum);
return res;
}

double num1 = InputNum("Введите координату X точки 1: ");
double num2 = InputNum("Введите координату Y точки 1: ");
double num3 = InputNum("Введите координату Z точки 1: ");
double num4 = InputNum("Введите координату Y точки 2: ");
double num5 = InputNum("Введите координату Y точки 2: ");
double num6 = InputNum("Введите координату Z точки 2: ");

double result = Math.Round((Distance(num1, num2, num3, num4, num5, num6)), 2);
Console.WriteLine($"Расстояние между точками 1 и 2 в 3D = {result}"); */

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int InputNum(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}
int num = InputNum("enter number N: ");
for(int i = 1; i <= num; i++)
{
	Console.Write($"{Math.Pow(i, 3)}");
	if(i < num)
	{
		Console.Write(", ");
	}
	else
	{
		Console.Write(".");
	}
}