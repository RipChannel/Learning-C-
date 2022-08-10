// Напишите программу, которая на вход принимает одной число (N), а на выходе показывает все целые числа в промежутке от -N до N.  
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = num * (-1);
while (i <= num)
{
    Console.Write($"{i} ");
    i = i + 1;
}
