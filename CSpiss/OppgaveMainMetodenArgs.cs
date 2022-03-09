namespace CSpiss;

public class OppgaveMainMetodenArgs
{
    public static void Run(string[] args)
    {
        foreach (var argumenter in args)
        {
            Console.WriteLine(argumenter);
        }
        Console.WriteLine(args.Length);
    }
}