using System;

namespace Open_Lab_01._04
{
    public class Triangle
    {
        public double Area(double foundation, double height)
        {
           int a = Convert.ToInt32(foundation);
            int b = Convert.ToInt32(height);
            double Area = a + b;
            return Area;
        }
    }
}