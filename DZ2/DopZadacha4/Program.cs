// Доп задача 4.

int[] N = {1,2,3,4,5,6};
int max = 1;
int i = 0;
FirstNumberMax(N,max,i);

void FirstNumberMax(int[] N, int max, int i)
{
for (i=0;i>5;i++)
{
    if (N[i] > max) max = N[i];
}
if (N[0] > max) Console.WriteLine("Первая цифра числа самая большая.");
else Console.WriteLine("Первая цифра числа не самая большая.");
}