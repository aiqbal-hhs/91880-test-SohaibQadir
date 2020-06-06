using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Air_Hockey
{
    abstract class Sprite
    {
        //########################################################################
        //# Abstract Methods
        /// <summary>
        /// Moves this sprite by a small amount.
        /// </summary>
        /// <param name="fraction">The fraction of the sprite's speed by which
        /// it moves. During each animation tick, the sprite should move by a
        /// distance specified as its speed. However, the complete distance will
        /// be covered in several iterations, and the fraction indicates how far
        /// the sprite should move. For example, a fraction of 0.25 would indicate
        /// that the sprite should be displaced by one quarter of its speed.</param>
        public abstract void Move(Rectangle bounds);

        /// <summary>
        /// Draws this sprite in the given graphics context.
        /// </summary>
        public abstract void Draw(Graphics graphics);

        /// <summary>
        /// The bounding rectangle containing the current location and size
        /// of this sprite.
        /// </summary>
        // public abstract Rectangle Bounds { get; }

        /// <summary>
        /// The current speed of this sprite in pixels per animation tick.
        /// This property only contains the amount of speed, not the direction
        /// of movement.
        /// </summary>
        // public abstract double Speed { get; }
    }
}
