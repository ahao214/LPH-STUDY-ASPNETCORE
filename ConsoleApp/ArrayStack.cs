using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ArrayStack<T>
    {
        //栈数组
        private readonly T[] _items;

        //栈的大小
        private readonly int _size;

        //栈中的元素个数
        private int _count;


        public ArrayStack(int size)
        {
            _items = new T[size];
            _size = size;
        }


        public bool Push(T item)
        {
            // 判断栈数组空间 如果满了就是
            if (_count == _size)
                return false;
            _items[_count++] = item;
            return true;
        }


        public T Pop()
        {
            if (_count == 0)
                return default;
            var tmp = _items[_count - 1];
            _count--;
            return tmp;
        }



    }
}
