using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVM_Lab9
{
    class MainVM : INotifyPropertyChanged
    {
        private double _number1;
        private double _number2;
        private double _number3;
        public double Number1
        {
            get { return _number1; }
            set { _number1 = value; OnPropertyChanged("Number4"); OnPropertyChanged("Number5"); }
        }
        public double Number2
        {
            get { return _number2; }
            set { _number2 = value; OnPropertyChanged("Number4"); OnPropertyChanged("Number5"); }
        }
        public double Number3
        {
            get { return _number3; }
            set { _number3 = value; OnPropertyChanged("Number4"); OnPropertyChanged("Number5"); }
        }
        public double Number4
        {
            get
            {
                var parallelogram = new Parallelogram(Number1, Number2, Number3);
                return parallelogram.H;
            }
        }
        public double Number5
        {
            get
            {
                var parallelogram = new Parallelogram(Number1, Number2, Number3);
                return parallelogram.S;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

