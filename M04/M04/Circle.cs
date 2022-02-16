namespace M04_1
{
    internal class Circle : Figure
    {
        protected int Radius { get; set; }
        public override double Area() => Math.PI * Math.Pow(Radius, 2);
        public override double Perimeter() => 2 * Math.PI * Radius;

        public Circle(int xCordinate, int yCordinate, int radius) : base(xCordinate, yCordinate)
        {
            if (radius > Console.WindowHeight / 2 || radius < 0)
                throw new ArgumentException("Radius should not be higher than a half of a window height or be negative");
            this.Radius = radius;
        }
    }
}