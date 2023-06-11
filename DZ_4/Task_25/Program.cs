// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            if(message == "Введите натуральный показатель степени: " && result < 0)
            {
                Console.WriteLine("Показатель степени должен быть натуральным!");
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("Ввели не число!");
        }
    }
    return result;
}

double Exponentiation(int basis, int degree)
{
    return Math.Pow(basis, degree);
}

int basis = GetNumber("Введите основание степени: ");
int degree = GetNumber("Введите натуральный показатель степени: ");

double result = Exponentiation(basis, degree);
Console.WriteLine($"{basis} в степени {degree} = {result}");
