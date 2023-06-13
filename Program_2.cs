/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// Число вводится пользователем

Console.Clear();
Console.Write("Enter the number: ");
string numberUser = Console.ReadLine() ?? "";
int Number = int.Parse(numberUser);

if (Number < 100)
{
    Console.WriteLine($"{Number} -> третьей цифры нет");
}

if (Number < 1000 && Number > 99)
{
    int makeTwoDigits = Number % 100;
    int makeOneDigit = makeTwoDigits % 10;
    Console.WriteLine($"{Number} -> {makeOneDigit}");
}
if (Number > 999)
{
    int i = 0;
    int a = Number;
    while (a > 999)
    {
        a = a / 10;
        i += 1;
    }
    int makeTwoDigits = a % 100;
    int makeOneDigit = makeTwoDigits % 10;
    Console.WriteLine($"{Number} -> {makeOneDigit}");
}