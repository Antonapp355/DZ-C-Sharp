// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Создаём массив из рандомных чисел и находим разницу между ними.");
Console.WriteLine("Нажми клавишу Enter.");
Console.ReadLine();
double[] myArray = new double [20];

GenArray(myArray);
Sravnenie(myArray);

void GenArray(double[] myArray)
{
    Random rand = new Random();
    for (int i=0;i<myArray.Length;i++)
    {
        myArray[i] = rand.Next(100, 999);
        Console.Write(myArray[i] + "; ");
    }Console.WriteLine();
}
void Sravnenie(double[] myArray)
{
    double min = myArray[0];
    double max = myArray[0];
    for (int i=0;i<myArray.Length;i++)
    {
        if (myArray[i] > max) max = myArray[i];
        else if (myArray[i] < min) min = myArray[i];
    }
    Console.WriteLine("Минимальное число: " + min);
    Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("Вывод разницы между максимальным и минимальным числом: " + (max-min));
}