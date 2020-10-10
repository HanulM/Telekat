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
    class Klaus : Physics
    {
        #region Fields
        // Sprites
        Texture2D klausSprite;

        //Character Fields
        private int lives = 9;

        // Fields for Physics
        protected Rectangle characterBox;
        private KeyboardState kbState;


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
        //Lets Klaus move around the screen
        public void KlausMove()
        {
            //Placeholder for klaus moving around the screen.
            kbState = Keyboard.GetState();
            if (kbState.IsKeyDown(Keys.W))
            {
                characterBox.Y--;
            }
            else if (kbState.IsKeyDown(Keys.S))
            {
                characterBox.Y++;
            }
            else if (kbState.IsKeyDown(Keys.A))
            {
                characterBox.X--;
            }
            else if (kbState.IsKeyDown(Keys.D))
            {
                characterBox.X++;
            }
        }

        #endregion
    }
}
