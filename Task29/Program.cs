/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]  */
using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(8,0,9999);


PrintMassiv(array);

void PrintMassiv(int[] massiv)
{
    /*for (int i=0;i<massiv.Length; i++ )
    {
        Write($"Введите {i} элемент массива: ");
        massiv[i] = Convert.ToInt32(ReadLine());

    } */
    WriteLine($"\n[{String.Join(",",massiv)}]\n");
}

int[] GetRandomArray(int size, int minvalue , int maxvalue)
{
    int[] result = new int[size];
    for(int i = 0; i<size;i++)
    {
        result[i] = new Random().Next(minvalue, maxvalue+1);
    }
    return result;
}