class DerivedClass : BaseClass
{
    public int derivedField;

    // Default konstruktor.
    public DerivedClass()
    {
    }

    public DerivedClass(int number1, int number2)
        : base(number1)
    {
        derivedField = number2;
    }
}