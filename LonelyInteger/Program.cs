class LonelyInteger
{
    public static void Main(string[] args)
    {
        Console.Write("");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        if (n < 1 || n > 100)
            return;

        if ((n % 2) == 0)
            return;

        Console.Write("");
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        if (a.Count < 0 || a.Count > n)
            return;

        int result = Lonelyinteger(a);

        Console.WriteLine(result);
        Console.ReadKey();
    }

    public static int Lonelyinteger(List<int> a)
    {
        int lonely = 0;
        int counter = 0;

        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < a.Count; j++)
                if (a[i] == a[j]) counter++;     

            if (counter == 1)
                lonely = a[i];

            counter = 0;
        }

        return lonely;
    }
}