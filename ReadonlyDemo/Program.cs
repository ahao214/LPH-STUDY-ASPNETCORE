using static System.Console;

Title = "Readonly只读修饰符";





class Shape
{
    readonly double PI = 3.1415;
    readonly int NumberOfSides;

    public Shape(double side1, double side2)
    {
        //4条边表示矩形
        NumberOfSides = 4;
    }

    public Shape(double side1, double side2, double side3)
    {
        //3条边表示三角形
        NumberOfSides = 3;
    }

}