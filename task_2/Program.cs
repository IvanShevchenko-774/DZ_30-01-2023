// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int lenNum = num.ToString().Length;

if (num >= 100 && num < 1000)
{
    num = num%10;
    System.Console.WriteLine($"Третья цифра: {num}");   
}
else if (num >=1000) // не понятно как вытащить первые 3 цифры
{
    int stepen = lenNum - 3;
    int result = num / (Convert.ToInt32(Math.Pow(10, stepen))) % 10;
    System.Console.WriteLine($"Третья цифра: {result}");

}
else
{
        System.Console.WriteLine("Третьей цифры нет");
}

