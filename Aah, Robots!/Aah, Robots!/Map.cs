using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace AahRobots
{
    public class Map
    {
        int ID;
        int mapX;
        int mapY;
        public List<List<int>> masterMap = new List<List<int>>();


        public Map(int mapID, int X, int Y)
        {
            this.ID = mapID; 
            this.mapX = X;
            this.mapY = Y;
        }

        public bool openMap()
        {
            System.Diagnostics.Debug.WriteLine("Mapping engine online...");
            List<int> thisMapLine = new List<int>();
            StreamReader sr = new StreamReader("Maps//testmap.txt");

            string line = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                line = sr.ReadLine();
                foreach (char character in line)
                {
                    System.Diagnostics.Debug.WriteLine(character);
                    if (thisMapLine.Count < mapX)
                    {
                        if (char.IsNumber(character))
                        {
                            thisMapLine.Add(character);
                            System.Diagnostics.Debug.WriteLine(character);
                        }
                    }
                    else
                    {
                        masterMap.Add(thisMapLine);
                        thisMapLine.Clear();
                    }
                }
            }
            return true;
        }
    }
}
