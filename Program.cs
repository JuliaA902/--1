// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число => ");
string paramstring1 = Console.ReadLine();
int numberInt1 = int.Parse(paramstring1);
Console.Write("Введите второе число => ");
string paramstring2 = Console.ReadLine();
int numberInt2 = int.Parse(paramstring2);
Console.Write("Введите третье число => ");
string paramstring3 = Console.ReadLine();
int numberInt3 = int.Parse(paramstring3);

int max = numberInt1;

if (max < numberInt2)
{
    max = numberInt2;
}
if (max < numberInt3)
{
    max = numberInt3;
}
Console.WriteLine($"Данное число является большим из трех {max}");


