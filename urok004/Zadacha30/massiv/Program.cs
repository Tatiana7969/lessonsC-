﻿// Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

 int[] array = new int[8];

 FillArr(array);
 PrintArr(array);

 void FillArr(int[] arr)
 {
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(2);
    }
 }

 void PrintArr(int[] arr)
 {
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
 }
