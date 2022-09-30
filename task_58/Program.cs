// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
int[,] MatrixMult (int [,] Matrix1, int [,] Matrix2)
{
        int [,] mult = new int [Matrix1.GetLength(0), Matrix2.GetLength(1)];
        for(int i=0; i<Matrix1.GetLength(0); i++)
        {
            for (int j=0; j< Matrix2.GetLength(1); j++)
            {
                for (int k=0; k<Matrix2.GetLength(0);k++)
                {
                    mult [i,j] = mult[i,j]+ Matrix1[i,k]*Matrix2[k,j];
                }
            }
        }
return mult;
}

try{
Console.WriteLine ("Enter number of rows Matrix1 ");
int m1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter number of columns Matrix1 ");
int n1 = Convert.ToInt32 (Console.ReadLine ());
int [,] Matrix1 = FillArray (m1,n1);
Console.WriteLine("Matrix1:");
PrintArray (Matrix1);
Console.WriteLine ("Enter number of rows Matrix2 ");
int m2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter number of columns Matrix2 ");
int n2 = Convert.ToInt32 (Console.ReadLine ());
int [,] Matrix2 = FillArray (m2,n2);
Console.WriteLine("Matrix2:");
PrintArray (Matrix2);
Console.WriteLine("Your Matrix1 * Matrix2:");
int [,] Result = new int [Matrix1.GetLength(0), Matrix2.GetLength(1)];
Result = MatrixMult (Matrix1, Matrix2);
PrintArray (Result);
}
catch
{
    Console.WriteLine ("Матрицы нельзя перемножить");
}

