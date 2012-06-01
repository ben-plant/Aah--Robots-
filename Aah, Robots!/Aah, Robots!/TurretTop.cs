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
    public class TurretTop : Block
    {
        Texture2D turretBase;
        int turretID;
        Rectangle turretLocation;

        public TurretTop(SpriteBatch turretBatch, Texture2D thisTurretBase, Vector2 thisBaseDrawLocation, int thisTurretIndex)
            : base(turretBatch, thisTurretBase, thisBaseDrawLocation, thisTurretIndex)
        {
            this.turretBase = thisTurretBase;
            this.turretID = thisTurretIndex;
            this.turretLocation = new Rectangle((int)thisBaseDrawLocation.X, (int)thisBaseDrawLocation.Y, (int)turretBase.Width, (int)turretBase.Height);
            this.canThisBlockBeWalkedThrough = true;
        }
    }
}
