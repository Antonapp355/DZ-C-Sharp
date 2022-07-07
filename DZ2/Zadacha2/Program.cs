// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string N = Convert.ToString(Console.ReadLine());
ThirdNumber(N);
          
void ThirdNumber(string current_number)
{
if (current_number.Length < 3) Console.WriteLine("Число не трёхзначное.");
else Console.WriteLine(current_number[2]);
}