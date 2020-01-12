using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericList<String> b = new GenericList<string>();

            b.Add("1gaga");
            b.Add("2gaga");
            b.Add("3gaga");
            b.Add("4gaga");
            b.Add("5gaga");
            b.Add("6gaga");
            b.Add("7gaga");
            b.Add("8gaga");
            b.Add("gaga22");
            b.Add("gagafdf");
            b.Add("gaga333");
            b.Add("gaga44");


            b.PrintAll();




            GenericList<Double> a = new GenericList<Double>();
            for (int i = 1; i < 11; i++)
            {
                a.Add(i);
            }
            a.PrintAll();
            a.Add(5);
            a.PrintAll();
            a.RemoveAt(2);
         //   a.RemoveAt(8);
         //   a.RemoveAt(10);
            a.PrintAll();
            a.RemoveAll();
            a.PrintAll();





            /*

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
            my
            List.PrintAll();
            */
        }
    }
}
