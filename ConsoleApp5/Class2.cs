using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp5
{
    class Class2
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);

            }
        }
    }
}
