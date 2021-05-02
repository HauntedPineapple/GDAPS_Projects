using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Dungeon
{
    class Program
    {
        #region Map key
        /// Vertical Wall - ║
        /// Horizontal Wall - ═
        /// Corners - ╔  ╗ ╚  ╝
        /// Character @
        /// Gem - *
        /// Monster - M
        /// Potion - P
        /// Weapon - W
        #endregion


        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon("Level 1", 50, 30);
            #region Walls
            dungeon.DrawObject(4, 4, '╔');
            dungeon.DrawWallVertical(4, 5, 17);
            dungeon.DrawWallHorizontal(5, 4, 16);
            dungeon.DrawObject(20, 4, '╗');

            dungeon.DrawObject(20, 12, '╚');
            dungeon.DrawWallVertical(20, 5, 7);
            dungeon.DrawWallHorizontal(21, 12, 8);
            dungeon.DrawObject(28, 12, '╝');

            dungeon.DrawObject(28, 4, '╔');
            dungeon.DrawWallVertical(28, 5, 7);
            dungeon.DrawWallHorizontal(29, 4, 18);
            dungeon.DrawObject(46, 4, '╗');

            dungeon.DrawObject(46, 26, '╝');
            dungeon.DrawWallVertical(20, 19, 3);
            dungeon.DrawWallHorizontal(45, 26, -19);
            dungeon.DrawObject(26, 26, '╚');

            dungeon.DrawObject(26, 18, '╗');
            dungeon.DrawWallVertical(26, 19, 7);
            dungeon.DrawWallHorizontal(25, 18, -6);
            dungeon.DrawObject(20, 18, '╔');

            dungeon.DrawObject(20, 22, '╝');
            dungeon.DrawWallVertical(46, 5, 21);
            dungeon.DrawWallHorizontal(19, 22, -16);
            dungeon.DrawObject(4, 22, '╚');
            #endregion

            dungeon.DrawObject(8, 12, '@', ConsoleColor.Green);
            dungeon.DrawObject(34, 8, 'W', ConsoleColor.Cyan);
            dungeon.DrawObject(32, 16, 'M', ConsoleColor.Red);
            dungeon.DrawObject(38, 20, 'P', ConsoleColor.Magenta);
            dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
            dungeon.DrawObject(41, 11, '*', ConsoleColor.Yellow);
            dungeon.DrawObject(42, 12, '*', ConsoleColor.Yellow);

            Console.ReadLine();
        }
    }
}
