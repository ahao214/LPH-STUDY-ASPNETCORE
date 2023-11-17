using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Ant_Linq
{
    /// <summary>
    /// IEnumerable 可枚举类型--可迭代类型
    /// IEnumerable 枚举器
    /// 
    /// Enum 枚举
    /// </summary>
    public class IEnumerableShow
    {
        public void Show()
        {
            int[] array = { 12, 3, 4, 56, 67 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

    }

    class Student:IEnumerable
    {
        public int Id { get; set; }

        public IEnumerator GetEnumerator()
        {
            yield return "block编程";
        }
    }
}
