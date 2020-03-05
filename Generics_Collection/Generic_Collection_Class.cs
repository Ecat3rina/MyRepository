using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Collection
{
    class Generic_Collection_Class<T>
    {
        private T[] array;

        public Generic_Collection_Class(int size)
        {
            array = new T[size + 1];
        }
        public T GetItem(int index)
        {
            return array[index];
        }
        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
        public void Swap<T>(ref T a, ref T b)
        {
            T temp;

            temp = a;
            a = b;
            b = temp;
        }
    }
}