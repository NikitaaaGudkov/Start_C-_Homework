// Задача 29: Напишите программу, которая задаёт массив из n элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Все n элементов должны получить за один Console.ReadLine();
// Подсказка: использовать потом метод string.Split();

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
            Console.WriteLine("Ввели не число или число <= 0!");
        }
    }
    return result;
}

int[] CreateArray(int count)
{
    int[] result = new int[count];
    return result;
}

int[] FillArray(int count, int[] numberArray)
{
    while(true)
    {
        Console.WriteLine($"Для массива размером {count} задайте числа, разделяя их пробелами: ");
        string[] result = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if(result.Length != count)
        {
            Console.WriteLine("Несовпадение размера массива с количеством введённых чисел!");
            continue;
        }
        int i = 0;
        for (; i < result.Length; ++i)
        {
            int tempDigit;
            if(int.TryParse(result[i], out tempDigit))
            {
                numberArray[i] = tempDigit;
            }
            else 
            {
                Console.WriteLine("Присутствуют символы отличные от цифр!");
                break;
            }
        }
        if(i != result.Length)
        {
            continue;
        }
        break;
    }
    return numberArray;
}

void PrintArray(int[] numberArray)
{
    Console.WriteLine("Вывод массива: ");
    Console.Write("[");
    for (int i = 0; i < numberArray.Length; i++)
    {
        if(i == numberArray.Length - 1)
        {
            Console.Write(numberArray[i]);
        }
        else
        {
            Console.Write(numberArray[i] + " ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int count = GetCount("Введите число элементов в массиве: ");
int[] elements = CreateArray(count);
elements = FillArray(count, elements);
PrintArray(elements);
