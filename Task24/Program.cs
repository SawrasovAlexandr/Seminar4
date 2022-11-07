// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

void GetSumNums(int number)
{
    int sum = (1 + number) / 2 * number;
    Console.WriteLine($"Cумма цифр от 1 до введенного числа: {sum}");
    return;
}

Console.Clear();

GetSumNums(5);