using System;
class A {
    public virtual void func() {
        Console.WriteLine("class A statement printed");
    }
}
class B : A {
    public override void func() {
        base.func();
        Console.WriteLine("class B statement printed");
    }
}
class C : B {
    public override void func() {
        base.func();
        Console.WriteLine("class C statement printed");
    }
}
class MultilevelInheritanceEx {
    public static void Main(string[] args) {
        C cobj=new C();
        cobj.func();
    }
}
