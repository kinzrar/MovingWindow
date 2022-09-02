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
       
        public Form1()
        {
            InitializeComponent();

        }
        int X = 0;
        int Y = 0;
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            this.Text += (char)e.KeyValue;

            Point? newLocation = null;

            // UP
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                newLocation = new Point(this.Location.X, this.Location.Y - 50);
            }

            // DOWN
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                newLocation = new Point(this.Location.X, this.Location.Y + 50);
            }


            // LEFT
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                newLocation = new Point(this.Location.X - 50, this.Location.Y);
            }

            //RIGHT 
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                newLocation = new Point(this.Location.X + 50, this.Location.Y);
            }


            if (newLocation != null)
            {
                if (Screen.PrimaryScreen.Bounds.Contains(new Rectangle(newLocation.Value, this.Size)))
                {
                    this.Location = newLocation.Value;
                }
            }
        }
    }
}
