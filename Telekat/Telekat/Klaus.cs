using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Microsoft.Xna.Framework;
using System.Microsoft.Xna.Framework.Graphics;
using System.Microsoft.Xna.Framework.Input;

namespace Telekat
{
    class Klaus : Physics
    {
        #region Fields
        // Sprites
        Texture2D klausSprite;

        //Character Fields
        private int lives = 9;

        // Fields for Physics
        protected Rectangle characterBox;


        // State

        #endregion


        #region Properties
        public Rectangle CharacterBox
        {
            get{ return this.characterBox; }
        }

        public int CharacterX
        {
            get{ return this.characterBox.X; }
            set{ this.characterBox.X = value; }
        }

        public int CharacterY
        {
            get{ return this.characterBox.Y; }
            set{ this.characterBox.Y = value; }
        }

        #endregion


        #region Constructor
        public Klaus(Texture2D asset, Rectangle playerBox)
        {
            klausSprite = asset;
            playerBox = characterBox;
        }

        #endregion


        #region Methods

        #endregion
    }
}
