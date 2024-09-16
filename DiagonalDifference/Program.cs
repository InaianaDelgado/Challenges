class DiagonalDifference
{
    public static void Main(string[] args)
    {
        Console.Write("");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("");
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = MatrixDiagonalDifference(arr);

        Console.WriteLine(result);
    }

    public static int MatrixDiagonalDifference(List<List<int>> arr)
    {
        int primary = 0;
        int secundary = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            primary += arr[i][i];
            secundary += arr[i][(arr.Count - 1) - i];
        }


        return Math.Abs(primary - secundary);
    }
}