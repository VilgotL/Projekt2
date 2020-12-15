using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
	class Enemy1 : EnemyClass
	{ 
		public Enemy1(Texture2D t, Vector2 p, Rectangle r) : base(t, p, r)
		{
			texture = t;
			posision = p;
			rectangle = r;

			lives = (int)Defense.Low;
		}

		public override void Update()
		{
			base.Update();
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, rectangle, Color.Yellow);
		}
	}
}
