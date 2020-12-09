using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Bullet : BaseClass
    {
        protected float speed = 8f;
        public Bullet(Texture2D t, Vector2 p, Rectangle r) : base(t, p, r)
        {
            texture = t;
            posision = p;
            rectangle = r;
        }

        public void Remove()
        {
            speed = 0f;
            posision.X = 1000;
        }

        public override void Update()
        {
            posision.Y -= speed;
            rectangle.Location = posision.ToPoint();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}