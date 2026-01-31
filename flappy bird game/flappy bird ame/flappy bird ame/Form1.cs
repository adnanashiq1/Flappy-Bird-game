using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_ame
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += gamekeyisdown;
            this.KeyUp += gamekeyisup;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void f(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

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

        private void pipebottom_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            scoretext.Text = "Score : " + score;
            if (pipebottom.Left < -150)
            {
                pipebottom.Left = 800;
                score++;
            }
            if (pipetop.Left < -180)
            {
                pipetop.Left = 950;
                score++;
            }
            if (flappybird.Bounds.IntersectsWith(pipebottom.Bounds) ||
               flappybird.Bounds.IntersectsWith(pipetop.Bounds) ||
               flappybird.Bounds.IntersectsWith(ground.Bounds) || 
               flappybird.Top < -25)
            {
                endgame();
            } 
        }
        private void endgame()
        {
            gametimer.Stop();
            scoretext.Text += "  Game Over!!!";

        }
    }
}
