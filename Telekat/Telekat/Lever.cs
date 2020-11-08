﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekat
{
    class Lever : Items
    {
        //Fields

        //Constructor 
        public Lever(int x, int y, int width, int height, Texture2D texture) : base(x, y, width, height, texture)
        {

        }

        public override bool ItemActive()
        {
            //Placeholder, coordinates for the lever
            //must be included
            MouseState mouse = Mouse.GetState();

            if(mouse.LeftButton == ButtonState.Pressed)
            {
                return true;
            }

            return false;
        }
    }
}
