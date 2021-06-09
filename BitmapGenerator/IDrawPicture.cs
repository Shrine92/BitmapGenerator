﻿using System.Drawing;

namespace BitmapGenerator
{
    public interface IDrawPicture
    {
        /// <summary>
        /// Draw a picture with type, height and width.
        /// </summary>
        /// <param name="height">The height of the picture, in pixels.</param>
        /// <param name="width">The width of the picture, in pixels.</param>
        /// <returns>The fully drawed Bitmap with your most advanced painting skills !</returns>
        Bitmap Draw(int height, int width);
    }

}
