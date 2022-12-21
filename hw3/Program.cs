// TASK 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool pal(int num)
{
    int num1 = 0;
    int num2 = num;
    while(num > 0)
    {
        num1 = num1 * 10 + num % 10;
        num = num / 10;
    }
    
    if(num2 == num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
bool result = pal(a);
Console.Write(result);
*/


// TASK 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double L(double xA, double yA, double xB, double yB, double zA, double zB)
{
    double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    return distance;
}
Console.Write("Input xA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double length = Math.Round(L(xA, yA, zA, xB, yB, zB),4);
Console.WriteLine($"Length = {length}");
*/

// TASK 3 Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

/*
void RowCube(int N)
{
    int result = 1;
    while(result <= N)
    {
        Console.Write(Math.Pow(result, 3) + " ");
        result++;
    }
}
Console.WriteLine($"Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
RowCube(N);
*/
