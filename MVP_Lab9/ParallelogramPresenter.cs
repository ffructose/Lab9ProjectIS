using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Lab9
{
    class ParallelogramPresenter
    {
        private readonly IParallelogramView view;
        private readonly IParallelogramModel model;


        public ParallelogramPresenter(IParallelogramView view, IParallelogramModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadParallelogram(double a, double b, double alfa)
        {
            var parallelogram = new Parallelogram(a, b, alfa);
            view.SetH(parallelogram.H());
            view.SetS(parallelogram.S());
        }
    }
}
