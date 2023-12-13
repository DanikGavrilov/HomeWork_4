// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int m = 1;
int n = 10;

static string GetNumbers(int m, int n)
{
    if(m == n)
        return "";
    
    return $"{m} " + GetNumbers(m + 1, n);
}
System.Console.WriteLine(GetNumbers(m, n));
