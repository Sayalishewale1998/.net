using ConsoleApp6.Models;

using System;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            SampleDB3Context db = new SampleDB3Context();
            Tblsample3 tblsample3 = new Tblsample3();
            tblsample3.Text = "Sayali";
            db.Tblsample3s.Add(tblsample3);
            db.SaveChanges();
              Console.WriteLine("Hello World!");
        }
    }
}
