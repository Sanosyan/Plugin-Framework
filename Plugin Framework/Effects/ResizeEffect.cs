public class ResizeEffect : IImageEffect
{
    public int NewWidth { get; set; }

    public ResizeEffect(int newWidth)
    {
        NewWidth = newWidth;
        
    }
    public void ApplyEffect(Image image)
    {
        
        Console.Write($"Resizing image {image.Path} to {NewWidth} pixels.");
       
    }
}