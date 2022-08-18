// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum=1;

if (a<1)
{
  Console.WriteLine("Невозможно обработать данное число");  
}
else
{
for (int i=1; i<=a; i++)
{
    sum*=i;
}
}
Console.Write($"Произведение чисел от 1 до А {sum} ");
