// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// получение координат каждой точки
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Некорректно введено число!");
        }
    }
}

int x1 = GetNumber("Введите координату x1: ");
int y1 = GetNumber("Введите координату y1: ");
int z1 = GetNumber("Введите координату z1: ");

int x2 = GetNumber("Введите координату x2: ");
int y2 = GetNumber("Введите координату y2: ");
int z2 = GetNumber("Введите координату z2: ");

double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine(result);