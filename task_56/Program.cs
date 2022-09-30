// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] FillArray (int m, int n)
{
    int [,] arr = new int [m, n];
    for (int i=0; i < m; i++)
    {
        for (int j=0; j< n; j++) arr [i,j] = new Random ().Next (0, 10);
    }
    return arr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindSumOfRow(int[,] matr)
{
    int sum = 0;
    int min = 0;
    int minIndex = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        min = sum;
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr [i,j];
        }
        if (min < sum) minIndex = i;
    }
    Console.WriteLine($"The row with minimum sum of elements has index {minIndex}");
}
try{
Console.WriteLine ("Enter number of rows");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter number of columns");
int n = Convert.ToInt32 (Console.ReadLine ());
int [,] res = FillArray (m,n);
Console.WriteLine("Your array:");
PrintArray (res);
FindSumOfRow (res);
}
catch
{
    Console.WriteLine ("Something wrong");
}