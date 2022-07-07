/* 2. Дана монотонная последовательность, 
в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... 
Дано число m. 
Выведите первые m членов этой последовательности.
m = 5 >> 1, 2, 2, 3, 3
*/

int m = 15;
Monotonic(m);

void Monotonic(int limit, int number = 0, int summ = 0)
{
    if (limit == 0) return;
    for (int i = 1; summ < limit; i++)
    {
        summ += i;
        number = i;
    }
    Monotonic(--limit);
    Console.Write(number + "\t");
}