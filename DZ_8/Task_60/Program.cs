/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// Получение размеров трёхмерного массива
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

// Заполнение трёхмерного массива случайными числами
int[,,] InitArray(int rowsCount, int columnsCount, int levelsCount)
{
    int[,,] result = new int[rowsCount, columnsCount, levelsCount];
    Random random = new Random();
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < result.GetLength(0); ++i)
    {
        for (int j = 0; j < result.GetLength(1); ++j)
        {
            for (int k = 0; k < result.GetLength(2); ++k)
            {
                int tempNumber = random.Next(10, 100);
                while(dict.ContainsKey(tempNumber))
                {
                    tempNumber = random.Next(10, 100);
                }
                dict.Add(tempNumber, 1);
                result[i, j, k] = tempNumber;
            }
        }
    }
    return result;
}

// Вывод массива на консоль
void PrintArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); ++k)
    {
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");   
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int rowsCount = GetNumber("Введите первое измерение массива: ");
int columnsCount = GetNumber("Введите второе измерение массива: ");
int levelsCount = GetNumber("Введите третье измерение массива: ");
int[,,] threeDimensionalArray = InitArray(rowsCount, columnsCount, levelsCount);
Console.WriteLine("Вывод трёхмерного массива: ");
PrintArray(threeDimensionalArray);