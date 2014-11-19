using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game3.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game3.View
{
    class BallView
    {
        private SpriteBatch spriteBatch;
        private Texture2D ballTexture;
        private Texture2D platformWall;
        private Camera camera;
       
       


        public BallView(GraphicsDevice graphicsDevice, ContentManager content) {

            ballTexture = content.Load<Texture2D>("tennisball");
            spriteBatch = new SpriteBatch(graphicsDevice);
            camera = new Camera(graphicsDevice.Viewport);

        }


        internal void drawBall(BallSimulation m_ballSimulation)
        {
            //Räknar ut de Visuella kordinaterna för bollens position
            int vX = (int)(m_ballSimulation.getPositionX() * camera.getScale() + camera.getBorder());
            int vY = (int)(m_ballSimulation.getPositionY() * camera.getScale() + camera.getBorder());
            int size = (int)(m_ballSimulation.getDiameter() * camera.getScale());

            //Vilka skärmkordinater som bollen ska täcka.
            Rectangle destrect = new Rectangle(vX - (size / 2), vY - (size / 2), size, size);

            spriteBatch.Begin();
            spriteBatch.Draw(ballTexture, destrect, Color.White);
            spriteBatch.End();


        }



        internal void drawPlatformWall(GraphicsDevice GraphicsDevice)
        {
           
            int borderWidth = 3;
            int scale = (int)camera.getScale();
            int border = (int)camera.getBorder();
            platformWall = new Texture2D(GraphicsDevice, 1, 1);
            var color = Color.Yellow;
            platformWall.SetData(new Color[] { color });

            //Skapar väggarna
            Rectangle top = new Rectangle(border, border, scale, borderWidth);

            Rectangle right = new Rectangle(border + scale, border, borderWidth, scale);

            Rectangle left = new Rectangle(border, border, borderWidth, scale);

            Rectangle bottom = new Rectangle(border, scale + border, scale, borderWidth);

            //Skriver ut väggarna
            spriteBatch.Begin();
            spriteBatch.Draw(platformWall, top, color);
            spriteBatch.Draw(platformWall, right, color);
            spriteBatch.Draw(platformWall, left, color);
            spriteBatch.Draw(platformWall, bottom, color);
            spriteBatch.End();
        }
    }
}

