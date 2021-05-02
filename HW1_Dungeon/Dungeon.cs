using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Dungeon
{
    class Dungeon
    {
        private int width, height;

        public Dungeon(string name, int _width = 50, int _height = 30)
        {
            Console.Title = name;

            if (_width > 100)
            {
                _width = 100;
            }
            if (_width < 25)
            {
                _width = 25;
            }

            if (_height > 50)
            {
                _height = 50;
            }
            if (_height < 15)
            {
                _height = 15;
            }

            width = _width;
            Console.WindowWidth = _width;
            height = _height;
            Console.WindowHeight = _height;
        }

        public void DrawWallVertical(int x, int y, int length, ConsoleColor color = ConsoleColor.White, char symbol = '║')
        {
            if (x < 0 || y < 0 || length == 0
                || x > width || y > height)
            {
                return;
            }

            for (int i = 0; i < Math.Abs(length); i++)
            {
                if (y > height || y < 0)
                {
                    return;
                }
                Console.CursorTop = y;
                Console.CursorLeft = x;
                Console.ForegroundColor = color;
                Console.Write(symbol);
                Console.ForegroundColor = ConsoleColor.Gray;
                if (length > 0)
                {
                    y++;
                }
                else
                {
                    y--;
                }
            }
        }

        public void DrawWallHorizontal(int x, int y, int length, ConsoleColor color = ConsoleColor.White, char symbol = '=')
        {
            if (x < 0 || y < 0 || length == 0
                || x > width || y > height)
            {
                return;
            }

            for (int i = 0; i < Math.Abs(length); i++)
            {
                if (x > width || x < 0)
                {
                    return;
                }
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.ForegroundColor = color;
                Console.Write(symbol);
                Console.ForegroundColor = ConsoleColor.Gray;
                if (length > 0)
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
        }
        public void DrawObject(int x, int y, char symbol, ConsoleColor color = ConsoleColor.White)
        {
            if (x < 0 || y < 0 || x > width || y > height)
            {
                return;
            }

            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
