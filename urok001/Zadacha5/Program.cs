// Напишите программу, которая 
// 1. на вход принимает одно число (N)
// 2. а на выходе показываает вск целые числа
//    в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1 0, 1, 2, 3, 4"   
// 2 -> "-2, -1, 0, 1, 2 "

Console.WriteLine("Введите натуральноу число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.Write("Неверное число");
}
else 
{
// for (int i = -number; i <= number; i++)
// {
//     Console.Write ($"{i}");
// }


int count = - number;
while(count <= number)
{
  Console.Write($"{count}");
  count++; 
}
}





