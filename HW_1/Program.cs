// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n >= 10000) && (n <= 99999))
{
    int n1 = n / 10000;
    int n5 = n % 10;
    int n2 = n / 1000;
    n2 = n2 % 10;
    int n4 = n % 100;
    n4 = n4 / 10;

    if (n1 == n5 && n2 == n4)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Нужно ввести пятизначное число: ");
}