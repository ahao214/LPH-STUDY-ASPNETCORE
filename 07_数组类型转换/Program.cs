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




#endregion



#region


#endregion



#region



#endregion