using CL02.Models;

namespace CL02;
internal class Program
{
    private static void Main(string[] args)
    {
        Guid guid = Guid.NewGuid();
        Humo humo = new(guid, "Hasanboy", 150000);
        humo.Pay(15000);


        Console.WriteLine(humo.Balance);

    }
}