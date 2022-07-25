double number1 = 0;
double max = 0;

Console.WriteLine("Enter number: ");
string userenter1 = Console.ReadLine();


bool enter1 = double.TryParse(userenter1, out number1);
if (enter1)
{
    max = number1% 2;
    if (max == 0)
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