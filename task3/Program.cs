// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
int a = 2;
while (a <= numberInt)
{
    Console.Write($" {a} " );
    a+=2;
}
