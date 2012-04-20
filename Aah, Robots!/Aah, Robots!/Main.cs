/// Aah, Robots! QUALITY ASSURANCE BUILD
/// 
/// Written by Cyborgs Anonymous for Windows Phone 7 (C) 2012
/// Lead Developer: Ben Plant
/// Lead Graphics : James Plant
/// Lead Story : Abigail Lewis
/// NOT FOR RELEASE: ENGINEERING COPY

/* Version History
 * ---------------------------------------
 * 0001A -> 0006A - Various shit
 * 0007A - Thumbstick implemented
 * 0008A - Buttons connected to player class
 * 0009A - Controls moved to player class: cockup corrected with tea drinking.
 */

/* Handy Info
 * ---------------------------------------
 * Invalid blocks are referred to as type 999
 *
 */

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
    public class Main : Microsoft.Xna.Framework.Game
    {
        public string buildNumber = "0009A"; ///Controls moved to player class

        public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        MapManager mapManager;
        BlockManager blockManager;
        //ControllerManager controllerManager;

        Player thePlayer;
        

        Texture2D thePlayerSkin;
        Texture2D smallRobotSkin;
        Texture2D bigRobotSkin;
        Texture2D floorTile;
        Texture2D wallTile;
        Texture2D windowTile;
        Texture2D DPadTexture;
        Texture2D AButtonTexture, BButtonTexture;
        //public Texture2D theThumbstickTexture;

        SpriteFont digiFont;
        SpriteFont normFont;

        static Vector2 playerPosition = new Vector2(50, 50); //Change these two!
        static Vector2 robotPosition = new Vector2(100, 100);
        public static Vector2 centreOfControlButtons;

        //Rectangle PlayerSize = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, 35, 35);
        Vector2 PlayerPosition = new Vector2(50, 50);
        Rectangle defaultBlockSize = new Rectangle(0, 0, 35, 35);
        Rectangle SmallRobotSize = new Rectangle((int)robotPosition.X, (int)robotPosition.Y, 50, 50);
        Rectangle LargeRobotSize = new Rectangle((int)robotPosition.X, (int)robotPosition.Y, 100, 100);

        Rectangle viewableWorld = new Rectangle(0, 0, 480, 800);

        public int theScore = 0;
        public int robotKillCount = 0;
        public int robotsOnScreen = 100;
        public int playerLivesRemaining = 3;
        

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = true;
            Content.RootDirectory = "Content";
            
            // Frame rate is 30 fps by default for Windows Phone.
            TargetElapsedTime = TimeSpan.FromTicks(333333);

            // Extend battery life under lock.
            InactiveSleepTime = TimeSpan.FromSeconds(1);
        }

        protected override void Initialize()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            mapManager = new MapManager(this);
            Components.Add(mapManager);

            blockManager = new BlockManager(this);
            Components.Add(blockManager);
            
            //Spawn the controller...
            
            //Components.Add(controllerManager);
            
            //Load the fonts up...
            digiFont = Content.Load<SpriteFont>("Fonts//digitalFont");
            normFont = Content.Load<SpriteFont>("Fonts//arialFont");

            //Then the controller...
            //DPadTexture = Content.Load<Texture2D>("Controller//DPADFILLER");
            //AButtonTexture = Content.Load<Texture2D>("Controller//ABUTTONFILLER");
            //BButtonTexture = Content.Load<Texture2D>("Controller//BBUTTONFILLER");

            //Now the sprites!
            thePlayerSkin = Content.Load<Texture2D>("Sprites//PLAYERFILLER");
            smallRobotSkin = Content.Load<Texture2D>("Sprites//SMALLROBOTFILLER");
            bigRobotSkin = Content.Load<Texture2D>("Sprites//LARGEROBOTFILLER");
            //theThumbstickTexture = Content.Load<Texture2D>("Controller//THUMBSTICKFILLER");

            thePlayer = new Player(thePlayerSkin, PlayerPosition, this);
            //centreOfControlButtons = A.returnSpriteOrigin(AButtonTexture);
            #region CrapCode
            //Scrap or temporary code starts here!
            
            #endregion
            base.Initialize();
        }

        #region LoadContent
        protected override void LoadContent()
        {

        }
        #endregion

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            TouchCollection panelTouches = TouchPanel.GetState();
            thePlayer.Update(gameTime, panelTouches);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            
            
            thePlayer.Draw(gameTime, spriteBatch);
            spriteBatch.DrawString(digiFont, "Robots to kill: " + robotsOnScreen.ToString(), new Vector2(20, 20), Color.White);
            spriteBatch.DrawString(digiFont, "Robots killed: " + robotKillCount.ToString(), new Vector2(20, 45), Color.White);
            //spriteBatch.DrawString(font, "Score: " + theScore.ToString(), new Vector2(20, 70), Color.White);
            if (playerLivesRemaining > 1)
            {
                spriteBatch.DrawString(digiFont, "Lives: " + playerLivesRemaining.ToString(), new Vector2(680, 20), Color.White);
            }
            else
            {
                spriteBatch.DrawString(digiFont, "Lives: " + playerLivesRemaining.ToString(), new Vector2(680, 20), Color.Red);
            }

            #region BuildStringRef
            spriteBatch.DrawString(normFont, "CYBORGS ANONYMOUS 2012 Pre-Alpha " + buildNumber.ToString(), new Vector2(20, 440), Color.Red);
            #endregion
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
