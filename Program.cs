// OneStream Code Assessment

// Outline any issues/concerns with the implemented code
// - The Console.WriteLine specification is using C++ syntax and needs to be changed to C#.
// - Console.WriteLine() includes terminating the line with \n. Adding it in the format statement adds an extra \n
// - Main isn't returning anything useful. The return type should be changed to void and delete the return statement.
// - In class B, you cannot set a constant to a class. It must be set to a constant value.
//   The solution is to change 'a' to readonly and initialize it in the constructor.

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
