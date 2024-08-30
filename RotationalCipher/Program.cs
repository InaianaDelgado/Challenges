public class Program
{
	public static char[] letters = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

	public static void Main()
	{
		Dictionary<string, int> cifra = new Dictionary<string, int>();
		string word = "";

		Console.WriteLine("______________________________________________________________________________");
		Console.WriteLine("       PLEASE, ENTER WITH A WORD AND TOTAL POSITION FOR CIPHER");
		Console.Write("       Word: ");
		word = Console.ReadLine();
		Console.Write("       Position: ");
		string position = Console.ReadLine();
		Console.WriteLine("______________________________________________________________________________");

		int.TryParse(position, out int pos);

		cifra.Add(word.ToLower(), pos);

		Result(cifra);
	}

	public static void Result(Dictionary<string, int> cifra)
	{
		string newLetter = "";
		ReadOnlySpan<char> lettersCipher;

		foreach (KeyValuePair<string, int> values in cifra)
		{
			lettersCipher = values.Key.AsSpan(0, values.Key.Length);

			for (var i = 0; i < lettersCipher.Length; i++)
				newLetter += letterIntoCircularArray(values.Value, lettersCipher[i]);
		}

		Console.WriteLine();
		Console.WriteLine("______________________________________________________________________________");
		Console.WriteLine("THE CIPHER FOR THE INPUT WORD IS: " + newLetter);
		Console.WriteLine("______________________________________________________________________________");
	}

	public static char letterIntoCircularArray(int position, char currentLetter)
	{
		int nElements = 26;
		char[] circularArray = new char[nElements];
		int pos = 0;
		int index = 0;

		for (int i = position; i < nElements + position; i++)
		{
			circularArray[pos] = letters[(i % nElements)];

			Console.WriteLine("Resto: " + i % nElements);

            if (letters[(i % nElements)] == currentLetter)
                index = (i % nElements);

			pos++;
        }

		return circularArray[index];
	}
}