class LonelyInteger
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Lonelyinteger(a);

        Console.WriteLine(result);
    }

    public static int Lonelyinteger(List<int> a)
    {
        return 0;
    }
}