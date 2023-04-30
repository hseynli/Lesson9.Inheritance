class DerivedClass : BaseClass
{
    public override void Method()
    {
        // Base klasın metodunun çağırılması.
        base.Method();

        Console.WriteLine("Method from DerivedClass");
    }
}