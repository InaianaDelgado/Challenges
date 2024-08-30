class SparseArray
{
    public static void Main(string[] args)
    {
        Console.Write("");
        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            Console.Write("");
            string stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        Console.Write("");
        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            Console.Write("");
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = MatchingStrings(strings, queries);

        Console.WriteLine(String.Join("\n", res));
        Console.ReadKey();
    }

    public static List<int> MatchingStrings(List<string> strings, List<string> queries)
    {
        var counter = 0;
        List<int> result = new List<int>();

        for (int i = 0; i < queries.Count; i++)
        {
            for (int j = 0; j < strings.Count; j++)
            {
                if (strings[j].Equals(queries[i]))
                {
                    counter++;
                }
            }
            
            result.Add(counter);
            counter = 0;
        }

        return result;
    }
}