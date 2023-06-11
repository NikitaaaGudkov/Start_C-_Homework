/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

// Поиск строки с наименьшей суммой элементов
int SerchRowWithMinSum(int[,] matrix)
{
    int temporaryMinSum = 0;
    for (int j = 0; j < matrix.GetLength(1); ++j)
    {
        temporaryMinSum += matrix[0, j]; 
    }
    int result = 0;
    
    for (int i = 1; i < matrix.GetLength(0); ++i)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            sum += matrix[i, j];
        }
        if(sum < temporaryMinSum)
        {
            temporaryMinSum = sum;
            result = i;
        }
    }
    return result;
}


int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matr = InitMatrix(rows, columns);
PrintMatrix(matr);
Console.WriteLine();
int minRow = SerchRowWithMinSum(matr);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow} строка");
