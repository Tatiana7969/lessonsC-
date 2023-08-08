﻿// 1. Задайте массив из 12 элентов, 
// 2. заполненный случайными
// числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов
// массива.
// в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// суммв положительных чисел равна 29,
// сумма отрицательных чисел равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); 
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
     Console.Write("]");
}

int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumNegative = 0;
    int sumPositive = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }

    return new int[]{sumNegative, sumPositive};
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine("");
int[] sumPositveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма отрицательных элементов = {sumPositveNegativeElem[0]}");
Console.WriteLine($"Сумма положительных элементов = {sumPositveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
