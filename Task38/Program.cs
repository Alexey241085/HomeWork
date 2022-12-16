// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//void InputArray(double[] array)

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

Console.WriteLine("Введите элементы массива: ");
for (int i =0; i < array.Length; i++ )
array[i] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"[{string.Join(", ", array)}]");


Console.WriteLine("Максимальное значение: "  + array.Max());
Console.WriteLine("Минимальное значение: "  + array.Min());
Console.WriteLine($" Разницв Max и Min =  {array.Max() - array.Min()}");

// void Maximum(double[] array)


// {   double max =0; double min =0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         max = array[i];
//     }
//         Console.WriteLine($" Мамксимальное значение : {max}");
// }


// void Minimum(double[] array)
// {   double min =0; 
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (min < array[i])
//         min = array[i];
//         else if(min<array[i])  {
//           min=array[i];
//         }
//     }
//         Console.WriteLine($" Минимальное значение : {min}");
// }

