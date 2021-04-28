using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver;
        int jumpSpeed, force;
        int playerSpeed = 10;
        bool playerColor = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            if (goLeft)
                player.Left -= playerSpeed;
            if (goRight)
                player.Left += playerSpeed;
            if (jumping && force < 0)
                jumping = false;
            if (jumping)
            {
                jumpSpeed = -10;
                force -= 1;
            }
            else
                jumpSpeed = 10;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Space && jumping == false)
                jumping = true;
            if (e.KeyCode == Keys.G) 
            {
                if (playerColor)
                {
                    player.BackColor = System.Drawing.Color.Chocolate;
                    playerColor = false;
                }
                else
                {
                    player.BackColor = System.Drawing.Color.DarkSlateGray;
                    playerColor = true;
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (jumping)
                jumping = false;
            if (e.KeyCode == Keys.Enter)
                StartGame();
            //if (e.KeyCode == Keys.G)
              //  if (playerColor)
                //    player.
        }

        private void StartGame() 
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;

            player.Left = 71;
            player.Top = 354;

            gameTimer.Start();

        }
    }
}
