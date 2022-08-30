// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int mult =1;
int c = 1;
while (c<=b)
{
    mult = mult*a;
    c=c+1;
}
Console.Write($"Число {a} в степени {b} равно {mult}");