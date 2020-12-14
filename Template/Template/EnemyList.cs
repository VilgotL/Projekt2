using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace Template
{
	class EnemyList 
	{
		Random rnd = new Random();
		protected static int spawnTime = 2000;
		protected List<EnemyClass> enemyList = new List<EnemyClass>();
		protected Texture2D eTexture;

		protected Stopwatch time = new Stopwatch();
		
		public EnemyList(Texture2D e)
		{
			eTexture = e;
		}

		public List<EnemyClass> EList
		{
			get { return enemyList; }
		}

		public void StartTime() 
		{
			time.Start();
		}

		public static void DecreaseSpawnTime()
		{
			spawnTime -= 50;
		}

		public void Update()
		{
	        if (time.ElapsedMilliseconds >= spawnTime)
			{
				int a = rnd.Next(1, 101);
				if (a <= 50)
					enemyList.Add(new Enemy1(eTexture, new Vector2(rnd.Next(0, 751), -100), new Rectangle(325, -100, 50, 50)));
				if (a > 50 && a <= 80)
					enemyList.Add(new Enemy2(eTexture, new Vector2(rnd.Next(0, 751), -100), new Rectangle(325, -100, 50, 50)));
				if (a > 80)
					enemyList.Add(new Enemy3(eTexture, new Vector2(rnd.Next(0, 751), -100), new Rectangle(325, -100, 50, 50)));
				time.Stop();
			    time.Reset();
			    time.Start();
			}
			
		} 
	}
}
