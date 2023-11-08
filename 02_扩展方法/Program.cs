
// 扩展方法

var text = "";

if (text.IsNotNullOrEmpty())
{

}


public static class StringExtensions
{
    public static bool IsNotNullOrEmpty(this string value)
    {
        return !string.IsNullOrEmpty(value);
    }
}