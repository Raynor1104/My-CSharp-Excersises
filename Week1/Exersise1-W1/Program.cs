// See https://aka.ms/new-console-template for more information
int day31 = 31;
int day30 = 30;
int day29 = 29;
int day28 = 28;
Console.WriteLine("Enter year: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter month: ");
int month = Convert.ToInt32(Console.ReadLine());
if (month > 12)
{
    Console.WriteLine("Invalid month");
}
else
{
    if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
    {
        Console.WriteLine($"This month have : {day31} days");
    }
    else if (month == 4 || month == 6 || month == 9 || month == 11) 
    {
        Console.WriteLine($"This month have : {day30} days");
    }
    else if (month == 2 && year % 4 == 0)
    {
        Console.WriteLine($"This month have : {day29} days");
    }
    else 
    {
        Console.WriteLine(day28);
    }
}


