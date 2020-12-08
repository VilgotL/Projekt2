using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
	class Enemy1 : BaseClass
	{
		protected float speed = 3f;
		public Enemy1(Texture2D t, Vector2 p, Rectangle r) : base(t, p, r)
		{
			texture = t;
			posision = p;
			rectangle = r;
		}

		public override void Update()
		{
			posision.Y += speed;
			rectangle.Location = posision.ToPoint();
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, rectangle, Color.Red);
		}
	}
}
