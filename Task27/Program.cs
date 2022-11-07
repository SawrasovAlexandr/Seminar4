// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumDigit(int number)
{
    int result = 0;
    while (Math.Abs(number) > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма всех цифр введенного числа равна: {GetSumDigit(num)}");