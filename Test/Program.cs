internal class Program
{
    private static void Main(string[] args)
    {

        A a = new A();
        A b = new B();
        A c = new C();
        A d = new D();

        //Console.WriteLine(a.ValueA());
        //Console.WriteLine(a.ValueB());

        //Console.WriteLine(b.ValueA());
        //Console.WriteLine(b.ValueB());

        //Console.WriteLine(c.ValueA());
        //Console.WriteLine(c.ValueB());

        //Console.WriteLine(d.ValueA());
        //Console.WriteLine(d.ValueB());

    }



}



public class A
{
    public string ValueA() => "A ni A funuksiyasin ishlatdim";
    public virtual string ValueB() => "A ni B funuksiyasin ishlatdim";
}

public class B : A
{
    public string ValueA() => "B ni A funuksiyasin ishlatdim";
    public override string ValueB() => "B ni B funuksiyasin ishlatdim";
}

public class C : B
{
    public new string ValueA() => "C ni A funuksiyasini ishlatdi";
    public override string ValueB() => "C ni B funuksiyasini ishlatdi";
}


public class D : B
{
    public new string ValueA() => "D ni A funuksiyasini ishlatdi";
    public override string ValueB() => "D ni B funuksiyasini ishlatdi";
}