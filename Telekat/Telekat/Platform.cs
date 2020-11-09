using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Telekat
{
    // This "item" does not have to appear in the external tool
    // The class is here and inherits from Items for general rules for collision
    class Platform : Items
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
        public Platform(int x, int y, int width, int height, Texture2D texture, string name)
            :base(x, y, width, height, texture, name)
        {
            //this.spriteBatch = spriteBatch;
            this.itemBox = new Rectangle(x, y, width, height);
            this.item = texture;
            this.itemName = name;
        }
        #endregion


        public override bool ItemActive()
        {
            return false; // always returns false - cannot directly be interacted with
        }

        public void LeverActivated()
        {
            // a hidden platform will appear when a lever is interacted with
        }
    }
}
