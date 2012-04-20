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
    class DPad : PlayerControl
    {
        public Texture2D DPadTexture;
        public Rectangle DPadLocation;
        
        

        public DPad(Texture2D dPad, Rectangle dPadLocation)
            : base(dPad, dPadLocation)
        {
            this.DPadTexture = dPad;
            //base.controlTexture = dPad;
            base.drawLocation = dPadLocation;
            //this.DPadLocation = dPadLocation;
            
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
            //spriteBatch.Draw(DPadTexture, DPadLocation, Color.White);
        }
    }
}
