// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// определяет, является ли день выходным
bool IsWeekend(int number)
{
    if(number == 6 || number == 7)
    {
        return true;
    }
    return false;
}

Console.Write("Введите цифру, обозначающую день недели: ");
int digitDay = int.Parse(Console.ReadLine());
if(digitDay < 1 || digitDay > 7)
{
    Console.WriteLine("Дня, соответствующего данной цифре не существует!");
}
else 
{
    if(IsWeekend(digitDay))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

