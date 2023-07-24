// Напишите программу, 
// 1. которая на вход принимает два числа
// 2. и проверяет, является ли первое число квадратом второго

// Например:
// a = 25, b = 5 -> да
// а = 2, b = 10 -> нет 
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine()); // 25
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine()); // 5

if (number1 == number2 * number2)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}








