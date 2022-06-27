// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите первое число => ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if (numberInt%2==0)
{
    Console.WriteLine($"Число {numberInt} будет являться четным");
}
else
{
    Console.WriteLine($"Число {numberInt} будет являться нечетным");
}
