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
    abstract class Items : Physics
    {
        #region Fields
        // Sprites
        Texture2D item;
        private SpriteBatch spriteBatch;

        // Item fields

        // Fields for Physics
        protected Rectangle itemBox;

        // Active or Nonactive
        protected bool isActive;

        #endregion


        #region Properties
        // Read only property of the item's hitbox.
        public Rectangle ItemBox
        {
            get{ return this.itemBox; }
        }
        // Read and sets the x value of the item's hitbox.
        public int ItemX
        {
            get{ return this.itemBox.X; }
            set{ this.itemBox.X = value; }
        }
        // Read and sets the y value of the item's hitbox.
        public int ItemY
        {
            get{ return this.itemBox.Y; }
            set{ this.itemBox.Y = value; }
        }

        #endregion


        #region Class Constructor
        public Items(int x, int y, int width, int height, Texture2D texture)
        {
            //this.spriteBatch = spriteBatch;
            this.itemBox = new Rectangle(x, y, width, height);
            this.item = texture;
            isActive = false;
        }

        #endregion


        #region Methods
        /// <summary>
        /// Sets the item as active if the player hovers their mouse over it
        /// </summary>
        /// <returns>Whether the items is active or not</returns>
        public abstract bool ItemActive();

        //Draws the item to the game. 
        public void Draw()
        {
            spriteBatch.Draw(item, ItemBox, Color.White);
        }

        #endregion
    }
}
