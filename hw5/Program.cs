// FOR TASK 1 & 2
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1); 
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
*/
// TASK 1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int Chetnost(int[] array)
{
    int qty = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            qty++; 
        }
    }
    return qty;
}

Console.Write("Inpit a qty of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);
int result = Chetnost(myArray);
Console.WriteLine("Kolvo chetnih " + result);
*/

//TASK 2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int summary(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.Write("Input a qty of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);

int result = summary(myArray);
Console.WriteLine($"Summa nechetnih elementov ravna: {result}");
*/

// TASK 3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {    
        array[i] = Math.Round((new Random().NextDouble() + Convert.ToDouble(new Random().Next(minValue, maxValue))),2); 
    }    
    return array;    
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); // Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

double difference(double[] array)
{
    int index_min = 0;
    int index_max = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > array[index_max])
        {
            index_max = i;
        }
        if(array[i] < array[index_min])
        {
            index_min = i;
        }      
    }        
    return array[index_max] - array[index_min];
}

Console.Write("Input a qty of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);

double result = difference(myArray);
Console.WriteLine($"Difference between max and min is {result}");
*/