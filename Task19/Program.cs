// Task19


Console.Clear();
Console.Write("Введите пятизначное число: ");

string? n = Console.ReadLine();

if(n[0] == n[4] && n[1] == n[3])
Console.WriteLine("Число ЯВЛЯЕТСЯ полиндромом");

else 
Console.WriteLine("Число НЕ ЯВЛЯЕТСЯ полиндромом");




