// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите колличество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[n, m];

AddArray();
PrintArray();

void AddArray()
{
    Random rand = new Random();
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            array[i,j] = rand.Next(0, 1000);
        }
    }
}

void PrintArray()
{
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }   
}  