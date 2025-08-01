using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TexturePackerLoader
{
    [Obsolete("Use SpriteBatch.Draw() instead of SpriteRender.Draw()")]
    public class SpriteRender
    {
        private SpriteBatch spriteBatch;

        public SpriteRender(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }

        [Obsolete("Use SpriteBatch.Draw() instead of SpriteRender.Draw()")]
        public void Draw(SpriteFrame sprite, Vector2 position, Color? color = null, float rotation = 0, float scale = 1, SpriteEffects spriteEffects = SpriteEffects.None)
        {
            spriteBatch.Draw(sprite, position, color, rotation, scale, spriteEffects);
        }

    }
}