//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
double number1 = 0;
double dev = 0;
double index = 0;

Console.WriteLine("Enter number: ");
string userenter1 = Console.ReadLine();


bool enter1 = double.TryParse(userenter1, out number1);
if (enter1)
{
    while (index < number1)
    {
        if (enter1)
        {
            dev = index% 2;
            if (dev == 0)
            {
                Console.Write($"{index},  ");
            }
        index++;
        }
        
    }
}
if (!enter1)
{
    Console.Write("Wrong input");
}