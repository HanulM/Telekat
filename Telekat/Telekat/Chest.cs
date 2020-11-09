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
    class Chest : Items
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
        private Items chestItem;
        new bool keyInInventory;
        private Dictionary<string, bool> inventory = new Dictionary<string, bool>();

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
        // Read-only property of the chest item
        public Items ChestItem { get { return chestItem; } }

        #endregion


        //Constructor 
        public Chest(int x, int y, int width, int height, Texture2D texture, string name) 
            : base(x, y, width, height, texture, name)
        {
            this.itemBox = new Rectangle(x, y, width, height);
            this.item = texture;
            this.itemName = name;
            isActive = false;
        }

        //Methods
        //Checks if the item is active
        public override bool ItemActive()
        {
            //If the player doesnt have a key in their inventory 
            //it cannot be activated 
            if(keyInInventory == true)
            {
                this.isActive = true;
                return true;
            }

            return false;
        }

        //Opens the chest and gives the player and item
        public void OpenChest()
        {
            MouseState mouse = Mouse.GetState();

            //Checks if the player decided to open the chest. 
            //Only opens if the chest is active.
            if(this.ItemActive() == true && mouse.LeftButton == ButtonState.Pressed)
            {
                //Add item to the inventory of Klaus (dictionary) 
                inventory.Add(chestItem.ItemName, true);
            }
        }
    }
}
