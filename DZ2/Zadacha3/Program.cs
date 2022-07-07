// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Сегодня выходной? Введи цифру от 1 до 7");
int N = Convert.ToInt32(Console.ReadLine());
weekend(N);
		
void week(int current_number)
{
if (current_number == 1) Console.WriteLine("Понедельник. Урра, снова на работу!!!");
if (current_number == 2) Console.WriteLine("Вторник. Ну уже не понедельник)");
if (current_number == 3) Console.WriteLine("Среда. Середина недели, ни туда и ни сюда.");
if (current_number == 4) Console.WriteLine("Четверг. Почти пятница!!!))");
if (current_number == 5) Console.WriteLine("Пятница. Уррраа!!!!");
if ((current_number > 5) && (current_number < 8)) Console.WriteLine("Выходные.");
else Console.WriteLine("Введено не верное число!!!");
}


void weekend(int current_number1)
{
if ((current_number1 >=1) && (current_number1 <= 5)) Console.WriteLine("Будний день.");
if ((current_number1 > 5) && (current_number1 < 8)) Console.WriteLine("Выходной.");
else Console.WriteLine("Введено не верное число!!!");
}
