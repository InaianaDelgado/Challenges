public static class BigO
{
    public static void Main()
    {
        //Constante(1, 2, 3, 4);
        //Linear(1, 2, 9, 10, 21);
        //Exponencial(1, 2);
        //Exponencial(1, 2, 3);
        //Exponencial(1, 2, 3, 4);

        var result = Logaritmico(3, 3, 5, 8, 10, 11, 24);
        Console.WriteLine($"Resultado Logaritmico: {result}");
    }

    public static void Constante(params int[] array)
    {
        //Notação O(1)
        Console.WriteLine($"Constante 1: {array[0]}");
        Console.WriteLine($"Constante 2: {array[1]}");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("************************************************************************");
    }

    public static void Linear(params int[] array)
    {
        //Notação O(n)
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Linear ({i}): {array[i]}");
        }
        Console.WriteLine("************************************************************************");
        Console.WriteLine("************************************************************************");
    }

    public static void Exponencial(params int[] array)
    {
        //Notação O(n^2)
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine($"Pares: {array[i]} - {array[j]}");
            }
        }
        Console.WriteLine("************************************************************************");
        Console.WriteLine("************************************************************************");
    }

    public static int Logaritmico(int key, params int[] array)
    {
        //Notação O(log n)
        var min = 0;
        var max = array.Length;

        while (min <= max)
        {
            var middle = Math.Abs((min + max) / 2);

            if (array[middle] == key) return middle;

            if (array[middle] > key)
                max = middle;
            else
                min = middle + 1;
        }

        return -1;
    }
}