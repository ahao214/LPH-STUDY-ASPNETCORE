using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ArrayQueue1<T>
    {
        // 队列数组
        private readonly T[] _items;
        private readonly int _size = 0;
        // 头部
        private int _head = 0;
        // 尾部
        private int _tail = 0;

        public ArrayQueue1(int size)
        {
            _items = new T[size];
            _size = size;
        }

        public bool Enqueue(T item)
        {
            if (_tail == _size)
            {
                // 整个队列都满了
                if (_head == 0)
                    return false;
                for(var i = _head;i< _tail;i++)
                {
                    _items[i - _head] = _items[i]; 
                }
                // 搬完以后重新更新heand和tail
                _tail -= _head;
                _head = 0;
            }
            _items[_tail++] = item;
            return true;
        }


        public T Dequeue()
        {
            if (_head == _tail)
                return default;
            var res = _items[_head];
            return res;
        }

    }
}
