/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12  */

using System;
using static System.Console;
Clear();
Write("введите число: ");

int number = Convert.ToInt32(ReadLine());

Write($"\nСумма цифр в числе {number} равна ");
WriteLine(SumNum(number));




int SumNum(int s)
{
    int result = 0;
    while(s>0)
    {
        int ost = s%10;
        result = result + ost;
        s=s/10;        
    }
    return result;
}