void InputMatrix(double[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)  
   {
      for(int j = 0; j< array.GetLength(1); j++)
      {
         array[i, j] = Math.Round(new Random().NextDouble()*(2+2)-2, 3);
         Console.Write($"{array[i,j]}         \t");
      }
      Console.WriteLine();
   }
}

Console.Clear();

Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] array = new double[size[0], size[1]];
InputMatrix(array);







