using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Telekat
{
    enum GameState
    {
        Menu,
        Game,
        GameOver,
        GameWin,
        PauseMenu
    }

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameState gameState;
        KeyboardState keyboardState;
        KeyboardState prevKeyboardState;
        double timer;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //Test 
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameState = GameState.Menu;
            keyboardState = Keyboard.GetState();
            timer = 10;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            //Change the game states 
            switch (gameState)
            {
                //user will be in the Menu of the game
                case GameState.Menu:

                    //Once the user presses "Enter" 
                    //it will change the game state 
                    //and it will start the game.
                    if (SingleKeyPress(Keys.Enter))
                    {
                        gameState = GameState.Game;
                    }

                    //Resets the placeholder for loosing mechanic
                    timer = 10;


                    break;

                //User will be in the Game 
                case GameState.Game:

                    //Place holder for the player losing mechanism. 
                    timer = timer - gameTime.ElapsedGameTime.TotalSeconds;

                    //Checks if the player pauses the game
                    //and changes the game state to pause
                    if (SingleKeyPress(Keys.P))
                    {
                        gameState = GameState.PauseMenu;
                    }

                    //Checks if the player lost the game/
                    //the timer hit 0 mark(placeholder for loosing) 
                    else if(timer <= 0)
                    {
                        gameState = GameState.GameOver;
                    }
                    //NOT WORKING (Have to work on it)
                    //else if (SingleKeyPress(Keys.W))
                    //{
                    //    gameState = GameState.GameWin;
                    //}

                    break;

                //User will be in Game over 
                case GameState.GameOver:

                    //If the user presses the enter key
                    //it will take the player back to the menu 
                    if (SingleKeyPress(Keys.Enter))
                    {
                        gameState = GameState.Menu;
                    }

                    break;

                //User is in the Pause menu
                case GameState.PauseMenu:

                    //If the user presses P again,
                    //it will take them back to the 
                    //Game.
                    if (SingleKeyPress(Keys.P))
                    {
                        gameState = GameState.Game;
                    }

                    //Placeholder to let the player reset the game
                    //NOT WORKING (Have to work on it)
                    //else if (SingleKeyPress(Keys.M))
                    //{
                    //    gameState = GameState.Menu;
                    //}

                    break;

                //User is in win menu
                case GameState.GameWin:

                    //if the user presses enter 
                    //it will take them back to the
                    //main menu of the game
                    if (SingleKeyPress(Keys.Enter))
                    {
                        gameState = GameState.Menu;
                    }

                    break;

            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            //Placeholders for the changes between
            //the game state.
            switch (gameState)
            {
                case GameState.Menu:
                    GraphicsDevice.Clear(Color.Coral);
                    break;

                case GameState.Game:
                    GraphicsDevice.Clear(Color.Yellow);

                    break;

                case GameState.GameOver:
                    GraphicsDevice.Clear(Color.Red);

                    break;

                case GameState.PauseMenu:
                    GraphicsDevice.Clear(Color.Blue);

                    break;

                case GameState.GameWin:
                    GraphicsDevice.Clear(Color.Green);

                    break;

            }

            spriteBatch.End();
            base.Draw(gameTime);
        }

        //Checks if the key being asked for 
        //was pressed only once. 
        public bool SingleKeyPress(Keys key)
        {
            //save the state of the previous keyboard state
            prevKeyboardState = keyboardState;

            //Get the state of the keyboard
            keyboardState = Keyboard.GetState();

            //Checks if the the prev keyboard state 
            //of a certain key was up.
            if (keyboardState.IsKeyDown(key) && prevKeyboardState.IsKeyUp(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
