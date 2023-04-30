class DerivedClass : BaseClass
{
    // Konstruktor.
    public DerivedClass()
    {
        publicField = "DerivedClass.publicField";
        protectedField = "DerivedClass.protectedField";
    }

    string _name;

    public DerivedClass(string name)
    {
        _name = name;
    }
}