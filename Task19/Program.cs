/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();

bool Pallindrom(int n)
{     
    int Nobr = 0, nn = n;
    while (n > 0 || n < 0)
    {
        Nobr = Nobr * 10 + n % 10;
        n = n / 10;
    }
    return Nobr == nn;
}

Console.Write("Введите число -> ");
int n = Convert.ToInt32(Console.ReadLine());
if (Pallindrom(n))
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");



