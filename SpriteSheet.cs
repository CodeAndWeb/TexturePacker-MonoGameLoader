namespace TexturePackerLoader;

public class SpriteSheet
{
    private readonly IDictionary<string, SpriteFrame> spriteList;

    public SpriteSheet()
    {
        spriteList = new Dictionary<string, SpriteFrame>();
    }

    public void Add(string name, SpriteFrame sprite)
    {
        spriteList.Add(name, sprite);
    }

    public void Add(SpriteSheet otherSheet)
    {
        foreach (var sprite in otherSheet.spriteList)
        {
            spriteList.Add(sprite);
        }
    }

    public SpriteFrame Sprite(string sprite)
    {
        return spriteList[sprite];
    }

    /// <summary>
    /// Attempts to retrieve a <see cref="SpriteFrame"/> from the sprite sheet by name.
    /// </summary>
    /// <param name="name">The name of the sprite to retrieve.</param>
    /// <returns>
    /// The <see cref="SpriteFrame"/> corresponding to the given name if it exists;
    /// otherwise, <c>null</c>. This method does not throw exceptions if the sprite is missing.
    /// </returns>
    public SpriteFrame? TryGetSprite(string sprite)
    {
        if (spriteList.TryGetValue(sprite, out var frame))
            return frame;

        return null;
    }

}