namespace M04_2
{
    internal class Obstacle : Object
    {
        internal new enum Name
        {
            Tree,
            Stone
        }

        internal Name ObsName { get; set; }

        public Obstacle(int xCordinate, int yCordinate, Name name) : base(xCordinate, yCordinate)
        {
            X = xCordinate;
            Y = yCordinate;
            ObsName = name;
        }
    }
}