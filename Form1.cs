﻿using System;
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
        private int r1, r2;
        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[400];
        private Label scoreLabel;
        private int dirX, dirY;
        private int _width = 700;
        private int _height = 600;
        private int _sizeOfSides = 20;
        private int score=0;
        public Form1()
        {
            InitializeComponent();
            this.Width = _width;
            this.Height = _height;
            dirX = 1;
            dirY = 0;
            scoreLabel = new Label();
            scoreLabel.Text = "Score: 0";
            scoreLabel.Location = new Point(530, 20);
            scoreLabel.BackColor = Color.White;
            this.Controls.Add(scoreLabel);
            snake[0] = new PictureBox();
            snake[0].Location = new Point(20, 20);
            snake[0].Size = new Size(_sizeOfSides, _sizeOfSides);
            snake[0].BackColor = Color.Cyan;
            this.Controls.Add(snake[0]);
            fruit = new PictureBox();
            fruit.Size = new Size(20, 20);
            fruit.BackColor = Color.PaleVioletRed;
             fruit.Location = new Point();
            _generateMap();
            _generateFruit();
            timer1.Tick += new EventHandler(_update);
            timer1.Interval = 500;
            timer1.Start();
            this.KeyDown += new KeyEventHandler(OKP);
        }
        private void _generateFruit()
        {
            Random r = new Random();
            r1 = r.Next(20, 500);
            int temp1 = r1 % 20;
            r1 -= temp1;
            r2 = r.Next(20, 500);
            int temp2 = r2 % 20;
            r2 -= temp2;
            fruit.Location = new Point(r1, r2);
            this.Controls.Add(fruit);

        }
        private void _eatFruit()
        {
            if (snake[0].Location.X == r1 && snake[0].Location.Y == r2)
            {
                scoreLabel.Text = "Score: " + ++score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 20 * dirX, snake[score - 1].Location.Y - 20 * dirY);
                snake[score].Size = new Size(_sizeOfSides, _sizeOfSides);
                snake[score].BackColor = Color.Red;
                this.Controls.Add(snake[score]);
                _generateFruit();
            }
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
        private void _moveSnake()
        {
            for(int i=score; i >= 0; i--)
            {
                snake[i].Location = new Point(snake[i].Location.X + dirX * _sizeOfSides, snake[i].Location.Y + dirY * _sizeOfSides);
            }
        }
        private void _update(object myObject, EventArgs eventArgs)
        {
            _eatFruit();
            _moveSnake();
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
