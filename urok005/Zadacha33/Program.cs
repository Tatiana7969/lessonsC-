﻿// Задайте массив, напишите программу, которая
// определяет, присутсвует ли заданное число в массиве
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size] ;
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

 void PrintArray(int[]arr)
 {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}");   
    }
    Console.Write("]");
 }

bool SearchNumberArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] == num) 
       {
        return true;
       } 
    }
    return false;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(12, -9, 9);

Console.Write($"{number}; массив" );
PrintArray(array); 

bool result = SearchNumberArray(array, number);
Console.WriteLine(result ? "-> да": "-> нет");
// Console.WriteLine(SearchNumberArray(array, number)? "-> да": "-> нет");

