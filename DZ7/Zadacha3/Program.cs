// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int n =5;
int m =5;

int[,] array = new int[n, m];

AddArray();
PrintArray();
Console.WriteLine();
SummArray();


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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }   
}  

void SummArray()
{
    for (int i=0;i<m;i++)
    {
        for (int j=0;j<n;j++)
        {
            Console.WriteLine(array[i,j]+array[i,j]);
        }   
    }   
}