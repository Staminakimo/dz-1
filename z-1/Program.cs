/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine ("Введите первое число:");
string first_number = Console.ReadLine();
int F_number = int.Parse(first_number);

Console.WriteLine ("Введите второе число:");
string second_number = Console.ReadLine();
int S_number = int.Parse (second_number);

if (F_number > S_number)
{
Console.WriteLine ($"Max = {F_number}, Min = {S_number}");
}
else 
{
    Console.WriteLine ($"Max = {S_number}, Min = {F_number}");
}
