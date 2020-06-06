using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Air_Hockey
{
    class Paddle : Sprite
    {

        private double x_;

        private double y_;

        private double xSpeed_;

        private double ySpeed_;

        private const double SPEED = 50;

        private static Bitmap BITMAP = Properties.Resources.Paddle;
        
         

        //########################################################################
        //# Properties
        public double XPosition
        {
            get
            {
                return x_;


            }
            set
            {
                x_ = value;
            }


        }

        public double YPosition
        {
            get
            {
                return y_;


            }
            set
            {
                y_ = value;
            }


        }

        Rectangle bounds_;
        public Rectangle Bound
        {
            get
            {
                return new Rectangle((int)x_, (int)y_, BITMAP.Width, BITMAP.Height);
            }



        }


        //########################################################################
        //# Constructor
        public Paddle(float x, float y)
        {
            x_ = x;
            y_ = y;
            xSpeed_ = SPEED;
            ySpeed_ = SPEED;
            bounds_ = new Rectangle((int)x_, (int)y_, BITMAP.Width, BITMAP.Height);
        }




        public override void Draw(Graphics graphics)
        {

            graphics.DrawImage(BITMAP, (int)x_,(int)y_,BITMAP.Width,BITMAP.Height);
        }


        public override void Move(Rectangle bounds)
        {
            x_ += xSpeed_;
            y_ += ySpeed_;
        }




    }
}
