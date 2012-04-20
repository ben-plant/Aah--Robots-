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
    class VirtualThumbstick
    {


        const float maxThumbstickDistance = 60f;
        public static Vector2 leftPosition;
        static int leftId = -1;

        public static Vector2? ThumbstickCentre { get; private set; }

        public static Vector2 Thumbstick
        {
            get
            {
                if (!ThumbstickCentre.HasValue)
                    return Vector2.Zero;

                Vector2 l = (leftPosition - ThumbstickCentre.Value) / maxThumbstickDistance;

                if (l.LengthSquared() > 1f)
                    l.Normalize();

                return l;
            }
        }

        public static void Update(TouchCollection touches)
        {
            TouchLocation? leftTouch = null;
            //TouchCollection touches = TouchPanel.GetState();

            foreach (var touch in touches)
            {
                if (touch.Id == leftId)
                {
                    leftTouch = touch;
                }
                
                TouchLocation earliestTouch;
                if (!touch.TryGetPreviousLocation(out earliestTouch))
                {
                    earliestTouch = touch;
                }

                if (leftId == -1)
                {
                    if (earliestTouch.Position.X < TouchPanel.DisplayWidth / 2)
                    {
                        leftTouch = earliestTouch;
                    }
                }
            }

            if (leftTouch.HasValue)
            {
                if (!ThumbstickCentre.HasValue)
                    ThumbstickCentre = leftTouch.Value.Position;
                leftPosition = leftTouch.Value.Position;
                leftId = leftTouch.Value.Id;
            }
            else
            {
                ThumbstickCentre = null;
                leftId = -1;
            }
        }
    }
}
