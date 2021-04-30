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
    public class GameObject
    {
        protected Texture2D texture;
        protected Rectangle position;
        public Rectangle Position { get { return position; } }

        public int X { get { return position.X; } set { position.X = value; } }
        public int Y { get { return position.Y; } set { position.Y = value; } }
        public int Height { get { return position.Height; } }
        public int Width { get { return position.Width; } }

        public GameObject(Texture2D texture, Rectangle position)
        {
            this.texture = texture;
            this.position = position;
        }
        /// <param name="texture"></param>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <param name="w">width</param>
        /// <param name="h">height</param>
        public GameObject(Texture2D texture, int x, int y, int w, int h)
        {
            this.texture = texture;
            position = new Rectangle(x, y, w, h);
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(texture,
                position,
                Color.White);
        }
    }
}