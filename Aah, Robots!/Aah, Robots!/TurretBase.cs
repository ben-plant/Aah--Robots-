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
    /* Turret subclass for the base, to be added to the listing block management class */
    class TurretBase : Block
    {
        Texture2D turretBase;
        int turretID;
        Rectangle turretLocation;

        public TurretBase(Texture2D thisTurretBase, int thisTurretNo, Rectangle thisBaseLayout) : base(thisTurretBase, thisTurretNo)
        {
            this.turretBase = thisTurretBase;
            this.turretID = thisTurretNo;
            this.turretLocation = thisBaseLayout;

            this.canThisBlockBeWalkedThrough = false;
            this.doesThisBlockGenerateProjectiles = false;
        }
    }
}
