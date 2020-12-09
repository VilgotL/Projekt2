﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player p;
        EnemyList eL;
        Points points;
        //KOmentar
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 800;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            p = new Player(Content.Load<Texture2D>("xwing"), Content.Load<Texture2D>("bullet4"), new Vector2(200, 650), new Rectangle(200, 650, 50, 50));          
            
            eL = new EnemyList(Content.Load<Texture2D>("xwingRotated"));
            eL.StartTime();

            points = new Points(Content.Load<SpriteFont>("Text"), new Vector2(660, 50));
            // TODO: use this.Content to load your game content here 
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            p.Update();
            eL.Update();

            foreach (Bullet bullet in p.BList)
            {
                bullet.Update();
                foreach (EnemyClass enemy in eL.EList)
                {
                    if (bullet.Rectangle.Intersects(enemy.Rectangle))
                    {
                        enemy.Die();
                        bullet.Remove();
                        points.Add();
                    }
                }
            }

            foreach (BaseClass element in eL.EList)
            {
                element.Update();
                if (element.Rectangle.Intersects(p.Rectangle))
                {
                    Exit();
                }
                if (element.Position.Y > 800)
                {
                    Exit();
                }
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here.
            spriteBatch.Begin();
            p.Draw(spriteBatch);
            points.Draw(spriteBatch);
            foreach (Bullet element in p.BList)
            {
                element.Draw(spriteBatch);
            }
            foreach (BaseClass element in eL.EList)
            {
                element.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}