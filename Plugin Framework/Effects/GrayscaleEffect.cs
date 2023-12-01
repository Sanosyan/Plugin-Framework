using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin_Framework.Effects
{
    public class GrayscaleEffect : IImageEffect
    {
        
        public void ApplyEffect(Image image)
        {
            Console.WriteLine($"Converting image {image.Path} to grayscale (Simulated).");
            //here you need to add the scale that contains the grayscale conversion logic"
        }
    }
}
