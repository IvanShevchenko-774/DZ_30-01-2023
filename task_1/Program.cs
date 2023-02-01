// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000)
{
    num = num / 10;
    num = num % 10;
    System.Console.WriteLine($"Вторая цифра: {num}");
}
else
{
    System.Console.WriteLine("Введено не трехзначное число");
}