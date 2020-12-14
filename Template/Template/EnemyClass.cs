using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
	class EnemyClass : BaseClass
	{
		protected float speed = 3f;

		protected enum Defense
		{
			Low,
			Medium,
			High
		}

		protected int lives;

		public EnemyClass(Texture2D t, Vector2 p, Rectangle r) : base(t, p, r)
		{
			texture = t;
			posision = p;
			rectangle = r;
		}

		public void Damage()
		{
			lives--;

			if (lives < 0)
				Die();
		}

		private void Die()
		{
			speed = 0f;
			posision.X = 2000;

			Points.AddPoint();

			EnemyList.DecreaseSpawnTime();
		}

		public override void Update()
		{
			posision.Y += speed;
			rectangle.Location = posision.ToPoint();
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, rectangle, Color.White);
		}
	}
}