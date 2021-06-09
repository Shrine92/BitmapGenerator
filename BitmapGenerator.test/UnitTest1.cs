using System;

using Xunit;

namespace BitmapGenerator.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1000, 1000)] // Limite inférieure
        [InlineData(6000, 6000)] // Limite supérieure
        [InlineData(2000, 2000)] // Cas moyen
        [InlineData(42, 6000)] // Cas d'erreur, ne devrait pas survenir mais éviter une exception :)
        [InlineData(6000, 42)] // Cas d'erreur, ne devrait pas survenir mais éviter une exception :)
        public void Whiteman(int height, int width)
        {
            using var result = new DrawPicture().Draw(height, width);
        }

    }
}
