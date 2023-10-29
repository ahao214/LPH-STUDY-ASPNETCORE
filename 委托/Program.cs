using static System.Console;

Title = "委托";

/*
 委托的好处
灵活、可重用、可维护
 */


Calulate del = new Calulate(Add);
WriteLine(del(1, 2));

MyClass.Call(Sub);

static int Add(int a, int b)
{
    return a + b;
}

static int Sub(int a, int b)
{
    return a - b;
}


class MyClass
{
    public static void Call(Calulate del)
    {
        WriteLine(del(1, 2));
    }
}

public delegate int Calulate(int x, int y);






