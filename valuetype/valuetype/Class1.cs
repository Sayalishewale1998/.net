using System;
using System.Collections.Generic;
using System.Text;

namespace valuetype
{
    class Employee

    {
            public string  Name;
            public int  ID;
            public string  Gender;
            public int Salary;
    }
    
            static void Main5(string[] args)
    {
        Employee s = new Employee();
        s. Name = "sayali";
        s.ID = 123564;
        s.Gender = "Female";
        s.Salary = 20000;
        Console.WriteLine("Employee Details Are :");
        Console.WriteLine("Name :");
        Console.WriteLine("ID :");
        Console.WriteLine("Gender :");
        Console.WriteLine("Salary:");
    }
}

