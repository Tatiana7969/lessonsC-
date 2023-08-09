// Задайте одномерный массив из 123 случайных чисел
// Найдите количество элементов массива, значения
// которых лежат в отрезке [10, 99]
// [5,18,123,6,2...] -> 1
// [1,2,3,6,2...] -> 0

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

 int CountTwoDigitNumbers(int[] arr, int start, int end)
 {
    int count = 0;
     for (int i = 0; i < arr.Length; i++)
     {
        if (arr[i] >= start && arr[i] <= end) count++;
     }
     return count;
 }
 Console.WriteLine("Введите начало диапазона");
 int startNumber = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите конец диапазона");
 int endNumber = Convert.ToInt32(Console.ReadLine());

 
 int[] array = CreateArrayRndInt(10, -1000, 1000);
 PrintArray(array); 

 int result = CountTwoDigitNumbers(array, startNumber, endNumber);
 Console.WriteLine($" -> {result}");

 