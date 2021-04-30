using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace HW3_QuadTrees
{
    class GameObject
    {
        // The game object's rectangle
        private Rectangle _rect;

        // This object's texture
        private Texture2D _texture;

        // This object's color
        private Color _color;


        /// <summary>
        /// This game object's rectangle
        /// </summary>
        public Rectangle Rectangle { get { return _rect; } }

        /// <summary>
        /// This game object's texture
        /// </summary>
        public Texture2D Texture { get { return _texture; } }

        /// <summary>
        /// This object's color
        /// </summary>
        public Color Color { get { return _color; } }


        /// <summary>
        /// Creates a new game object
        /// </summary>
        /// <param name="rect">The rectangle for this game object</param>
        /// <param name="texture">The texture for this object</param>
        /// <param name="color">The color of this object</param>
        public GameObject(Rectangle rect, Texture2D texture, Color color)
        {
            _rect = rect;
            _texture = texture;
            _color = color;
        }
    }
}