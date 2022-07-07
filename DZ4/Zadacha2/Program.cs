// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (number>0)
{
    summ = (number%10) + summ;
    number = number / 10;
}
Console.WriteLine(summ);