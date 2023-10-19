// Выводит третью цифру заданного числа или сообщает
// что третьей цифры нет.
Console.Write("Введите любое число: ");
string? number = Console.ReadLine();
int length = number.Length;
int numberint = Convert.ToInt32(number);
if ((length < 3)&(numberint > 0) | (length < 4)&(numberint < 0))
{
    Console.Write("Третьей цифры нет.");
}
else
{
    if (numberint < 0)
    {
        Console.WriteLine($"Третья цифра {number[3]}");
    }
    else
    {
        Console.WriteLine($"Третья цифра {number[2]}");
    }
}
