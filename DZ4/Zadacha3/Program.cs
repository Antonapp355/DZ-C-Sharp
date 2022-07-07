// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
Console.WriteLine("Привет. Создадим массив из 8 рандомных чисел от -8 до 8 и отсортируем его по модулю.");
Console.Write("Нажми клавишу Enter.");
Console.ReadLine();
int[] myArray = new int [7];

GenArray(myArray);
SortArray(myArray);
PrintArray(myArray);

void GenArray(int[] myArray)
{
    Random rand = new Random();
    for (int i=0;i<myArray.Length;i++)
    {
        myArray[i] = rand.Next(-8, 8);
        Console.Write(myArray[i] + ", ");
    }Console.WriteLine();
}

void SortArray(int[] myArray)
{
    for (int i = 0 ; i < (myArray.Length - 1 ); i++)
    {
        int minIndex = 0;
        int temp = 0;
            
            minIndex = i;
            for (int j = i; j < myArray.Length; j++)
            {
                if (myArray[j] < myArray[minIndex]) minIndex = j;
            }
            if (minIndex != i)
            {
                temp = myArray[i];
                myArray[i] = myArray[minIndex];
                myArray[minIndex] = temp;
            }
    }
}

void PrintArray(int[] myArray)
{
    Console.WriteLine("Вывод: ");
    for (int i = 0 ; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ", ");
    }
    
}