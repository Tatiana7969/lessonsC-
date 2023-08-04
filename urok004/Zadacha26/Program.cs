// Напишите программу, которая 
// 1. принимает на вход число
// 2. выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using System.Runtime.InteropServices;

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountNumberDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {result}");

int CountNumberDigit(int num)
{
    int countDigit = 0;
    while (num != 0)
    {
        countDigit++;
        num = num / 10;
    }
    return countDigit;
}
