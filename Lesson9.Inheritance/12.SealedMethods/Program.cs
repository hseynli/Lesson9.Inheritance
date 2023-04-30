ClassA instanceA = new ClassA();
instanceA.Method1();
instanceA.Method2();

Console.WriteLine(new string('-', 15));

ClassB instanceB = new ClassB();
instanceB.Method1();
instanceB.Method2();

Console.WriteLine(new string('-', 15));

ClassC instanceC = new ClassC();
instanceC.Method1();
instanceC.Method2();


partial class ClassA
{
    public virtual void Method1() { Console.WriteLine("ClassA.Method1"); }
    public virtual void Method2() { Console.WriteLine("ClassA.Method2"); }
}
partial class ClassA
{

}

class ClassB : ClassA
{
    public sealed override void Method1() { Console.WriteLine("ClassB.Method1"); }
    public override void Method2() { Console.WriteLine("ClassB.Method2"); }
}

class ClassC : ClassB
{
    // Method1 metodunu override etmək kompilyasiya səviyyəsində xətaya gətirib çıxaracaqdır.
    // public override void Method1() { Console.WriteLine("ClassC.Method1"); }

    // Method2-ni override etmək icazə verilir.
    public override void Method2() { Console.WriteLine("ClassC.Method2"); }
}