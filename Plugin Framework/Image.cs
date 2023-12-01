public class Image
{
    public string Path { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public List<IImageEffect> Effects { get; set; }

    public Image(string path, int width, int height)
    {
        Path = path;
        Width = width;
        Height = height;
        Effects = new List<IImageEffect>();
    }
    public void ApplyEffects()
    {
        foreach (var effect in Effects)
        {
            effect.ApplyEffect(this);
        }
    }
}