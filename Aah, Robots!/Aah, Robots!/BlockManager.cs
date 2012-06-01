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
        public Game thisGame;

        public List<Block> blocksInMap = new List<Block>();
        public List<Turret> turretsInMap = new List<Turret>();
        public List<Texture2D> blockTextures = new List<Texture2D>();
        SpriteBatch blockBatch;

        Texture2D floorTile;
        Texture2D wallTile;

        public BlockManager(Game game, SpriteBatch blkBatch) : base(game)
        {
            thisGame = game;
            blockBatch = blkBatch;
            thisGame.Content.RootDirectory = "Content";
            this.loadTexturesIntoMemory();
        }

        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            base.Update(gameTime);
        }

        public bool spawnBlock(Vector2 spawnLoc, int blockID)
        {
            if (blockID == 2)
            {
                return (this.spawnTurret(spawnLoc));
            }
            else
            {
                try
                {
                    int blocksPrinted = blocksInMap.Count;
                    Block thisBlock = new Block(blockBatch, blockTextures.ElementAt<Texture2D>(blockID), spawnLoc, ++blocksPrinted);
                    blocksInMap.Add(thisBlock);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool spawnTurret(Vector2 spawnLoc)
        {
            try
            {
                int turretsPrinted = turretsInMap.Count;
                Turret spawnedTurret = new Turret(blockBatch, spawnLoc, blockTextures.ElementAt<Texture2D>(1), blockTextures.ElementAt<Texture2D>(0), 1, ++turretsPrinted);
                turretsInMap.Add(spawnedTurret);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool loadTexturesIntoMemory()
        {
            floorTile = thisGame.Content.Load<Texture2D>("Sprites//TURRETBASEFILLER");
            wallTile = thisGame.Content.Load<Texture2D>("Sprites//TURRETTOPFILLER");
            blockTextures.Add(floorTile);
            blockTextures.Add(wallTile);
            return true;
        }

        public void drawAllBlocks(SpriteBatch blockBatch)
        {
            foreach (Block block in blocksInMap)
            {
                block.Draw(blockBatch);
            }
        }


        public void drawAllTurrets(SpriteBatch blockBatch)
        {
            foreach (Turret turret in turretsInMap)
            {
                turret.Draw(blockBatch);
            }
        }
    }
}
