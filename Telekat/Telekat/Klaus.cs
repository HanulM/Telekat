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
        private Dictionary<string, Items> inventory;

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
            get{ return (int)klausLoc.X; }
            set{ klausLoc.X = value; }
        }
        // Read and sets the y value of the character's hitbox.
        public int KlausY
        {
            get{ return (int)klausLoc.Y; }
            set{ klausLoc.Y = value; }
        }
        // Read and sets the character's inventory
        public Dictionary<string, Items> Inventory
        {
            get { return this.inventory; }
            set { this.inventory = value; }
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
            numFrames = 7;

            this.inventory = new Dictionary<string, Items>();
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
            //Calc for frames
            framesElapsed = (int)(gameTime.TotalGameTime.TotalMilliseconds / timePerFrame);

            //gets the state of the keyboard
            kbState = Keyboard.GetState();
            
            switch (klausState)
            {
                case KlausState.FaceLeft:
                    //Checks if klaus still facing left and the key A
                    //is being pressed, it will walk left
                    if(kbState.IsKeyDown(Keys.A))
                    {
                        klausState = KlausState.WalkLeft;
                    }   

                    //if klaus looks to the other direction 
                    //it will face that direction 
                    if(kbState.IsKeyDown(Keys.D))
                    {
                        klausState = KlausState.FaceRight;
                    }

                    break;

                case KlausState.FaceRight:

                    //if klaus looks to the other direction
                    //it will face that direction.
                    if(kbState.IsKeyDown(Keys.A))
                    {
                        klausState = KlausState.FaceLeft;
                    }

                    //if klaus still facing right and the key D
                    //is being pressed it will walk right 
                    if(kbState.IsKeyDown(Keys.D))
                    {
                        klausState = KlausState.WalkRight;
                    }

                    break;

                case KlausState.WalkLeft:

                    //Stop walking and faces the other direction 
                    if(kbState.IsKeyUp(Keys.A))
                    {
                        
                        klausState = KlausState.FaceLeft;
                    }

                    
                    if (kbState.IsKeyDown(Keys.A))
                    {
                        //Changes frames for klaus walking animation
                        frames = framesElapsed % numFrames + 1;

                        if (klausLoc.X < 225)
                        {
                            klausLoc.X += 2;
                        }

                        //Lets klaus move to the left 
                        klausLoc.X -= 2;
                    }
                    else
                    {
                        //resets the frames if klaus is not moving 
                        frames = 0;
                    }

                    break;

                case KlausState.WalkRight:

                    //Stop walking and faces the other direction 
                    if (kbState.IsKeyUp(Keys.D))
                    {
                        klausState = KlausState.FaceRight;
                    }

                    if (kbState.IsKeyDown(Keys.D))
                    {
                        //Changes frames for klaus  walking animation
                        frames = framesElapsed % numFrames + 1;
                        
                        if (KlausX > 560)
                        {
                            KlausX -= 2;
                        }
                        //Lets klaus move right 
                        klausLoc.X += 2;
                    }
                    else
                    {
                        //Resets the frames if klaus is not moving 
                        frames = 0;
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
