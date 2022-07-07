// Задача 1. На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].

Console.Write("Введите меньшее число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите большее число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество чисел (до 1000): ");
int k = Convert.ToInt32(Console.ReadLine());

int[] Array = new int [1000];

GenArray(Array);

void GenArray(int[] Array)
{
    Random rand = new Random();
    for (int i=0;i<k;i++)
    {
        Array[i] = rand.Next(n, m);
        Console.Write(Array[i] + "\t");
    }Console.WriteLine();
}