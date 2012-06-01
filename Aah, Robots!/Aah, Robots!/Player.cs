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
    class Player : Sprite
    {
        Texture2D playerTexture;
        private const float acceleration = 0.5f;
        private Vector2 playerPosition;
        private Rectangle playerBoundary;
        public List<Button> controllerButtons = new List<Button>();
        public VirtualThumbstick theThumbstick = new VirtualThumbstick();
        public Button A;
        public Button B;
        public Texture2D theThumbstickTexture;
        public Texture2D theThumbstickTouch;
        

        public Player(Texture2D playerTex, Vector2 playerPos, Game game)
            : base(playerTex, playerPos)
        {
            SpriteBatch controllerBatch = new SpriteBatch(game.GraphicsDevice);

            Rectangle PlayerAButton = new Rectangle(580, 260, 90, 90);
            Rectangle PlayerBButton = new Rectangle(690, 370, 90, 90);

            Button A = new Button(game.Content.Load<Texture2D>("Controller//ABUTTONFILLER"), PlayerAButton, 0);
            Button B = new Button(game.Content.Load<Texture2D>("Controller//BBUTTONFILLER"), PlayerBButton, 1);
            theThumbstickTexture = game.Content.Load<Texture2D>("Controller//THUMBSTICKFILLER");
            theThumbstickTouch = game.Content.Load<Texture2D>("Controller//THUMBSTICKTOUCH");

            controllerButtons.Add(A);
            controllerButtons.Add(B);

            this.playerTexture = playerTex;
            this.playerPosition = playerPos;
            this.playerBoundary = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, 35, 35);
        }

        public void Update(GameTime gameTime, TouchCollection panelTouches, List<Block> blocksOnMap)
        {
            VirtualThumbstick.Update(panelTouches);
            foreach (Button button in controllerButtons)
            {
                button.Update(panelTouches);
            }

            foreach (Block block in blocksOnMap)
            {
                if (this.playerBoundary.Intersects(block.thisBlockShape))
                {
                    spriteVelocity *= 0f;
                }
            }

            spriteVelocity += VirtualThumbstick.Thumbstick;// *acceleration;
            playerPosition += spriteVelocity;
            spriteVelocity *= 0.8f;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (VirtualThumbstick.ThumbstickCentre.HasValue)
            {
                spriteBatch.Draw(theThumbstickTexture, VirtualThumbstick.ThumbstickCentre.Value - new Vector2(theThumbstickTexture.Width / 2f, theThumbstickTexture.Height / 2f), Color.White);
                spriteBatch.Draw(theThumbstickTouch, VirtualThumbstick.leftPosition - new Vector2(theThumbstickTouch.Width / 2f, theThumbstickTouch.Height / 2f), Color.White);
            }

            foreach (Button button in controllerButtons)
            {
                if (button.iHaveBeenPressed == true)
                {
                    spriteBatch.Draw(button.ButtonTexture, button.ButtonLocation, Color.Red);
                }
                else
                {
                    spriteBatch.Draw(button.ButtonTexture, button.ButtonLocation, Color.White);
                }
            }


            spriteBatch.Draw(playerTexture, new Rectangle((int)playerPosition.X, (int)playerPosition.Y, 35, 35), Color.White);
        }
    }
}
