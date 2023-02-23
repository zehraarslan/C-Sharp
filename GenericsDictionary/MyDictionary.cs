using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        public MyDictionary()
        { 
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            foreach (var itemKey in _keys)
            {
                if (itemKey.Equals(key))
                {
                    Console.WriteLine("{ " + key + ": " + value + " } bu anahtar mevcut!");
                    return;
                }
            }

            TKey[] tempKeys = _keys;
            TValue[] tempValues = _values;
            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
            }
            _keys[tempKeys.Length] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                _values[i] = tempValues[i];
            }
            _values[tempKeys.Length] = value;
        }


        public TKey[] Keys
        {
            get { return _keys; }
        }

        public TValue[] Value
        {
            get { return _values; }
        }

        public void ToString()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine(_keys[i] + ": " + _values[i]);
            }
        }
    }
}
