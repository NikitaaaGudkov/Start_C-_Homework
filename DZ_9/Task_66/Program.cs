/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// Получение чисел M и N от пользователя
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

// Вывод суммы натуральных элементов в промежутке от M до N.
int SumElementsWithRecursion(int M, int N)
{
    if(M == N) return N;
    else return M + SumElementsWithRecursion(M + 1, N); 
}


int M = GetNumber("Введите положительное число M: ");
int N = GetNumber("Введите положительное число N: ");
if(M >= N)
{
    Console.WriteLine("Число M должно быть меньше числа N!");
}
else
{
    int result = SumElementsWithRecursion(M, N);
    Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {result}");
}

