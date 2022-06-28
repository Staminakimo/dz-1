/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine ("Введите число:");
string number = Console.ReadLine();
int number_N = int.Parse (number);
int number_N2 = 2;
for (int i = number_N2; i <= number_N; i=i+2)
{
Console.WriteLine (i);
}

