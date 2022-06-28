/*
Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine ("Введите первое число:");
string first_number = Console.ReadLine();
int F_number = int.Parse (first_number);

Console.WriteLine ("Введите второе число:");
string second_number = Console.ReadLine();
int S_number = int.Parse (second_number);

Console.WriteLine ("Введите третье число:");
string third_number = Console.ReadLine();
int T_number = int.Parse (third_number);

if (F_number > S_number && F_number > T_number )
{
Console.WriteLine ($"Max = {F_number}");
}
else if (S_number > F_number && S_number > T_number )
{
    Console.WriteLine ($"Max = {S_number}");
}
else
{
    Console.WriteLine ($"Max = {T_number}");
}

