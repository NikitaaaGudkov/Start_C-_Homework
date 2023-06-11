/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// Получение числа строк и столбцов матрицы
int GetNumber(string message)
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

// Создание матрицы, заполненной случайными числами
int[,] InitMatrix(int rowsCount, int columnsCount)
{
    int[,] result = new int[rowsCount, columnsCount];
    Random random = new Random();
    for (int i = 0; i < result.GetLength(0); ++i)
    {
        for (int j = 0; j < result.GetLength(1); ++j)
        {
            result[i, j] = random.Next(0, 10);
        }
    }
    return result;
}

// Вывод матрицы на консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Произведение двух матриц
int[,] MatrixProduct(int[,] leftMatrix, int[,] rightMatrix)
{
    int[,] result = new int[leftMatrix.GetLength(0), rightMatrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); ++i)
    {
        for (int j = 0; j < result.GetLength(1); ++j)
        {
            int tempSum = 0;
            for (int k = 0; k < leftMatrix.GetLength(1); ++k)
            {
                tempSum += leftMatrix[i, k] * rightMatrix[k, j];
            }
            result[i, j] = tempSum;
        }
    }
    return result;
}


int leftRows = GetNumber("Введите число строк левой матрицы: ");
int leftColumns = GetNumber("Введите число столбцов левой матрицы: ");
int[,] leftMatrix = InitMatrix(leftRows, leftColumns);

int rightRows = GetNumber("Введите число строк правой матрицы: ");
int rightColumns = GetNumber("Введите число столбцов правой матрицы: ");
int[,] rightMatrix = InitMatrix(rightRows, rightColumns);

Console.WriteLine("Левая матрица: ");
PrintMatrix(leftMatrix);
Console.WriteLine();
Console.WriteLine("Правая матрица: ");
PrintMatrix(rightMatrix);
Console.WriteLine();

if(leftColumns != rightRows)
{
    Console.WriteLine("Ошибка! Число столбцов левой матрицы должно равняться числу строк правой матрицы!");
}
else
{
    int[,] newMatrix = MatrixProduct(leftMatrix, rightMatrix);
    Console.WriteLine("Произведение двух матриц: ");
    PrintMatrix(newMatrix);
}