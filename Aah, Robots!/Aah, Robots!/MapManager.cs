using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace AahRobots
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class MapManager : Microsoft.Xna.Framework.GameComponent
    {
        Game thisGame;
        BlockManager blockManager;

        public MapManager(Game game, BlockManager blkManager)
            : base(game)
        {
            this.thisGame = game;
            this.blockManager = blkManager;
        }

        public Map openMap(int mapID)
        {
            Map thisMap = new Map(mapID, 8, 8);
            thisMap.openMap();
            return thisMap;
        }

        public override void Initialize()
        {

            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
