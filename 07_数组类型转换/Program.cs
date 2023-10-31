using static System.Console;

Title = "数组类型转换";


#region 数组类型转换 1对1

// 方法一，循环处理 转化为字符串数组
int[] arri = {12,3,4,5,6,798,90};
string[] arrs = new string[arri.Length];
for(int i = 0;i< arri.Length;i++)
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
for(int i = 0;i< arrI.Length;i++)
{
    byte[] temp = BitConverter.GetBytes(arrI[i]);
    Array.Copy(temp, 0, result, i * sizeof(int), temp.Length);
}

// 更简单的方法


#endregion



#region


#endregion



#region



#endregion