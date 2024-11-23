# OneStream Assessment
### Readonly protection

Given the following:

```
class A
{
  public int a { get; set; }
  public int b { get; set; }
}

class B
{
  public const A a;
  public B() { a.a = 10; }
}

int main()
{
  B b = new B();
  Console.WriteLine("%d %d\n", b.a.a, b.a.b);
  return 0;
}
```
Question: Outline any issues/concerns with the implemented code.

### Answer
1. In ```class B```, ```a``` cannot be declared ```const```. The correct way to protect ```A``` from being updated through ```B``` is to change ```const``` to ```readonly``` and initialize it in the constructor before it is used.
2. The format string passed to ```Console.WriteLine()``` are using C++ syntax. Instead it should be ```Console.WriteLine("{0} {1}", ...```
3. The format string passed to ```Console.WriteLine()``` includes a newline character. ```Console.WriteLine()``` appends a newline resulting in two new lines. The newline in the format string should be removed.

```Program.cs``` contains correct code.
