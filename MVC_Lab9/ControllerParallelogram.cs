using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    internal class ControllerParallelogram
    {
        public double QuestionH(double a, double b, double alfa)
        {
            var parallelogram = new Parallelogram(a, b, alfa);
            return parallelogram.H;
        }
        public double QuestionS(double a, double b, double alfa)
        {
            var parallelogram = new Parallelogram(a, b, alfa);
            return parallelogram.S;
        }
    }
}

