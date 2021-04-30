using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HW4_Djikstra
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		// MonoGame Defaults
		private GraphicsDeviceManager graphics;
		private SpriteBatch spriteBatch;

		// The graph
		private Graph graph;

		// Assets
		private Texture2D vertexTexture;
		private SpriteFont font;

		// Mouse stuff
		private MouseState prevMouseState;

		/// <summary>
		/// Creates a new game
		/// </summary>
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
			// Show the mouse
			this.IsMouseVisible = true;

			// Set up the graph
			graph = new Graph(GraphicsDevice, this.Window);

			// Add vertices to the graph
			graph.AddVertex(new Vertex("Tower 0", new Vector2(50, 50)));
			graph.AddVertex(new Vertex("Tower 1", new Vector2(300, 200)));
			graph.AddVertex(new Vertex("Tower 2", new Vector2(400, 400)));
			graph.AddVertex(new Vertex("Tower 3", new Vector2(600, 350)));
			graph.AddVertex(new Vertex("Tower 4", new Vector2(500, 110)));
			graph.AddVertex(new Vertex("Tower 5", new Vector2(100, 410)));
			graph.AddVertex(new Vertex("Tower 6", new Vector2(700, 250)));
			graph.AddVertex(new Vertex("Tower 7", new Vector2(250, 405)));
			graph.AddVertex(new Vertex("Tower 8", new Vector2(700, 50)));

			// Add some edges
			graph.AddUndirectedEdge(1, 2, 13);
			graph.AddUndirectedEdge(2, 3, 10);
			graph.AddUndirectedEdge(6, 3, 15);
			graph.AddUndirectedEdge(0, 5, 73);
			graph.AddUndirectedEdge(2, 4, 54);
			graph.AddUndirectedEdge(0, 6, 2);
			graph.AddUndirectedEdge(1, 5, 12);
			graph.AddUndirectedEdge(7, 2, 3);
			graph.AddUndirectedEdge(7, 5, 5);
			graph.AddUndirectedEdge(8, 4, 20);
			graph.AddUndirectedEdge(8, 6, 19);

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

			// Load assets
			vertexTexture = Content.Load<Texture2D>("tower");
			font = Content.Load<SpriteFont>("Arial10");

			// Set the values in the graph
			graph.Font = font;
			graph.VertexTexture = vertexTexture;
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

			// Always reset the edge colors to support
			// highlighting edges based on mouse hover
			graph.ResetEdgeColors();

			// Grab the current mouse state and check for click
			MouseState mouseState = Mouse.GetState();
			if (mouseState.LeftButton == ButtonState.Pressed && prevMouseState.LeftButton != ButtonState.Pressed)
			{
				// If we're selecting a new vertex, we need to run the algorithm again
				graph.ResetPaths();
				graph.SelectVertex(graph.GetVertexUnderMouse());
			}

			// Save the state for next frame
			prevMouseState = mouseState;

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			// Begin the sprite batch
			spriteBatch.Begin();

			// Draw the graph's pieces
			graph.DrawEdges(spriteBatch);
			graph.DrawVertices(spriteBatch);

			// End the sprite batch
			spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}