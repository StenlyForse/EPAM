using System.ComponentModel.DataAnnotations;

namespace RectangleHelper
{
    public class Rectangle
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Enter value greater than 0")]
        public int Width { get; private set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Enter value greater than 0")]
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Perimetr()
        {
            return 2 * (Width + Height);
        }

        public int Square()
        {
            return Width * Height;
        }
    }
}