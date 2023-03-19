// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

class DataGeneric<K>
{
    private K data;

    public DataGeneric(K data)
    {
        this.data = data;
    }
    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah : " + data);
    }
}
public class program
{
    public static void Main(string[] args)
    {
        DataGeneric<String> dat = new DataGeneric<String> ("1302210041");
        dat.printData();
    }
}

