
int Akkerman(int m, int n)
{ 
  if (m == 0)
  {
   return n + 1;
  }
    else if (m > 0 && n == 0)
     {
      return Akkerman(m - 1, 1);
     }
   else
   {
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
   }
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Akkerman(m,n);
Console.Write("Результат: ");
Console.Write(Akkerman(m, n));