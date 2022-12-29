void InputArray (int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++ )
   {
      for (int j = 0; j < array.GetLength(1); j++)
        array [i,j] = new Random().Next(1,11);
   }
} 

void PrintArray (int [,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       Console.Write($"{array[i,j]} \t");
       Console.WriteLine();
    }
}

void NumberRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
           sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

Console.Clear();
Console.Write("Введите размер прямоугольного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер прямоугольного двумерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
int[,] array = new int[size[0], size[1]];
InputArray(array);
Console.WriteLine("Начальный двумерный массив: ");
PrintArray(array);
Console.WriteLine();
NumberRow(array);


