using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WORDLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(textBox1.Text);
            if(num <= 3)
            {
                MessageBox.Show("The Number must be greater than 3!");
            }
            else 
            {
                this.Visible= false;
                Form2 newform = new Form2(num);
                newform.Show();
            }
        }
    }
}
