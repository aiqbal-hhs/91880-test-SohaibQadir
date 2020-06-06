using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Air_Hockey
{
    class Puck : Sprite
    { //########################################################################
        //# Instance Variables
        private double x_ = 100;

        private double y_ = 200;

        private double xSpeed_;

        private double ySpeed_;

        private const int DIAMETER = 40;

        private const double SPEED = 6;

        private const double SPEEDUP = 0.06 * SPEED;

        private List<Paddle> paddles_;

        private static Bitmap BITMAP = Properties.Resources.Paddle;





        //########################################################################
        //# Constructor
        public Puck(float x, float y, List<Paddle> paddles)
        {
            x_ = x;
            y_ = y;
            xSpeed_ = SPEED;
            ySpeed_ = SPEED;
            paddles_ = paddles;
        }


        //########################################################################
        //# Abstract Methods

        public override void Draw(Graphics graphics)
        {

            graphics.FillEllipse(Brushes.Red, (int)x_, (int)y_, DIAMETER, DIAMETER);
        }
        /// <summary>
        /// Walls rebound for puck
        /// </summary>
        /// <param name="bounds"></param>
        public override void Move(Rectangle bounds)
        {
            x_ += xSpeed_;
            y_ += ySpeed_;
            if (ySpeed_ > 0 && y_ + DIAMETER >= bounds.Bottom)
            {
                ySpeed_ = -ySpeed_;

            }
            else if (ySpeed_ < 0 && y_ <= bounds.Top)
            {
                ySpeed_ = -ySpeed_;
                y_ = bounds.Top;
            }
            else if (xSpeed_ > 0 && x_ + DIAMETER >= bounds.Right)
            {
                xSpeed_ = -xSpeed_;

            }
            else if (xSpeed_ < 0 && x_ <= bounds.Left)
            {
                xSpeed_ = -xSpeed_;
                x_ = bounds.Left;
            }


            //########################################################################
            //# 


            Paddle paddle1 = paddles_[0];
            Paddle paddle2 = paddles_[1];

            double radiousPuck = DIAMETER / 2;
            double radiousPaddle = BITMAP.Height / 2;

            double centerPuckX = x_ + DIAMETER / 2;
            double centerPuckY = y_ + DIAMETER / 2;


            double centerXPaddle1 = paddle1.XPosition + BITMAP.Height / 2;
            double centerYPaddle1 = paddle1.YPosition + BITMAP.Width / 2;

            double dx1 = centerPuckX - centerXPaddle1;
            double dy1 = centerPuckY - centerYPaddle1;

            double centerXPaddle2 = paddle2.XPosition + BITMAP.Height / 2;
            double centerYPaddle2 = paddle2.YPosition + BITMAP.Width / 2;

            double dx2 = centerPuckX - centerXPaddle2;
            double dy2 = centerPuckY - centerYPaddle2;
            

            double distance1 = Math.Sqrt((Math.Pow(dx1, 2)) + (Math.Pow(dy1, 2)));
            double distance2 = Math.Sqrt((dx2 * dx2) + (dy2 * dy2));


            if (radiousPaddle + radiousPuck >= distance1)
            {
                double newDx = SPEED;
                double newDy = SPEED;
                xSpeed_ = newDx;
                ySpeed_ = newDy;


            }

            if (radiousPaddle + radiousPuck >= distance2)
            {
                double newDx = -SPEED;
                double newDy = -SPEED;
                xSpeed_ = newDx;
                ySpeed_ = newDy;


            }
            



            
        }







    }
}
