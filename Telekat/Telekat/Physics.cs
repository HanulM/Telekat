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
    class Physics
    {
        #region Fields
        protected Rectangle firstRectangle;
        protected Rectangle secondRectangle;
        #endregion

        #region properties
        public Rectangle FirstRectangle { get { return this.firstRectangle; } }
        public Rectangle SecondRectangle { get { return this.secondRectangle; } }
        #endregion


        // Methods
        // Collision Detection
        public bool Collided()
        {
            if (FirstRectangle.Contains(SecondRectangle))
            {
                return true;
            }

            return false; //else
        }

        // Gravity - Unsure on how to implement
        /*public void Gravity(Klaus player)
        {

        }*/
    }
}
