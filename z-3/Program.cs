/*
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine ("Введите число:");
string number = Console.ReadLine();
int F_number = int.Parse (number);

if (F_number%2 == 0)
{
Console.WriteLine ($"{F_number} - является четным числом");
}

else
{
    Console.WriteLine ($"{F_number} - не является четным числом");
}


