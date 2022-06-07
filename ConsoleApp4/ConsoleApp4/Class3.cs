using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int _age)
        {
            age = _age;
        }

        }
    class student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void Showage()
        {
            Console.WriteLine("My age is :" + age);
         }
    }
    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class Class3
    {
        public static void Main8()
        {
            Person p = new Person();
            p.Greet();
            student s = new student();
            s.SetAge(24);
            s.Greet();
            s.Showage();
            Teacher t = new Teacher();
            t.SetAge(50);
            t.Greet();
            t.Explain();
        }
    }
}
