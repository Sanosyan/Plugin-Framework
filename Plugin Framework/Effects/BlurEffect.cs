public class BlurEffect : IImageEffect
{
    public int BlurSize { get; set; }

    public BlurEffect(int blurSize)
    {
        BlurSize = blurSize;
    }

    public void ApplyEffect(Image image)
    {
        

        Console.WriteLine($"Applying {BlurSize}px blur to image {image.Path}.");
        //here you need to add the scale that contains the grayscale conversion logic"
    }
}