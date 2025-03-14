using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {   

        private class Direction
        {
            public int XDir;
            public int YDir;    
        }

        Direction movementDirection = new Direction();

        public Form2()
        {
            InitializeComponent();
            Text = "Лабораторная работа №1.2";
            pictureBoxGame.Location = new Point((panel1.Width - pictureBoxGame.Width) / 2, (panel1.Height - pictureBoxGame.Height) / 2);
            this.Icon = global::Lab1.Properties.Resources.logo;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int[] dirs = new int[2] {-1, 1};
            Random rnd = new Random(); 
            labelOutput.Text = "CLICK!!!  CLICK!!!";
            movementDirection.XDir =  dirs[rnd.Next(0,2)];
            movementDirection.YDir = dirs[rnd.Next(0, 2)];
            timer1.Enabled = true;
            timer2.Enabled = true;
            trackBar1.Enabled = false;
            button1.Enabled = false;
        }

        private void GameMovement(object sender, EventArgs e)
        {
            if (Convert.ToInt16(labelTimer.Text) == 0)
            {
                GameLoseStop();
            }
            else {
                
                int speed = trackBar1.Value;
                if ((pictureBoxGame.Location.X + pictureBoxGame.Width >= panel1.Width) || (pictureBoxGame.Location.X - 1 <= 0))
                {
                    movementDirection.XDir *= -1;
                }
                if ((pictureBoxGame.Location.Y + pictureBoxGame.Height >= panel1.Height) || (pictureBoxGame.Location.Y - 1 <= 0))
                {
                    movementDirection.YDir *= -1;
                }

                
                pictureBoxGame.Left += movementDirection.XDir * speed*5;
                pictureBoxGame.Top += movementDirection.YDir * speed*5;
            }

            

        }

        private void GameLoseStop()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            labelTimer.Text = "30";
            pictureBoxGame.Location = new Point((panel1.Width - pictureBoxGame.Width) / 2, (panel1.Height - pictureBoxGame.Height) / 2);
            int new_score = Convert.ToInt16(labelScore.Text) - 100;
            labelScore.Text = new_score.ToString();
            labelOutput.Text = "You've lost! -100$";
            trackBar1.Enabled = true;
            button1.Enabled = true;
        }
        private void GameWinStop(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                timer2.Enabled= false;
                labelTimer.Text = "30";
                pictureBoxGame.Location = new Point((panel1.Width - pictureBoxGame.Width) / 2, (panel1.Height - pictureBoxGame.Height) / 2);
                int speed = trackBar1.Value;
                int new_score = Convert.ToInt16(labelScore.Text) + (int)Math.Pow(10, speed);
                labelScore.Text = new_score.ToString();
                labelOutput.Text = "You've won! +" + Convert.ToString((int) Math.Pow(10, speed)) + "$";
                trackBar1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void GameTimer(object sender, EventArgs e)
        {
            int new_time = Convert.ToInt16(labelTimer.Text) - 1;
            labelTimer.Text = new_time.ToString();
        }
    }
}
