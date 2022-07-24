/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

Console.Clear();
int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationOfTwoMatrixs(int[,] matrix1, int[,] matrix2)
{

    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return resultMatrix;
}

int[,] arr = GetMatrix(4, 4, 0, 10);
Console.WriteLine();
PrintMatrix(arr);
Console.WriteLine();
Console.WriteLine("и");
Console.WriteLine();
int[,] arr2 = GetMatrix(4, 4, 0, 10);
PrintMatrix(arr2);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов будет равно следующему массиву: ");
Console.WriteLine();
int[,] arr3 = MultiplicationOfTwoMatrixs(arr, arr2);
PrintMatrix(arr3);