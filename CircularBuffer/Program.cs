public static class Program
{
    private static string[] NUMBERS = new string[3];
    private static int POSITION;
    private static string NEW_VALUE = "";

    public static void Main()
    {
        AddValue();
        DisplayArray();
    }

    public static void AddValue()
    {
        DisplayInstructions();

        ValidatePositionToUpdate(NEW_VALUE);

        DisplayInput(NEW_VALUE);

        var next = GetValueToValidate();
        bool isValid = ValidateInput(next);

        while (!isValid)
        {
            next = GetValueToValidate();
            isValid = ValidateInput(next);
        }

        if (isValid && next.Equals("y"))
            AddValue();
    }

    public static void UpdateCircularBuffer(string newValue)
    {
        POSITION = POSITION + 1;
        var olderPosition = POSITION;

        if (olderPosition == NUMBERS.Length)
            POSITION = 0;

        NUMBERS[POSITION] = newValue;
    }

    public static string GetValueToValidate()
    {
        Console.WriteLine("DO YOU WANT TO INCLUDE MORE VALUES? (PRESS 'y' TO CONTINUE OR 'n' TO FINISH THE PROCESS");
        return Console.ReadLine().ToLower();
    }

    public static bool ValidateInput(string next)
    => (next == "y" || next == "n");

    public static void ValidatePositionToUpdate(string newValue)
    {
        if (NUMBERS[POSITION] != null)
            UpdateCircularBuffer(newValue);
        else
            NUMBERS[POSITION] = newValue;
    }

    public static void DisplayInstructions()
    {
        Console.WriteLine("_____________________________________________________");
        Console.Write(" >>> ENTER A VALUE TO SAVE INTO BUFFER: ");
        NEW_VALUE = Console.ReadLine();
    }

    public static void DisplayInput(string newValue)
    {
        Console.WriteLine();
        Console.WriteLine("_______________________________________________________________________");
        Console.WriteLine($"THE VALUE '{newValue}' WAS INCLUDED ON BUFFER INTO POSITION {POSITION}");
        Console.WriteLine("_______________________________________________________________________");
        Console.WriteLine();
    }

    public static void DisplayArray()
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("NOW THE ARRAY LOOKS LIKE THIS: ");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine();

        for (int i = 0; i < NUMBERS.Length; i++)
        {
            Console.WriteLine($"POSITION {i}: {NUMBERS[i]}");
        }
    }
}