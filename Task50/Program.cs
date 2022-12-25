
void InputMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = new Random().Next(1,11); 
           Console.Write($" {array[i,j]}\t");
        }
     Console.WriteLine();
    }
}
    
Console.Clear();
int[,] array = new int[4,5];
InputMatrix(array);
Console.WriteLine("Введите номер строки: ");
int n =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m =  Convert.ToInt32(Console.ReadLine());

if (n > array.GetLength(0)-1 || m > array.GetLength(1)-1)
    Console.WriteLine("Такого значения нет");
else
Console.WriteLine("Значение: " + array[n,m]);
