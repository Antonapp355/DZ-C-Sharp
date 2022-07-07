// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки А по оси x: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси z: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси x: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси y: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси z: ");
int Bz = Convert.ToInt32(Console.ReadLine());
Coord(Ax,Bx,Ay,By,Az,Bz);

void Coord(double Ax,double Bx,double Ay,double By,double Az,double Bz)
{
double coord_AB = Math.Sqrt(((Ax - Bx) * (Ax - Bx)) + ((Ay - By) * (Ay - By)) + ((Az - Bz) * (Az - Bz)));

Console.WriteLine(coord_AB);
}