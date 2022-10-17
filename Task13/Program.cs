// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет;

int a;

Console.Write("Введите любое целое число ");
int.TryParse(Console.ReadLine()!, out a);

int temp = a;

int d = 0; 
while(a != 0)
    {
    a = a / 10; 
    d++;
    }

Console.WriteLine($"Третья цифра введенного числа - {(temp / (int) Math.Pow(10, d - 3)) % 10}");



