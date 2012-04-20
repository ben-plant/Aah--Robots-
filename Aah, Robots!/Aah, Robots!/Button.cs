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
    class Button : PlayerControl
    {
        public Texture2D ButtonTexture;
        public Rectangle ButtonLocation;
        public int ButtonIndex;
        public bool iHaveBeenPressed = false;



        public Button(Texture2D button, Rectangle buttonLocation, int buttonIndex)
            : base(button, buttonLocation, buttonIndex)
        {


            this.ButtonTexture = button;
            this.ButtonLocation = buttonLocation;
            this.ButtonIndex = buttonIndex;
        }

        public void Update(TouchCollection touches)
        {
            iHaveBeenPressed = false;

            foreach (var touch in touches)
            {
                if (ButtonLocation.Contains(new Point((int)touch.Position.X, (int)touch.Position.Y)))
                {
                    iHaveBeenPressed = true;
                }
            }
        }

        public void commitAction()
        {

        }
    }
}
