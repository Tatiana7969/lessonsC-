﻿// Напишите программу, которая
// 1. Выводит случайное трехзначное число
// 2. Удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999: {number}");

int result = DeleteSecondDigit(number);
Console.WriteLine($"Результат удаления второй цифры: {result}");

int DeleteSecondDigit(int num)
{
    int firstDigit = num /100;
    int thirdDigit = num % 10;

    return firstDigit * 10 + thirdDigit;
}




