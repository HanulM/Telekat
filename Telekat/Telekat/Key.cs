using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Telekat
{
    class Key : Items
    {
        #region Fields
        // Sprites
        Texture2D item;
        private SpriteBatch spriteBatch;

        // Fields for Physics
        new Rectangle itemBox;

        // Active or Nonactive
        new bool isActive;

        // Other Fields
        new string itemName;
        #endregion


        #region Properties
        // Read only property of the item's hitbox.
        new Rectangle ItemBox
        {
            get { return this.itemBox; }
        }
        // Read and sets the x value of the item's hitbox.
        new int ItemX
        {
            get { return this.itemBox.X; }
            set { this.itemBox.X = value; }
        }
        // Read and sets the y value of the item's hitbox.
        new int ItemY
        {
            get { return this.itemBox.Y; }
            set { this.itemBox.Y = value; }
        }
        // Read-only property of the item's name
        new string ItemName
        {
            get { return this.itemName; }
        }

        #endregion


        //Constructor
        public Key(int x, int y, int width, int height, Texture2D texture, string name) : 
            base(x, y, width, height, texture, name)
        {
            this.itemBox = new Rectangle(x, y, width, height);
            this.itemName = name;
            this.item = texture;
            isActive = false;
        }


        #region Methods
        public override bool ItemActive()
        {
            //Placeholder, coordinates for the lever
            //must be included
            MouseState mouse = Mouse.GetState();

            if(mouse.LeftButton == ButtonState.Pressed && itemBox.Contains(mouse.X, mouse.Y))
            {
                //Add the item to the inventory of the player
                return true;
            }

            return false;
        }

        public void UnlockChest(Chest myChest)
        {
            MouseState currentState = Mouse.GetState();

            if (this.isActive == true)
            {
                // call the Chest class' OpenChest method - needs a chest object but in order to do that we need to load the chest asset here instead
                // of in the Game1 class
            }
        }

        #endregion
    }
}
