#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

namespace HW3_QuadTrees
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        // MonoGame Basics
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        // Mouse related
        private Rectangle _mouseRect;
        private QuadTreeNode _mouseQuad;

        // Basic textures
        private Texture2D _whitePixel;

        // The quad tree
        private QuadTreeNode _quadTree;

        // A list of game objects
        private List<GameObject> _gameObjects;

        // Random number generator
        private Random _random;

        // A color used to flash game objects
        private Color _flash;

        // Constants
        private const int NUM_GAME_OBJECTS = 50;
        private const int MIN_GAME_OBJECT_SIZE = 5;
        private const int MAX_GAME_OBJECT_SIZE = 15;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Set up the game object list
            _gameObjects = new List<GameObject>();

            // Make the random object
            _random = new Random();

            // Set up the mouse rectangle
            _mouseRect = new Rectangle(0, 0, 25, 25);

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

            // Create a basic 1x1 white pixel texture
            _whitePixel = new Texture2D(graphics.GraphicsDevice, 1, 1);
            _whitePixel.SetData<Color>(new Color[1] { Color.White });

            // Create the quad tree
            _quadTree = new QuadTreeNode(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);

            // Create a bunch of randomly placed game objects
            for (int i = 0; i < NUM_GAME_OBJECTS; i++)
            {
                // Choose a random size
                int size = _random.Next(MIN_GAME_OBJECT_SIZE, MAX_GAME_OBJECT_SIZE + 1);

                // Choose x and y values (with a buffer around the border of the window)
                int x = _random.Next(size, GraphicsDevice.Viewport.Width - size);
                int y = _random.Next(size, GraphicsDevice.Viewport.Height - size);
                Color color = new Color(
                    (float)Math.Max(_random.NextDouble(), 0.25f),
                    (float)Math.Max(_random.NextDouble(), 0.25f),
                    (float)Math.Max(_random.NextDouble(), 0.25f),
                    1.0f);

                // Make the game object
                GameObject gameObj = new GameObject(new Rectangle(x, y, size, size), _whitePixel, color);

                // Add it to the list and the quad tree
                _gameObjects.Add(gameObj);
                _quadTree.AddObject(gameObj);
            }
        }


        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Change the flash color
            _flash = new Color(0.0f, 0.0f, 0.0f, (float)Math.Sin(gameTime.TotalGameTime.TotalSeconds * 10) * 0.5f + 0.5f);

            // Update the mouse rectangle
            MouseState mState = Mouse.GetState();
            _mouseRect.X = mState.X;
            _mouseRect.Y = mState.Y;

            // Get the quad that the mouse rectangle is in
            _mouseQuad = _quadTree.GetContainingQuad(_mouseRect);

            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // Clear the screen
            GraphicsDevice.Clear(Color.Black);

            // Start the sprite batch
            spriteBatch.Begin();

            // Is the mouse inside of a quad?
            if (_mouseQuad != null)
            {
                DrawBox(_mouseQuad.Rectangle, Color.CornflowerBlue);
            }

            // Get all the quad tree rectangles and draw them
            List<Rectangle> rects = _quadTree.GetAllRectangles();
            foreach (Rectangle rect in rects)
                DrawRectangleOutline(rect, Color.White);

            // Draw all of the objects
            foreach (GameObject gameObj in _gameObjects)
                spriteBatch.Draw(gameObj.Texture, gameObj.Rectangle, gameObj.Color);

            // Flash any objects in the current quad
            if (_mouseQuad != null)
            {
                // Flash the quad's objects
                foreach (GameObject gameObj in _mouseQuad.GameObjects)
                {
                    spriteBatch.Draw(gameObj.Texture, gameObj.Rectangle, _flash);
                    DrawRectangleOutline(gameObj.Rectangle, Color.White);
                }
            }

            // Draw the mouse rectangle
            spriteBatch.Draw(_whitePixel, _mouseRect, Color.White);

            // End the sprite batch
            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Draws the outline of the specified rectangle
        /// </summary>
        /// <param name="rect">The rectangle to draw</param>
        /// <param name="color">The color to use when drawing</param>
        private void DrawRectangleOutline(Rectangle rect, Color color)
        {
            // Draw the 4 lines as 4 thin boxes:
            // Top, right, bottom, left
            DrawBox(rect.X, rect.Y, rect.Width, 1, color);
            DrawBox(rect.X + rect.Width, rect.Y, 1, rect.Height, color);
            DrawBox(rect.X, rect.Y + rect.Height, rect.Width, 1, color);
            DrawBox(rect.X, rect.Y, 1, rect.Height, color);
        }

        /// <summary>
        /// Draws a box
        /// </summary>
        /// <param name="x">The x position of the box</param>
        /// <param name="y">The y position of the box</param>
        /// <param name="width">The width of the box</param>
        /// <param name="height">The height of the box</param>
        /// <param name="color">The color to use when drawing</param>
        private void DrawBox(int x, int y, int width, int height, Color color)
        {
            // Draw the box
            spriteBatch.Draw(
                _whitePixel,
                new Rectangle(x, y, width, height),
                color);
        }

        /// <summary>
        /// Draws a box using a rectangle
        /// </summary>
        /// <param name="rect">The rectangle that defines the box</param>
        /// <param name="color">The color of the rectangle</param>
        private void DrawBox(Rectangle rect, Color color)
        {
            // Draw the box
            spriteBatch.Draw(
                _whitePixel,
                rect,
                color);
        }
    }
}