// TASK 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int secondnum(int num)
{
    int num2 = num /10 % 10;
    return num2;
}
Console.Write("vvedite trehznachnoe chislo: ");
int a = Convert.ToInt32(Console.ReadLine());
int newNum = secondnum(a);
Console.Write($"vtoraya cifra {a} eto {newNum}");
*/


// TASK 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int thirdnumber(int num)
{
    int num1;
    while(num > 1000)
    {
        num = num / 10;
    }
    
    if(num < 100)
    {
        num1 = -1;
    }
    else
    {
        num1 = num % 10;
    }
    return num1;
}

Console.Write("Vvedite chislo: ");
int a = Convert.ToInt32(Console.ReadLine());
int newNum = thirdnumber(a);
if(newNum != -1)
{
    Console.Write($"Tretya cifra chisla {a} eto {newNum}");
}
else
{
    Console.Write("net tretei cifri");
}
*/


// TASK 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool holiday(int day)
{
    if(day > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Vvedite nomer dnya nedeli: ");
int a = Convert.ToInt32(Console.ReadLine());
bool result = holiday(a);
Console.Write($"Is this day a holiday? - {result}");
*/