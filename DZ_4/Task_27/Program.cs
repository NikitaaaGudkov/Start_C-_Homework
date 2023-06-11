// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число!");
        }
    }
    return result;
}

int GetSumDigit(int number)
{
    if(number < 0)
    {
        number *= -1;
    }
    int result = 0;
    while(number != 0)
    {
        int digit = number % 10;
        result += digit;
        number /= 10;
    }
    return result;
}

int number = GetNumber("Введите число: ");
int sum = GetSumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
