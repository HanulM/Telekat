using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekat
{
    class Chest : Items
    {
        //Fields
        private Items chestItem;
        private bool keyInInventory; 

        //Properties 
        public Items ChestItem { get { return chestItem; } }

        //Constructor 
        public Chest(int x, int y, int width, int height, Texture2D texture) : base(x, y, width, height, texture)
        {

        }

        //Methods
        //Checks if the item is active
        public override bool ItemActive()
        {
            //If the player doesnt have a key in their inventory 
            //it cannot be activated 
            if(keyInInventory == true)
            {
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
            }
        }
    }
}
