// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// получение корректного числа
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            return result;
        }
        else
        {
            Console.WriteLine("Некорректно введено число!");
        }
    }
}

int number = GetNumber("Введите положительное число: ");
int index = 1;
while(index <= number)
{
    double temp = Math.Pow(index, 3);
    Console.Write(temp + " ");
    ++index;
}
