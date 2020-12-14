using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
    class Player : BaseClass
    {
        protected float speed = 7f;

        protected Texture2D bulletTexture;

        protected List<Bullet> bulletList = new List<Bullet>();

        protected KeyboardState kNewState;
        protected KeyboardState kOldState;
  
        public Player(Texture2D t, Texture2D bT, Vector2 p, Rectangle r) : base(t, p, r)
        {
            texture = t;
            posision = p;
            rectangle = r;
            bulletTexture = bT;
        }

        public List<Bullet> BList
        {
            get { return bulletList; }
        }

        private void Move()
        {
            kNewState = Keyboard.GetState();

            if (kNewState.IsKeyDown(Keys.D))
                posision.X += speed;

            if (kNewState.IsKeyDown(Keys.A))
                posision.X -= speed;
        }

        private void Shoot()
        {
            kNewState = Keyboard.GetState();

            if (kNewState.IsKeyDown(Keys.Space) && kOldState.IsKeyUp(Keys.Space))
                bulletList.Add(new Bullet(bulletTexture, new Vector2(posision.X + 16, posision.Y), new Rectangle((int)posision.X, (int)posision.Y, 20, 20)));

            rectangle.Location = posision.ToPoint();

            kOldState = kNewState;
        }


        public override void Update()
        {
            Move();
            Shoot();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}