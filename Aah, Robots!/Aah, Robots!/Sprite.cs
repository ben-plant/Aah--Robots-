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
    public abstract class Sprite
    {
        Texture2D theSprite;
        Vector2 spriteSpawn;
        public Vector2 spriteVelocity;

        public Sprite(Texture2D spriteTexture, Vector2 spritePos)
        {
            this.theSprite = spriteTexture;
            this.spriteSpawn = spritePos;
        }

        public virtual void Update(GameTime gameTime)
        {
            Console.WriteLine("The developer fucked up. Please tell him.");
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(theSprite, spriteSpawn, Color.White);
        }

        public virtual Vector2 returnSpriteOrigin(Texture2D findMyMiddle)
        {
            Vector2 tempTexture = new Vector2(findMyMiddle.Height / 2, findMyMiddle.Width / 2);
            return tempTexture;
        }
    }
}
