class Program
{
    static void Main()
    {
        /* Potęga();
         Podzielne();
         Dzielniki();
         Console.WriteLine($"suma liczb: {Suma()}");
         Bajtuś();*/
        Console.WriteLine(Fibonacci(5)); 
    }

    static void Dzielniki()
    {
        Console.Write("Wprowadź n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine($"Dzielniki liczby: {n}");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine($"* {i}");
        }
        Console.ReadKey();
        Console.Clear();
    }

    static void Potęga()
    {
        Console.Write("Wprowadź liczbę: ");
        int ilość = int.Parse(Console.ReadLine());
        Console.Clear();

        for (int i = 0; i <= ilość; i++)
        {
            Console.WriteLine(Math.Pow(i + 3, 3));
        }
        Console.ReadKey();
        Console.Clear();
    }

    static void Podzielne()
    {

        Console.Write("Podaj liczbę: ");
        int value = int.Parse(Console.ReadLine());
        int[] liczby = new int[value];
        Console.Clear();

        int idx = 0;
        int input = 0;
        while (idx < liczby.Length)
        {
            Console.Write($"index: {idx} Podaj liczbę: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                liczby[idx] = input;
                idx++;
            }
            Console.Clear();
        }

        foreach (int i in liczby)
        {
            if (i % 15 == 0)
                Console.WriteLine(i);
        }
    }

    static int Suma()
    {
        Console.Write("Podaj liczbę: ");
        int value = int.Parse(Console.ReadLine());
        int[] liczby = new int[value];
        int suma = 0;
        Console.Clear();

        int idx = 0;
        int input = 0;
        while (idx < liczby.Length)
        {
            Console.Write($"index: {idx} Podaj liczbę: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                liczby[idx] = input;
                idx++;
            }
            Console.Clear();
        }

        foreach (int i in liczby)
        {
            suma += i;
        }
        return suma;
    }
    static void Bajtuś()
    {
        int n = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 0; i < n - 1; i++)
            suma += int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine((n + 1) * n / 2 - suma);
    }
    static int Fibonacci(int n) {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        int f1 = 0, f2 = 1, m = 0;
        for(int i = 2; i <= n; i++) {
            m = f1 + f2;
            f2 = f1;
            f1 = m;
        }
        return f1;
    }
}
