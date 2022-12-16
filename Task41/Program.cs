// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void InputArray(int[] array)
{
Console.WriteLine("Введите числа массива: ");
for(int i = 0; i < array.Length; i++)
    array [i] = Convert.ToInt32(Console.ReadLine());
}

void Result(int [] array)
{  
    int count =0;
for(int i = 0; i < array.Length; i++)
    if (array[i] > 0)
  {
    count =  count + 1; 
  } 
    Console.WriteLine($"Кличество чисел больше 0: {count}"); 
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Result(array);



