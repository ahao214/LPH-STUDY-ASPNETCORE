using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ArrayQueue<T>
    {
        // 队列数组
        private readonly T[] _items;
        private readonly int _size = 0;
        private int _head = 0;
        private int _tail = 0;

        public ArrayQueue(int size)
        {
            _items = new T[size];
            _size = size;
        }

        public bool Enqueue(T item)
        {
            if (_tail == _size)
                return false;
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
