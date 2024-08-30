public static class Recursion
{
    public static void Main()
    {
        var factorial = Factorial(8);
        var recursiveResult = RecursiveFactorial(5);

        Console.WriteLine($"factorial: {factorial}");
        Console.WriteLine($"recursive factorial: {recursiveResult}");
        Console.ReadLine();
    }

    public static int Factorial(int n)
    {
        int result = 1;

        for (int i = n; i >= 1; i--)
            result = result * i;

        return result;
    }

    public static int RecursiveFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * RecursiveFactorial(n - 1);
    }

    //public static bool RecursivePalindrome(string word)
    //{

    //}
}