// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите колличество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[n, m];


AddArray();
PrintArray();
Console.WriteLine();
SortArray();
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

void SortArray()
{
    for (int i = 0 ; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {   
            for (int p = 0; p < m; p++)
            {
                if (array[i,p] < array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,p];
                    array[i,p] = temp;
                }
                
            }   
        }
    }
}