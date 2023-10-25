using static System.Console;

/*
递归 
*/

Recursion(5);


static void Recursion(int a)
{
    Recursion(a);
    if (a == 0)
    {
        return;
    }
    else
    {
        Recursion(a - 1);
    }

    WriteLine($"a={a}");
}