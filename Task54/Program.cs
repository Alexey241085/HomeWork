
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

void ReleaseArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {  for (int j = 0; j < array.GetLength(1); j++)
     {
        for (int k = 0; k < array.GetLength(1) -1; k++)
        {
           if (array[i,k] > array[i, k+1])
           {
            int temp = array[i, k +1];
            array[i, k+1] = array[i,k];
            array[i,k] = temp;
           }
        }
     } 
  } 
}


Console.Clear();
Console.Write("Ввести размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
int[,] array = new int[size[0], size[1]]; 
InputArray(array);
Console.WriteLine("Начальный двумерный массив: ");
PrintArray(array);
Console.WriteLine();
ReleaseArray(array);
Console.WriteLine("Конечный двумерный массив: ");
PrintArray(array);

