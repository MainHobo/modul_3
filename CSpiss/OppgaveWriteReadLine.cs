namespace CSpiss;

public class OppgaveWriteReadLine
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Hei, hva heter du?");
        string name = Console.ReadLine();
        Console.WriteLine($"Velkommen {name} !");
    }
}