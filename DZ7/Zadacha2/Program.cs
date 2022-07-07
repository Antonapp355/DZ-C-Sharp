/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

Console.Write("Введите введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int n =5;
int m =5;

int[,] array = new int[n, m];
if((i>=n)&&(j>=m))Console.WriteLine("Такого элемента не существует.");
else
{
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

    Console.WriteLine(array[i-1,j-1]);
}