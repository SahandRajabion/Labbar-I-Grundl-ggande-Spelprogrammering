using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game3.Model;
using Microsoft.Xna.Framework.Graphics;

namespace Game3.View
{
    class Camera
    {
        
        private float scale;
        private int width;
        private int height;
        private float logicalX = 1.0f;
        private float logicalY = 1.0f;
        
        private int borderSize = 10;

        public Camera(Viewport viewport)
        {
            //Räknar ut skalan
            width = viewport.Width;
            height = viewport.Height;

            float scaleX = width  - (borderSize * 2) /logicalX;
            float scaleY = height - (borderSize * 2) / logicalY;

            scale = scaleX;
            if(scaleY < scaleX)
            {
                scale = scaleY;
            }
        }


        public float getScale()
        {
            return scale;
        }
 
        internal float getBorder()
        {
            return borderSize;
        }
    }
}