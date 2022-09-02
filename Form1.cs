using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        DateTime timeStarted;
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e) {this.Text = (DateTime.Now - timeStarted).Milliseconds.ToString();}

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeStarted = DateTime.Now;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)  { timer1.Stop(); }
    }
}
