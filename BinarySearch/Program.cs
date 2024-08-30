public static class BinarySearch
{
    public static int[] numbers = new[] { 5, 8, 9, 19, 20 };

    public static void Main()
    {
        int find = 3;

        int result = SearchMyNumber(find);

        if (result == 0)
            Console.WriteLine("The number {0} is not found", find);
        else
            Console.WriteLine("The number found at position: {0}", result);
    }

    public static int SearchMyNumber(int numberWanted)
    {
        var min = 0;
        var max = numbers.Length;

        while (min < max)
        {
            var middle = (min + max) / 2;

            if (numberWanted == numbers[middle]) return middle;

            if (numbers[middle] > numberWanted)
                max = middle;
            else
                min = middle + 1;
        }

        return 0;
    }
}