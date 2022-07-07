// Доп задача 3.

Console.WriteLine("Введите сумму вложения: ");
double bank = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите процент: ");
double percent = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите колличество месяцев: ");
double month = Convert.ToDouble(Console.ReadLine());
Percent1(bank,percent,month);

void Percent1(double bank,double percent, double month)
{
Console.WriteLine((((bank / 100) * percent) * month) + bank); // Любой свой процент.
}

/*
void Percent2(double bank, double month)
{
Console.WriteLine((bank *1,015) * month); // Процент 1,5.
}
*/