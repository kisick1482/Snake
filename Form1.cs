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
        private int dirX, dirY;
        private int _width = 700;
        private int _height = 600;
        private int _sizeOfSides = 20;
        public Form1()
        {
            InitializeComponent();
            this.Width = _width;
            this.Height = _height;
            dirX = 1;
            dirY = 0;
            _generateMap();
            timer1.Tick += new EventHandler(_update);
            timer1.Interval = 500;
            timer1.Start();
            this.KeyDown += new KeyEventHandler(OKP);
        }
        private void _generateMap()
        {
            for(int i = 1; i <= _width / 28; i++)
            {
                PictureBox picb = new PictureBox();
                picb.BackColor = Color.DarkGreen;
                picb.Location = new Point(20, _sizeOfSides * i);
                picb.Size = new Size(_width - 200, 1);
                this.Controls.Add(picb);
            }
            for (int i = 1; i < _height / 23; i++)
            {
                PictureBox picb = new PictureBox();
                picb.BackColor = Color.DarkGreen;
                picb.Location = new Point( _sizeOfSides * i, 20);
                picb.Size = new Size(1, _height - 100);
                this.Controls.Add(picb);
            }
        }
        private void _update(object myObject, EventArgs eventArgs)
        {
            cube.Location = new Point(cube.Location.X + dirX * _sizeOfSides, cube.Location.Y + dirY * _sizeOfSides);
        }
        private void OKP(object sender, KeyEventArgs e)
            {
                switch (e.KeyCode.ToString())
                {
                    case "Right":
                        dirX = 1;
                        dirY = 0;
                        break;
                    case "Left":
                        dirX = -1;
                        dirY = 0;
                        break;
                    case "Up":
                        dirX = 0;
                        dirY = -1;
                        break;
                    case "Down":
                        dirX = 0;
                        dirY = 1;
                        break;
            }
        }
            private void cube_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
