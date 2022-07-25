//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int number1 = 0;
int number2 = 0;
int number3 = 0;
int max = 0;

Console.WriteLine("Enter number1: ");
string userenter1 = Console.ReadLine();
Console.WriteLine("Enter number2: ");
string userenter2 = Console.ReadLine();
Console.WriteLine("Enter number3: ");
string userenter3 = Console.ReadLine();

bool enter1 = int.TryParse(userenter1, out number1);
if (enter1)
{
    max = number1;
}
if (!enter1)
{
    Console.Write("Wrong input");
}

bool enter2 = int.TryParse(userenter2, out number2);
if (enter2)
{
    if (number2 > max)
    {
        max = number2;
    }
}
if (!enter2)
{
    Console.Write("Wrong input");
}

bool enter3 = int.TryParse(userenter3, out number3);
if (enter3)
{
    if (number3 > max)
    {
        max = number3;
    }
}
if (!enter3)
{
    Console.Write("Wrong input");
}

Console.Write($"Max =  {max}");