Console.WriteLine("Введите трехзначное число");
        int.TryParse(Console.ReadLine()!, out int k);
    
        if (k>999 || k<100)
        {
        Console.WriteLine("Не трехзначное число!!!");
        return;
        }
        int GetSecond(int k)
        {
        while (k >= 100) k /= 10;
        int d = k % 10;
        return d;
        }
        Console.WriteLine(GetSecond(k));