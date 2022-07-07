// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int n = 4; // Колличество строк.
int m = 5; // Колличество столбцов.

int[,] array = new int[n, m];


AddArray();
PrintArray();
Console.WriteLine();
MinSummArray();

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

void MinSummArray()
{   
    int min_summ = 5000;  
    int p = 0;            // Индекс строки.

    for (int i = 0 ; i < n; i++)
    {   
        int summ = 0;
        for (int j = 0; j < m; j++)
        {
            summ += array[i,j];
        }

        if (summ < min_summ) 
        {
            min_summ = summ;
            p = i;
        }

    }

    Console.WriteLine("Номер строки с наименьшей суммой: " + p);
}