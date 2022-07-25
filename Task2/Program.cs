int number1 = 0;
int number2 = 0;
int max = 0;

Console.WriteLine("Enter number1: ");
string userenter1 = Console.ReadLine();
Console.WriteLine("Enter number2: ");
string userenter2 = Console.ReadLine();

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
    if (number2 > number1)
    {
        max = number2;
    }
}
if (!enter2)
{
    Console.Write("Wrong input");
}
Console.Write($"Max =  {max}");