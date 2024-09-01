class FlippingBits
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = FlippingB(n);

            Console.WriteLine(result);
        }

        Console.ReadKey();
    }

    public static long FlippingB(long n)
    {
        //work in progress
        return 0;
    }
}