using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Telekat
{
    class Ladder : Items
    {
        #region Fields
        // Sprites
        Texture2D item;
        private SpriteBatch spriteBatch;

        // Fields for Physics
        new Rectangle itemBox;

        // Active or Nonactive
        new bool isActive;

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

        #endregion


        #region Class Constructor 
        public Ladder(int x, int y, int width, int height, Texture2D texture, string name) 
            : base(x, y, width, height, texture, name)
        {
            this.itemBox = new Rectangle(x, y, width, height);
            this.item = texture;
            isActive = false;
            this.itemName = name;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Checks if the item is active
        /// </summary>
        /// <returns>Whether the item is active or not</returns>
        public override bool ItemActive()
        {
            MouseState currentState = Mouse.GetState();
            int mouseX = currentState.X;
            int mouseY = currentState.Y;

            if (itemBox.Contains(mouseX, mouseY))
            {
                this.isActive = true;
                return true;
            }

            return false;
        }


        #endregion
    }
}
