using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_InheritanceAndMonsters
{
	/// <summary>
	/// Represents a game with Update and Draw functionality
	/// </summary>
	class Game
	{
		// Fields
		protected bool gameOver;
		protected int targetFPS;
		private int timeBetweenFrames;

		/// <summary>
		/// Gets or sets whether or not the game is over
		/// </summary>
		public bool GameOver { get { return gameOver; } set { gameOver = value; } }

		/// <summary>
		/// Gets or sets the target frames per second, between 1 and 1000
		/// </summary>
		public int TargetFPS
		{
			get { return targetFPS; }
			set
			{
				// Clamp to valid values and calculate
				targetFPS = Math.Min(1000, Math.Max(1, value));
				timeBetweenFrames = 1000 / targetFPS;
			}
		}

		/// <summary>
		/// Creates a new game and sets the FPS to a default value
		/// </summary>
		/// <param name="targetFPS">The approximate frames per second.  The default value is 20.</param>
		public Game(int targetFPS = 20)
		{
			gameOver = false;
			TargetFPS = targetFPS;
		}

		/// <summary>
		/// Runs the game while the game is not over
		/// </summary>
		public void GameLoop()
		{
			while (!gameOver)
			{
				Update();
				Draw();
			}
		}

		/// <summary>
		/// This method should update the game state, respond to user input, etc.
		/// 
		/// It should not actually "draw" (Console.Write or Console.WriteLine) anything
		/// to the screen.  That should happen in the Draw method.
		/// </summary>
		public virtual void Update()
		{
			// Sleeps for a specified amount of time
			System.Threading.Thread.Sleep(timeBetweenFrames);
		}

		/// <summary>
		/// This method should handle "drawing" objects to the console window
		/// using Console.Write or Console.WriteLine
		/// 
		/// Remember: You can set the cursor's current position by using
		/// Console.CursorTop and Console.CursorLeft
		/// 
		/// You will get an error if you try to move the cursor outside
		/// the console's bounds.  You can find the bounds using
		/// Console.WindowWidth and Console.WindowHeight
		/// </summary>
		public virtual void Draw()
		{
			// Clears the screen
			Console.Clear();
		}

	}
}
