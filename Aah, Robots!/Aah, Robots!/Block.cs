using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace AahRobots
{
    class Block
    {
        Texture2D thisBlock;
        public Rectangle thisBlockShape;
        public int thisBlockIndex;

        public Block(SpriteBatch blockBatch, Texture2D importedBlock, Vector2 blockDrawLocation, int blockIndex)
        {
            thisBlock = importedBlock;
            thisBlockShape = new Rectangle((int)blockDrawLocation.X, (int)blockDrawLocation.Y, 35, 35);
            thisBlockIndex = blockIndex;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch drawSurface)
        {
            drawSurface.Draw(thisBlock, thisBlockShape, Color.White);
        }

        public Rectangle blockArea()
        {
            return thisBlockShape;
        }
    }
}
