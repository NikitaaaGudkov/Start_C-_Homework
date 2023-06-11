// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// получение корректного пятизначного числа
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result <= 99999)
        {
            return result;
        }
        else
        {
            Console.WriteLine("Некорректно введено число!");
        }
    }
}

// преобразование числа в массив цифр
int[] NumberToArray(int number)
{
    int[] result = new int[5];
    int index = result.Length - 1;
    while(index >= 0)
    {
        result[index] = number % 10;
        number = number / 10;
        --index;
    }
    return result;
}


int number = GetNumber("Введите пятизначное число: ");
int[] array = NumberToArray(number);
string result = "";
int index = 0;
while(index < array.Length / 2)
{
    if(array[index] != array[array.Length - 1 - index])
    {
        result = "нет";
        break;
    }
    ++index;
}
if(result == "")
{
    result = "да";
}
Console.WriteLine(result);
