// программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int a;

Console.Write("Введите цифру обозначающую день недели от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out a);

if (a == 6) 
    Console.WriteLine("Это выходной день");
    else 
        if (a == 7) 
            Console.WriteLine("Это выходной день");
            else 
                Console.WriteLine("Это невыходной день");
