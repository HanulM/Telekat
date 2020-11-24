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
    interface IPhysics
    {
        #region Properties

        Vector2 Location { get; set; }
        Vector2 Velocity { get; set; }
        Vector2 Gravity { get; set; }

        double Timer { get; set; } // for gravity

        #endregion


        #region Methods

        bool CollidingTop();
        bool CollidingLeft();
        bool CollidingRight();
        bool CollidingBottom(); 

        #endregion 
    }
}
