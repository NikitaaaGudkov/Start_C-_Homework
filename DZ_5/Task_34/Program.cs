// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        arr[i] = rnd.Next(100, 1000);
    }
    return;
}

// Определяет количество чётных чисел
int CountEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; ++i)
    {
        if(arr[i] % 2 == 0)
        {
            ++count;
        }
    }
    return count;
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


int size = GetSizeArray("Введите размерность массива");
int[] elements = CreateArray(size);
FillArray(elements);
PrintArray(elements);
int count = CountEvenNumber(elements);
Console.WriteLine($"Число чётных элементов равно: {count}");