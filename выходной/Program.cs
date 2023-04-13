System.Console.WriteLine("номер дня недели");
string number = Console.ReadLine();
int weeknumber = int.Parse(number);

if (weeknumber ==6 || weeknumber == 7)
{
    System.Console.WriteLine ($"день недели № {weeknumber} - выходной");
}
else if (weeknumber<1 || weeknumber>7)
{
    System.Console.WriteLine("не корректный № деня недели");
}
else
{
    System.Console.WriteLine($"День недели №{weeknumber}- будний день");
}