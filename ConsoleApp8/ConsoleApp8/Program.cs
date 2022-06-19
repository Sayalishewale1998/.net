using System;
using ConsoleApp8.Models;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            CapgiContext db = new CapgiContext();
            //Table1 table1 = new Table1();
            //  table1.Ename = "Sayali";
            //db.Table1s.Add(table1);

            var data = db.Table1s;
            Console.WriteLine("Values from database");
            foreach(var item in data)
            {
                Console.WriteLine(item.Eid + " | " + item.Ename);
            }
           // Console.WriteLine("Hello World!");
        }
    }
}
