namespace CSpiss;

public class OppgaveVariabelordning
{
    public static void Run(string[] args)
    {
        int integer = 1;
        long longInteger = 2;
        float decimalNumber = 3.3f;
        decimal someDecimalNumber = 4.44m;
        double someOtheDecimalNumber = 5.555;
        string someString = "hello";
        char character = 'y';
        bool boolean = true;

        int a = 5;
        decimal b = 3.0m;
        decimal sum = a + b;
        
        Console.WriteLine(sum);
    }
}