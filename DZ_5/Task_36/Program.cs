// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Получение размера массива
int GetSizeArray(string message)
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
            Console.WriteLine("Ввели не число или неположительное число!");
        }
    }
    return result;
}

// Создание массива
int[] CreateArray(int size)
{
    int[] result = new int[size];
    return result;
}

// Заполнение массива
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return;
}

// Вывод массива на консоль
void PrintArray(int[] arr)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < arr.Length; ++i)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

// Сумма элементов, стоящих на нечётных позициях
int SumElemOddPos(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        result += arr[i];
    }
    return result;
}


int size = GetSizeArray("Введите размерность массива");
int[] elements = CreateArray(size);
FillArray(elements);
PrintArray(elements);
int count = SumElemOddPos(elements);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {count}");
