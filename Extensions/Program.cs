using System;
using System.Collections.Generic;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(556);
            list.Add(44);
            bool t = list._IsNullOrEmpty();
            string k = "aseawk";
            k.TryGetWordFromThird(out string b);

            Console.WriteLine(list.GetMiddleElement());



            
        }
    }
}
