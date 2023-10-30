using static System.Console;

Title = "数组复制";


string[] names = { "妲己", "姜子牙", "后羿", "亚瑟王" };

// 复制方法一
string[] arrOne = new string[names.Length];
for (int i = 0; i < names.Length; i++)
{
    arrOne[i] = names[i];
}


// 复制方法二
string[] arrTwo = new string[names.Length];

names.CopyTo(arrTwo, 0);


// 复制方法三
string[] arrThree = new string[names.Length];
// 源数组 目标数组 数目
Array.Copy(names, arrThree, names.Length);
// 源数组 源开始 目标数组 目标开始 数目
Array.Copy(names, 0, arrThree, 0, names.Length);

// 复制方法四
string[] arrFour;
arrFour = (string[])names.Clone();




