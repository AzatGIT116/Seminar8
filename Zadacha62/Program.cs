/* Задача 62. Заполните спирально массив 4 на 4. */

int size = 4;
int[,] matrix = GetMatrixSpirally(size);
PrintMatrix(matrix);

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write(mtrx[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixSpirally(int lenght)
{
    int[,] Arr = new int[lenght, lenght];
    int num = 1;
    for (int delta = 0; delta < lenght; delta++)
    {
        for (int i = 0 + delta; i < lenght - delta; i++)
        {
            Arr[0 + delta, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + delta; i <= lenght - 1 - delta; i++)
        {
            Arr[i, lenght - 1 - delta] = num;
            num++;
        }
        num--;
        for (int i = lenght - 1 - delta; i >= 0 + delta; i--)
        {
            Arr[lenght -1 - delta, i] = num;
            num++;
        }
        num--;
        for (int i = lenght - 1 - delta; i > 0 + delta; i--)
        {
            Arr[i, 0 + delta] = num;
            num++;
        }
    }
    return Arr;
}