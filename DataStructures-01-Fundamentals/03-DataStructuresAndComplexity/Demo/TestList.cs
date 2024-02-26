using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class TestList<T>
    {
        public TestList()
        {
            init();    
        }
        private T[] init()
        {
            T[] array = new T[4];
            return array;
        }
        public void Add(T valueToAdd)
        {

        }
    }
}
