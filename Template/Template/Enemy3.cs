using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
	class Enemy3 : EnemyClass
	{
		public Enemy3(Texture2D t, Vector2 p, Rectangle r) : base(t, p, r)
		{
			texture = t;
			posision = p;
			rectangle = r;

			lives = (int)Defense.High;
		}

		public override void Update()
		{
			base.Update();
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, rectangle, Color.Red);
		}
	}
}