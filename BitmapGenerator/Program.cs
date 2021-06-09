using System.Drawing.Imaging;

namespace BitmapGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var img = new DrawPicture().Draw(500, 200);
            img.Save("file.png", ImageFormat.Png);
        }
    }
}
