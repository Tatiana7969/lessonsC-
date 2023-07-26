// Напишите программу, которая 
// 1. Принимает на вход число 
// 2. Проверяет, кратно ли оно 7 и 23 одновременно
// 14 -> нет 
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Miltiplicity(num);
Console.WriteLine(result? "ДА": "Нет");

bool Miltiplicity (int number)
{
    return number % 7 == 0 && number % 23 == 0;
}





