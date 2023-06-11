/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

// Получение чисел m и n от пользователя
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else
        {
            System.Console.WriteLine("Ввели не число или число отрицательное!");
        }
    }
    return result;
}

// Вычисление функции Аккермана с помощью рекурсии.
int CalculatingAckermanFunctionUsingRecursion(int m, int n)
{
    if(m == 0) return n + 1;
    else if(n == 0) return CalculatingAckermanFunctionUsingRecursion(m - 1, 1);
    else return CalculatingAckermanFunctionUsingRecursion(m - 1, CalculatingAckermanFunctionUsingRecursion(m, n - 1));
}


int m = GetNumber("Введите неотрицательное число m: ");
int n = GetNumber("Введите неотрицательное число n: ");
int result = CalculatingAckermanFunctionUsingRecursion(m, n);
Console.WriteLine(result);
