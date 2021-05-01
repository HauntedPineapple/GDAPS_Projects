using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PE_MonoGame_Basics
{
    enum SpriteState
    {
        FaceLeft,
        FaceRight,
        WalkLeft,
        WalkRight
    }

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteState spriteState;

        private Texture2D spriteTexture;
        private Vector2 spritePosition;
        private int numSpritesInSheet;
        private int widthOfSingleSprite;
        // Animation-related fields
        private double fps;
        private double secondsPerFrame;
        private double timeCounter;
        private int currentFrame;

        KeyboardState input;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            // Load the sprite texture and setup other related vars
            spriteTexture = Content.Load<Texture2D>("walk_sheet");

            numSpritesInSheet = 10; // Hard-code this value
            widthOfSingleSprite = spriteTexture.Width / numSpritesInSheet;

            spritePosition = new Vector2(200, 200);

            // Initialize animation data
            fps = 60;
            secondsPerFrame = 5 / fps;
            currentFrame = 1;
            timeCounter = 0;

            spriteState = SpriteState.FaceLeft;
        }

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
            input = Keyboard.GetState();
            // *** Put code to check and update your FINITE STATE MACHINE
            // *** here - remember to use a switch statement, and have each
            // *** case only worry about tasks that have to do with that state
            switch (spriteState)
            {
                case SpriteState.FaceLeft:
                    if (input.IsKeyDown(Keys.Left) || input.IsKeyDown(Keys.D))
                    { //walk left
                        spriteState = SpriteState.WalkLeft;
                    }
                    if (input.IsKeyDown(Keys.Right) || input.IsKeyDown(Keys.A))
                    { //walk right
                        spriteState = SpriteState.WalkRight;
                    }
                    break;
                case SpriteState.FaceRight:
                    if (input.IsKeyDown(Keys.Left) || input.IsKeyDown(Keys.D))
                    { //walk left
                        spriteState = SpriteState.WalkLeft;
                    }
                    if (input.IsKeyDown(Keys.Right) || input.IsKeyDown(Keys.A))
                    { //walk right
                        spriteState = SpriteState.WalkRight;
                    }
                    break;
                case SpriteState.WalkLeft:
                    spritePosition.X -= 2.0f;
                    if (input.IsKeyDown(Keys.Right) || input.IsKeyDown(Keys.A))
                    { //walk right
                        spriteState = SpriteState.WalkRight;
                    }
                    else if (input.IsKeyUp(Keys.Left) || input.IsKeyDown(Keys.D))
                    { //the left key is released and the right key isn't pressed: stop
                        spriteState = SpriteState.FaceLeft;
                    }
                    break;
                case SpriteState.WalkRight:
                    spritePosition.X += 2.0f;
                    if (input.IsKeyDown(Keys.Left) || input.IsKeyDown(Keys.D))
                    { //walk left
                        spriteState = SpriteState.WalkLeft;
                    }
                    else if (input.IsKeyUp(Keys.Right) || input.IsKeyDown(Keys.A))
                    { //the right key is released and the left key isn't pressed: stop
                        spriteState = SpriteState.FaceRight;
                    }
                    break;
            }

            UpdateAnimation(gameTime);
            base.Update(gameTime);
        }

        private void UpdateAnimation(GameTime gt)
        {
            // Add to the time counter (need TOTAL SECONDS here)
            timeCounter += gt.ElapsedGameTime.TotalSeconds;
            if (timeCounter >= secondsPerFrame)
            {
                currentFrame++;
                if (currentFrame == numSpritesInSheet)
                    currentFrame = 0;
                timeCounter -= secondsPerFrame;
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.GhostWhite);

            spriteBatch.Begin();

            if (spriteState == SpriteState.FaceLeft)
            {
                DrawStanding(SpriteEffects.FlipHorizontally);
            }
            if (spriteState == SpriteState.FaceRight)
            {
                DrawStanding(SpriteEffects.None);
            }
            if (spriteState == SpriteState.WalkLeft)
            {
                DrawWalking(SpriteEffects.FlipHorizontally);
            }
            if (spriteState == SpriteState.WalkRight)
            {
                DrawWalking(SpriteEffects.None);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void DrawWalking(SpriteEffects flip)
        {
            spriteBatch.Draw(
                spriteTexture,
                spritePosition,
                new Rectangle(
                    currentFrame * widthOfSingleSprite,
                    0,
                    widthOfSingleSprite,
                    spriteTexture.Height),
                Color.White,    // Color
                0.0f,           // Rotation
                Vector2.Zero,   // Origin
                Vector2.One,    // Scale
                flip,           // Flip
                0               // Layer depth
                );
        }

        private void DrawStanding(SpriteEffects flip)
        {
            spriteBatch.Draw(
                spriteTexture,
                spritePosition,
                new Rectangle(0, 0, widthOfSingleSprite, spriteTexture.Height),
                Color.White,    // Color
                0.0f,           // Rotation
                Vector2.Zero,   // Origin
                Vector2.One,    // Scale
                flip,           // Flip
                0               // Layer depth
                );
        }
    }
}
