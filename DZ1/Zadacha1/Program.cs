// Задача 1: Какое из чисел больше?


Console.WriteLine("Привет, как тебя зовут? :");
string name = Console.ReadLine();
Console.WriteLine("Привет, " + name + " !");
Console.WriteLine(name + ", давай узнаем какое из чисел больше!");
Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Число " + number1 + " больше числа " + number2 + " .");
}
else Console.WriteLine("Число " + number2 + " больше числа " + number1 + " .");