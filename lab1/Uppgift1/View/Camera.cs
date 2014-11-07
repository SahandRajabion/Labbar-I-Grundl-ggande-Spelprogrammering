using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1.View
{
    class Camera
    {
        private float scale;
        private int platformHeight = 512;
        private int platformWidth = 512;
        private int sizeOfTile = 64;
        private int borderSize = 64;




        //Uppgift1
        //Converts Logical Coordinates for white player to Visual Coordinates.
        internal Vector2 translateLogicalWhite(Vector2 logicalWhite)
        {
            float visualX = borderSize + logicalWhite.X * sizeOfTile;
            float visualY = borderSize + logicalWhite.Y * sizeOfTile;
            return new Vector2(visualX, visualY);
        }

        //Uppgift2
        //Converts Logical Coordinates for black player to Visual Coordinates.
        //Rotates the chess board to render position of the black player´s move.
        internal Vector2 translateLogicalBlack(Vector2 logicalBlack)
        {
            float visualX = borderSize + (7 - logicalBlack.X) * sizeOfTile;
            float visualY = borderSize + (7 - logicalBlack.Y) * sizeOfTile;
            return new Vector2(visualX, visualY);
        }

        //Input logical coordinates and translate to visual coordinates
        // (0,0) = 512,0 , 512,0
        // (6,0) = 128,0 , 512,0
        // (2,7) = 384,0 , 64,0
        // (7,7) = 64,0 , 64,0


        //Uppgift3
        // Rescales to 320:240 inside of vector2 "platformScale".
        // Then sets the screen, depending on X&Y values recieved.

        internal void setDimensions(Vector2 platformScale)
        {
            float scaleX = (platformScale.X - borderSize * 2) / platformWidth;
            float scaleY = (platformScale.Y - borderSize * 2) / platformHeight;
            
            scale = scaleX;
            if (scaleY < scaleX)
            {
                scale = scaleY;
            }
        }

        internal float getScale()
        {
            return scale;
        }
    }
}



