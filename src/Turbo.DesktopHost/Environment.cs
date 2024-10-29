using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Turbo.DesktopHost;

public class Environment : Game
{
    private SpriteFont _font;
    
    private GraphicsDeviceManager _graphics;
    
    private SpriteBatch _spriteBatch;

    public Environment()
    {
        _graphics = new GraphicsDeviceManager(this);
     
        Content.RootDirectory = "_Content";
        
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        Window.Title = "Turbo";
        
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _font = Content.Load<SpriteFont>("font");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        _spriteBatch.Begin();
        
        _spriteBatch.DrawString(_font, "├───────┼───────┼───────┤", new Vector2(30, 30), Color.White);
        
        _spriteBatch.DrawString(_font, "12345", new Vector2(30, 80), Color.White);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}