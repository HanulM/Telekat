using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekat
{
    class Key : Items
    {
        //Fields
        private bool placeHolder;

        //Constructor
        public Key(int x, int y, int width, int height, Texture2D texture) : base(x, y, width, height, texture)
        {

        }

        public override bool ItemActive()
        {
            //Placeholder, coordinates for the lever
            //must be included
            MouseState mouse = Mouse.GetState();

            if(mouse.LeftButton == ButtonState.Pressed)
            {
                //Add the item to the inventory of the player
                return true;
            }

            return false;
        }
    }
}
