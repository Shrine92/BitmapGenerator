using System;
using System.Drawing;

namespace BitmapGenerator
{
    public class DrawPicture: IDrawPicture
    {
        private readonly Random _random = new Random();
        
        public Bitmap Draw(int height, int width)
        {
            var img = new Bitmap(width, height);

            // 

            return img;
        }

        
        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
