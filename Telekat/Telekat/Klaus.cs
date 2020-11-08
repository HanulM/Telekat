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
    enum KlausState
    {
        FaceLeft,
        FaceRight,
        WalkLeft,
        WalkRight
    }
    class Klaus : Physics
    {

        #region Fields
        // Sprites
        private Texture2D klausSprite;
        private SpriteBatch spriteBatch;
        private Rectangle klausBox;
        private Vector2 klausLoc;
        private int framesElapsed;
        private double timePerFrame = 100;
        private int numFrames;
        private int frames;

        //Character Fields
        private int lives = 9;

        // Inputs
        private KeyboardState kbState;
        private MouseState mouseState;


        // State
        private KlausState klausState;

        #endregion


        #region Properties
        // Read only property of the character's hitbox
        public Rectangle KlausBox
        {
            get{ return this.klausBox; }
        }
        // Read and sets the x value of the character's hitbox.
        public int KlausX
        {
            get{ return this.klausBox.X; }
            set{ this.klausBox.X = value; }
        }
        // Read and sets the y value of the character's hitbox.
        public int KlausY
        {
            get{ return this.klausBox.Y; }
            set{ this.klausBox.Y = value; }
        }

        #endregion


        #region Constructor
        // Creates a Klaus object using parameters for an asset and a hitbox.
        public Klaus(Texture2D asset, Rectangle playerBox, SpriteBatch spriteBatch, Vector2 klausLoc)
        {
            klausSprite = asset;
            this.klausBox = playerBox;
            this.spriteBatch = spriteBatch;
            this.klausLoc = klausLoc;
            numFrames = 8;
        }

        #endregion


        #region Methods

        // Triggers Klaus' telekinesis
        public bool Tele()
        {
            mouseState = Mouse.GetState();

            /*if(mouseState.LeftButton)
            {
                return true;
            }*/

            return false;
        }

        //Lets Klaus move around the screen
        public void KlausMove(GameTime gameTime)
        {
            framesElapsed = (int)(gameTime.TotalGameTime.TotalMilliseconds / timePerFrame);

            //Placeholder for klaus moving around the screen.
            kbState = Keyboard.GetState();
            
            switch (klausState)
            {
                case KlausState.FaceLeft:

                    if(kbState.IsKeyDown(Keys.A))
                    {
                        klausState = KlausState.WalkLeft;
                    }   

                    if(kbState.IsKeyDown(Keys.D))
                    {
                        klausState = KlausState.FaceRight;
                    }

                    break;

                case KlausState.FaceRight:

                    if(kbState.IsKeyDown(Keys.A))
                    {
                        klausState = KlausState.FaceLeft;
                    }

                    if(kbState.IsKeyDown(Keys.D))
                    {
                        klausState = KlausState.WalkRight;
                    }

                    break;

                case KlausState.WalkLeft:

                    if(kbState.IsKeyUp(Keys.A))
                    {
                        klausState = KlausState.FaceLeft;
                    }

                    if (kbState.IsKeyDown(Keys.A))
                    {
                        klausLoc.X -= 2;
                    }

                    break;

                case KlausState.WalkRight:

                    if(kbState.IsKeyUp(Keys.D))
                    {
                        klausState = KlausState.FaceRight;
                    }

                    if (kbState.IsKeyDown(Keys.D))
                    {
                        klausLoc.X += 2;
                    }

                    break;

                    // gotta implement code where he jumps - uses gravity
            }
        }

        public void KlausDraw()
        {
            if (klausState == KlausState.FaceLeft || klausState == KlausState.WalkLeft)
            {
                spriteBatch.Draw(klausSprite, klausLoc, new Rectangle(klausBox.X + frames * klausBox.Width, klausBox.Y, klausBox.Width, klausBox.Height), Color.White,
                    0, Vector2.Zero, 1, SpriteEffects.FlipHorizontally, 0);
            }
            else
            {
                spriteBatch.Draw(klausSprite, klausLoc, new Rectangle(klausBox.X + frames * klausBox.Width, klausBox.Y, klausBox.Width, klausBox.Height), Color.White);
            }
            
        }

        #endregion
    }
}
