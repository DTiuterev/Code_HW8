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
for (int a = 0; a < array56.GetLength(0); a++)
{
  int tempSumElements = SumElements(array56, a);
  
  if (sumElements > tempSumElements)
  {
    sumElements = tempSumElements;
    minSumRow = a;
  }
  Console.WriteLine($"Сумма элементов строки {a+1} = {tempSumElements}");
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

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine();
Console.WriteLine("Задача 60: Я сформирую трехмерный массив указанного Вами размера из неповторяющихся двузначных чисел. Затем построчно выведу элементы массива и их индексы.");
Console.WriteLine("Введите размер массива X x Y x Z:");
int x = InputNumbers60("Введите X: ");
int y = InputNumbers60("Введите Y: ");
int z = InputNumbers60("Введите Z: ");
Console.WriteLine();

int InputNumbers60(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

if (x*y*z < 90)
{
    Console.WriteLine($"Элементы Вашего трехмерного массива {x}x{y}x{z} (с индексами): ");
    Console.WriteLine();
    int[,,] array60 = new int[x, y, z];
    FillArray60(array60);
    PrintArray60(array60);
}
else 
{
    Console.WriteLine("Заданный Вами трехмерный массив невозможно заполнить неповторяющимися двузначными числами, в массиве больше 89 элементов.");
}

void FillArray60(int[,,] array60)
{
  int[] temp = new int[array60.GetLength(0) * array60.GetLength(1) * array60.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array60.GetLength(0); x++)
  {
    for (int y = 0; y < array60.GetLength(1); y++)
    {
      for (int z = 0; z < array60.GetLength(2); z++)
      {
        array60[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray60(int[,,] array60)
{
  for (int i = 0; i < array60.GetLength(0); i++)
  {
    for (int j = 0; j < array60.GetLength(1); j++)
    {
      for (int k = 0; k < array60.GetLength(2); k++)
      {
        Console.Write($"{array60[i,j,k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

// Задача 62: Заполните спирально массив 4 на 4.
Console.WriteLine();
Console.WriteLine("Задача 62: Заполните спирально заданный пользователем квадратный массив (количество строк равно количеству столбцов.)");
Console.WriteLine("Введите количество строк и столбцов квадратного массива: ");
int mn62 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваш массив {mn62} x {mn62}: ");
int[,] array62 = new int[mn62, mn62];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= array62.GetLength(0) * array62.GetLength(1))
{
  array62[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array62.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array62.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array62.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray62(array62);

void PrintArray62 (int[,] array62)
{
  for (int i = 0; i < array62.GetLength(0); i++)
  {
    for (int j = 0; j < array62.GetLength(1); j++)
    {
      if (array62[i,j] / 10 <= 0)
      Console.Write($" {array62[i,j]} ");

      else Console.Write($"{array62[i,j]} ");
    }
    Console.WriteLine();
  }
}