// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Привет. Создаём массив из рандомных чисел.");
Console.WriteLine("Нажми клавишу Enter.");
Console.ReadLine();
int[] myArray = new int [20];

GenArray(myArray);
Counter(myArray);

void GenArray(int[] myArray)
{
    Random rand = new Random();
    for (int i=0;i<myArray.Length;i++)
    {
        myArray[i] = rand.Next(100, 999);
        Console.Write(myArray[i] + ", ");
    }Console.WriteLine();
}

void Counter(int[] myArray)
{
    int summ = 0;
    for (int i=0;i<myArray.Length;i++)
    {
        if (myArray[i]%2==0) summ++;
    }
    Console.WriteLine("В массиве " + summ + " чётных чисел.");
}