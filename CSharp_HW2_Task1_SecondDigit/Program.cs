// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
if (number / 1000 != 0 || number / 100 == 0)
{
    Console.WriteLine("Введено число не уддовлетворяющее условиям задачи.");
}
else
{
    int SecDig = (number % 100) / 10;
    Console.WriteLine("Вторая цифра вашего трёхзначного числа: " + SecDig);
}