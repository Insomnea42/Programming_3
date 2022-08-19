// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

bool ProvercaZnaka(int num)
{
    if (num > 0) return true;
    else return false;
}


Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
bool pos = ProvercaZnaka(n);
int i = 1;
Console.Write("Таблица кубов до " + n + ": ");
n = Math.Abs(n);
if (n == 0)
{
    Console.Write(0);
}
else
{
    while (i <= n)
    {
        if (pos == true) Console.Write(Math.Pow(i, 3));
        else Console.Write("-" + Math.Pow(i, 3));
        i++;
        if (i <= n) Console.Write(", ");
    }
}
Console.WriteLine(";");