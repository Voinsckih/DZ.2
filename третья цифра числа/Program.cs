 int ThirdDigit(int number)
    {
       int result = -1;
        if (number >= 100)
        {
        while (number > 999)
            {
                number = number / 10;
            }
            result = number % 10;
        }
        return result; 
       }
 
Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Third digit is {ThirdDigit(number1)}");