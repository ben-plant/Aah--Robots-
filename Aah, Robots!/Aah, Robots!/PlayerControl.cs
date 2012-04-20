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
    abstract class PlayerControl
    {
        public Texture2D controlTexture;
        public Rectangle drawLocation;

        public PlayerControl(Texture2D spawnTexture, Rectangle spawnLocation)
        {
            this.controlTexture = spawnTexture;
            this.drawLocation = spawnLocation;
        }

        public PlayerControl(Texture2D spawnTexture, Rectangle spawnLocation, int controlIndex)
        {
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(controlTexture, drawLocation, Color.White);
        }
    }
}
