// Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.
int n = 4; // Колличество строк.
int m = 5; // Колличество столбцов.

int[,] array = new int[n, m];


AddArray();
Console.WriteLine();

void AddArray()
{
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            if (array[i,j] < 4 ) array[i,j] += 1;
            else 
        }
    }
}
