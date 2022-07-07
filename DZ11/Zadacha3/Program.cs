/* Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет, 
является ли он високосным или нет. Постарайтесь воспользоваться только сложением или вычитанием.
*/

Console.Write("Введите год: ");
int N = Convert.ToInt32(Console.ReadLine());
LeapYear();

void LeapYear(int summ = 0)
{
    summ += 4;
    if (summ == N) 
    { 
        Console.WriteLine("Год высокосный.");
        return;
    }
    else if (summ > N) // Проверяем кратность четырём (если сумма вышла за пределы введённого числа).
        {
            Console.WriteLine("Год не высокосный.");
            return;
        }
    LeapYear(summ);
}