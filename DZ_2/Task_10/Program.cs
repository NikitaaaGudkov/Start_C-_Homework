// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// выдаёт вторую цифру введённого трёхзначного числа
int GetSecondDigit(int number)
{
    int result = number / 10;
    result = result % 10;
    return result;
}

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(GetSecondDigit(number));
