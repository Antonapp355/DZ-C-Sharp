// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая построчно выведет элементы и их индексы.

int n = 3; // Колличество строк.
int m = 3; // Колличество столбцов.
int k = 3; // третоье измерение.

int[,,] array1 = new int[n, m, k];
int[,,] array2 = new int[n, m, k];

AddArray1();
PrintArray1();
Console.WriteLine();
NumberIndex();

void AddArray1()
{
    Random rand = new Random();
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            for (int p=0;p<k;p++)
            {
                array1[i,j,p] = rand.Next(0, 10);
            }
        }
    }
}

void PrintArray1()
{
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            for (int p=0;p<k;p++)
            {
                Console.Write(array1[i,j,p] + "\t");
            }
        }
        Console.WriteLine();
    }   
}  

void NumberIndex()
{   
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            for (int p=0;p<k;p++)
            {
                Console.Write("Cтрока № " + i + "\t");
            }
        }
    }   Console.WriteLine();
}