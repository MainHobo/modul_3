namespace CSpiss;

public static class OppgaveReturn
{
    public static void Run(string[] args)
    {
        int a = 35;
        int b = 34;
        
        Console.WriteLine(GetSum(a, b) + " Nice!");
        SomeMethod();
    }
    static decimal GetSum(int a, int b)
    {
        return a + b;
    }

    static void SomeMethod()
    {
        Console.WriteLine("Denne metoden returnerer ingenting");
    }
}