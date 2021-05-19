using System;
using System.Runtime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game3
{
    public partial class Form1 : Form
    {
        int speed = 5;
        int gravity = 7;
        int score = 0;
        int rnd;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            downWall.Left -= speed;
            upperWall.Left -= speed;
            gravity++;

            if (downWall.Left < -downWall.Width)
            {
                MakeNewWalls();
                score++;
                scoreText.Text = score.ToString();
            }

            if (bird.Bounds.IntersectsWith(upperWall.Bounds) ||
                bird.Bounds.IntersectsWith(downWall.Bounds) ||
                bird.Top + bird.Height < 0 || bird.Top + bird.Height > 565)
                timer1.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

            if (e.KeyCode == Keys.Enter)
                RestartGame();
        }

        private void RestartGame()
        {
            scoreText.Text = "score:";
            gravity = -10;
            bird.Top = 165;
            score = 0;
            MakeNewWalls();
            timer1.Start();
        }

        private void MakeNewWalls()
        {
            rnd = rand.Next(150, 550);
            downWall.Left = 600;
            downWall.Top = rnd;
            upperWall.Left = 600;
            upperWall.Top = downWall.Top - upperWall.Height - 200;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
