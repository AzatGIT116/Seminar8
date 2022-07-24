/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

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
            if (j == 0) Console.Write(" | ");
            Console.Write($"{matrix[i, j],2} | ");
        }
        Console.WriteLine();
    }
}

int MinLineRow(int[,] matrix)
{
    int line = 0;
    int sum1 = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum2 = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum2 += matrix[i, j];
        }
        if (sum2 < sum1)
        {
            sum1 = sum2;
            line = i;
        }
    }
    Console.WriteLine($"Номер строки с наимейшей суммой элементов: {line + 1} строка");
    return sum1;
}

int[,] arr = GetMatrix(4, 4, 0, 10);
Console.WriteLine();
PrintMatrix(arr);
Console.WriteLine();
MinLineRow(arr);

