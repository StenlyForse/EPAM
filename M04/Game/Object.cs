namespace M04_2
{
    internal class Object
    {
        internal int X { get; set; }
        internal int Y { get; set; }
        protected string? Name { get; set; }

        public Object(int xCordinate, int yCordinate, string name) : this(xCordinate, yCordinate)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name can not be null or blank", nameof(name));
            this.Name = name;
        }

        public Object(int xCordinate, int yCordinate)
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