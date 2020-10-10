﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Telekat
{
    abstract class Items : Physics
    {
        #region Fields
        // Sprites
        Texture2D item;

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

        #endregion


        #region Methods

        #endregion
    }
}
