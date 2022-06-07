using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    interface Vehicle
    {
        void ChangeGear(int a);
        void SpeedUp(int a);
        void ApplyBreaks(int a);
    }
    class Bicycle :Vehicle
    {
        int speed;
        int gear;
        public void ApplyBreaks(int decrement)
        {
            speed = speed - decrement;
        }
        public void ChangeGear(int newgear)
        {
            gear=newgear;
        }
        public void SpeedUp(int increment)
        {
            speed = speed +increment;
        }
        public void PrintStates()
        {
            Console.WriteLine("Bicycle speed"  + speed +  "Bicycle Gear :" + gear);
        }
    }
    class Bike: Vehicle
    {
        int speed;
        int gear;
        public void ApplyBreaks(int decrement)
        {
            speed = speed - decrement;
        }
        public void ChangeGear(int newgear)
        {
            gear = newgear;
        }
        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
        public void PrintStates()
        {
            Console.WriteLine("Bike speed" + speed + "Bike Gear :" + gear);
        }
    }
    class Class7
    {
        public static void Main()
        {
            Bicycle b = new Bicycle();
            b.ChangeGear(2);
            b.ApplyBreaks(1);
            b.SpeedUp(3);
            b.PrintStates();


            Bike s = new Bike();
            s.ChangeGear(1);
            s.ApplyBreaks(4);
            s.SpeedUp(3);
            s.PrintStates();

        }
    }
}
