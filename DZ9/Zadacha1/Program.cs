/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9"
M = 13; N = 20. -> "15, 18"
*/

int M = 2; 
int N = 15;

NaturalNumbers(M,N);

void NaturalNumbers(int M, int N)
{    
    int temp = M%3;
    if (M <= N)
    {
        if (temp==0) {Console.Write(M + "; "); M++;}
        else M++;
        NaturalNumbers(M,N);
    }
}