namespace InheritanceDemo;

internal class A
{
    public A()
    {
        Console.WriteLine("A Ctor Çalıştı");
    }

    public A(object obj)
    {
        Console.WriteLine("A 1 Ctor Çalıştı");
    }
}

internal class B : A
{
    public B()
    {
        Console.WriteLine("B Ctor Çalıştı");
    }

    public B(object obj)
    {
        Console.WriteLine("B 1 Ctor Çalıştı");
    }
}

internal class C : B
{
    public C()
    {
        Console.WriteLine("C Ctor Çalıştı");
    }

    public C(object obj) : base(obj)
    {
        Console.WriteLine("C 1 Ctor Çalıştı");
    }
}


class Sample
{

}
// Derleme sonrası->
class Sample2 : Object
{
    public Sample2() : base()
    {
        
    }
}
