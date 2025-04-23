public class Q8ComparableString
{
    public string str { get; set; }

    public Q8ComparableString(string str)
    {
        this.str = str;
    }

    public static bool operator <(Q8ComparableString str1,
                                Q8ComparableString str2)
    {
        string s1 = str1.str;
        string s2 = str2.str;

        if (s1 is null)
        {
            if (s2 is null) { return false; }
            return true;
        }
        if (s2 is null) { return false; }

        if (s1.Length > s2.Length) { return false; }
        if (s1.Length < s2.Length) { return true; }
        int s = s1.CompareTo(s2);
        if (s == -1) { return true; }
        return false;
    }
    public static bool operator >(Q8ComparableString str1,
                                Q8ComparableString str2)
    {
        string s1 = str1.str;
        string s2 = str2.str;

        if (s2 is null)
        {
            if (s1 is null) { return false; }
            return true;
        }
        if (s1 is null) { return false; }

        if (s1.Length > s2.Length) { return true; }
        if (s1.Length < s2.Length) { return false; }
        int s = s1.CompareTo(s2);
        if (s == 1) { return true; }
        return false;
    }

    public static bool operator ==(Q8ComparableString str1,
                                Q8ComparableString str2)
    {
        string s1 = str1.str;
        string s2 = str2.str;
        if (s1 == s2) { return true;}
        return false;
    }
    public static bool operator !=(Q8ComparableString str1,
                                Q8ComparableString str2)
    {
        string s1 = str1.str;
        string s2 = str2.str;
        if (s1 == s2) { return false; }
        return true;
    }
}