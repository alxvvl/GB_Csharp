// TASK 1 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void low(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
low(myArray);
Show2dArray(myArray);
*/

// TASK 3 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*

Console.Write("Input number of rows of first matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns of first matrix(rows of second): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns of second matrix: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
}

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nFirst Matrix:");
ShowArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nSecond Matrix:");
ShowArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nMultiply:");
ShowArray(resultMatrix);
*/


// TASK 4 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom2dArray()
{
	Console.Write("Input number of x: ");
	int x = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input number of y: ");
	int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of z: ");
	int z = Convert.ToInt32(Console.ReadLine());
	
	int[,,] array = new int[x, y, z]; 
	
	for(int i = 0; i < x; i++)
		for(int j = 0; j < y; j++)
            for(int k = 0; k < z; k++)
                array[i,j,k] = new Random().Next(10, 100);
	return array;
}	

void Show2dArray(int[,,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2);k++)                
                {
                    Console.Write(array[i,j,k] + "\t"); 
                }
                Console.WriteLine();
            }
		Console.WriteLine();
	}		
	Console.WriteLine();			
}

int[,,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// TASK 5 Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

ShowArray(sqareMatrix);

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/


