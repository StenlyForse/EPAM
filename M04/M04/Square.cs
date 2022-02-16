namespace M04_1
{
    internal class Square : Figure
    {
        protected int Height { get; set; }
        public override double Area() => Height * Height;
        public override double Perimeter() => Height * 4;

        public Square(int xCordinate, int yCordinate, int height) : base(xCordinate, yCordinate)
        {
            if (height > Console.WindowHeight || height <= 0)
                throw new ArgumentException("Height should be lower than a window height and be greater than zero");

            this.Height = height;
        }
    }
}