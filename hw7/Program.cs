// TASK 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
	Console.Write("Input number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a min possible value: ");
	int minValue = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a max possible value: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());
	
	double[,] array = new double[rows, columns]; 
	
	for(int i = 0; i < rows; i++)
	{
		for(int j = 0; j < columns; j++)
		{
			array[i,j] = Math.Round((new Random().NextDouble() + Convert.ToDouble(new Random().Next(minValue, maxValue +1))),2);
		}
	}
	return array;
}	

void Show2dArray(double[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i,j] + "\t"); 
		}
		Console.WriteLine();
	}		
	Console.WriteLine();			
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// TASK 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
	Console.Write("Input number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a min possible value: ");
	int minValue = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a max possible value: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());
	
	int[,] array = new int[rows, columns]; 
	
	for(int i = 0; i < rows; i++)
	{
		for(int j = 0; j < columns; j++)
		{
			array[i,j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return array;
}	

void Show2dArray(int[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i,j] + "\t"); 
		}
		Console.WriteLine();
	}		
	Console.WriteLine();			
}

void Element(int[,] array)
{
	Console.Write("Input number of row: ");
	int row = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input number of column: ");
	int column = Convert.ToInt32(Console.ReadLine());
	if(row > array.GetLength(0) || column > array.GetLength(1))
	{
        Console.WriteLine("Element didnt find");
	}
	else
	{
		Console.WriteLine(array[row - 1, column - 1]);
	}
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Element(myArray);
*/

// TASK 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
double[,] CreateRandom2dArray()
{
	Console.Write("Input number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input number of colums: ");
	int colums = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a min possible value: ");
	int minValue = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a max possible value: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());
	
	double[,] array = new double[rows, colums]; 
	
	for(int i = 0; i < rows; i++)
	{
		for(int j = 0; j < colums; j++)
		{
			array[i,j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return array;
}	

void Show2dArray(double[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i,j] + "\t"); 
		}
		Console.WriteLine();
	}		
	Console.WriteLine();			
}

double[] avg(double[,] array)
{
    double sum = 0;
	double[] result = new double[array.GetLength(1)];
	for(int j = 0; j < array.GetLength(1); j++)
	{
        
		for(int i = 0; i < array.GetLength(0); i++)
		{
			sum+=array[i,j];
		}
		sum/=array.GetLength(1);
        Console.WriteLine(sum + ",");
	}
	return sum;			
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] result = avg(myArray);
*/
