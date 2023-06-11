// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// выводит количество цифр входящего числа
int CountDigit(int number)
{
    int result = 0;
    while(number != 0)
    {
        number = number / 10;
        ++result;
    }
    return result;
}

// выводит третью цифру входящего числа
int GetThirdDigit(int number)
{
    int count = CountDigit(number);
    if(count < 3)
    {
        return -1;
    }
    int[] array = new int[count];
    int index = array.Length - 1;
    while(index >= 0)
    {
        int tempDigit = number % 10;
        number = number / 10;
        array[index] = tempDigit;
        --index;
    }
    return array[2];
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = GetThirdDigit(number);
if(result == -1)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(result);
}
