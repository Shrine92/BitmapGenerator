using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace BitmapGenerator
{
    public class DrawPicture: IDrawPicture
    {
        public int _height { get; private set; }
        public int _width { get; private set; }

        private readonly Random _random = new();
        private const int MinBoundariesPoint = 4;
        private const int MaxBoundariesPoint = 4;


        public Bitmap Draw(int height, int width)
        {
            _height = height;
            _width = width;

            var img = new Bitmap(_width, _height);

            // Create a random number of point that'll be the boundaries
            var nbrPoints = RandomNumber(MinBoundariesPoint, MaxBoundariesPoint);

            // Give them random position
            var boundaries = new List<Point>();

            for (int i = 0; i < nbrPoints; i++)
            {
                var boundarie = PointInsideBoundaries();
                // Mark the currentPoint on the Bitmap
                img.SetPixel(boundarie.X, boundarie.Y, Color.Black);

                boundaries.Add(boundarie);
            }

            // Take a random point to start
            var currentPoint = PointInsideBoundaries();


            // Take enough iteration to fill the bitmap
            for (int i = 0; i < _height * _width / 10; i++)
            {
                // Mark the currentPoint on the Bitmap
                img.SetPixel(currentPoint.X, currentPoint.Y, Color.Black);

                // Take a point to move to
                var pointToMove = boundaries[RandomNumber(0, nbrPoints - 1)];

                currentPoint = new Point((currentPoint.X + pointToMove.X) / 2, (currentPoint.Y + pointToMove.Y) / 2);
            }

            return img;
        }

        private Point PointInsideBoundaries()
            => new Point(RandomNumber(0, _width), RandomNumber(0, _height));



        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}
