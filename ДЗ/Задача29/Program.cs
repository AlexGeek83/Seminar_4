﻿// Напишите программу, которая задает массив из некоторого элементов
// и выводит их на экран
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// объявляем массив
//int[] age;

// выделяем память для массива
//age = new int[5];

int [] age = {1, 2, 5, 7, 19};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}
PrintArray(age);




