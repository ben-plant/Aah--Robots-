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
    public class ControllerManager : Microsoft.Xna.Framework.DrawableGameComponent
    {
        //SpriteBatch controllerBatch;

        //public List<Button> controllerButtons = new List<Button>();

        //VirtualThumbstick theThumbstick;
        //Button A;
        //Button B;

        //Rectangle PlayerAButton = new Rectangle(580, 260, 90, 90);
        //Rectangle PlayerBButton = new Rectangle(690, 370, 90, 90);
        
        //Texture2D theThumbstickTexture;
        //Texture2D theThumbstickTouch;

        public ControllerManager(Game game)
            : base(game)
        {
            //theThumbstick = new VirtualThumbstick();
            //A = new Button(Game.Content.Load<Texture2D>("Controller//ABUTTONFILLER"), PlayerAButton, 0);
            //B = new Button(Game.Content.Load<Texture2D>("Controller//BBUTTONFILLER"), PlayerBButton, 1);
            //controllerButtons.Add(A);
            //controllerButtons.Add(B);
            
            //theThumbstickTexture = Game.Content.Load<Texture2D>("Controller//THUMBSTICKFILLER");
            //theThumbstickTouch = Game.Content.Load<Texture2D>("Controller//THUMBSTICKTOUCH");

        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            //controllerBatch = new SpriteBatch(Game.GraphicsDevice);
            //base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            //Cyclic touchscreen press audit
            //TouchCollection panelTouches = TouchPanel.GetState();

            //VirtualThumbstick.Update(panelTouches);
            //foreach (Button button in controllerButtons)
            //{
            //    button.Update(panelTouches);
            //}
        }

        public override void Draw(GameTime gameTime)
        {
            //controllerBatch.Begin();
            ////theDPad.Draw(gameTime, controllerBatch);
            //foreach (Button button in controllerButtons)
            //{
            //    if (button.iHaveBeenPressed == true)
            //    {
            //        controllerBatch.Draw(button.ButtonTexture, button.ButtonLocation, Color.Red);
            //    }
            //    else
            //    {
            //        controllerBatch.Draw(button.ButtonTexture, button.ButtonLocation, Color.White);
            //    }
            //}

            //if (VirtualThumbstick.ThumbstickCentre.HasValue)
            //{
            //    controllerBatch.Draw(theThumbstickTexture, VirtualThumbstick.ThumbstickCentre.Value - new Vector2(theThumbstickTexture.Width / 2f, theThumbstickTexture.Height / 2f), Color.White);
            //    controllerBatch.Draw(theThumbstickTouch, VirtualThumbstick.leftPosition - new Vector2(theThumbstickTouch.Width / 2f, theThumbstickTouch.Height / 2f), Color.White);
            //}
            //controllerBatch.End();

            //base.Draw(gameTime);
        }
    }
}
