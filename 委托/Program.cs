using static System.Console;

Title = "委托";

/*
 
 */


Calulate del = new Calulate(Add);
WriteLine(del(1, 2));

static int Add(int a, int b)
{
    return a + b;
}

public delegate int Calulate(int x, int y);





