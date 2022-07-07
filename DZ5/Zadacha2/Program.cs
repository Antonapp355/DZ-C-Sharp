// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Привет. Создаём массив из рандомных чисел.");
Console.WriteLine("Нажми клавишу Enter.");
Console.ReadLine();
int[] myArray = new int [9];

GenArray(myArray);
SummNechetNummArray(myArray);

void GenArray(int[] myArray)
{
    Random rand = new Random();
    for (int i=0;i<myArray.Length;i++)
    {
        myArray[i] = rand.Next(0, 10);
        Console.Write(myArray[i] + ", ");
    }Console.WriteLine();
}

void SummNechetNummArray(int[] myArray)
{
    int summ = 0;
    for (int i=1;i<myArray.Length;i=i+2)
    {
        summ=summ+myArray[i];
    }
    Console.WriteLine("Сумма чисел нечётных элементов равна " + summ );
}