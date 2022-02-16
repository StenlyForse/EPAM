namespace M04_2
{
    internal class Field
    {
        internal int Height { get; set; }
        internal int Width { get; set; }

        public Field(int height, int width)
        {
            if (height > Console.WindowHeight || width <= 0)
                throw new ArgumentException("Height should be lower than a window height and be greater than zero");
            if (width > Console.WindowWidth || width <= 0)
                throw new ArgumentException("Width should be lower than a window width and be greater than zero");
            this.Height = height;
            this.Width = width;
        }
    }
}