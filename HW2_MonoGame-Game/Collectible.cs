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
    public class Collectible : GameObject
    {
        private bool isSpecial; //bool value to tell if item is "special" ex: rare candy that gives extra points
        private bool isActive;
        public bool IsActive { get { return isActive; } set { isActive = value; } }
        public bool IsSpecial { get { return isSpecial; } set { isSpecial = value; } }

        public Collectible(Texture2D texture, Rectangle position) : base(texture, position)
        {
            this.texture = texture;
            this.position = position;
            isActive = true;
            isSpecial = false;
        }
        public Collectible(Texture2D texture, Rectangle position, bool special) : base(texture, position)
        {
            this.texture = texture;
            this.position = position;
            isActive = true;
            isSpecial = special;
        }
        public Collectible(Texture2D texture, int x, int y, int w, int h) : base(texture, x, y, w, h)
        {
            this.texture = texture;
            position = new Rectangle(x, y, w, h);
            isActive = true;
            isSpecial = false;
        }

        public bool CheckCollision(GameObject check)
        { //if it isn't active, don't bother checking
            if (!isActive)
                return false;
            if (position.Intersects(check.Position))
            {
                isActive = false;
                return true;
            }
            else
                return false;
        }

        public override void Draw(SpriteBatch sb)
        {
            if (!isActive)
                return;
            base.Draw(sb);
        }
    }
}