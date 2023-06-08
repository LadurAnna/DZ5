// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// ___Задача 34:_____
//  Задайте массив заполненный 
// случайными положительными трёхзначными 
// числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] arr=new int[4]{345, 897, 568, 234};
// int k = 0;
// for (int i = 0; i<4; ++i)
// {
//     if (arr[i]%2 == 0)
//     {
//         k++;
//     } 
// }
// Console.WriteLine(k);
  

// ________Задача 36:_______ 
// Задайте одномерный массив,
//  заполненный случайными числами. 
//  Найдите сумму элементов, стоящих 
//  на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] arr=new int[4];
// Random rand = new Random();
// for (int i = 0; i<4; ++i)
// {
//     arr[i]=rand.Next(0,101);
//     Console.WriteLine(arr[i]);
// }
// int result = 0;
// for (int i = 0; i<4; ++i)
// {
//     if (i % 2==1)
//     {
//         result = result + arr[i];
//     }
// }
// Console.WriteLine(result);
  

// ________Задача 38:_______
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] arr=new double[5];
// Random rand = new Random();
// for (int i = 0; i<5; ++i)
// {
//     arr[i]=rand.NextDouble()*100;
//     Console.WriteLine(arr[i]);
// }
// double minElem = arr[0];
// double maxElem = arr[0];
// for (int i = 0; i<5; ++i)
// {
//     if (arr[i]<minElem)
//     {
//         minElem=arr[i];
//     }
//     if (arr[i]>maxElem)
//     {
//         maxElem=arr[i];
//     }
// }
// Console.WriteLine(maxElem-minElem);