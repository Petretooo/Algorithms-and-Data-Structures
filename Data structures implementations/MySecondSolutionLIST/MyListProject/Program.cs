using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            for (int i = 1; i < 11; i++)
            {
                myList.Add(i);
            }
            myList.PrintAll();
            myList.Add(5);
            myList.PrintAll();
            myList.RemoveAt(2);
            myList.RemoveAt(8);
            myList.RemoveAt(10);
            myList.PrintAll();
            myList.RemoveAll();
            myList.PrintAll();
        }
    }
}
