
int SummMN(int a, int b)
{
    int result = 0;
    if (a == b)
        return 0;
    else
    { 
        a++;
        result = a + SummMN(a, b);
        return result;
    }
}

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

SummMN(m, n);
Console.Write("Сумма чисел от m  до n ровна ");
Console.Write(SummMN(m - 1, n));

