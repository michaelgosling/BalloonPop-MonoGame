using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BalloonPop.Screens
{
	interface IScreen
	{
		void Draw(SpriteBatch spriteBatch);
		void Update(GameTime gameTime);
	}
}