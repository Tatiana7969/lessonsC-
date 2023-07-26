// напишите программу, которая будет 
// 1. принимать на вход два числа 
// 2. и выводить, явлется ли первое число кратно второму.
// 3. Если первое число не кратно второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int resalt = Remains(num1, num2);

// int resalt = num1 % num2;

// if (resalt == 0)
// Console.WriteLine("кратно");
// else
// Console.WriteLine($"не кратно, остаток {resalt}");

if (resalt == 0)
Console.WriteLine("кратно"); 
else
Console.WriteLine($"не кратно, остаток {resalt}");

int Remains(int number1, int number2)
{
return number1 % number2;
}

