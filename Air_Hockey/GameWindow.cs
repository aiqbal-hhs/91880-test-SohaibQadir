using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Hockey
{
    public partial class GameWindow : Form
    
    {
        //########################################################################
        //# Instance Variables

        private static Bitmap BITMAP = Properties.Resources.Paddle;

        private List<Paddle> paddles_;

        private Puck puck_;

        private const float POSITION = 50;

        public GameWindow()
        {
            InitializeComponent();

            paddles_ = new List<Paddle>();
            puck_ = new Puck(200, 200, paddles_);

            Paddle paddle1 = new Paddle(POSITION, (pictureBox_.Height - BITMAP.Height) / 2);
            paddles_.Add(paddle1);

            Paddle paddle2 = new Paddle((pictureBox_.Width - BITMAP.Width) - POSITION, (pictureBox_.Height - BITMAP.Height) / 2);
            paddles_.Add(paddle2);


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            puck_.Draw(graphics);
            foreach (Paddle paddle in paddles_)
            {

                paddle.Draw(e.Graphics);


            }

        }


        private void animationTimer__Tick(object sender, EventArgs e)
        {
            puck_.Move(pictureBox_.DisplayRectangle);
            pictureBox_.Invalidate();

        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            //Control for player 1
            Paddle paddle1 = paddles_[0];

            if (e.KeyCode == Keys.Z)
            {

                paddle1.XPosition -= 5;
            }
            if (e.KeyCode == Keys.C)
            {


                paddle1.XPosition += 5;
            }
            if (e.KeyCode == Keys.X)
            {

                paddle1.YPosition += 5;
            }
            if (e.KeyCode == Keys.S)
            {

                paddle1.YPosition -= 5;
            }


            //Control for player 2
            Paddle paddle2 = paddles_[1];
            if (e.KeyCode == Keys.Left)
            {

                paddle2.XPosition -= 5;
            }
            if (e.KeyCode == Keys.Right)
            {

                paddle2.XPosition += 5;
            }
            if (e.KeyCode == Keys.Down)
            {

                paddle2.YPosition += 5;
            }
            if (e.KeyCode == Keys.Up)
            {

                paddle2.YPosition -= 5;
            }


        }



    }
}
