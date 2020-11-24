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
    class Platform
    {
        #region Fields

        private Rectangle location;

        #endregion


        #region Properties

        public Rectangle Location
        {
            get { return location; }
        }

        public float X
        {
            get { return location.X; }
        }

        public float Y
        {
            get { return location.Y; }
        }

        #endregion


        #region Constructor

        public Platform(int width, int height, int x, int y)
        {
            location = new Rectangle(x, y, width, height);
        }

        #endregion


        #region Methods

        // implement a method for lever activation here

        #endregion
    }
}
