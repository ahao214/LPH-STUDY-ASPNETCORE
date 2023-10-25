using static System.Console;

/*
递归 
递归时每次调用都是一个全新的栈帧
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