using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Lab9
{
    class Parallelogram : IParallelogramModel
    {
        double a;
        double b;
        double alfa;

        public Parallelogram(double a, double b, double alfa)
        {
            this.a = a;
            this.b = b;
            this.alfa = alfa;
        }
        public Parallelogram()
        {
            this.a = 10;
            this.b = 12;
            this.alfa = 60;
        }

        public double H()
        {
            return (b * Math.Sin(Radians(alfa)));
        }

        public double S()
        {
            return (a * b * Math.Sin(Radians(alfa)));
        }

        private double Radians(double angle)
        {
            return angle * Math.PI / 180.0;
        }
    }
}
