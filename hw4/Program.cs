// TASK 1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int degree(int x, int y)
{
    int num = x;
    if(y == 0)
    {
        num = 1;
    }
    for(int i = 1; i < y; i++)
    {
        num = num * x;
    }
    return num;
}
Console.Write("Input first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = degree(A,B);
Console.Write($"A v stepeni B eto {result}");
*/
// TASK 2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int sum(int num)
{
    int i = 0;
    int x;
    while(num > 0)
    {
        x = num % 10;
        i = i + x;
        num = num / 10;
    }
    return i;
}
Console.Write("Input a number: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = sum(A);
Console.Write($"Sum of dignits of {A} is {result}");
*/

// TASK 3 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); // Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}
Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);
*/