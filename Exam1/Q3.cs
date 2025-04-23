public class Type1
{
    private int? _Count = null;
    public int? Count { get => (int)_Count; 
    set {
        if (_Count is null)
        {
            _Count = value;
        }
    } }
}
public class Type2
{
    public int Count { get; set; }
}