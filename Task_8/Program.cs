/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

System.Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());
int current = 2;

if (N<1)
{
    Console.WriteLine("ошибка ввода, число должно быть не меньше 1");
}
else if (N==1)
{
    Console.WriteLine("такие чётные числа отсутствуют");
}
else
{
    while (current<=N)
    {
        Console.Write($"{current}, ");
        current += 2;
    }
}


 

