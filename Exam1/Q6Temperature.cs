public class Q6Temperature
{
    private double _celsius;
    public double Celsius { get => _celsius; 
    set {
        _celsius = value;
        _fahrenheit = 9.0 * value / 5 + 32.0;
    } 
    }
    private double _fahrenheit;
    public double Fahrenheit { get => _fahrenheit; 
    set {
        _fahrenheit = value;
        _celsius = 5.0 * (value - 32) / 9;
    }
    }
}