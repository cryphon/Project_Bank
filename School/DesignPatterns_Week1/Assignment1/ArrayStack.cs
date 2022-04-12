using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArrayStack : IStack
    {
        protected int[] _StackValues;
        private int _Count;

        public ArrayStack(int n)
        {
            _StackValues = new int[n];
            _Count = 0;
        } 

        public bool Contains(int value)
        {
            for (int i = 0; i < _Count; i++)
                if (_StackValues[i] == value)
                    return true;

            return false;
        }

        public int Count => _Count;

        public bool IsEmpty() => _Count == 0;

        public int Pop()
        {
            if (_Count == 0)
                throw new InvalidOperationException("Stack is empty!");

            int last = _StackValues[_Count - 1];
            _StackValues[_Count - 1] = 0;
            _Count --;
            return last;
        }

        public void Push(int value)
        {
            if (_Count == _StackValues.Length)
                throw new InvalidOperationException("Stack is full!");

            _StackValues[_Count] = value;
            _Count++;
        }
    }
}
