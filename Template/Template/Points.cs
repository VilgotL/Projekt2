using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.IO;

namespace Template
{
	class Points 
	{
		protected static int points = 0;

		protected Vector2 position1;
		protected Vector2 position2;

		protected SpriteFont font;

		protected BinaryReader br;
		protected BinaryWriter bw;

		protected int highScore;
		
		public Points(SpriteFont f, Vector2 p1, Vector2 p2)
		{
			position1 = p1;
			position2 = p2;
			font = f;
		}
		
		public static void AddPoint()
		{
			points++;
		}

		public void ReadHighScore()
		{
			br = new BinaryReader(new FileStream("Fil.tim", FileMode.OpenOrCreate, FileAccess.Read));
			highScore = br.ReadInt32();
			br.Close();
		}

		public void WriteHighScore()
		{
			if (points > highScore)
			{
				bw = new BinaryWriter(new FileStream("Fil.tim", FileMode.OpenOrCreate, FileAccess.Write));
				bw.Write(points);
				bw.Close();
			}
			
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(font, "Points: " + points.ToString(), position1, Color.Black);
			spriteBatch.DrawString(font, "High Score: " + highScore.ToString(), position2, Color.Black);
		}
	}
}
