class FlippingBits
{
    public static void Main(string[] args)
    {
        Console.Write("");
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            Console.Write("");
            uint n = Convert.ToUInt32(Console.ReadLine().Trim());

            uint result = Flipping(n);

            Console.WriteLine(result);
        }

        Console.ReadKey();
    }

    public static uint Flipping(uint n)
    {
        uint max32BitsUint = 0xFFFFFFFF;

        return n ^ max32BitsUint;
    }
}