using System;
using System.Collections.Generic;
using System.Text;

namespace Map
{
    class KeyValuePair<TKey, TValue>
    {
        private TKey key;
        private TValue value;
        public KeyValuePair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
        public TKey Key
        {
            get
            {
                return this.key;
            }
        }
        public TValue Value
        {
            get
            {
                return this.value;
            }
        }
    }



    public class HashMap<K,V>
    {

        private List<KeyValuePair<K,V>>[] table;
        private int Size = 100;

        public HashMap()
        {
            table = new List<KeyValuePair<K, V>>[Size];
        }
        private int GetHash(K key)
        {
            return Math.Abs(key.GetHashCode() % this.table.Length);
        }

        private List<KeyValuePair<K, V>> FindChain(K key, bool createIfMissing)
        {
            int index = GetHash(key);
            if(this.table[index] == null && createIfMissing)
            {
                this.table[index] = new List<KeyValuePair<K, V>>();
            }
            return this.table[index] as List<KeyValuePair<K, V>>;
        }

        public V Add(K key, V value)
        {
            List<KeyValuePair<K, V>> chain = this.FindChain(key, true);
            for (int i = 0; i < chain.Count; i++)
            {
                KeyValuePair<K, V> entry = chain[i];
                if (entry.Key.Equals(key))
                {
                    KeyValuePair<K, V> newEntry = new KeyValuePair<K, V>(key, value);
                    chain[i] = newEntry;
                    return entry.Value;
                }
            }
            chain.Add(new KeyValuePair<K, V>(key, value));
            return default(V);
        }
        public V Get(K key)
        {
            List<KeyValuePair<K, V>> chain = this.FindChain(key, false);
            if(chain != null)
            {
                foreach(KeyValuePair<K,V> entry in chain)
                {
                    if (entry.Key.Equals(key))
                    {
                        return entry.Value;
                    }
                }
            }
            return default(V);
        }

    }
}