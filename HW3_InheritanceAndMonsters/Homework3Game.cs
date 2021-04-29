using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_InheritanceAndMonsters
{
	class Homework3Game : Game
	{
		// Example fields - remove these
		private int exampleX;
		private int exampleY;

		/// <summary>
		/// Example constructor - Make this do whatever your game needs it to do
		/// </summary>
		public Homework3Game()
		{
			// Changes the console window's title
			Console.Title = "Welcome to the Homework 3 Game!";

			// ==============================
			// Replace the following code with your own
			exampleX = 10;
			exampleY = 10;

		}

		/// <summary>
		/// This method should update the game state, respond to user input, etc.
		/// 
		/// It should not actually "draw" (Console.Write or Console.WriteLine) anything
		/// to the screen.  That should happen in the Draw() method below.
		/// </summary>
		public override void Update()
		{
			// Pause to allow the user to see what's on the screen
			base.Update(); // Don't remove this

			// Ends the game if Escape is pressed
			if (KeyboardHelper.IsKeyDown(KeyCode.Escape))
			{
				GameOver = true;
			}

			// ==============================
			// Replace the following code with your own

			// Example keyboard input
			if (KeyboardHelper.IsKeyDown(KeyCode.Left))
			{
				exampleX--;
				if (exampleX < 0)
					exampleX = 0;
			}

			if (KeyboardHelper.IsKeyDown(KeyCode.Right))
			{
				exampleX++;
				if (exampleX >= Console.WindowWidth)
					exampleX = Console.WindowWidth - 1;
			}
		}

		/// <summary>
		/// This method should handle "drawing" objects to the console window
		/// using Console.Write() or Console.WriteLine()
		/// 
		/// Remember: You can set the cursor's current position by using
		/// Console.CursorTop and Console.CursorLeft
		/// 
		/// You will get an error if you try to move the cursor outside
		/// the console's bounds.  You can find the bounds using
		/// Console.WindowWidth and Console.WindowHeight
		/// </summary>
		public override void Draw()
		{
			// Clears the screen
			base.Draw(); // Don't remove this

			// =========================
			// Replace the following code with your own

			// Print instructions to the screen
			Console.WriteLine("Press left or right arrows to move");

			// You can move the "cursor" around in the console window
			Console.CursorTop = exampleY;
			Console.CursorLeft = exampleX;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("X");
			Console.ForegroundColor = ConsoleColor.Gray;
		}

	}
}