// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int a, int b)
{
  if (a == 0)
    return b + 1;
  else
    if ((a != 0) && (b == 0))
      return AckermanFunction(a - 1, 1);
    else
      return AckermanFunction(a - 1, AckermanFunction(a, b - 1));
}

Console.WriteLine("Enter A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermanFunction(numA,numB));
