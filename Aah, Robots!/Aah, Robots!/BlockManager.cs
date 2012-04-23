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
    /// Manages the block library and calls blocks with the correct tiles and co-ordinates based on the
    /// instructions of MapManager.
    /// </summary>
    public class BlockManager : Microsoft.Xna.Framework.GameComponent
    {
        Block brickWallBlock;
        Block railingBlock;
        Block potPlantBlock;

        Texture2D brickWallTexture;
        Texture2D railingTexture;
        Texture2D potPlantTexture;

        public List<Block> blocksInMap = new List<Block>();
        public List<Rectangle> nonePenetrableBlocks = new List<Rectangle>();
        public List<Rectangle> penetrableBlocks = new List<Rectangle>();

        public BlockManager(Game game)
            : base(game)
        {
            
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }
    }
}
