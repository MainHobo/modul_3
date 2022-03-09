namespace CSpiss;

public class OppgaveLøkker
{
    public static void Run(string[] args)
    {
        // for (var i = 0; i < 5; i++)
        // {
        //     Console.WriteLine("Terje er kul");
        // }

        // string terjeString = "terje";
        // var i = 0;
        // foreach (var terje in terjeString)
        // {
        //     Console.WriteLine(terjeString[i]);
        //     i++;
        // }
        
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine($"Runde Nr.{i + 1}");
            i++;
        }
    }
}