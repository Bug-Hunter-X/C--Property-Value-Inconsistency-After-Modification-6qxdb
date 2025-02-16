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
        int x = Value; // Accessing the property
        Value = x + 1; // Modifying the property

        if (Value == x + 1) // This comparison might fail due to unexpected behavior
        {
            // ...
        }
    }
}