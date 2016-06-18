using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F4_ATIS_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            about.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var editprompt = new EditATISForm();
            editprompt.Show();
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startATISButton_Click(object sender, EventArgs e)
        {

        }
    }
}
