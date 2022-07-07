// Задача 2: Какое из трёх чисел больше?


Console.WriteLine("Привет, как тебя зовут? :");
string name = Console.ReadLine();
Console.WriteLine("Привет, " + name + " !");
Console.WriteLine(name + ", давай узнаем какое из чисел больше!");
Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if((number1 > number2) && (number1 > number3)) Console.WriteLine("Число " + number1 + " самое большое.");
if((number2 > number3) && (number2 > number1)) Console.WriteLine("Число " + number2 + " самое большое.");
if((number3 > number1) && (number3 > number2)) Console.WriteLine("Число " + number3 + " самое большое.");