// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Получаем количество строк и столбцов матрицы
int GetCount(string message)
{
    int result;
    while(true)
    {
        Console.Write(message);
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

// Создаём матрицу указанного размера
int[,] InitArray(int row, int col)
{
    return new int[row, col];
}

// Выводим матрицу на консоль
void PrintMatrix(int[,] matr)
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

// Заполняем матрицу псевдослучайными целыми числами
void FillArray(int[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); ++i)
    {
        for (int j = 0; j < matr.GetLength(1); ++j)
        {
            matr[i, j] = random.Next(-9, 10);
        }
    }
}

// Нахождение среднего арифметического элементов в каждом столбце матрицы
double[] ArithmeticMeanElements(int[,] matr)
{
    double[] result = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); ++j)
    {
        for (int i = 0; i < matr.GetLength(0); ++i)
        {
            result[j] += matr[i, j];  
        }
        result[j] = Math.Round(result[j] / matr.GetLength(0), 1, MidpointRounding.AwayFromZero);
    }
    return result;
}

// Вывод одномерного массива на консоль
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
}

int rowCount = GetCount("Введите количество строк матрицы: ");
int columnCount = GetCount("Введите количество столбцов матрицы: ");
int[,] matrix = InitArray(rowCount, columnCount);
FillArray(matrix);
PrintMatrix(matrix);
double[] arrayResult = ArithmeticMeanElements(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arrayResult);