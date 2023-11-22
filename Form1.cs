using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new transilvania();
            newform.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new moldova(); 
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newform = new dobrogea(); 
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newform = new muntenia(); 
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newform = new bucovina(); 
            newform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newform = new oltenia(); 
            newform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newform = new maramures(); 
            newform.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newform = new crisana(); 
            newform.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var newform = new banat(); 
            newform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
