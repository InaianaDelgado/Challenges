class CountingSort1
{
    public static void Main(string[] args)
    {
        Console.Write("");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.Write("");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = CountingSort(arr);

        Console.WriteLine(String.Join(" ", result));
    }

    public static List<int> CountingSort(List<int> arr)
    {
        //work in progress

        return new List<int>();
    }
}
