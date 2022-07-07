/* 3. Дано натуральное число n > 1. Вывести все простые множители данного числа.
10 >> 5, 2.
12 >> 2, 2, 3.
*/

int n = 38;
Multipliers(n);

void Multipliers(int currentNumber, int remains = 2)
{
    if (remains == n) return;
    if (currentNumber % remains == 0) 
    {
        Console.Write(remains + "\t");
    }
    remains++;
    Multipliers(currentNumber,remains);
    
    
}