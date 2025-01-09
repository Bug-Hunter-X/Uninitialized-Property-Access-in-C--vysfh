public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-initialized property can lead to unexpected behavior.
        int value = MyProperty; 
    }
}