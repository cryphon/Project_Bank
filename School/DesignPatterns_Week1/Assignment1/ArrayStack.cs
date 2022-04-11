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

        public int Count() => _Count;

        public bool IsEmpty() => _Count == 0;

        public int Pop()
        {
            if (_Count == 0)
                throw new InvalidOperationException("Stack is empty!");

            int value = _StackValues[_Count - 1];
            int[] newArray = new int[_Count - 1];
            for (int i = 0; i < _Count - 1; i++)
                newArray[i] = _StackValues[i];

            _StackValues = newArray;
            _Count --;
            return value;
        }

        public void Push(int value)
        {
            int[] newArray = new int[_Count + 1];
            for (int i = 0; i < _Count; i++)
                newArray[i] = _StackValues[i];

            newArray[_Count] = value;
            _StackValues = newArray;
            _Count++;
        }
    }
}
