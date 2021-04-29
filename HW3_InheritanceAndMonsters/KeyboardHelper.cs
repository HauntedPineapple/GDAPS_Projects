using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_InheritanceAndMonsters
{
	#region Common Keys
	/// <summary>
	/// Common key codes for keys
	/// You can find more keys to add to the enum here: 
	/// http://www.pinvoke.net/default.aspx/Enums/VirtualKeys.html
	/// </summary>
	public enum KeyCode
	{
		Tab = 0x09,
		Escape = 0x1B,
		Enter = 0x0D,
		Space = 0x20,
		Left = 0x25,
		Up = 0x26,
		Right = 0x27,
		Down = 0x28,
		Key_0 = 0x30,
		Key_1 = 0x31,
		Key_2 = 0x32,
		Key_3 = 0x33,
		Key_4 = 0x34,
		Key_5 = 0x35,
		Key_6 = 0x36,
		Key_7 = 0x37,
		Key_8 = 0x38,
		Key_9 = 0x39,
		Key_A = 0x41,
		Key_B = 0x42,
		Key_C = 0x43,
		Key_D = 0x44,
		Key_E = 0x45,
		Key_F = 0x46,
		Key_G = 0x47,
		Key_H = 0x48,
		Key_I = 0x49,
		Key_J = 0x4A,
		Key_K = 0x4B,
		Key_L = 0x4C,
		Key_M = 0x4D,
		Key_N = 0x4E,
		Key_O = 0x4F,
		Key_P = 0x50,
		Key_Q = 0x51,
		Key_R = 0x52,
		Key_S = 0x53,
		Key_T = 0x54,
		Key_U = 0x55,
		Key_V = 0x56,
		Key_W = 0x57,
		Key_X = 0x58,
		Key_Y = 0x59,
		Key_Z = 0x5A,
	}
	#endregion

	/// <summary>
	/// Contains methods to help with keyboard input
	/// </summary>
	static class KeyboardHelper
	{
		// Import a Windows-level function to get raw key data
		[DllImport("User32.dll")]
		static extern short GetKeyState(KeyCode keyCode);

		/// <summary>
		/// Determines if the specified key is currently down
		/// </summary>
		/// <param name="keyCode">The code of the key to check</param>
		/// <returns>True if the key is down, false if it's up</returns>
		public static Boolean IsKeyDown(KeyCode keyCode)
		{
			// Determine if the key is currently down
			return Convert.ToBoolean(GetKeyState(keyCode) & 0x8000);
		}

		/// <summary>
		/// Determines if the specified key is currently up
		/// </summary>
		/// <param name="keyCode">The code of the key to check</param>
		/// <returns>True if the key is up, false if it's down</returns>
		public static Boolean IsKeyUp(KeyCode keyCode)
		{
			// Return the inverse of IsKeyDown
			return !IsKeyDown(keyCode);
		}
	}
}
