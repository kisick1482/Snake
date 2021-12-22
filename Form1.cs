using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OKP);
        }
            private void OKP(object sender, KeyEventArgs e)
            {
                MessageBox.Show(e.KeyCode.ToString());
                switch (e.KeyCode.ToString())
                {
                    case "Right":
                       cube.Location = new Point(cube.Location.X + 20, cube.Location.Y);
                       break;
                    case "Left":
                        cube.Location = new Point(cube.Location.X - 20, cube.Location.Y);
                        break;

                    case "Up":
                        cube.Location = new Point(cube.Location.X, cube.Location.Y - 20);
                        break;
                    case "Down":
                        cube.Location = new Point(cube.Location.X, cube.Location.Y + 20);
                        break;
            }
        }
            private void cube_Click(object sender, EventArgs e)
        {

        }
    }
}
