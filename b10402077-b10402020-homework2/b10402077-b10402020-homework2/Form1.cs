using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b10402077_b10402020_homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            comboBox1.Items.Clear();
            Class1 random_num = new Class1();
            Class2 prime_num = new Class2();
            n = random_num.RandomNum();
            label1.Text = "" + n;
            for(int i=2;i<=n;i++)
            {
                if (prime_num.PrimeNum(i) == true) comboBox1.Items.Add(i);
            }
        }
    }
}
