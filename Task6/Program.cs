//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
double number1 = 0;
double dev = 0;

Console.WriteLine("Enter number: ");
string userenter1 = Console.ReadLine();


bool enter1 = double.TryParse(userenter1, out number1);
if (enter1)
{
    dev = number1% 2;
    if (dev == 0)
    {
        Console.Write("True");
    }
    else
    {
        Console.Write("False");
    }
}
if (!enter1)
{
    Console.Write("Wrong input");
}