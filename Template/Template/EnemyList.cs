using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace Template
{
	class EnemyList 
	{
		protected List<BaseClass> enemyList = new List<BaseClass>();
		protected Texture2D e1Texture;

		protected Stopwatch time = new Stopwatch();
		

		public EnemyList(Texture2D e1)
		{
			e1Texture = e1;
		}

		public List<BaseClass> EList
		{
			get { return enemyList; }
		}

		public void LoadContent() 
		{
			time.Start();
		}

		public void Update()
		{
	        if (time.ElapsedMilliseconds >= 2000)
			{
				enemyList.Add(new Enemy1(e1Texture, new Vector2(300, 0), new Rectangle(300, -100, 50, 50)));
				time.Stop();
			    time.Reset();
			    time.Start();
			}
			
		} 
	}
}
