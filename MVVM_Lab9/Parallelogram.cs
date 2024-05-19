using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lab9
{
    internal class Parallelogram
    {
        double a;
        double b;
        double alfa;

        public Parallelogram()
        {
            this.a = 10;
            this.b = 12;
            this.alfa = 60;
        }

        public Parallelogram(double a, double b, double alfa)
        {
            this.a = a;
            this.b = b;
            this.alfa = alfa;
        }

        public double H
        {
            get { return (b * Math.Sin(Radians(alfa))); }
        }

        public double S
        {
            get { return (a * b * Math.Sin(Radians(alfa))); }
        }

        private double Radians(double angle)
        {
            return angle * Math.PI / 180.0;
        }
    }
}
