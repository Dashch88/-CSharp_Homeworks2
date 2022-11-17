// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число для нахождения значения его третьей цифры: ");

int number = int.Parse(Console.ReadLine());
Console.WriteLine();

int index = 100;
int div = number / index;
if (div == 0)
{
    Console.WriteLine("В введённом числе нет третьей цифры.");
}
else
{
    while (div != 0)
    {
        index = index * 10;
        div = number / index;
    }
    int thirdDig = (number / (index / 1000)) % 10;
    Console.WriteLine("Третья цифра введённого числа: " + thirdDig);
}