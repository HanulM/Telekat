using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekat
{
    class Physics
    {
        // Attributes
        private bool topCollided;
        private bool rightCollided;
        private bool leftCollided;
        private bool bottomCollided;

        // Properties


        // Methods
        // Collision Detection
        public bool TopCollision()
        {
            topCollided = false;
        }

        public bool RightCollision()
        {
            rightCollided = false;
        }

        public bool LeftCollision()
        {
            leftCollided = false;
        }

        public bool BottomCollision()
        {
            bottomCollided = false;
        }

        // Gravity
    }
}
