using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HW2_MonoGame_Game
{
    enum GameState
    {
        Menu,
        Game,
        GameOver
    }
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Variables
        private GameState state;
        private Player player;
        private List<Collectible> shinies;
        private Random rng;
        private int currentLevel;
        private double time;
        private double highScore;
        private KeyboardState kbState;
        private KeyboardState previousKbState;
        private double fps;
        private double secondsPerFrame;
        private double timeCounter;
        private int currentFrame;
        private int numOfSpritesHorizontally;
        private int numOfSpritesVertically;
        private int widthOfSingleSprite;
        private int heightOfSingleSprite;
        private Texture2D character;
        private Texture2D floor1;
        private Texture2D floor2;
        private Texture2D item;
        private Texture2D candy;
        private Texture2D menuScreen;
        private Texture2D gameOverScreen;
        private PlayerState playerState;
        private SpriteFont font;
        #endregion

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 900;
            graphics.PreferredBackBufferHeight = 900;
            graphics.ApplyChanges();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
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

            //Textures Content.Load<Texture2D>("");
            font = Content.Load<SpriteFont>("myFont");
            floor1 = Content.Load<Texture2D>("floor1");
            floor2 = Content.Load<Texture2D>("floor2");
            character = Content.Load<Texture2D>("pkmnTrainer2");
            item = Content.Load<Texture2D>("crystal1");
            candy = Content.Load<Texture2D>("candy");
            menuScreen = Content.Load<Texture2D>("Menu");
            gameOverScreen = Content.Load<Texture2D>("GAMEOVER");

            numOfSpritesHorizontally = 4;
            widthOfSingleSprite = character.Width / numOfSpritesHorizontally;
            numOfSpritesVertically = 4;
            heightOfSingleSprite = character.Height / numOfSpritesVertically;

            player = new Player(character, GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2, widthOfSingleSprite, heightOfSingleSprite);

            // Initialize animation data
            fps = 60;
            secondsPerFrame = 7 / fps;
            currentFrame = 1;
            timeCounter = 0;

            currentLevel = 0;
            highScore = 0;
            rng = new Random();

            shinies = new List<Collectible>(5);
            state = GameState.Menu;
            playerState = PlayerState.FaceDown;
            previousKbState = Keyboard.GetState();
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

            // GameState FiniteStateMachine
            switch (state)
            {
                case GameState.Menu:
                    if (SingleKeyPress(Keys.Enter))
                    {
                        state = GameState.Game;
                        ResetGame();
                    }
                    break;
                case GameState.Game:
                    MovePlayer();
                    UpdateAnimation(gameTime);
                    ScreenWrap(player);

                    time -= gameTime.ElapsedGameTime.TotalSeconds;

                    int numActive = shinies.Count; //number of active collectibles
                    for (int a = 0; a < shinies.Count; a++)
                    {
                        if (shinies[a].CheckCollision(player))
                        {
                            if (shinies[a].IsSpecial)
                            {
                                player.LevelScore += 5;
                            }
                            player.LevelScore += 2;
                            shinies[a].IsActive = false;
                        }
                        if (shinies[a].IsActive == false)
                        {
                            numActive -= 1;
                        }
                        if (numActive == 0)
                        {
                            NextLevel();
                            break;
                        }
                    }
                    if (time <= 0)
                    {
                        player.TotalScore += player.LevelScore;
                        state = GameState.GameOver;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Q))
                    {
                        state = GameState.GameOver;
                    }
                    break;
                case GameState.GameOver:
                    if (SingleKeyPress(Keys.Enter))
                    {
                        state = GameState.Menu;
                    }
                    break;
            }
            previousKbState = Keyboard.GetState();
            base.Update(gameTime);
        }
        protected bool SingleKeyPress(Keys key)
        {
            kbState = Keyboard.GetState();
            if (kbState.IsKeyDown(key) && previousKbState.IsKeyUp(key))
                return true;
            else
                return false;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            if (state == GameState.Menu)
            {
                spriteBatch.Draw(menuScreen, new Vector2(0, 0), Color.White);
            }
            if (state == GameState.GameOver)
            {
                spriteBatch.Draw(gameOverScreen, new Vector2(0, 0), Color.White);
                spriteBatch.DrawString(font, player.TotalScore.ToString(), new Vector2(460, 301), Color.Red); //total game score
            }

            if (state == GameState.Game)
            {
                if (currentLevel % 2 == 0)
                    spriteBatch.Draw(floor1, new Vector2(0, 0), Color.White);
                else //floor texture for level alternates with each level
                    spriteBatch.Draw(floor2, new Vector2(0, 0), Color.White);

                for (int a = 0; a < shinies.Count; a++)
                {
                    shinies[a].Draw(spriteBatch);
                }

                switch (playerState)
                {
                    case PlayerState.FaceDown:
                        spriteBatch.Draw(character,
                    player.Position,
                    new Rectangle(0, 0, widthOfSingleSprite, heightOfSingleSprite),
                    Color.White);
                        break;
                    case PlayerState.FaceLeft:
                        spriteBatch.Draw(character,
                       player.Position,
                       new Rectangle(0, heightOfSingleSprite, widthOfSingleSprite, heightOfSingleSprite),
                       Color.White);
                        break;
                    case PlayerState.FaceRight:
                        spriteBatch.Draw(character,
                    player.Position,
                    new Rectangle(0, heightOfSingleSprite * 2, widthOfSingleSprite, heightOfSingleSprite),
                    Color.White);
                        break;
                    case PlayerState.FaceUp:
                        spriteBatch.Draw(character,
                   player.Position,
                   new Rectangle(0, heightOfSingleSprite * 3, widthOfSingleSprite, heightOfSingleSprite),
                   Color.White);
                        break;
                    case PlayerState.WalkDown:
                        spriteBatch.Draw(character,
                       player.Position,
                       new Rectangle(currentFrame * widthOfSingleSprite, 0, widthOfSingleSprite, heightOfSingleSprite),
                       Color.White);
                        break;
                    case PlayerState.WalkLeft:
                        spriteBatch.Draw(character,
                              player.Position,
                              new Rectangle(currentFrame * widthOfSingleSprite, heightOfSingleSprite, widthOfSingleSprite, heightOfSingleSprite),
                              Color.White);
                        break;
                    case PlayerState.WalkRight:
                        spriteBatch.Draw(character,
                   player.Position,
                   new Rectangle(currentFrame * widthOfSingleSprite, heightOfSingleSprite * 2, widthOfSingleSprite, heightOfSingleSprite),
                   Color.White);
                        break;
                    case PlayerState.WalkUp:
                        spriteBatch.Draw(character,
                     player.Position,
                     new Rectangle(currentFrame * widthOfSingleSprite, heightOfSingleSprite * 3, widthOfSingleSprite, heightOfSingleSprite),
                     Color.White);
                        break;
                }

                spriteBatch.DrawString(font, string.Format("{0:0.00}", time),
                    new Vector2(5, 5),
                    Color.Red);
                spriteBatch.DrawString(font, "Level Score: " + player.LevelScore.ToString(),
                    new Vector2(5, 850),
                    Color.Red);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        protected void NextLevel()
        {
            currentLevel += 1;
            time = 20; //seconds

            player.TotalScore += player.LevelScore;
            player.LevelScore = 0;
            player.X = GraphicsDevice.Viewport.Width / 2; //centers(-ish) player
            player.Y = GraphicsDevice.Viewport.Height / 2;
            shinies.Clear();
            int i = (currentLevel - 1) * 3;
            int maxWidth = GraphicsDevice.Viewport.Width - item.Width;
            int maxHeight = GraphicsDevice.Viewport.Height - item.Height;
            for (int a = 0; a < 5 + i; a++)
            {
                if (rng.Next(0, 75) == rng.Next(0, 75)) //determines if special candy appears
                {   // adds special score boosting candy
                    shinies.Add(new Collectible(candy, new Rectangle(rng.Next(0, maxHeight),
                     rng.Next(0, maxWidth),
                     item.Width,
                     item.Height),
                     true));
                }
                else
                {
                    shinies.Add(new Collectible(item, new Rectangle(rng.Next(0, maxHeight),
                         rng.Next(0, maxWidth),
                         item.Width,
                         item.Height
                        )));
                }
            }
        }

        protected void ResetGame()
        {
            player.TotalScore = 0;
            currentLevel = 0;
            NextLevel();
        }


        protected void ScreenWrap(GameObject objToWrap)
        {
            if (objToWrap.X > GraphicsDevice.Viewport.Width)
            {
                objToWrap.X = -player.Width;
            }
            if (objToWrap.Y > GraphicsDevice.Viewport.Height)
            {
                objToWrap.Y = -player.Height;
            }
            if (objToWrap.X < -player.Width)
            {
                objToWrap.X = GraphicsDevice.Viewport.Width;
            }
            if (objToWrap.Y < -player.Height)
            {
                objToWrap.Y = GraphicsDevice.Viewport.Height;
            }
        }

        protected void MovePlayer()
        {
            int a = 3; //arbitrary value name to be able to change
                       // how far the character travels for testing porpoises

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                player.Y += a;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                player.X -= a;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                player.X += a;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                player.Y -= a;
            }

            switch (playerState)
            {
                case PlayerState.FaceDown:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }
                    break;

                case PlayerState.FaceLeft:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }

                    break;

                case PlayerState.FaceRight:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }
                    break;

                case PlayerState.FaceUp:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }
                    break;

                case PlayerState.WalkDown:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }
                    else if (Keyboard.GetState().IsKeyUp(Keys.Up)
                        && Keyboard.GetState().IsKeyUp(Keys.Left)
                        && Keyboard.GetState().IsKeyUp(Keys.Right))
                    {
                        playerState = PlayerState.FaceDown;
                    }
                    break;

                case PlayerState.WalkLeft:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }
                    else if (Keyboard.GetState().IsKeyUp(Keys.Down)
                        && Keyboard.GetState().IsKeyUp(Keys.Up)
                        && Keyboard.GetState().IsKeyUp(Keys.Right))
                    {
                        playerState = PlayerState.FaceLeft;
                    }
                    break;

                case PlayerState.WalkRight:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }
                    else if (Keyboard.GetState().IsKeyUp(Keys.Down)
                        && Keyboard.GetState().IsKeyUp(Keys.Left)
                        && Keyboard.GetState().IsKeyUp(Keys.Up))
                    {
                        playerState = PlayerState.FaceRight;
                    }
                    break;

                case PlayerState.WalkUp:
                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        playerState = PlayerState.WalkDown;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        playerState = PlayerState.WalkUp;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        playerState = PlayerState.WalkLeft;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        playerState = PlayerState.WalkRight;
                    }
                    else if (Keyboard.GetState().IsKeyUp(Keys.Down)
                        && Keyboard.GetState().IsKeyUp(Keys.Left)
                        && Keyboard.GetState().IsKeyUp(Keys.Right))
                    {
                        playerState = PlayerState.FaceUp;
                    }
                    break;
            }
            ScreenWrap(player);
        }
        protected void UpdateAnimation(GameTime gt)
        {
            // Add to the time counter (need TOTAL SECONDS here)
            timeCounter += gt.ElapsedGameTime.TotalSeconds;

            // Has enough time gone by to swap frames?
            if (timeCounter >= secondsPerFrame)
            {
                // Update the frame
                currentFrame++;
                if (currentFrame > 3)
                    currentFrame = 1;

                // Remove one "frame" worth of time
                timeCounter -= secondsPerFrame;
            }
        }
    }
}