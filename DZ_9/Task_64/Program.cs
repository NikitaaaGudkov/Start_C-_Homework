/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// Получение числа от пользователя
int GetNumber(string message)
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
            System.Console.WriteLine("Ввели не число или число неположительное!");
        }
    }
    return result;
}

// Вывод натуральных чисел в порядке убывания через рекурсию
string NumbersInDescendingOrderRecursion(int number)
{
    if(number == 1) return "1";
    else return $"{number} {NumbersInDescendingOrderRecursion(number - 1)}";
}


int number = GetNumber("Введите положительное число: ");
Console.WriteLine(NumbersInDescendingOrderRecursion(number));
