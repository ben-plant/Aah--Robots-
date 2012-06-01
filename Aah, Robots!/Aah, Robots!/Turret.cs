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

    /*Turret superclass generates two objects, a base and a top, both of which are block types. 
     * These will be added into the BlockManager listing class later, I guess. */

    public class Turret
    {
        public Vector2 TurretSpawnLocation;
        public Rectangle TurretBaseRectangle;
        public Rectangle TurretTopRectangle;
        public Vector2 TurretTopSwivel;
        public Texture2D TurretBase;
        public Texture2D TurretTop;
        public SpriteBatch spriteBatch;
        public int TurretLevel;
        public int TurretCost;
        public int TurretHealth;
        public int TurretIndex;
        

        //public string TurretName;
        public TurretTop thisTurretTop;
        public TurretBase thisTurretBase;

        public Turret(SpriteBatch batchToDrawTo, Vector2 spawnLocation, Texture2D topTex, Texture2D baseTex, int turretLevel, int turretNumber)
        {
            this.spriteBatch = batchToDrawTo;
            this.TurretSpawnLocation = spawnLocation;
            this.TurretTop = topTex;
            this.TurretBase = baseTex;
            this.TurretLevel = turretLevel;
            this.TurretHealth = (100 + (TurretLevel * 50));

            TurretBaseRectangle = new Rectangle((int)TurretSpawnLocation.X, (int)TurretSpawnLocation.Y, 64, 64);
            TurretTopRectangle = new Rectangle((int)TurretBaseRectangle.X, (int)(TurretBaseRectangle.Y - TurretTop.Height / 2), 64, 64);
            this.TurretTopSwivel = new Vector2((TurretTopRectangle.Width / 2), (TurretTopRectangle.Height / 2));

            this.thisTurretTop = new TurretTop(this.spriteBatch, this.TurretTop, this.TurretSpawnLocation, this.TurretIndex);
            this.thisTurretBase = new TurretBase(this.spriteBatch, this.TurretBase, this.TurretSpawnLocation, this.TurretIndex);
        }

        public bool TurretLevelUp()
        {
            if (TurretLevel != 0 || TurretLevel < 10 )
            {
                TurretLevel++;
                //this.TurretTop = - Potentially change turret textures to suit higher levels, therefore making them look cool
                return true;
            }
            else
            {
                //Turret cannot be upgraded either because it doesn't exist or it's level 10
                return false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }

    }
}
