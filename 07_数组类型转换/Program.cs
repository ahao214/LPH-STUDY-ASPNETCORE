using System.Text;
using static System.Console;

Title = "数组类型转换";


#region 数组类型转换 1对1

// 方法一，循环处理 转化为字符串数组
int[] arri = { 12, 3, 4, 5, 6, 798, 90 };
string[] arrs = new string[arri.Length];
for (int i = 0; i < arri.Length; i++)
{
    arrs[i] = arri[i].ToString();
}


// 方法二 使用Array.ConvertAll()
int[] arrt = { 12, 3, 4, 5, 6, 798, 90 };
string[] arrTS = Array.ConvertAll(arrt, i => i.ToString());
double[] arrd = Array.ConvertAll(arri, i => Convert.ToDouble(i));

#endregion



#region 数组转化为byte[] 1对多

// byte[] 是常用的一种数据类型 程序中经常需要转化为这种类型
// BitConverter可将基本数据类型转换为一个字节数组
// 也可将一个字节数组转换为基本数据类型

int[] arrI = { 12, 23, 4, 5, 6, 21, 67, 98 };
byte[] result = new byte[arrI.Length * sizeof(int)];
for (int i = 0; i < arrI.Length; i++)
{
    // 单个转换
    byte[] temp = BitConverter.GetBytes(arrI[i]);
    // 拼接
    Array.Copy(temp, 0, result, i * sizeof(int), temp.Length);
}

// 更简单的方法
byte[] result1 = new byte[arrI.Length * sizeof(int)];
Buffer.BlockCopy(arrI, 0, result1, 0, result1.Length);

// 小端转大端 字节序反转
byte[] result2 = new byte[arrI.Length * sizeof(int)];
for (int i = 0; i < arrI.Length; i++)
{
    // 单个转换
    byte[] temp = BitConverter.GetBytes(arrI[i]);
    if (BitConverter.IsLittleEndian)
        Array.Reverse(temp);    // 小端转大端
    Array.Copy(temp, 0, result2, i * sizeof(int), temp.Length); // 拼接
}

// 使用BitConverter.ToString()可以显示转换结果
WriteLine(BitConverter.ToString(result));
WriteLine(BitConverter.ToString(result1));
WriteLine(BitConverter.ToString(result2));



#endregion



#region 字符串转字节数组

// 字符串转字节数组 字符串转字节数组不是固定的一对多，而是按编码方案转换
string str = "Excel梦想家";
byte[] buff = Encoding.UTF8.GetBytes(str);  // 编码
WriteLine(BitConverter.ToString(buff));


// 字节数组转字符(用什么编码，就用什么解码)
string str2 = Encoding.UTF8.GetString(buff);
WriteLine(str2);


#endregion



#region



#endregion