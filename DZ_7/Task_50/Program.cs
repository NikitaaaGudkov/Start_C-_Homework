// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void PrintArray(int[,] matr)
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

// Поиск элемента по указанным координатам
int SearchElement(int[,] matr, int row, int col)
{
    // Считаем что пользователь начинает нумерацию строк и столбцов с единицы
    int result;
    row -= 1;
    col -= 1;
    // Проверяем корректность введёных координат. 
    // Если таких координат в данной матрице нет, то возвращается число, которое гарнтировано не будет являться элементом матрицы.
    if(row >= matr.GetLength(0) || col >= matr.GetLength(1))
    {
        result = int.MaxValue;
    }
    else
    {
        result = matr[row, col];
    }
    return result;
}

int rowCount = GetCount("Введите количество строк матрицы: ");
int columnCount = GetCount("Введите количество столбцов матрицы: ");
int[,] matrix = InitArray(rowCount, columnCount);
FillArray(matrix);
PrintArray(matrix);
int rowPosition = GetCount("Введите строку элемента: ");
int columnPosition = GetCount("Введите столбец элемента: ");
int element = SearchElement(matrix, rowPosition, columnPosition);
if(element == int.MaxValue)
{
    Console.WriteLine("Элемента на такой позиции в матрице нет!");
}
else
{
    Console.WriteLine($"На этой позиции находится элемент {element}");
}