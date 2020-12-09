using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
	class Points 
	{
		protected int points = 0;
		protected Vector2 position;
		protected SpriteFont font;

		public Points(SpriteFont f, Vector2 p)
		{
			position = p;
			font = f;
		}
		public void Add()
		{
			points++;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(font, "Points: " + points.ToString(), position, Color.Black);
		}
	}
}
