// Принимает на вход трехзначное число и на выходе показывает вторую цифру.
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SecondDigit = (number % 100 - number % 10) / 10;
Console.Write($"Вторая цифра: {SecondDigit}");
