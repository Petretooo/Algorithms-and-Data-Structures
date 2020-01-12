using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplaHashTable
{
    class Program
    {
        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public Person(int Age, string Name)
            {
                this.Age = Age;
                this.Name = Name;
            }

            public override string ToString()
            {
                return String.Format("Name: {0}, Age: {1}", Name, Age);
            }
        }

        public class HashEntry
        {
            public int Key { get; set; }
            public Person Value {get; set;}

            public HashEntry(int Key, Person Value)
            {
                this.Key = Key;
                this.Value = Value;
            }
        }

        public class HashMap
        {
            private const int TABLE_SIZE = 100;

            private HashEntry[] table;

            public HashMap()
            {
                table = new HashEntry[TABLE_SIZE];
                for(int i=0; i< TABLE_SIZE; i++)
                {
                    table[i] = null;
                }
            }

            public void insert(int Key, Person Value)
            {
                int hash = (Key % TABLE_SIZE);

                while (table[hash] != null && table[hash].Key != Key)
                {
                    hash = (hash + 1) % TABLE_SIZE;
                }

                table[hash] = new HashEntry(Key, Value);
            }

            public Person get(int Key)
            {
                int hash = (Key % TABLE_SIZE);

                while (table[hash] != null && table[hash].Key != Key)
                {
                    hash = (hash + 1) % TABLE_SIZE;
                }

                if (table[hash] != null)
                {
                    return table[hash].Value;
                }
                return null;
            }
        }

        static void Main(string[] args)
        {
            HashMap map = new HashMap();
            map.insert(7, new Person(25, "Ivan"));
            map.insert(9, new Person(170, "Petar"));
            map.insert(220, new Person(200, "Stoyan"));


            Console.WriteLine("Searching for key 9: {0}", map.get(9));
            Console.WriteLine("Searching for key 15: {0}", map.get(15));

            Console.ReadKey();
        }
    }
}
