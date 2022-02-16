namespace M04_1
{
    internal abstract class Figure
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        public abstract double Area();
        public abstract double Perimeter();

        public Figure(int xCordinate, int yCordinate)
        {
            if (xCordinate > Console.WindowHeight || yCordinate > Console.WindowWidth)
                throw new ArgumentException("Cordinates cannot be higher than window size");
            if (xCordinate < 0 || yCordinate < 0)
                throw new ArgumentException("Cordinates cannot be lower than zero");

            this.X = xCordinate;
            this.Y = yCordinate;
        }
    }
}