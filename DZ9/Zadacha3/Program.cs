/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(n,m) = 29
*/

int M = 3; 
int N = 2;

FunkAkkerman(M,N);

Console.Write(FunkAkkerman(M,N));

void FunkAkkerman(int M, int N)
{   
    if (M==0) Console.WriteLine(N+1);
    else if (N==0) FunkAkkerman(M-1, 1);
    else FunkAkkerman(M-1, FunkAkkerman(M, N-1));
}