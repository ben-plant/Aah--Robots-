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
    abstract class Tile
    {
        Texture2D thisTile;
        int thisTileType;

        public Tile()
        {
            thisTile = null;
            thisTileType = 999; //Set block as "null" in the presence of a non-nullable type
        }

        public int whatTileAmI()
        {
            if (thisTileType != 999)
            {
                return thisTileType;
            }
            else
            {
                return 999;
            }
        }
    }
}
