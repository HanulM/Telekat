using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekat
{
    class Ladder : Items
    {
        //Fields
        private bool placeHolder;

        //Constructor 
        public Ladder(int x, int y, int width, int height, Texture2D texture) 
            : base(x, y, width, height, texture)
        {

        }

        public override bool ItemActive()
        {
            return placeHolder;
        }
    }
}
