// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Получение чисел
int[] GetNumbers(string message)
{
    int[] result;
    while(true)
    {
        string[] strArr;
        Console.WriteLine(message);
        string str = Console.ReadLine();
        if (!String.IsNullOrEmpty(str))
        {
            strArr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
        else
        {
            Console.WriteLine("Ничего не введено!");
            continue;
        }
        result = new int[strArr.Length];
        int i = 0;
        for (; i < result.Length; ++i)
        {
            int temp;
            if(int.TryParse(strArr[i], out temp))
            {
                result[i] = temp;
            }
            else
            {

                break;
            }
        }
        if(i == result.Length)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено некорректное число!");
        }
    }
    return result;
}

// Вывод массива на консоль
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; ++i)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

// Подсчёт положительных чисел
int CountPosNumbers(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; ++i)
    {
        if(numbers[i] > 0)
        {
            ++result;
        }
    }
    return result;
}

int[] arr = GetNumbers("Введите числа через пробел и нажмите клавишу Enter: ");
Console.WriteLine("Получившийся массив: ");
PrintArray(arr);
Console.WriteLine($"Количество положительных чисел: {CountPosNumbers(arr)}");