using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class BaseClass
    {
        protected Texture2D texture;
        protected Vector2 posision;
        protected Rectangle rectangle;

        public BaseClass(Texture2D t, Vector2 p, Rectangle r)
        {
            texture = t;
            posision = p;
            rectangle = r;
        }
        public Rectangle Rectangle
        {
            get { return rectangle; }
        }

        public Vector2 Position
        {
            get { return posision; }
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}