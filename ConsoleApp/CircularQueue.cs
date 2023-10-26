using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CircularQueue<T>
    {
        // 循环队列
        private readonly T[] _items;
        private readonly int _size;
        private int _head;
        private int _tail;

        public CircularQueue(int size)
        {
            _items = new T[size];
            _size = size;
        }


        public bool Enqueue(T item)
        {
            // 队满的条件
            if ((_tail + 1) % _size == _head)
                return false;
            _items[_tail] = item;
            _tail = (_tail + 1) % _size;
            return true;
        }

        public T Dequeue()
        {
            if (_head == _tail)
                return default;
            var item = _items[_head];
            _head = (_head + 1) % _size;
            return item;
        }
    }
}
