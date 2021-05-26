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
        bool right;
        bool left;
        int speed = 5;
        int gravity = 7;
        int score = 0;
        int rnd;
        int reversed = 1;
        bool warningArea = false;
        bool play = true;
        int doubleGravityTime = -1; 
        string warningMessage = "!WARNING!";
        int reverseTime = -1;
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
            if (right)
                bird.Left += 7;

            if (left)
                bird.Left -= 7;

            if (play)
            {
                bird.Top += gravity;
                downWall.Left -= speed;
                upperWall.Left -= speed;
                gravity = gravity + 1 * reversed;
            }

            if (!warningArea)
            {
                if (downWall.Left < -downWall.Width)
                {
                    MakeNewWalls();
                    score++;
                    scoreText.Text = score.ToString();
                    reverseTime--;
                    if (reverseTime == 1)
                        Reverse();
                }
            }

            if (reverseTime < -3)
            {
                ReveseHold();
            }
            
            if (bird.Bounds.IntersectsWith(upperWall.Bounds) ||
                    bird.Bounds.IntersectsWith(downWall.Bounds) ||
                    bird.Top + bird.Height < 0 || bird.Top + bird.Height > 565)
                timer1.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15 * reversed;

            if (e.KeyCode == Keys.Enter)
                RestartGame();

            if (e.KeyCode == Keys.Left)
                left = true;

            if (e.KeyCode == Keys.Right)
                right = true;
        }

        private void RestartGame()
        {
            doubleGravityTime = -1;
            scoreText.Text = "score:";
            reverseTime = -1;
            gravity = -10;
            bird.Top = 165;
            reversed = 1;
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

        private void ReveseHold()
        {
            reverseTime = rand.Next(3, 10);
            Reverse();
        }

        private void ChangeGravity()
        {

        }

        private void Reverse() { reversed *= -1; }

        private void DoubleGravity() { gravity *= 2; }

        private void NormalGravity() { gravity = 7; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                left = false;

            if (e.KeyCode == Keys.Right)
                right = false;
        }
    }
}
