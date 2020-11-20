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
    class Lever : Items
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


        #region Class Constructor
        public Lever(int x, int y, int width, int height, Texture2D texture, string name):
            base(x, y, width, height, texture, name)
        {
            //this.spriteBatch = spriteBatch;
            this.itemBox = new Rectangle(x, y, width, height);
            this.item = texture;
            isActive = false;
            this.itemName = name;
        }
        #endregion


        #region Methods

        // A method that makes the item interactable
        public override bool ItemActive()
        {
            //Placeholder, coordinates for the lever
            //must be included
            MouseState mouse = Mouse.GetState();

            if(mouse.LeftButton == ButtonState.Pressed && itemBox.Contains(mouse.X, mouse.Y))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calls to the platform class to make a platform appear
        /// </summary>
        /// <param name="myPlatform">The platform to activate</param>
        public void ActivatePlatform(Platform myPlatform)
        {
            myPlatform.LeverActivated();
        }

        #endregion
    }
}
