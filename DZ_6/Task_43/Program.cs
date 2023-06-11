// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Ввод коэффициентов пользователем
double GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число!");
        }
    }
    return result;
}

// Нахождение точки пересечения
(double, double) IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

double k1 = GetNumber("Введите коэффициент k1: ");
double b1 = GetNumber("Введите коэффициент b1: ");
double k2 = GetNumber("Введите коэффициент k2: ");
double b2 = GetNumber("Введите коэффициент b2: ");
if(k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают!");
}
else if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    (double x, double y) = IntersectionPoint(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({x};{y})");
}