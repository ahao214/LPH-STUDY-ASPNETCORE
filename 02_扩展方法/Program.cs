
// 扩展方法
// 扩展方法必须写在静态类中，并且该类中的方法必须是静态方法
// 如何给string增加一些方法



var text = "";

if (text.IsNotNullOrEmpty())
{

}

text.Append("").Append("");


public static class StringExtensions
{
    public static bool IsNotNullOrEmpty(this string value)
    {
        return !string.IsNullOrEmpty(value);
    }

    public static string Append(this string value,string text)
    {
        return value + text;
    }
}