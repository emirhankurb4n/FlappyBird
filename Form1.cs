using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tas_Kagıt_Makas
{
    public partial class Form1 : Form
    {
        private int boruhizi = 8;
        private int gravity = 10;
        private int score = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            BoruAlt.Left -= boruhizi;
            BoruUst.Left -= boruhizi;
            label1.Text = "Skor : " + score/2;

            if (BoruAlt.Left <- 150)
            {
                BoruAlt.Left = 800;
                score++;
            }

            if (BoruUst.Left <- 180)
            {
                BoruUst.Left = 950;
                score++; 
            }

            if (flappybird.Bounds.IntersectsWith(BoruAlt.Bounds) || flappybird.Bounds.IntersectsWith(BoruUst.Bounds) || flappybird.Bounds.IntersectsWith(Zemin.Bounds) || flappybird.Top<-25)
            {
                endGame();
            }
            if (score > 5)
            {
                boruhizi = 15;
            }
            if (score > 15)
            {
                boruhizi = 20;  
            }
            if (score > 30)
            {
                boruhizi = 25;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            label1.Top = 150;
            label1.Left = 70;
            label1.Text = "Oyun Bitti!!! Skorun : " + score/2;
            groupBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Restart();   
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
