class MinMaxSum
{
    public static void Main(string[] args)
    {
        Console.Write("");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        MiniMaxSum(arr);
    }

    public static void MiniMaxSum(List<int> arr)
    {
        long min = 0;
        long max = 0;
        long sum;

        for (int i = 0; i < arr.Count; i++)
        {
            sum = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (i != j)
                    sum += arr[j];
            }

            if (i == 0)
            {
                max = sum;
                min = sum;
            }

            min = (i == 0) ? sum : Math.Min(min, sum);
            max = (i == 0) ? sum : Math.Max(max, sum);
        }

        Console.WriteLine($"{min} {max}");
        Console.ReadKey();
    }
}