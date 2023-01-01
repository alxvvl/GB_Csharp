// TASK 1 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " "); 
    if(num > 1) 
    {
        ShowNums(num - 1);
    }
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

// TASK 2 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum(int num1, int num2)
{
    if(num1 > num2) return FindSum(num1 - 1, num2) + num1;
    if(num1 < num2) return FindSum(num1 + 1, num2) + num1;
    return num2; 
}

Console.Write("Input a M number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a N number: ");
int N = Convert.ToInt32(Console.ReadLine());
int res = FindSum(M,N);
Console.Write(res);
*/


// TASK 3 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AkkermanFunc(int m, int n)
	{
		if(m == 0)
		{
            return n + 1;
		}
        if(m > 0 && n == 0)
		{
			return AkkermanFunc(m - 1, 1);
		}
		return AkkermanFunc(m - 1, AkkermanFunc(m, n -1));
	}
Console.Write("input m number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input n number: ");
int n = Convert.ToInt32(Console.ReadLine());	
int res = AkkermanFunc(m,n);	
Console.WriteLine(res);
*/