/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


System.Console.Write("Введите 1-е число ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите 2-е число ");
int b = int.Parse(Console.ReadLine());
System.Console.Write("Введите 3-е число ");
int c = int.Parse(Console.ReadLine());

if (a>=b && a>=c && (a!=b || a!=c))
{
    Console.WriteLine($"max = {a}");
}
else if (b>=c && b>=a && (b!=a || b!=c))
{
    Console.WriteLine($"max = {b}");
}
else if (c>=a && c>=b && (c!=a || c!=b))
{
    Console.WriteLine($"max = {c}");
}
else
{
    Console.WriteLine("Введенные числа равны");
}