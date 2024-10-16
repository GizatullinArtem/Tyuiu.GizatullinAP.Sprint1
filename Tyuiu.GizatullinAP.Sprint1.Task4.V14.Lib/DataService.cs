﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GizatullinAP.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y)
        {
            var r = Math.Sqrt(7 + Math.Abs(x -y)) / (3*x*Math.Pow(y,2));
            r = Math.Round(r, 3);
            return r;
        }
    }
}
