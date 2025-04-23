public class Basics
{
    public static void Q2MultiplyAndReset(ref int num1, ref int num2)
    {
        num1 = num1 * num2;
        num2 = 1;
    }

    public static void Q5TryCatchFinally(bool DoThrow
                                        , List<string> reports
                                        , bool DoCatch)
    {
        if (DoCatch)
        {
            try
            {
                reports.Add("Try");
                if (DoThrow)
                { throw new InvalidOperationException(); }
                reports.Add("AfterTry");
            } catch (InvalidOperationException)
            {
                reports.Add("Catch");
                throw;
            } finally {
                reports.Add("Finally");
            }

        }
        else {
            reports.Append("Do not catch anything and finished");
        }
    }
    public static void Q5TryCatchFinally(bool DoThrow
                                        , List<string> reports)
    {
        try
        {
            reports.Add("Try");
            if (DoThrow)
            { throw new InvalidOperationException(); }
            reports.Add("AfterTry");
        } catch (InvalidOperationException)
        {
            reports.Add("Catch");
        } finally {
            reports.Add("Finally");
        }
    }
}