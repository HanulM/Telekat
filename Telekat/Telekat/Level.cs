using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekat
{
    class Level
    {
        #region Fields

        private int levelHeight;
        private int levelWidth;

        private Platform[,] platforms;
        private int platformWidth;
        private int platformHeight;

        #endregion


        #region Properties

        public int PlatformWidth
        {
            get { return platformWidth; }
        }

        public int PlatformHeight
        {
            get { return platformHeight; }
        }

        public Platform[,] Platforms
        {
            get { return platforms; }
        }

        #endregion 

        // Unsure on how to go about with a constructor
    }
}
