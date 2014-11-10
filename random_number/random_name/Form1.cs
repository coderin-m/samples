using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            Random num = new Random(); 
            int n = num.Next(0, 100); 

            MessageBox.Show(n.ToString()); 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            names.Add(this.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
