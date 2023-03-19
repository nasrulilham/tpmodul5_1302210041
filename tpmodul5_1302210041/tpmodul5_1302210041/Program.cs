// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Halo User " + SapaUser("Nasrul"));
    }

    public static Nas SapaUser<Nas>(Nas a)
    {
        return (dynamic)a;
    }
}
