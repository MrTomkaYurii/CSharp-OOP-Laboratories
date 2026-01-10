class BiggestOfThree
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }
        else
        {
            if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        
        ///////////////
        // Використання методу TryParse
        ///////////////
        int aa, bb, cc;
        if (int.TryParse(Console.ReadLine(), out aa) &&
            int.TryParse(Console.ReadLine(), out bb) &&
            int.TryParse(Console.ReadLine(), out cc))
        {
            // Тепер змінні aa, bb та cc містять коректні цілочисельні значення.
        }
        else
        {
            Console.WriteLine("Введыть коректні цілочисельні значення.");
        }

        ///////////////
        // Використання тернарного оператору
        ///////////////
        // int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
        // Console.WriteLine("MAX = "+ max );
        // Console.WriteLine($"MAX = {max}");

        Console.ReadKey();
    }
}
