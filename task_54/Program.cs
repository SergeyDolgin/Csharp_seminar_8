// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] FillArray (int m, int n)
{
    int [,] arr = new int [m, n];
    for (int i=0; i < m; i++)
    {
        for (int j=0; j< n; j++) arr [i,j] = new Random ().Next (0, 100);
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

void SortOnRows(int [,] matr)
{
    for(int k = 0; k < matr.GetLength(1)*matr.GetLength(0); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < (matr.GetLength(1))-1; j++)
            {
                if (matr[i,j] < matr[i,j+1])
                {
                   (matr[i,j], matr[i,j+1]) = (matr[i,j+1], matr[i,j]);
                }
            }
        }
    }
}
try{
Console.WriteLine ("Enter number of rows");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter number of columns");
int n = Convert.ToInt32 (Console.ReadLine ());
int [,] res = FillArray (m,n);
Console.WriteLine ("Your matrix is:");
PrintArray (res);
Console.WriteLine ("Matrix after sorting will be ");
SortOnRows (res);
PrintArray (res);
}
catch
{
    Console.WriteLine ("Something wrong");
}