using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeler3
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (i < 10)
            {
                listBox1.Items.Add((i + 1) + ". " + textBox1.Text);
                i++;
            }
            else {
                MessageBox.Show("10 adet veri girebilirsiniz!");
            }
        }
    }
}
