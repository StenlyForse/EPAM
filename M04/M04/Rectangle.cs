namespace M04_1
{
    internal class Rectangle : Square
    {
        protected int Width { get; set; }
        public override double Area() => Height * Width;
        public override double Perimeter() => (Height + Width) * 2;

        public Rectangle(int xCordinate, int yCordinate, int height, int width) : base(xCordinate, yCordinate, height)
        {
            if (width > Console.WindowWidth || width <= 0)
                throw new ArgumentException("Width should be lower than a window width and be greater than zero");

            this.Width = width;
        }
    }
}