using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1=Convert.ToDouble(textBox1.Text);
            //label2.Text =Convert.ToString( Math.Abs(n1));
            //label2.Text = Math.Ceiling(n1).ToString();
            //label2.Text = Math.Floor(n1).ToString();
            //label2.Text = Math.Pow(n1,3).ToString();
            label2.Text=Math.Sqrt(n1).ToString();
        }
    }
}
