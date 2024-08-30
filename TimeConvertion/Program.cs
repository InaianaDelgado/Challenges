class TimeConvertion
{
    public static void Main(string[] args)
    {
        Console.Write("");
        string s = Console.ReadLine();

        string result = TimeConversion(s);

        Console.WriteLine(result);
        Console.ReadKey();
    }

    public static string TimeConversion(string s)
    {
        string[] time = s.Split([':']);

        var hour = time[0];
        var second = time[2];

        if (time[2][^2..].Equals("PM"))
        {
            if (time[0].Equals("12"))
                return $"{time[0]}:{time[1]}:{time[2][0..^2]}";

            hour = CastingHour(time[0]);
            second = time[2][0..^2];
        }

        if (time[2][^2..].Equals("AM"))
        {
            if (time[0].Equals("12"))
                return $"00:{time[1]}:{time[2][0..^2]}";

            second = time[2][0..^2];
        }

        return $"{hour}:{time[1]}:{second}";
    }

    public static string CastingHour(string hour)
    {
        var dataDict = new Dictionary<string, string>();

        dataDict.Add("01", "13");
        dataDict.Add("02", "14");
        dataDict.Add("03", "15");
        dataDict.Add("04", "16");
        dataDict.Add("05", "17");
        dataDict.Add("06", "18");
        dataDict.Add("07", "19");
        dataDict.Add("08", "20");
        dataDict.Add("09", "21");
        dataDict.Add("10", "22");
        dataDict.Add("11", "23");

        return dataDict[hour];
    }
}