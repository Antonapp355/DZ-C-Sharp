// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Напиши 5 значное число: ");
string N = Convert.ToString(Console.ReadLine());
Palindrom(N);

void Palindrom(string N)
{
if ((N[0] != N[4]) | (N[1] != N[3])) Console.WriteLine("Число не палинлром.");
else 
Console.WriteLine("Число палиндром.");
}