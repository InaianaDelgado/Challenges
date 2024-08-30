class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal plus = 0;
        decimal minus = 0;
        decimal zero = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < 0) minus++;
            if (arr[i] == 0) zero++;
            if (arr[i] > 0) plus++;
        }

        decimal minusCalc = minus / arr.Count;
        decimal zeroCalc = zero / arr.Count;
        decimal plusCalc = plus / arr.Count;

        Console.WriteLine(minusCalc.ToString("N6"));
        Console.WriteLine(zeroCalc.ToString("N6"));
        Console.WriteLine(plusCalc.ToString("N6"));
        Console.ReadLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.Write("");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}