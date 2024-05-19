using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB9
{
    public partial class View : Form
    {
        ControllerParallelogram controller = new ControllerParallelogram();

        public View()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                var alfa = Convert.ToDouble(textBox3.Text);
                label7.Text = controller.QuestionH(a, b, alfa).ToString();
                label9.Text = controller.QuestionS(a, b, alfa).ToString();
            }
            catch { MessageBox.Show("ERROR INPUT"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
