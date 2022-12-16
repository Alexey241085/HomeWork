// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); 
}

void EvenNumber(int[] array)
{    int count = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        count = count + array[i];

    }
        Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях: {count}");
}

Console.Clear();
int[] array = new int[6];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
EvenNumber(array);

