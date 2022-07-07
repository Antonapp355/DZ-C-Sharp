// Задача 3: Четное ли число?

Console.WriteLine("Привет, как тебя зовут? :");
string name = Console.ReadLine();
Console.WriteLine("Привет, " + name + " !");
Console.WriteLine(name + ", давай узнаем четное ли число!");
Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1) Console.WriteLine("Число " + number + " является не четным.");
else Console.WriteLine("Число " + number + " является четным.");