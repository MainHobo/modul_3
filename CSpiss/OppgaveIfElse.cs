namespace CSpiss;

public class OppgaveIfElse
{
    public static void Run(string[] args)
    {
        bool a = IfTrue(args);
        int b = IfNotEqual(args);
        bool c = ifTrue2(args);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }

    public static bool IfTrue(string[] args)
    {
        int TallEn = Int32.Parse(args[0]);
        int TallTo = Int32.Parse(args[1]);
        bool ReturnValue = false;

        if (TallEn < TallTo)
        {
            ReturnValue = true;
        }

        return ReturnValue;
    }
    public static int IfNotEqual(string[] args)
    {
        int TallEn = Int32.Parse(args[0]);
        int TallTo = Int32.Parse(args[1]);
        int sum = 0;
        
        if (TallEn != TallTo)
        {
            sum = TallEn + TallTo;
        }
        else if (TallEn == TallTo)
        {
            sum = TallEn * TallTo;
        }

        return sum;
    }

    public static bool ifTrue2(string[] mans)
    {
        int TallEn = Int32.Parse(mans[0]);
        int TallTo = Int32.Parse(mans[1]);
        bool ReturnValue = false;

        if (TallEn + TallTo == 30 || TallEn == 30 || TallTo == 30)
        {
            ReturnValue = true;
        }

        return ReturnValue;
    }
}
