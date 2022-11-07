// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArr(int lenght)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}

int[] array = GetArr(8);
Console.WriteLine($"[{String.Join(", ", array)}]");