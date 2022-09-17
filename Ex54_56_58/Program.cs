//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine();
Console.WriteLine("Задача 54: Задайте двумерный массив. Я упорядочу по убыванию элементы каждой строки массива.");
Console.WriteLine("Введите размер массива m x n, min и max элементы массива. Я заполню его случайными целыми числами.");
int m54 = InputNumbers54("Введите количество строк m: ");
int n54 = InputNumbers54("Введите количество столбцов n: ");
int min54 = InputNumbers54("Введите min элемент: ");
int max54 = InputNumbers54("Введите min элемент: ");

int InputNumbers54(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[,] array54 = new int[m54, n54];
FillArray54(array54);
Console.WriteLine();
Console.WriteLine("Ваш массив: ");
PrintArray54(array54);

void FillArray54(int[,] array54)
{
  for (int i = 0; i < array54.GetLength(0); i++)
  {
    for (int j = 0; j < array54.GetLength(1); j++)
    {
      array54[i, j] = new Random().Next(min54, max54 + 1);
    }
  }
}

void PrintArray54(int[,] array54)
{
  for (int i = 0; i < array54.GetLength(0); i++)
  {
    for (int j = 0; j < array54.GetLength(1); j++)
    {
      Console.Write(array54[i, j] + " ");
    }
    Console.WriteLine();
  }
}

NewArray54(array54);
Console.WriteLine();
Console.WriteLine("Массив с отсортированными строками: ");
PrintArray54(array54);

void NewArray54(int[,] array54)
{
  for (int i = 0; i < array54.GetLength(0); i++)
  {
    for (int j = 0; j < array54.GetLength(1); j++)
    {
      for (int k = 0; k < array54.GetLength(1) - 1; k++)
      {
        if (array54[i, k] < array54[i, k + 1])
        {
          int temp = array54[i, k + 1];
          array54[i, k + 1] = array54[i, k];
          array54[i, k] = temp;
        }
      }
    }
  }
}
Console.WriteLine();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine();
Console.WriteLine("Задача 56: Задайте двумерный массив. Я найду строку с наименьшей суммой элементов.");
Console.WriteLine("Введите размер массива m x n, min и max элементы массива. Я заполню его случайными целыми числами.");
int m56 = InputNumbers56("Введите количество строк m: ");
int n56 = InputNumbers56("Введите количество столбцов n: ");
int min56 = InputNumbers56("Введите min элемент: ");
int max56 = InputNumbers56("Введите max элемент: ");

int InputNumbers56(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[,] array56 = new int[m56, n56];
void FillArray(int[,] array56)
{
  for (int i = 0; i < array56.GetLength(0); i++)
  {
    for (int j = 0; j < array56.GetLength(1); j++)
    {
      array56[i, j] = new Random().Next(min56, max56 + 1);
    }
  }
}
FillArray(array56);

Console.WriteLine();
Console.WriteLine("Ваш массив: ");
void PrintArray(int[,] array56)
{
  for (int i = 0; i < array56.GetLength(0); i++)
  {
    for (int j = 0; j < array56.GetLength(1); j++)
    {
      Console.Write(array56[i,j] + " ");
    }
    Console.WriteLine();
  }
}
PrintArray(array56);

int SumElements(int[,] array56, int i)
{
  int sumElements = array56[i,0];
  for (int j = 1; j < array56.GetLength(1); j++)
  {
    sumElements += array56[i,j];
  }
  return sumElements;
}
Console.WriteLine();
int minSumRow = 0;
int sumElements = SumElements(array56, 0);
for (int i = 0; i < array56.GetLength(0); i++)
{
  int tempSumElements = SumElements(array56, i);
  
  if (sumElements > tempSumElements)
  {
    sumElements = tempSumElements;
    minSumRow = i;
  }
  Console.WriteLine($"Сумма элементов строки {i+1} = {tempSumElements}");
}
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow + 1}. Сумма элементов строки = {sumElements}.");
Console.WriteLine();

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine();
Console.WriteLine("Задача 58: Задайте две матрицы. Я найду произведение двух матриц.");
Console.WriteLine("Введите размеры матриц, min и max элементы матриц, я заполню их случайными целыми числами: ");
int m58 = InputNumbers58("Введите число строк первой матрицы: ");
int n58_m58_2 = InputNumbers58("Введите число столбцов первой матрицы: ");
Console.WriteLine($"По условию нахождения произведения двух матриц число строк второй матрицы: {n58_m58_2}");
int n58_2 = InputNumbers58("Введите число столбцов второй матрицы: ");
int min58 = InputNumbers58("Введите min элемент: ");
int max58 = InputNumbers58("Введите max элемент: ");

int InputNumbers58(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[,] array1 = new int[m58, n58_m58_2];
FillArray58(array1);
Console.WriteLine("Первая матрица:");
PrintArray58(array1);

int[,] array2 = new int[n58_m58_2, n58_2];
FillArray58(array2);
Console.WriteLine("Вторая матрица: ");
PrintArray58(array2);

void FillArray58(int[,] array58)
{
  for (int i = 0; i < array58.GetLength(0); i++)
  {
    for (int j = 0; j < array58.GetLength(1); j++)
    {
      array58[i, j] = new Random().Next(min58, max58 +1);
    }
  }
}

void PrintArray58(int[,] array58)
{
  for (int i = 0; i < array58.GetLength(0); i++)
  {
    for (int j = 0; j < array58.GetLength(1); j++)
    {
      Console.Write(array58[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] arrayResult = new int[m58,n58_2];

MultiplyArray(array1, array2, arrayResult);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintArray58(arrayResult);

void MultiplyArray(int[,] array1, int[,] array2, int[,] arrayResult)
{
  for (int i = 0; i < arrayResult.GetLength(0); i++)
  {
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      arrayResult[i,j] = sum;
    }
  }
}
Console.WriteLine();

