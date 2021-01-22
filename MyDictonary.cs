using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary <T>
    {
        T[] things;
        public MyDictonary()
        {
            things = new T[0];
        }
        public void Add(T thing)
        {
            T[] temp = things;
            things = new T[things.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                things[i] = temp[i];
            }
            things[things.Length - 1] = thing;
        }
    }
}
