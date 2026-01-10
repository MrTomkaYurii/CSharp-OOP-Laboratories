class SignOfProduct
{
    static void Main()
    {
        string inputA = Console.ReadLine();
        string inputB = Console.ReadLine();
        string inputC = Console.ReadLine();

        if (inputA == null || inputB == null || inputC == null)
        {
            Console.WriteLine("Input is null. Please enter valid values.");
            return;
        }

        double a = double.Parse(inputA);
        double b = double.Parse(inputB);
        double c = double.Parse(inputC);

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0))
        {
            Console.WriteLine("Positive");
        }
        else
        {
            Console.WriteLine("Negative");
        }

        Console.ReadKey();
    }
}