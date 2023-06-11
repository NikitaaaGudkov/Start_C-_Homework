// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
double[] CreateArray(int size)
{
    double[] result = new double[size];
    return result;
}

// Заполнение массива
void FillArray(double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return;
}

// Вывод массива на консоль
void PrintArray(double[] arr)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < arr.Length; ++i)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

// Определение максимального и минимального элементов массива
(double, double) FindMaxMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; ++i)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
        else if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return (max, min);
}

// Определение разности между максимальным и минимальным элементами массива
double Diff(double max, double min)
{
    double result = max - min;
    return result;
}


int size = GetSizeArray("Введите размерность массива");
double[] elements = CreateArray(size);
FillArray(elements);
PrintArray(elements);
(double max, double min) = FindMaxMin(elements);
Console.WriteLine($"Максимальный элемент массива равен {max}, минимальный равен {min}");
double difference = Diff(max, min);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна: {difference}");