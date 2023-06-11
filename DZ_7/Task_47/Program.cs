// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetCount(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число не положительное!");
        }
    }
    return result;
}

double[,] InitArray(int row, int col)
{
    return new double[row, col];
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); ++i)
    {
        for (int j = 0; j < matr.GetLength(1); ++j)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); ++i)
    {
        for (int j = 0; j < matr.GetLength(1); ++j)
        {
            matr[i, j] = Math.Round(random.Next(-9, 10) + random.NextDouble(), 1, MidpointRounding.AwayFromZero);
        }
    }
}

int rowCount = GetCount("Введите количество строк матрицы: ");
int columnCount = GetCount("Введите количество столбцов матрицы: ");
double[,] matrix = InitArray(rowCount, columnCount);
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);