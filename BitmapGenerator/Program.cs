using System;
using System.Drawing.Imaging;

namespace BitmapGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var img = new DrawPicture().Draw(2000, 2000);
            img.Save($"BitmapGenerated-{DateTime.Now:HH-mm-ss}.png", ImageFormat.Png);
        }
    }
}
