using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DelegateMath
{
    public class DelegateMath
    {
        public delegate double MyDelegate(double x);

        public DelegateMath()
        {
            MyDelegate myDelegateSquare = new MyDelegate(Square);
            MyDelegate myDelegateDoubleUp =  new MyDelegate(DoubleUp);

            List<double> myDoubles = new List<double>( 
                new double []
                {
                    10.5,
                    1.6,
                    2.3,
                    3.78,
                    2.8
                });

            foreach (var myDouble in myDoubles)
            {
                Display(myDelegateSquare, myDouble);
            }

            foreach (var myDouble in myDoubles)
            {
                Display(myDelegateDoubleUp, myDouble);
            }
        }

        public double Square(double num)
        {
            num *= num;
            return num;
        }

        public double DoubleUp(double num)
        {
            num *= 2;
            return num;
        }

        public double Display(MyDelegate myDelegate, double num)
        {
            num = myDelegate(num);
            Console.WriteLine(num);
            return num;
        }
    }
}