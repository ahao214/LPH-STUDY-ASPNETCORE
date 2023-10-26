using static System.Console;

/*
静态构造方法的使用

1、在使用任何其他静态成员和创建类的任何实例之前运行
2、方法名称和类名相同并且不能有返回值
3、只能有一个、不能带参数
4、不能访问实例方法
5、不能手动调用,系统会自动调用

如果没有显示定义静态构造方法,则编译器会自动生成一个默认的
 */

RandomNumber a = new RandomNumber();
RandomNumber b = new RandomNumber();
WriteLine(a.GetRandomNumber());
WriteLine(b.GetRandomNumber());



class RandomNumber
{
    private static Random RandomKey;

    static RandomNumber()
    {
        RandomKey = new Random();
    }

    public int GetRandomNumber()
    {
        return RandomKey.Next();
    }

}