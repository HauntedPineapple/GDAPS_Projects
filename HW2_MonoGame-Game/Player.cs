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
    public enum PlayerState
    {
        FaceLeft,
        FaceRight,
        FaceUp, //facing away from user
        FaceDown, //facing toward user
        WalkLeft,
        WalkRight,
        WalkUp,
        WalkDown
    }
    public class Player : GameObject
    {
        private int totalScore;
        private int levelScore;
        public int TotalScore { get { return totalScore; } set { totalScore = value; } }
        public int LevelScore { get { return levelScore; } set { levelScore = value; } }

        public Player(Texture2D texture, Rectangle position) : base(texture, position)
        {
            this.texture = texture;
            this.position = position;
            levelScore = 0;
            totalScore = 0;
        }
        public Player(Texture2D texture, int x, int y, int w, int h) : base(texture, x, y, w, h)
        {
            this.texture = texture;
            position = new Rectangle(x, y, w, h);
            LevelScore = 0;
            TotalScore = 0;
        }
    }
}