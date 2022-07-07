/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int M = 2; 
int N = 6;
int summ = 0;

SummNaturalNumbers(M,N,summ);

void SummNaturalNumbers(int M, int N, int summ)
{    
    if (M<=N) 
    {
        summ = summ + M; M++;
        SummNaturalNumbers(M,N,summ);
    }

    else Console.Write(summ);
}