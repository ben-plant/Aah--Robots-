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
    class Turret
    {
        public readonly bool canThisBlockBeWalkedThrough = false;

        public Vector2 TurretSpawnLocation;
        public Rectangle TurretBaseRectangle;
        public Rectangle TurretTopRectangle;
        public Texture2D TurretBase;
        public Texture2D TurretTop;
        public int TurretLevel;
        public int TurretCost;
        public int TurretHealth;
        

        //public string TurretName;
        public TurretTop thisTurretTop;
        public TurretBase thisTurretBase;

        public Turret(Vector2 spawnLocation, Texture2D topTex, Texture2D baseTex, int turretLevel)
        {
            this.TurretSpawnLocation = spawnLocation;
            this.TurretTop = topTex;
            this.TurretBase = baseTex;
            this.TurretLevel = turretLevel;
            this.TurretHealth = (100 + (TurretLevel * 50));


            TurretBaseRectangle = new Rectangle((int)TurretSpawnLocation.X, (int)TurretSpawnLocation.Y, 64, 64);
            TurretTopRectangle = new Rectangle(TurretBaseRectangle.X, (TurretBaseRectangle.Y - TurretTop.Height / 2), 64, 64);

            TurretTop thisTurretTop = new TurretTop();
            TurretBase thisTurretBase = new TurretBase();
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

    }
}
