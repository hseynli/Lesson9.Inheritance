SealedClass instance = new SealedClass();
instance.x = 100;
instance.y = 200;

Console.WriteLine("x = {0}, y = {1}", instance.x, instance.y);


sealed class SealedClass
{
    public int x;
    public int y;
}

// sealed klasdan miras almaq OLMAZ.

class DerivedClass //: SealedClass   // Error
{
}