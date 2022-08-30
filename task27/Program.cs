//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int test (int x)
{
    int sum = 0;
    while (x>0)
    {
        int c = x%10;
        sum = sum+c;
        x=x/10;
    }
    return sum; 
}
int r = test(x);
Console.Write($"Сумма цифр числа {x} равна {r}");