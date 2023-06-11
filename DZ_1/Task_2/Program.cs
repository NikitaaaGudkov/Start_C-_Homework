// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine());

if(first_number > second_number)
{
    Console.WriteLine($"max = {first_number}");
}
else if(first_number < second_number)
{
    Console.WriteLine($"max = {second_number}");
}
else
{
    Console.WriteLine("Два введённых числа равны");
}
