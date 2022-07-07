// Задача 4: 

Console.WriteLine("Привет, как тебя зовут? :");
string name = Console.ReadLine();
Console.WriteLine("Привет, " + name + " !");
Console.WriteLine("Давай узнаем, какие четные числа находятся перед твоим, введённым далее, числом!");
Console.WriteLine("Введи число N от 1 до 10: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = {1,2,3,4,5,6,7,8,9,10};

for (int i=1; i<N; i=i+2)
{
    if (Array[i] % 2 == 0)
    {
        Console.WriteLine(Array[i]);
    }
    else 
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine();