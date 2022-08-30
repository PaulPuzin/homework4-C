// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] x = new int [8];
Random r = new Random();
for (int i =0;i<x.Length;i++)
{
    x[i] = r.Next();
    Console.Write(x[i] + " ");
}