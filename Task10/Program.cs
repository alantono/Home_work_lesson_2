// программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a;

Console.Write("Введите любое трехзначное число ");
int.TryParse(Console.ReadLine()!, out a);

Console.WriteLine($"Вторая цифра введенного числа - {a / 10 % 10}");