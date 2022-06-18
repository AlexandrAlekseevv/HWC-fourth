/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
using System;
using static System.Console;
Clear();

Write("Введите число : ");int A = Convert.ToInt32(ReadLine());
Write($"В какую стемень возвести {A} : ");int B = Convert.ToInt32(ReadLine());

Write($"Ответ: {A}  в степени {B} равно -> ");WriteLine(degrNumber(B));

int degrNumber( int c)
{
    int degree = Convert.ToInt32(Math.Pow(A ,c));
    return degree;
}