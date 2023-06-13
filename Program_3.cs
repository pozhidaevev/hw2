/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

// Число вводится пользователем

Console.Clear();
Console.Write("Enter number from 1 to 7: ");
string numberUser = Console.ReadLine() ?? "";
int Number = int.Parse(numberUser);

if (Number >= 6)
{
    Console.WriteLine($"{Number} -> да");
}
else
{
    Console.WriteLine($"{Number} -> нет");
}