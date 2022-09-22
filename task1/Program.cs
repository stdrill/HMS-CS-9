// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumbers(int n, int m)
{
    if (n < m) return;
    Console.Write($"{m} ");
    PrintNumbers(n, m+1);
}

Console.WriteLine("Enter M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintNumbers(numberN,numberM);
