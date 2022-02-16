namespace M04_1
{
    internal class Triangle : Figure
    {
        protected int Length { get; set; }
        public override double Area() => (Math.Pow(Length, 2) * Math.Sqrt(3)) / 4;
        public override double Perimeter() => Length * 3;

        public Triangle(int xCordinate, int yCordinate, int length) : base(xCordinate, yCordinate)
        {
            if (length <= 0)
                throw new ArgumentException("Length should be greater than zero");
            this.Length = length;
        }
    }
}