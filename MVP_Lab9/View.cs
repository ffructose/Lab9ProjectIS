using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Lab9
{
    public partial class View : Form, IParallelogramView
    {
        private ParallelogramPresenter presenter;
        public View()
        {
            InitializeComponent();

            presenter = new ParallelogramPresenter(this, new Parallelogram());
        }

        void IParallelogramView.SetH(double a)
        {
            label5.Text = a.ToString();
        }

        void IParallelogramView.SetS(double a)
        {
            label7.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.LoadParallelogram(Convert.ToDouble(textBox1.Text), 
                Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
