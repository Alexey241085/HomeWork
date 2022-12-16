// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

 void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); 
}

void EvenNumber(int[] array)
{    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        count = count + 1;
    }
        Console.WriteLine($"Четных чисел в массиве: {count}");
}

Console.Clear();
int[] array = new int[19];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
EvenNumber(array);


