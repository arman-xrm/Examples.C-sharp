using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class MathClass
    {
        public delegate void myDelegate(double num1, double num2);

        public void Sum(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void Pow(double num1, double num2)
        {
            double numPow = 1;
            
            for (int i = 0; i < num2; i++)
            {
                numPow *= num1;
            }
            Console.WriteLine(numPow);
        }
        public static void Div(double num1, double num2)
        {
            Console.WriteLine((num1 / num2));
        }
        public double Sum (double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }  
        public static double Div(double num1,double num2, double num3)
        {
            return num1 / num2 / num3;
        }
    }
}
