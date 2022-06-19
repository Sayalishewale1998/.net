using System;
using Console8.Models;
using System.Linq;


namespace Console8
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDB1Context db = new SampleDB1Context();
            Tblsample tblsample = new Tblsample();
            tblsample.Text = "Sayali";
            db.Tblsamples.Add(tblsample);

            Console.WriteLine("Hello World!");
        }
    }
}
