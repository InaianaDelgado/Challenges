public static class Sorting
{
    public static void Main()
    {
        int[] numbers = new int[] { 10, 5, 3, 33, 15 };
        Sort(numbers, 0, numbers.Length);

        for (int i = 0; i < numbers.Length; i++)
            Console.WriteLine(numbers[i]);

        Console.Read();
    }

    public static void Swap(int[] array, int left, int right)
    {
        var temp = array[left];
        array[left] = array[right];
        array[right] = temp;
    }

    public static int PartArray(int[] array, int left, int right)
    {
        int minIndex = left;
        int minValue = array[left];

        for (int i = left + 1; i < right; i++)
        {
            if (array[i] < minValue)
            {
                minIndex++;
                Swap(array, minIndex, i);
            }
        }
        Swap(array, minIndex, left);
        return minIndex;
    }

    public static void Sort(int[] array, int left, int right)
    {
        if (left < right)
        {
            var index = PartArray(array, left, right);
            Sort(array, left, index - 1);
            Sort(array, index + 1, right);
        }
    }
}
