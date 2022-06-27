// Напишите программу, которая на вход принимает два числа 
// и выдает, какое число большее, а какое меньшее.
Console.Write("Ведите первое число => ");
string paramstring1 = Console.ReadLine();
int numberInt1 = int.Parse(paramstring1);
Console.Write("Введите второе число => ");
string paramstring2 = Console.ReadLine();
int numberInt2 = int.Parse(paramstring2);
int max = 0, min = 0;

if (numberInt1 > numberInt2)
{
    max = numberInt1;
    min = numberInt2;
    Console.WriteLine($"Первое число является большим: {max}");
}
if (numberInt1 < numberInt2)
{
    max = numberInt2;
    min = numberInt1;
    Console.WriteLine($"Второе число является большим: {max}");
}
else (numberInt1 = numberInt2);
{
    Console.WriteLine("Данные числа равны");
} 
