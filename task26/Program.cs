﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArrayWithRandomNumber (int size)
 {
    int [] arr = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9,10); 
    }
return arr;
 }
 System.Console.WriteLine("Введите количество элементов массива");
 int len = Convert.ToInt32(Console.ReadLine());
 int[] array = FillArrayWithRandomNumber (len);
 System.Console.WriteLine(string.Join (", ", array));
 int newLen = array.Length /2  + array.Length % 2;
 int [] newarray = new int [newLen];
 for (int i = 0; i < array.Length/2; i++)
 {
    newarray[i] = array[i] * array[array.Length - 1 - i];
 }
 if (array.Length % 2 == 1) newarray[newLen - 1] = array[array.Length / 2];
 System.Console.WriteLine(string.Join (", ", newarray));