/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

// Число вводится пользователем

Console.Clear();
Console.Write("Enter the number of three digits: ");
string numberUser = Console.ReadLine() ?? "";
int Number = int.Parse(numberUser);

int makeTwoDigits = Number / 10;
int makeOneDigit = makeTwoDigits % 10;

Console.WriteLine($"{Number} -> {makeOneDigit}");