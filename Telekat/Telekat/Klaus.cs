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
        // Read only property of the character's hitbox
        public Rectangle CharacterBox
        {
            get{ return this.characterBox; }
        }
        // Read and sets the x value of the character's hitbox.
        public int CharacterX
        {
            get{ return this.characterBox.X; }
            set{ this.characterBox.X = value; }
        }
        // Read and sets the y value of the character's hitbox.
        public int CharacterY
        {
            get{ return this.characterBox.Y; }
            set{ this.characterBox.Y = value; }
        }

        #endregion


        #region Constructor
        // Creates a Klaus object using parameters for an asset and a hitbox.
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
