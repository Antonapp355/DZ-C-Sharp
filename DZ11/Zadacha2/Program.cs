// Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10. Найдите количество элементов, значение которых больше 5, и их сумму.

Console.Write("Введите колличество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Генерирую массив...");

int[,] array = new int[n, m];

AddArray();
PrintArray();
Summ();

void AddArray()
{
    Random rand = new Random();
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            array[i,j] = rand.Next(1, 10);
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


void Summ()
{
    int summ = 0;  //Сумма элементов.
    int summ1 = 0; //Колличество элементов больше 5.
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            if (array[i, j] > 5) 
            {
                summ1++;
                summ += array[i, j];
            }
        }
        Console.WriteLine();
    }   
    Console.WriteLine("Колличество элементов больше 5 равно " + summ1 + ", их сумма равна " + summ);
}  