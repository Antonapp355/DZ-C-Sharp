// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int n = 3; // Колличество строк.
int m = 3; // Колличество столбцов.

int[,] array1 = new int[n, m];
int[,] array2 = new int[n, m];
int[,] array3 = new int[n, m];

AddArray1();
PrintArray1();
Console.WriteLine();
AddArray2();
PrintArray2();
Multiplication();
Console.WriteLine("Ответ: ");
PrintArray3();

void AddArray1()
{
    Random rand = new Random();
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            array1[i,j] = rand.Next(0, 10);
        }
    }
}

void AddArray2()
{
    Random rand = new Random();
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            array2[i,j] = rand.Next(0, 10);
        }
    }
}

void PrintArray1()
{
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            Console.Write(array1[i, j] + "\t");
        }
        Console.WriteLine();
    }   
}  

void PrintArray2()
{
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            Console.Write(array2[i, j] + "\t");
        }
        Console.WriteLine();
    }   
}  

void Multiplication()
{   
    for (int i = 0 ; i < n; i++)
    {   
        for (int j = 0; j < m; j++)
        {   
            int p = 0;
            for (int k = 0; k < m; k++)
            {
                p += (array1[i, k] * array2[k, j]);
                array3[i,j] = p;
            }
        }
    }
}

void PrintArray3()
{
    for (int j=0;j<n;j++)
    {
        for (int i=0;i<m;i++)
        {
            Console.Write(array3[i,j] + "\t");
        }
        Console.WriteLine();
    }   
}  
