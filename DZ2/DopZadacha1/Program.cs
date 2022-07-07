// Доп задача 1.

Console.WriteLine("Введи размер стороны A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи размер стороны B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи размер стороны C: ");
int C = Convert.ToInt32(Console.ReadLine());
RavnobedrenniTreugolnik(A,B,C);

void RavnobedrenniTreugolnik(int A, int B, int C)
{
if ((A == B) && (B == C) && (A == C)) Console.WriteLine("Треугольник равнобедренный.");
else Console.WriteLine("Треугольник не равнобедренный.");
}