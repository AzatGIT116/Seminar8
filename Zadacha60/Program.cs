/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

Console.Clear();
int[,,] GetMatrix(int size1, int size2, int size3, int min = 10, int max = 99)
{
    int[,,] matrix = new int[size1, size2, size3];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintIndexMatrix(int[,,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                Console.Write($"{mtrx[i, j, k], 3}  ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] arr = GetMatrix(2, 2, 2);
PrintIndexMatrix(arr);
Console.WriteLine();