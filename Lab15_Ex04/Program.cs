using static System.Console;

var b = new Base();
var d1 = new Derived_1();
var d2 = new Derived_2();

b.A();   // Base.A() จะถูกเรียก
d1.A();  // Derived_1.A() จะถูกเรียก
d2.A();  // Derived_2.A() จะถูกเรียก

class Base
{
    // เมธอด A ใน Base สามารถถูก override ได้
    public virtual void A()
    {
        WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    // Override เมธอด A ใน Derived_1
    public override void A()
    {
        WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    // Override เมธอด A ใน Derived_2
    public override void A()
    {
        WriteLine("Derived_2.A()");
    }
}
