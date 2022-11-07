// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

void GetProdNums(int number)
{
    int prod = 1;
    for (int i = 1; i <= Math.Abs(number); i++) prod *= i;
    Console.WriteLine($"Произведение цифр от 1 до введенного числа: {prod}");
}

Console.Clear();

GetProdNums(5);