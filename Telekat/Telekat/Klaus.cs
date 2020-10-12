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
        enum KlausState
        {
            FaceLeft,
            FaceRigth,
        }

        #region Fields
        // Sprites
        private Texture2D klausSprite;
        private int framesElapsed;
        private double timePerFrame = 100;
        private SpriteBatch spriteBatch;
        private KlausState klausState;
        private int numFrames;
        private int frames;
        private Vector2 klausLoc;

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
        public Klaus(Texture2D asset, Rectangle playerBox, SpriteBatch spriteBatch)
        {
            klausSprite = asset;
            playerBox = characterBox;
            this.spriteBatch = spriteBatch;
            klausLoc = new Vector2(10,10);
            numFrames = 8;
        }

        #endregion


        #region Methods
        //Lets Klaus move around the screen
        public void KlausMove(GameTime gameTime)
        {
            framesElapsed = (int)(gameTime.TotalGameTime.TotalMilliseconds / timePerFrame);

            //Placeholder for klaus moving around the screen.
            kbState = Keyboard.GetState();
            
            if (kbState.IsKeyDown(Keys.A))
            {
                klausState = KlausState.FaceLeft;
            }
            else if (kbState.IsKeyDown(Keys.D))
            {
                klausState = KlausState.FaceRigth;
            }

            switch (klausState)
            {
                case KlausState.FaceLeft:
                    if (kbState.IsKeyDown(Keys.A))
                    {
                        frames = framesElapsed % numFrames + 1;
                        characterBox.X--;
                    }
                    else
                    {
                        frames = 0;
                    }

                    break;

                case KlausState.FaceRigth:
                    if (kbState.IsKeyDown(Keys.D))
                    {
                        frames = framesElapsed % numFrames + 1;
                        characterBox.X++;
                    }
                    else
                    {
                        frames = 0;
                    }

                    break;
            }
        }

        public void KlausDraw()
        {
            if (klausState == KlausState.FaceLeft || klausState == KlausState.FaceRigth)
            {
                spriteBatch.Draw(klausSprite, klausLoc,
                    new Rectangle(characterBox.X + frames * characterBox.Width,
                    characterBox.Y, characterBox.Width, characterBox.Height ), Color.White, 
                    0, Vector2.Zero, 1, SpriteEffects.FlipHorizontally, 0);
            }
            else
            {
                spriteBatch.Draw(klausSprite, characterBox, Color.White);
            }
        }

        #endregion
    }
}
