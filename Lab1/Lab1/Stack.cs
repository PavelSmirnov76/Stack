using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab1
{
    public class Stack<T> : IEnumerable, IEquatable<Stack<T>>
    {
        private T[] _Array;
        private int _Size;

        public Stack()
        {
            _Array = new T[1000];
            Size = 0;
        }
        private void Resize(int item)
        {
            if (IsFull())
                Array.Resize(ref _Array, _Array.Length * 2);
            Size+=item;
        }
        public int Size
        {
            get
            { 
                return _Size;
            }
            private set
            {
                _Size = value;
            }
               
        }
        public bool IsFull()
        {
            return _Array.Length == this._Size;
        }
        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void Push(T item)
        {
            Resize(1);
            _Array[Size-1] = item;

        }
        public T Pop()
        {           
            if (IsEmpty())
                throw new Exception("Стек пуст.");
            Resize(-1);
            return _Array[Size];
        }
        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Стек пуст.");
            var item = _Array[Size - 1];
            return item;
        }
        public bool Contains(T item)
        {
            foreach(T c in _Array)
            {
                if (c.Equals(item))
                    return true;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            if (this.IsEmpty())
                throw new Exception("Стек пуст.");
            for (int i = Size; i > 0; i--)
                yield return _Array[i - 1];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Equals([AllowNull] Stack<T> item)
        {
            if (this.IsEmpty())
                throw new Exception("Стек пуст.");
            if (item == null) return false;
            Stack itemAsPart = item as Stack;
            if (itemAsPart == null) return false;
            else return Equals(itemAsPart);
        }
    }
}
