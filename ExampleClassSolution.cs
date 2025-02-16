public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        int x = Value; 
        int newValue = x + 1;
        Value = newValue; // Modifying the property

        if (newValue == Value) // Comparing using a temporary variable
        {
            // ...
        }
    }
}