public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (x is null && y is null) { return 0; }
        if (x is null)
        { return -1; } 
        if (y is null) { return 1; }
        if (x.Length == y.Length)
        {
            return x.CompareTo(y);
        }
        return x.Length.CompareTo(y.Length);
    }
}