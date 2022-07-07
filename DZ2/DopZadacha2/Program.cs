// Доп задача 2.

Console.WriteLine("Введите день месяца в которое вы родились: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца в который вы родились: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год вашего рождения: ");
int year = Convert.ToInt32(Console.ReadLine());
Age(day,month,year);

void Age(int day, int month, int year)
{
    //Date 1.02.2022.
    int day1 = 1;
    int month1 = 2;
    int age1 = 2022;
    if (month <= month1) Console.WriteLine(2022-year);
    else Console.WriteLine((2022 - year) - 1);
}