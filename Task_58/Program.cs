/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//пробую новую технику решения)

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число строк первой матрицы: ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число строк второй матрицы: ");
column = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int n, int m)
{
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

int[,] PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}


int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine();
        Console.WriteLine("Матрицы нельзя перемножить в таком порядке.");
        return matrix1;
    }

    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int[,] matrix1 = FillArray(rows, column);
int[,] matrix2 = FillArray(rows, column);
int[,] matrix3 = ProductMatrix(matrix1, matrix2);
Console.WriteLine();
Console.Write("Задана матрица:"); PrintArray(matrix1); Console.WriteLine();
Console.Write("Задана матрица:"); PrintArray(matrix2); Console.WriteLine(); 
Console.Write("Результат:"); PrintArray(matrix3); 

