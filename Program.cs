B b = new B();
Console.WriteLine("{0} {1}", b.a.a, b.a.b);

class A
{
    public int a { get; set; }
    public int b { get; set; }
}

class B
{
    public readonly A a;
    public B()
    {
        a = new A();
        a.a = 10;
    }
}
