using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Xml;


namespace ButtonBash
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Game World
        SpriteFont font;
        GamePadState pad1;      //holds state of gamepad during update() call.
        GamePadState oldpad1;   //holds state of gamepad during previous update() call.
        GamePadState pad2;
        GamePadState oldpad2;
        GamePadState pad3;
        GamePadState oldpad3;
        GamePadState pad4;
        GamePadState oldpad4;

        // Count number of times buttons are pressed.
        int acount1;
        int bcount1;
        int xcount1;
        int ycount1;

        int acount2;
        int bcount2;
        int xcount2;
        int ycount2;

        int acount3;
        int bcount3;
        int xcount3;
        int ycount3;

        int acount4;
        int bcount4;
        int xcount4;
        int ycount4;

        // Set screen position of numbers.
        Vector2 apos1 = new Vector2(150, 250);
        Vector2 bpos1 = new Vector2(200, 200);
        Vector2 xpos1 = new Vector2(100, 200);
        Vector2 ypos1 = new Vector2(150, 150);

        Vector2 apos2 = new Vector2(600, 250);
        Vector2 bpos2 = new Vector2(650, 200);
        Vector2 xpos2 = new Vector2(550, 200);
        Vector2 ypos2 = new Vector2(600, 150);

        Vector2 apos3 = new Vector2(150, 450);
        Vector2 bpos3 = new Vector2(200, 400);
        Vector2 xpos3 = new Vector2(100, 400);
        Vector2 ypos3 = new Vector2(150, 350);

        Vector2 apos4 = new Vector2(600, 450);
        Vector2 bpos4 = new Vector2(650, 400);
        Vector2 xpos4 = new Vector2(550, 400);
        Vector2 ypos4 = new Vector2(600, 350);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //Load SpriteFont
            font = Content.Load<SpriteFont>("SpriteFont1");
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Get gamepad states
            pad1 = GamePad.GetState(PlayerIndex.One);
            pad2 = GamePad.GetState(PlayerIndex.Two);
            pad3 = GamePad.GetState(PlayerIndex.Three);
            pad4 = GamePad.GetState(PlayerIndex.Four);

#if test

            //test code - copy value of pad1 into pad2, 3, and 4.
            pad2 = pad1;
            pad3 = pad1;
            pad4 = pad1;
