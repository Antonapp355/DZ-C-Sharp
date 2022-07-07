/* Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
*/

Console.WriteLine("Введите колличество точек: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите номер четверти: ");
double N = Convert.ToDouble(Console.ReadLine());

int i = 0;
int[] myArray = {};

Random X = new Random();
Random Y = new Random();

for (i=1;i<=n;i++);
{
    if (N == 1) myArray[i] = (X.Next(-20, 0) + Y.Next(0, 20));
    else if (N == 2) myArray[i] = (X.Next(0, 20) + Y.Next(0, 20));
    else if (N == 3) myArray[i] = (X.Next(-20, 0) + Y.Next(-20, 0));
    else if (N == 4) myArray[i] = (X.Next(0, 20) + Y.Next(-20, 0));
}

Console.WriteLine(myArray[2]);