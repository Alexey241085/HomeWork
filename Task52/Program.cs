// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,11); 
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void MdArElement (int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
      double summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
     {
        summa = summa + array[i, j];
     }
     Console.WriteLine($"Ср. арифм. элементов в столбце {Math.Round(summa / array.GetLength(0),3)} ");
    }
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
InputMatrix(array);
MdArElement(array);