#endif
            if (pad1.IsConnected)
            {
                // Begin game by pressing start button
                if(pad1.Buttons.Start == ButtonState.Pressed)
                {
                    acount1 = 0;
                    bcount1 = 0;
                    xcount1 = 0;
                    ycount1 = 0;
                    //repeat for the other gamepads
                }

                if(oldpad1.Buttons.A == ButtonState.Released && pad1.Buttons.A == ButtonState.Pressed)
                {
                    acount1++;
                }
                if(oldpad1.Buttons.B == ButtonState.Released && pad1.Buttons.B == ButtonState.Pressed)
                {
                    bcount1++;
                }
                if (oldpad1.Buttons.X == ButtonState.Released && pad1.Buttons.X == ButtonState.Pressed)
                {
                    xcount1++;
                }
                if (oldpad1.Buttons.Y == ButtonState.Released && pad1.Buttons.Y == ButtonState.Pressed)
                {
                    ycount1++;
                }

                oldpad1 = pad1;
            }
            if (pad2.IsConnected)
            {
                // Begin game by pressing start button
                if (pad2.Buttons.Start == ButtonState.Pressed)
                {
                    acount2 = 0;
                    bcount2 = 0;
                    xcount2 = 0;
                    ycount2 = 0;
                }

                if (oldpad2.Buttons.A == ButtonState.Released && pad2.Buttons.A == ButtonState.Pressed)
                {
                    acount2++;
                }
                if (oldpad2.Buttons.B == ButtonState.Released && pad2.Buttons.B == ButtonState.Pressed)
                {
                    bcount2++;
                }
                if (oldpad2.Buttons.X == ButtonState.Released && pad2.Buttons.X == ButtonState.Pressed)
                {
                    xcount2++;
                }
                if (oldpad2.Buttons.Y == ButtonState.Released && pad2.Buttons.Y == ButtonState.Pressed)
                {
                    ycount2++;
                }

                oldpad2 = pad2;
            }
            if (pad3.IsConnected)
            {
                // Begin game by pressing start button
                if (pad3.Buttons.Start == ButtonState.Pressed)
                {
                    acount3 = 0;
                    bcount3 = 0;
                    xcount3 = 0;
                    ycount3 = 0;
                }

                if (oldpad3.Buttons.A == ButtonState.Released && pad3.Buttons.A == ButtonState.Pressed)
                {
                    acount3++;
                }
                if (oldpad3.Buttons.B == ButtonState.Released && pad3.Buttons.B == ButtonState.Pressed)
                {
                    bcount3++;
                }
                if (oldpad3.Buttons.X == ButtonState.Released && pad3.Buttons.X == ButtonState.Pressed)
                {
                    xcount3++;
                }
                if (oldpad3.Buttons.Y == ButtonState.Released && pad3.Buttons.Y == ButtonState.Pressed)
                {
                    ycount3++;
                }

                oldpad3 = pad3;
            }
            if (pad4.IsConnected)
            {
                // Begin game by pressing start button
                if (pad3.Buttons.Start == ButtonState.Pressed)
                {
                    acount4 = 0;
                    bcount4 = 0;
                    xcount4 = 0;
                    ycount4 = 0;
                }

                if (oldpad4.Buttons.A == ButtonState.Released && pad4.Buttons.A == ButtonState.Pressed)
                {
                    acount4++;
                }
                if (oldpad4.Buttons.B == ButtonState.Released && pad4.Buttons.B == ButtonState.Pressed)
                {
                    bcount4++;
                }
                if (oldpad4.Buttons.X == ButtonState.Released && pad4.Buttons.X == ButtonState.Pressed)
                {
                    xcount4++;
                }
                if (oldpad4.Buttons.Y == ButtonState.Released && pad4.Buttons.Y == ButtonState.Pressed)
                {
                    ycount4++;
                }

                oldpad4 = pad4;
            }


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Draw the value of "count" onto the screen
            _spriteBatch.Begin();

            if (pad1.IsConnected)
            {
                _spriteBatch.DrawString(font, acount1.ToString(), apos1, Color.Green);
                _spriteBatch.DrawString(font, bcount1.ToString(), bpos1, Color.Red);
                _spriteBatch.DrawString(font, xcount1.ToString(), xpos1, Color.Blue);
                _spriteBatch.DrawString(font, ycount1.ToString(), ypos1, Color.Yellow);
            }
            
            if (pad2.IsConnected)
            {
                _spriteBatch.DrawString(font, acount2.ToString(), apos2, Color.Green);
                _spriteBatch.DrawString(font, bcount2.ToString(), bpos2, Color.Red);
                _spriteBatch.DrawString(font, xcount2.ToString(), xpos2, Color.Blue);
                _spriteBatch.DrawString(font, ycount2.ToString(), ypos2, Color.Yellow);
            }

            if (pad3.IsConnected)
            {
                _spriteBatch.DrawString(font, acount3.ToString(), apos3, Color.Green);
                _spriteBatch.DrawString(font, bcount3.ToString(), bpos3, Color.Red);
                _spriteBatch.DrawString(font, xcount3.ToString(), xpos3, Color.Blue);
                _spriteBatch.DrawString(font, ycount3.ToString(), ypos3, Color.Yellow);
            }
            
            if (pad4.IsConnected)
            {
                _spriteBatch.DrawString(font, acount4.ToString(), apos4, Color.Green);
                _spriteBatch.DrawString(font, bcount4.ToString(), bpos4, Color.Red);
                _spriteBatch.DrawString(font, xcount4.ToString(), xpos4, Color.Blue);
                _spriteBatch.DrawString(font, ycount4.ToString(), ypos4, Color.Yellow);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}