// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

Console.Write("Введите число A: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Выедите число B: ");
double b = Convert.ToInt32(Console.ReadLine());

double result = 1;

for(int i = 0; i < b; i++)
result = result*a;

Console.WriteLine(result);