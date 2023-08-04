// Напишите программу, которая
// 1. принимает на вход число N 
// 2. выдает произведение чисел от 1 до N 
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());   

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i < num; i++)
    {
        checked
        {
         fact *= i; //fact = fact * i
        }
    }
    return fact;
}
