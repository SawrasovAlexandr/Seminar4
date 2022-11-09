// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] GetArr(int lenght)
// {
//     int[] result = new int[lenght];
//     for (int i = 0; i < lenght; i++)
//     {
//         result[i] = new Random().Next(100);
//     }
//     return result;
// }

// int[] array = GetArr(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] InputArr(string input)
// {
//     string[] str = input.Split();
//     int length = str.Length;
//     int[] result = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//        result[i] = int.Parse(str[i]);
//     }
//     return result;
// }

Console.WriteLine("Введите числа через пробел: ");
int[] array = InputArr(Console.ReadLine());
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] InputArr(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ') count++;
    }
    int[] result = new int[count];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            j++;
           
        }
        else if (result[j] == 0) 
        {
            result[j] = int.Parse(input[i].ToString());
        }
        else result[j] = result[j] * 10 + int.Parse(input[i].ToString());
    }
    return result;
}

