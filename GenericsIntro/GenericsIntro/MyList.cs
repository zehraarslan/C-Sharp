using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        private object get;

        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[tempArray.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[tempArray.Length] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
