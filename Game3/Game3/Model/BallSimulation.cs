using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game3.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game3.Model
{
    class BallSimulation
    {
        Ball ball;

        public BallSimulation()
        {
            // TODO: Complete member initialization
            ball = new Ball();
        }

        


        internal void Update(GameTime gameTime)
        {
            float elapsedTimeSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;

            ball.centerXPosition += elapsedTimeSeconds * ball.speedX;
            ball.centerYPosition += elapsedTimeSeconds * ball.speedY;
            



            //Får bollen att "studsa" mot väggarna i X och Y led.
            if (ball.centerXPosition > 1.0f - ball.diameter / 2)
            {
                ball.speedX = ball.speedX * -1.0f;

            }

            if (ball.centerYPosition > 1.0f - ball.diameter / 2)
            {
                ball.speedY = ball.speedY * -1.0f;

            }


            if (ball.centerXPosition < 0.0f + ball.diameter / 2)
            {
                ball.speedX = ball.speedX * -1.0f;

            }

            if (ball.centerYPosition < 0.0f + ball.diameter / 2)
            {
                ball.speedY = ball.speedY * -1.0f;

            }
        }

        internal float getPositionX()
        {
            return ball.centerXPosition;
        }

        internal float getPositionY()
        {
            return ball.centerYPosition;
        }

        internal float getDiameter()
        {
            return ball.diameter;
        }



       
    }
}