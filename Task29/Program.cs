// Напишите программу, которая спрашивает у пользователя кол-во элементов 
// и спршивает сами элементы. После записи элементов в массив, 
// необходимо его вывести на экран.
// 8
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i =0; i < array.Length; i++ )
array[i] = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"[{string.Join(" , " , array)}]");


