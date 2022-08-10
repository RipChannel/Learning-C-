// Напишите программу, которая на вход принимает число и выдаёт, является ли число четным.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
   Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}