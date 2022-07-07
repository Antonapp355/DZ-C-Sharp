/* 1. Дано число n. Получите число, записанное в обратном порядке.
345 >> 543
81 >> 18
*/

int n = 123456236;

PerevorotNumber(n);

void PerevorotNumber(int n, int m = 0)
{
    if (n == 0)
    { 
        Console.Write(m);
        return;
    }
    m = m*10 + n%10;
    n/=10;
    PerevorotNumber(n,m);
}