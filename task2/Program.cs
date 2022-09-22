// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
     if (n == m) return n;
    return (m + SumNumbers(m + 1, n));
}

Console.WriteLine("Enter M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumNumbers(numM,numN)}");
