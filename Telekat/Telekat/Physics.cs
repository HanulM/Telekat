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
            return topCollided;
         //need a player rectangle
        }

        public bool RightCollision()
        {
            rightCollided = false;
            return rightCollided;
            //need a player rectangle
        }

        public bool LeftCollision()
        {
            leftCollided = false;
            return leftCollided;
            //need player rectangle
        }

        public bool BottomCollision()
        {
            bottomCollided = false;
            return bottomCollided;
            //need player rectangle
        }

        // Gravity
        public void Gravity(Klaus player)
        {

        }
    }
}
