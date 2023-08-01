// Напишите программу, которая 
// 1. принимает на вход число (N)
// 2. и выдает таблицу квадратов чисел от 1 до N 
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1,4

using System.Data;

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
SquareTable (number);

void SquareTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int square = i * i;
        Console.WriteLine($"{i}  {square}");
    }
}






