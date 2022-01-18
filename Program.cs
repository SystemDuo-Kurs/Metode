public partial class Program
{
    public static void Foo(string nesto)
    {
        Console.WriteLine(nesto);
    }

    public static void Main()
    {
        int broj = 8;
        Console.WriteLine($"Broj je {broj} pre poziva");
        broj = Inc(broj);
        Console.WriteLine($"Broj je {broj} posle poziva");
        //Sabirac(5, 6);
    }

    public static int Inc(int zklj)
    {
        Console.WriteLine($"Broj je {zklj} po pozivu");
        zklj++;
        Console.WriteLine($"Broj je {zklj} posle uvecavanja");
        if (zklj % 2 == 0)
        {
            return zklj;
        }
        else
        {
            return zklj * 2;
        }
    }

    public static void SabiracJosNesto(int x, int y)
    {
        Console.WriteLine("Zbir je: " + (x + y));
        Console.WriteLine(x + " + " + y + " je: " + (x + y));
        Console.WriteLine($"{x} + {y} je: {x + y}");
    }
}