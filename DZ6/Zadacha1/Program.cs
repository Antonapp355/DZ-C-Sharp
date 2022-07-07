/* Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите колличество чисел: ");

int count = Convert.ToInt32(Console.ReadLine());
int summ = 0;
Console.WriteLine();
Console.WriteLine("Введите " + count + " натуральных чисел через enter!");

for(int i=0;i<count;i++)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number>0) summ++;
}

Console.WriteLine("Вы ввели " + summ + " положительных чисел.");