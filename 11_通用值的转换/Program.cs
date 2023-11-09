using static System.Console;

// 通用值的转换

var result = "2023-1-1".Parse<DateTime?>();

WriteLine($"值是：{result},数据类型是：{result.GetType().Name}");

ReadKey();


public static class Extensions
{
    public static T Parse<T>(this object value)
    {
        var type = typeof(T);
        var nullableType = Nullable.GetUnderlyingType(type);
        if (nullableType is not null)
        {
            return (T)Convert.ChangeType(value, nullableType);
        }

        return (T)Convert.ChangeType(value, type);
    }

}